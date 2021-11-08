using FFmpegArgs.Cores.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// T.. alphamerge        VV->V      Copy the luma value of the second input into the alpha channel of the first input.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#alphamerge
  /// </summary>
  public class AlphamergeFilter : ImageToImageFilter, ITimelineSupport
  {
    internal AlphamergeFilter(params ImageMap[] imageMap): base("alphamerge",imageMap)
    {
      AddMapOut();
      IsAllowEmptyOption = true;
    }
  }

  public static class AlphamergeFilterExtensions
  {
    /// <summary>
    /// Add or replace the alpha component of the primary input with the grayscale value of a second input.<br>
    /// </br> This is intended for use with alphaextract to allow the transmission or storage of frame sequences that have alpha in a format that doesn’t support an alpha channel.
    /// </summary>
    /// <param name="imageMap"></param>
    /// <param name="alpha"></param>
    /// <returns></returns>
    public static AlphamergeFilter AlphamergeFilter(this ImageMap imageMap, ImageMap alpha)
      => new AlphamergeFilter(imageMap, alpha);
  }
}
