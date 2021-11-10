using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters.Enums;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// TSC colorlevels       V->V       Adjust the color levels.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#colorlevels
  /// </summary>
  public class ColorlevelsFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
  {
    internal ColorlevelsFilter(ImageMap imageMap) : base("colorlevels", imageMap)
    {
      IsAllowEmptyOption = true;
      AddMapOut();
    }

    public ColorlevelsFilter Adjust(ColorlevelsAdjustName adjust, float val)
    {
      FloatRangeAttribute range = adjust.GetAttribute<FloatRangeAttribute>();
      return this.SetOptionRange(adjust.ToString(), val, range.Min, range.Max);
    }
    /// <summary>
    /// Set preserve color mode.
    /// </summary>
    /// <param name="preserve"></param>
    /// <returns></returns>
    public ColorlevelsFilter Preserve(ColorlevelsPreserve preserve)
      => this.SetOption("preserve", preserve);
  }

  public static class ColorlevelsFilterExtensions
  {
    /// <summary>
    /// 
    /// </summary>
    public static ColorlevelsFilter ColorlevelsFilter(this ImageMap imageMap)
      => new ColorlevelsFilter(imageMap);
  }

  public enum ColorlevelsAdjustName
  {
    /// <summary>
    /// Adjust red, green, blue and alpha input black point. Allowed ranges for options are [-1.0, 1.0]. Defaults are 0.
    /// </summary>
    [FloatRange(-1, 1)] rimin,
    /// <summary>
    /// Adjust red, green, blue and alpha input black point. Allowed ranges for options are [-1.0, 1.0]. Defaults are 0.
    /// </summary>
    [FloatRange(-1, 1)] gimin,
    /// <summary>
    /// Adjust red, green, blue and alpha input black point. Allowed ranges for options are [-1.0, 1.0]. Defaults are 0.
    /// </summary>
    [FloatRange(-1, 1)] bimin,
    /// <summary>
    /// Adjust red, green, blue and alpha input black point. Allowed ranges for options are [-1.0, 1.0]. Defaults are 0.
    /// </summary>
    [FloatRange(-1, 1)] aimin,



    /// <summary>
    /// Adjust red, green, blue and alpha input white point. Allowed ranges for options are [-1.0, 1.0]. Defaults are 1.<br></br>
    /// Input levels are used to lighten highlights (bright tones), darken shadows (dark tones), change the balance of bright and dark tones.
    /// </summary>
    [FloatRange(-1, 1)] rimax,
    /// <summary>
    /// Adjust red, green, blue and alpha input white point. Allowed ranges for options are [-1.0, 1.0]. Defaults are 1.<br></br>
    /// Input levels are used to lighten highlights (bright tones), darken shadows (dark tones), change the balance of bright and dark tones.
    /// </summary>
    [FloatRange(-1, 1)] gimax,
    /// <summary>
    /// Adjust red, green, blue and alpha input white point. Allowed ranges for options are [-1.0, 1.0]. Defaults are 1.<br></br>
    /// Input levels are used to lighten highlights (bright tones), darken shadows (dark tones), change the balance of bright and dark tones.
    /// </summary>
    [FloatRange(-1, 1)] bimax,
    /// <summary>
    /// Adjust red, green, blue and alpha input white point. Allowed ranges for options are [-1.0, 1.0]. Defaults are 1.<br></br>
    /// Input levels are used to lighten highlights (bright tones), darken shadows (dark tones), change the balance of bright and dark tones.
    /// </summary>
    [FloatRange(-1, 1)] aimax,



    /// <summary>
    /// Adjust red, green, blue and alpha output black point. Allowed ranges for options are [0, 1.0]. Defaults are 0.
    /// </summary>
    [FloatRange(0, 1)] romin,
    /// <summary>
    /// Adjust red, green, blue and alpha output black point. Allowed ranges for options are [0, 1.0]. Defaults are 0.
    /// </summary>
    [FloatRange(0, 1)] gomin,
    /// <summary>
    /// Adjust red, green, blue and alpha output black point. Allowed ranges for options are [0, 1.0]. Defaults are 0.
    /// </summary>
    [FloatRange(0, 1)] bomin,
    /// <summary>
    /// Adjust red, green, blue and alpha output black point. Allowed ranges for options are [0, 1.0]. Defaults are 0.
    /// </summary>
    [FloatRange(0, 1)] aomin,



    /// <summary>
    /// Adjust red, green, blue and alpha output white point. Allowed ranges for options are [0, 1.0]. Defaults are 1.<br></br>
    /// Output levels allows manual selection of a constrained output level range.
    /// </summary>
    [FloatRange(0, 1)] romax,
    /// <summary>
    /// Adjust red, green, blue and alpha output white point. Allowed ranges for options are [0, 1.0]. Defaults are 1.<br></br>
    /// Output levels allows manual selection of a constrained output level range.
    /// </summary>
    [FloatRange(0, 1)] gomax,
    /// <summary>
    /// Adjust red, green, blue and alpha output white point. Allowed ranges for options are [0, 1.0]. Defaults are 1.<br></br>
    /// Output levels allows manual selection of a constrained output level range.
    /// </summary>
    [FloatRange(0, 1)] bomax,
    /// <summary>
    /// Adjust red, green, blue and alpha output white point. Allowed ranges for options are [0, 1.0]. Defaults are 1.<br></br>
    /// Output levels allows manual selection of a constrained output level range.
    /// </summary>
    [FloatRange(0, 1)] aomax
  }

  public enum ColorlevelsPreserve
  {
    /// <summary>
    /// Disable color preserving, this is default.
    /// </summary>
    none,
    /// <summary>
    /// Preserve luminance.
    /// </summary>
    lum,
    /// <summary>
    /// Preserve max value of RGB triplet.
    /// </summary>
    max,
    /// <summary>
    /// Preserve average value of RGB triplet.
    /// </summary>
    avg,
    /// <summary>
    /// Preserve sum value of RGB triplet.
    /// </summary>
    sum,
    /// <summary>
    /// Preserve normalized value of RGB triplet.
    /// </summary>
    nrm,
    /// <summary>
    /// Preserve power value of RGB triplet.
    /// </summary>
    pwr,

  }
}
