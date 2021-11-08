using FFmpegArgs.Cores.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// T.C bbox              V->V       Compute bounding box for each frame.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#bbox
  /// </summary>
  public class BboxFilter : ImageToImageFilter
  {
    internal BboxFilter(ImageMap imageMap) : base("bbox", imageMap)
    {
      AddMapOut();
      IsAllowEmptyOption = true;
    }

    /// <summary>
    /// Set the minimal luminance value. Default is 16.
    /// </summary>
    /// <param name="min_val"></param>
    /// <returns></returns>
    public BboxFilter MinVal(float min_val)
      => this.SetOptionRange("min_val", min_val, 0, float.MaxValue);
  }

  public static class BboxFilterExtensions
  {
    /// <summary>
    /// Compute the bounding box for the non-black pixels in the input frame luminance plane.<br></br>
    /// This filter computes the bounding box containing all the pixels with a luminance value greater than the minimum allowed value.The parameters describing the bounding box are printed on the filter log.
    /// </summary>
    /// <param name="imageMap"></param>
    /// <returns></returns>
    public static BboxFilter BboxFilter(this ImageMap imageMap)
      => new BboxFilter(imageMap);
  }
}
