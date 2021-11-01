using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.VideoFilters
{
  public class CropFilter : ImageToImageFilter
  {
    static readonly IEnumerable<string> _variables = new List<string>()
    {
      "x", "y",
      "in_w","in_h", "iw", "ih",
      "out_w","out_h", "ow", "oh",
      "a", "sar", "dar", "hsub", "vsub",
      "n", "pos", "t"
    };
    readonly Expression expression = new Expression(_variables);
    internal CropFilter(ImageMap imageMap,
      Action<Expression> x, Action<Expression> y,
       Action<Expression> w, Action<Expression> h) : base("crop", imageMap)
    {
      this.SetOption("x", x.Run(expression));
      this.SetOption("y", y.Run(expression));
      this.SetOption("w", w.Run(expression));
      this.SetOption("h", h.Run(expression));
      AddMapOut();
    }

    public CropFilter KeepAspect(bool flag)
      => this.SetOption("keep_aspect", flag.ToFFmpegFlag());
    public CropFilter Exact(bool flag)
     => this.SetOption("exact", flag.ToFFmpegFlag());
  }

  public static class CropFilterExtension
  {
    public static CropFilter CropFilter(this ImageMap imageMap,
      Action<Expression> x, Action<Expression> y,
       Action<Expression> w, Action<Expression> h)
    {
      return new CropFilter(imageMap, x, y, w, h);
    }

    public static CropFilter CropFilter(this ImageMap imageMap,
      string x, string y,
       string w, string h)
    {
      return new CropFilter(imageMap, x.Expression(), y.Expression(), w.Expression(), h.Expression());
    }
  }
}
