using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// T.. boxblur           V->V       Blur the input.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#boxblur
  /// </summary>
  public class BoxBlurFilter : ImageToImageFilter, ITimelineSupport
  {
    static readonly IEnumerable<string> _variables = new List<string>()
    {
      "w","h",
      "cw","ch",
      "hsub", "vsub"
    };
    readonly Expression expression = new Expression(_variables);
    internal BoxBlurFilter(IImageMap imageMap) : base("boxblur", imageMap)
    {
      _mapsOut.Add(new ImageMap(this.FilterGraph, $"f_{this.FilterIndex}"));
    }

    public BoxBlurFilter LumaRadius(Action<Expression> lr)
      => this.SetOption("lr", lr.Run(expression));
    public BoxBlurFilter LumaRadius(string lr)
      => LumaRadius(lr.Expression());


    public BoxBlurFilter ChromaRadius(Action<Expression> cr)
      => this.SetOption("cr", cr.Run(expression));
    public BoxBlurFilter ChromaRadius(string cr)
      => ChromaRadius(cr.Expression());

    public BoxBlurFilter AlphaRadius(Action<Expression> ar)
      => this.SetOption("ar", ar.Run(expression));
    public BoxBlurFilter AlphaRadius(string ar)
      => AlphaRadius(ar.Expression());


    public BoxBlurFilter LumaPower(double lp)
    {
      return this.SetOption("lp", lp);
    }
    public BoxBlurFilter ChromaPower(double cp)
    {
      return this.SetOption("cp", cp);
    }
    public BoxBlurFilter AlphaPower(double ap)
    {
      return this.SetOption("ap", ap);
    }

  }

  public static class BoxBlurFilterExtension
  {
    /// <summary>
    /// Apply a boxblur algorithm to the input video.
    /// </summary>
    /// <param name="imageMap"></param>
    /// <returns></returns>
    public static BoxBlurFilter BoxBlurFilter(this IImageMap imageMap)
    {
      return new BoxBlurFilter(imageMap);
    }
  }
}
