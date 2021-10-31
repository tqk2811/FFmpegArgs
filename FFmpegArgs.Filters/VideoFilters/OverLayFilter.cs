using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// TSC overlay           VV->V      Overlay a video source on top of the input.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#overlay-1 
  /// </summary>
  public class OverlayFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport, IFramesync
  {
    static readonly IEnumerable<string> _variables = new List<string>()
    {
      "main_w","W",
      "main_h","H",
      "overlay_w", "w",
      "overlay_h", "h",
      "x", "y",
      "hsub", "vsub",
      "n", "pos","t"
    };

    readonly Expression expression = new Expression(_variables);

    internal OverlayFilter(Action<Expression> x, Action<Expression> y, IImageMap bottom, IImageMap top) : base("overlay", bottom, top)
    {
      _mapsOut.Add(new ImageMap(this.FilterGraph, $"f_{this.FilterIndex}"));
      this.SetOption("x", x.Run(expression));
      this.SetOption("y", y.Run(expression));
    }

    public OverlayFilter Eval(OverlayEval eval)
      => this.SetOption("eval", eval.ToString().ToLower());

    public OverlayFilter Format(OverlayPixFmt format)
       => this.SetOption("format", format.ToString());

    public OverlayFilter Alpha(OverlayAlpha alpha)
      => this.SetOption("alpha", alpha.ToString().ToLower());
  }

  public static class OverlayFilterExtension
  {
    public static OverlayFilter OverlayFilterOn(this IImageMap top, IImageMap bottom, Action<Expression> x, Action<Expression> y)
    {
      return new OverlayFilter(
        x, y,
        bottom ?? throw new ArgumentNullException(nameof(bottom)),
        top ?? throw new ArgumentNullException(nameof(top))
        );
    }

    public static OverlayFilter OverlayFilterOn(this IImageMap top, IImageMap bottom, string x, string y)
    {
      return new OverlayFilter(
        x.Expression(),
        y.Expression(),
        bottom ?? throw new ArgumentNullException(nameof(bottom)),
        top ?? throw new ArgumentNullException(nameof(top))
        );
    }
  }


  public enum OverlayAlpha
  {
    Straight,
    Premultiplied
  }

  public enum OverlayPixFmt
  {
    yuv420,
    yuv420p10,
    yuv422,
    yuv422p10,
    yuv444,
    rgb,
    gbrp,
    auto
  }

  /// <summary>
  /// Set when the expressions for x, and y are evaluated.
  /// </summary>
  public enum OverlayEval
  {
    /// <summary>
    /// only evaluate expressions once during the filter initialization or when a command is processed
    /// </summary>
    Init,

    /// <summary>
    /// evaluate expressions for each incoming frame
    /// </summary>
    Frame
  }

}
