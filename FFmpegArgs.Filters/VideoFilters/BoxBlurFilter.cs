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
    internal BoxBlurFilter(ImageMap imageMap) : base("boxblur", imageMap)
    {
      AddMapOut();
    }

    /// <summary>
    /// Set an expression for the box radius in pixels used for blurring the corresponding input plane.<br></br>
    /// The radius value must be a non-negative number, and must not be greater than the value of the expression min(w, h)/2 for the luma and alpha planes, and of min(cw, ch)/2 for the chroma planes.<br></br>
    /// Default value for luma_radius is "2". If not specified, chroma_radius and alpha_radius default to the corresponding value set for luma_radius.
    /// </summary>
    /// <param name="lr"></param>
    /// <returns></returns>
    public BoxBlurFilter LumaRadius(Action<Expression> lr)
      => this.SetOption("lr", lr.Run(expression));
    /// <summary>
    /// Set an expression for the box radius in pixels used for blurring the corresponding input plane.<br></br>
    /// The radius value must be a non-negative number, and must not be greater than the value of the expression min(w, h)/2 for the luma and alpha planes, and of min(cw, ch)/2 for the chroma planes.<br></br>
    /// Default value for luma_radius is "2". If not specified, chroma_radius and alpha_radius default to the corresponding value set for luma_radius.
    /// </summary>
    /// <param name="lr"></param>
    /// <returns></returns>
    public BoxBlurFilter LumaRadius(string lr)
      => LumaRadius(lr.Expression());

    /// <summary>
    /// Set an expression for the box radius in pixels used for blurring the corresponding input plane.<br></br>
    /// The radius value must be a non-negative number, and must not be greater than the value of the expression min(w, h)/2 for the luma and alpha planes, and of min(cw, ch)/2 for the chroma planes.<br></br>
    /// Default value for luma_radius is "2". If not specified, chroma_radius and alpha_radius default to the corresponding value set for luma_radius.
    /// </summary>
    /// <param name="lr"></param>
    /// <returns></returns>
    public BoxBlurFilter ChromaRadius(Action<Expression> cr)
      => this.SetOption("cr", cr.Run(expression));
    /// <summary>
    /// Set an expression for the box radius in pixels used for blurring the corresponding input plane.<br></br>
    /// The radius value must be a non-negative number, and must not be greater than the value of the expression min(w, h)/2 for the luma and alpha planes, and of min(cw, ch)/2 for the chroma planes.<br></br>
    /// Default value for luma_radius is "2". If not specified, chroma_radius and alpha_radius default to the corresponding value set for luma_radius.
    /// </summary>
    /// <param name="lr"></param>
    /// <returns></returns>
    public BoxBlurFilter ChromaRadius(string cr)
      => ChromaRadius(cr.Expression());

    /// <summary>
    /// Set an expression for the box radius in pixels used for blurring the corresponding input plane.<br></br>
    /// The radius value must be a non-negative number, and must not be greater than the value of the expression min(w, h)/2 for the luma and alpha planes, and of min(cw, ch)/2 for the chroma planes.<br></br>
    /// Default value for luma_radius is "2". If not specified, chroma_radius and alpha_radius default to the corresponding value set for luma_radius.
    /// </summary>
    /// <param name="lr"></param>
    /// <returns></returns>
    public BoxBlurFilter AlphaRadius(Action<Expression> ar)
      => this.SetOption("ar", ar.Run(expression));
    /// <summary>
    /// Set an expression for the box radius in pixels used for blurring the corresponding input plane.<br></br>
    /// The radius value must be a non-negative number, and must not be greater than the value of the expression min(w, h)/2 for the luma and alpha planes, and of min(cw, ch)/2 for the chroma planes.<br></br>
    /// Default value for luma_radius is "2". If not specified, chroma_radius and alpha_radius default to the corresponding value set for luma_radius.
    /// </summary>
    /// <param name="lr"></param>
    /// <returns></returns>
    public BoxBlurFilter AlphaRadius(string ar)
      => AlphaRadius(ar.Expression());

    /// <summary>
    /// Specify how many times the boxblur filter is applied to the corresponding plane.<br></br>
    /// Default value for luma_power is 2. If not specified, chroma_power and alpha_power default to the corresponding value set for luma_power.<br></br>
    /// A value of 0 will disable the effect.
    /// </summary>
    /// <param name="lp"></param>
    /// <returns></returns>
    public BoxBlurFilter LumaPower(double lp)
      => this.SetOption("lp", lp);
    /// <summary>
    /// Specify how many times the boxblur filter is applied to the corresponding plane.<br></br>
    /// Default value for luma_power is 2. If not specified, chroma_power and alpha_power default to the corresponding value set for luma_power.<br></br>
    /// A value of 0 will disable the effect.
    /// </summary>
    /// <param name="lp"></param>
    /// <returns></returns>
    public BoxBlurFilter ChromaPower(double cp)
      => this.SetOption("cp", cp);
    /// <summary>
    /// Specify how many times the boxblur filter is applied to the corresponding plane.<br></br>
    /// Default value for luma_power is 2. If not specified, chroma_power and alpha_power default to the corresponding value set for luma_power.<br></br>
    /// A value of 0 will disable the effect.
    /// </summary>
    /// <param name="lp"></param>
    /// <returns></returns>
    public BoxBlurFilter AlphaPower(double ap)
      => this.SetOption("ap", ap);

  }

  public static class BoxBlurFilterExtension
  {
    /// <summary>
    /// Apply a boxblur algorithm to the input video.
    /// </summary>
    /// <param name="imageMap"></param>
    /// <returns></returns>
    public static BoxBlurFilter BoxBlurFilter(this ImageMap imageMap)
    {
      return new BoxBlurFilter(imageMap);
    }
  }
}
