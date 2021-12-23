using FFmpegArgs.Expressions;
using FFmpegArgs.Filters.Enums;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoSources
{
    /// <summary>
    /// ... buffer            |->V       Buffer video frames, and make them accessible to the filterchain.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#buffer
    /// </summary>
    public class BufferFilter : SourceImageFilter
    {
        readonly FFmpegExpression expression = new FFmpegExpression();
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
        /// Specify the size (width and height) of the buffered video frames.
        /// </summary>
        /// <param name="videoSize"></param>
        /// <returns></returns>
        public BufferFilter VideoSize(Size videoSize)
          => this.SetOption("video_size", $"{videoSize.Width}x{videoSize.Height}");

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
        public BufferFilter PixFmt(PixFmt pix_fmt)
          => this.SetOption("pix_fmt", pix_fmt);

        /// <summary>
        /// Specify the timebase assumed by the timestamps of the buffered frames.<br></br>(from 0 to DBL_MAX) (default 0/1)
        /// </summary>
        /// <param name="time_base"></param>
        /// <returns></returns>
        public BufferFilter TimeBase(Rational time_base)
          => this.SetOption("time_base", time_base.Check(0, INT_MAX));

        /// <summary>
        /// Specify the frame rate expected for the video stream.<br></br>(from 0 to DBL_MAX) (default 0/1)
        /// </summary>
        /// <param name="frame_rate"></param>
        /// <returns></returns>
        public BufferFilter FrameRate(Rational frame_rate)
          => this.SetOption("frame_rate", frame_rate.Check(0, DBL_MAX));

        /// <summary>
        /// (pixel_aspect) The sample (pixel) aspect ratio of the input video.<br>
        /// </br>sample aspect ratio (from 0 to DBL_MAX) (default 0/1)
        /// </summary>
        /// <param name="sar"></param>
        /// <returns></returns>
        public BufferFilter Sar(Rational sar)
          => this.SetOption("sar", sar.Check(0, DBL_MAX));

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public BufferFilter SwsParam(string sws_param)
          => this.SetOption("sws_param", sws_param);
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
