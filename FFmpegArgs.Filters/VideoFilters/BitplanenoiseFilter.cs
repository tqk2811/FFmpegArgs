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
  /// T.. bitplanenoise     V->V       Measure bit plane noise.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#bitplanenoise
  /// </summary>
  public class BitplanenoiseFilter : ImageToImageFilter, ITimelineSupport
  {
    internal BitplanenoiseFilter(ImageMap imageMap) : base("bitplanenoise",imageMap)
    {
      AddMapOut();
      IsAllowEmptyOption = true;
    }

    /// <summary>
    /// Set which plane to analyze. Default is 1.
    /// </summary>
    /// <param name="bitplane"></param>
    /// <returns></returns>
    public BitplanenoiseFilter Bitplane(int bitplane)
      => this.SetOptionRange("bitplane", bitplane, 0, int.MaxValue);

    /// <summary>
    /// Filter out noisy pixels from bitplane set above. Default is disabled.
    /// </summary>
    /// <param name="flag"></param>
    /// <returns></returns>
    public BitplanenoiseFilter filter(bool flag)
      => this.SetOption("filter", flag.ToFFmpegFlag());
  }

  public static class BitplanenoiseFilterExtensions
  {
    /// <summary>
    /// Show and measure bit plane noise.
    /// </summary>
    public static BitplanenoiseFilter BitplanenoiseFilter(this ImageMap imageMap)
      => new BitplanenoiseFilter(imageMap);
  }
}
