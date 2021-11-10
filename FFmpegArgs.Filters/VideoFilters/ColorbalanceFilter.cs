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
  /// TSC colorbalance      V->V       Adjust the color balance<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#colorbalance
  /// </summary>
  public class ColorbalanceFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
  {
    internal ColorbalanceFilter(ImageMap imageMap) : base("colorbalance", imageMap)
    {
      IsAllowEmptyOption = true;
      AddMapOut();
    }

    /// <summary>
    /// Allowed ranges for options are [-1.0, 1.0]. Defaults are 0.
    /// </summary>
    /// <param name="type"></param>
    /// <param name="val"></param>
    /// <returns></returns>
    public ColorbalanceFilter AdjustType(ColorbalanceType type, float val)
      => this.SetOptionRange(type.ToString(), val, -1.0f, 1.0f);

    /// <summary>
    /// Preserve lightness when changing color balance. Default is disabled.
    /// </summary>
    /// <param name="flag"></param>
    /// <returns></returns>
    public ColorbalanceFilter PreserveLightness(bool flag)
      => this.SetOption("pl", flag.ToFFmpegFlag());
  }

  public static class ColorbalanceFilterExtensions
  {
    /// <summary>
    /// Modify intensity of primary colors (red, green and blue) of input frames.<br></br>
    /// The filter allows an input frame to be adjusted in the shadows, midtones or highlights regions for the red-cyan, green-magenta or blue-yellow balance.<br></br>
    /// A positive adjustment value shifts the balance towards the primary color, a negative value towards the complementary color.
    /// </summary>
    public static ColorbalanceFilter ColorbalanceFilter(this ImageMap imageMap)
      => new ColorbalanceFilter(imageMap);
  }

  public enum ColorbalanceType
  {
    /// <summary>
    /// Adjust red shadows (darkest pixels).
    /// </summary>
    rs,
    /// <summary>
    /// Adjust green shadows (darkest pixels).
    /// </summary>
    gs,
    /// <summary>
    /// Adjust blue shadows (darkest pixels).
    /// </summary>
    bs,


    /// <summary>
    /// Adjust red midtones (medium pixels).
    /// </summary>
    rm,
    /// <summary>
    /// Adjust green midtones (medium pixels).
    /// </summary>
    gm,
    /// <summary>
    /// Adjust blue midtones (medium pixels).
    /// </summary>
    bm,


    /// <summary>
    /// Adjust red highlights (brightest pixels).
    /// </summary>
    rh,
    /// <summary>
    /// Adjust green highlights (brightest pixels).
    /// </summary>
    gh,
    /// <summary>
    /// Adjust blue highlights (brightest pixels).
    /// </summary>
    bh,
  }
}
