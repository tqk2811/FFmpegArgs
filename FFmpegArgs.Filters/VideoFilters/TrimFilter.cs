using FFmpegArgs.Cores.Maps;
using System;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// ... trim              V->V       Pick one continuous section from the input, drop the rest.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#trim
  /// </summary>
  public class TrimFilter : ImageToImageFilter
  {
    internal TrimFilter(ImageMap imageMap) : base("trim", imageMap)
    {
      AddMapOut();
    }

    /// <summary>
    /// Specify the time of the start of the kept section, i.e. the frame with the timestamp start will be the first frame in the output.
    /// </summary>
    /// <param name="val"></param>
    /// <returns></returns>
    public TrimFilter Start(long val)
      => this.SetOptionRange("start", val, 0, long.MaxValue);

    /// <summary>
    /// Specify the time of the first frame that will be dropped, i.e. the frame immediately preceding the one with the timestamp end will be the last frame in the output.
    /// </summary>
    /// <param name="val"></param>
    /// <returns></returns>
    public TrimFilter End(double val)
      => this.SetOptionRange("end", val, 0, long.MaxValue);

    /// <summary>
    /// This is the same as start, except this option sets the start timestamp in timebase units instead of seconds.
    /// </summary>
    /// <param name="val"></param>
    /// <returns></returns>
    public TrimFilter StartPts(long val)
      => this.SetOptionRange("start_pts", val, 0, long.MaxValue);

    /// <summary>
    /// This is the same as end, except this option sets the end timestamp in timebase units instead of seconds.
    /// </summary>
    /// <param name="val"></param>
    /// <returns></returns>
    public TrimFilter EndPts(long val)
      => this.SetOptionRange("end_pts", val, 0, long.MaxValue);

    /// <summary>
    /// The maximum duration of the output in seconds.
    /// </summary>
    /// <param name="val"></param>
    /// <returns></returns>
    public TrimFilter Duration(TimeSpan val)
      => this.SetOptionRange("duration", val, TimeSpan.Zero, TimeSpan.MaxValue);

    /// <summary>
    /// The number of the first frame that should be passed to the output.
    /// </summary>
    /// <param name="val"></param>
    /// <returns></returns>
    public TrimFilter StartFrame(long val)
      => this.SetOptionRange("start_frame", val, 0, long.MaxValue);

    /// <summary>
    /// The number of the first frame that should be dropped.
    /// </summary>
    /// <param name="val"></param>
    /// <returns></returns>
    public TrimFilter EndFrame(long val)
      => this.SetOptionRange("end_frame", val, 0, long.MaxValue);
  }

  public static class TrimFilterExtension
  {
    public static TrimFilter TrimFilter(this ImageMap imageMap)
    {
      return new TrimFilter(imageMap);
    }
  }
}
