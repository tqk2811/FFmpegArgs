using FFmpegArgs.Cores.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// TSC avgblur           V->V       Apply Average Blur filter.<br>
  /// </br>https://ffmpeg.org/ffmpeg-filters.html#avgblur
  /// </summary>
  public class AvgblurFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
  {
    internal AvgblurFilter(ImageMap imageMap) : base("avgblur", imageMap)
    {
      AddMapOut();
    }

    /// <summary>
    /// Set horizontal radius size.
    /// </summary>
    /// <param name="sizeX"></param>
    /// <returns></returns>
    public AvgblurFilter SizeX(double sizeX)
      => this.SetOptionRange("sizeX", sizeX, 0, double.MaxValue);

    /// <summary>
    /// Set which planes to filter. By default all planes are filtered.
    /// </summary>
    /// <param name="planes"></param>
    /// <returns></returns>
    public AvgblurFilter Planes(int planes)
      => this.SetOptionRange("planes", planes, 0, int.MaxValue);


    /// <summary>
    /// Set vertical radius size, if zero it will be same as sizeX. Default is 0.
    /// </summary>
    /// <param name="sizeY"></param>
    /// <returns></returns>
    public AvgblurFilter SizeY(double sizeY)
     => this.SetOptionRange("sizeY", sizeY, 0, double.MaxValue);
  }

  public static class AvgblurFilterExtensions
  {
    /// <summary>
    /// Apply average blur filter.
    /// </summary>
    /// <param name="imageMap"></param>
    /// <returns></returns>
    public static AvgblurFilter AvgblurFilter(this ImageMap imageMap)
      => new AvgblurFilter(imageMap);
  }
}
