using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// T.C drawbox           V->V       Draw a colored box on the input video.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#drawbox 
  /// </summary>
  public class DrawBoxFilter : ImageToImageFilter, ITimelineSupport, ICommandSupport
  {
    static readonly IEnumerable<string> _variables = new List<string>()
    {
      "dar",
      "hsub", "vsub",
      "in_h", "ih",
      "in_w", "iw",
      "sar",
      "x", "y",
      "w", "h",
      "t"
    };

    readonly Expression expression = new Expression(_variables);
    internal DrawBoxFilter(Color color,
      Action<Expression> x, Action<Expression> y, Action<Expression> w, Action<Expression> h, IImageMap imageMap) : base("drawbox", imageMap)
    {
      _mapsOut.Add(new ImageMap(this.FilterGraph, $"f_{this.FilterIndex}"));
      this.SetOption("x", x.Run(expression));
      this.SetOption("y", y.Run(expression));
      this.SetOption("w", w.Run(expression));
      this.SetOption("h", h.Run(expression));
      this.SetOption("c", color.ToHexStringRGB());
    }

    public DrawBoxFilter ThicknessFill()
      => this.SetOption("t", "fill");

    public DrawBoxFilter Thickness(Action<Expression> t)
      => this.SetOption("t", t.Run(expression));

    public DrawBoxFilter Thickness(string t)
      => Thickness(_t => _t.Check(t));

    public DrawBoxFilter Replace(bool replace)
       => this.SetOption("replace", replace.ToFFmpegFlag());
  }

  public static class DrawBoxFilterExtension
  {
    public static DrawBoxFilter DrawBoxFilter(this IImageMap imageMap, Color color,
      Action<Expression> x, Action<Expression> y, Action<Expression> w, Action<Expression> h)
    {
      return new DrawBoxFilter(color, x, y, w, h, imageMap ?? throw new ArgumentNullException(nameof(imageMap)));
    }

    public static DrawBoxFilter DrawBoxFilter(this IImageMap imageMap, Color color,
     string x, string y, string w, string h)
    {
      return new DrawBoxFilter(color, x.Expression(), y.Expression(), w.Expression(), h.Expression(), imageMap ?? throw new ArgumentNullException(nameof(imageMap)));
    }
  }
}
