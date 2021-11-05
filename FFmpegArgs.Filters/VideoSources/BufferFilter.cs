using FFmpegArgs.Filters.Enums;
using FFmpegArgs.Filters.VideoFilters;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Filters.VideoSources
{
  /// <summary>
  /// ... buffer            |->V       Buffer video frames, and make them accessible to the filterchain.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#buffer
  /// </summary>
  public class BufferFilter : SourceImageFilter
  {
    readonly Expression expression = new Expression();
    internal BufferFilter(FilterGraph filterGraph) : base("buffer", filterGraph)
    {
      AddMapOut();
    }

    /// <summary>
    /// Specify the size (width and height) of the buffered video frames.
    /// </summary>
    /// <param name="videoSize"></param>
    /// <returns></returns>
    public BufferFilter VideoSize(VideoSizeUtils videoSize)
      => this.SetOption("video_size", videoSize.GetAttribute<NameAttribute>().Name);

    /// <summary>
    /// The input video width.
    /// </summary>
    /// <param name="width"></param>
    /// <returns></returns>
    public BufferFilter Width(int width)
      => this.SetOptionRange("width", width, 0, int.MaxValue);

    /// <summary>
    /// The input video height.
    /// </summary>
    /// <param name="height"></param>
    /// <returns></returns>
    public BufferFilter Height(int height)
      => this.SetOptionRange("width", height, 0, int.MaxValue);

    /// <summary>
    /// A string representing the pixel format of the buffered video frames. It may be a number corresponding to a pixel format, or a pixel format name.
    /// </summary>
    /// <param name="pix_fmt"></param>
    /// <returns></returns>
    public BufferFilter PixFmt(FormatPixFmt pix_fmt)
      => this.SetOption("pix_fmt", pix_fmt);

    /// <summary>
    /// Specify the timebase assumed by the timestamps of the buffered frames.
    /// </summary>
    /// <param name="time_base"></param>
    /// <returns></returns>
    public BufferFilter TimeBase(TimeSpan time_base)
      => this.SetOptionRange("time_base", time_base, TimeSpan.Zero, TimeSpan.MaxValue);

    /// <summary>
    /// Specify the frame rate expected for the video stream.
    /// </summary>
    /// <param name="frame_rate"></param>
    /// <returns></returns>
    public BufferFilter FrameRate(float frame_rate)
      => this.SetOptionRange("frame_rate", frame_rate,0, float.MaxValue);

    /// <summary>
    /// The sample (pixel) aspect ratio of the input video.
    /// </summary>
    /// <param name="sar"></param>
    /// <returns></returns>
    public BufferFilter Sar(string sar)
      => this.SetOption("sar", sar.Expression().Run(expression));

    /// <summary>
    /// The sample (pixel) aspect ratio of the input video.
    /// </summary>
    /// <param name="sar"></param>
    /// <returns></returns>
    public BufferFilter Sar(Action<Expression> sar)
      => this.SetOption("sar", sar.Run(expression));

    ///// <summary>
    ///// When using a hardware pixel format, this should be a reference to an AVHWFramesContext describing input frames.
    ///// </summary>
    ///// <returns></returns>
    //public BufferFilter HwFramesCtx(hw_frames_ctx)
    //  => this.SetOption("hw_frames_ctx", hw_frames_ctx);
  }

  public static class BufferFilterExtensions
  {
    /// <summary>
    /// Buffer video frames, and make them available to the filter chain.<br></br>
    /// This source is mainly intended for a programmatic use, in particular through the interface defined in libavfilter/buffersrc.h.
    /// </summary>
    /// <param name="filterGraph"></param>
    /// <returns></returns>
    public static BufferFilter BufferFilter(this FilterGraph filterGraph)
      => new BufferFilter(filterGraph);
  }
}
