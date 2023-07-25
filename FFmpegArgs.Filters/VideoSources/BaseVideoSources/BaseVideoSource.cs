namespace FFmpegArgs.Filters.VideoSources
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class BaseVideoSource : SourceImageFilter
    {
        internal BaseVideoSource(string filterName, IImageFilterGraph filterGraph) : base(filterName, filterGraph)
        {
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public interface IBaseVideoSourceSize// : IFilter
    {
    }
    /// <summary>
    /// 
    /// </summary>
    public static class BaseVideoSourceExtensions
    {
        /// <summary>
        /// Specify the frame rate of the sourced video, as the number of frames generated per second.<br>
        /// </br> It has to be a string in the format frame_rate_num/frame_rate_den, an integer number, a floating point number or a valid video frame rate abbreviation.<br>
        /// </br> The default value is "25".
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static T Rate<T>(this T t, Rational r) where T : BaseVideoSource
         => t.SetOption("r", r);
        /// <summary>
        /// If not specified, or the expressed duration is negative, the video is supposed to be generated forever.<br></br>
        /// Since the frame rate is used as time base, all frames including the last one will have their full duration.<br>
        /// </br>If the specified duration is not a multiple of the frame duration, it will be rounded up.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="d"></param>
        /// <returns></returns>
        public static T Duration<T>(this T t, TimeSpan d) where T : BaseVideoSource
          => t.SetOptionRange("d", d, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        /// Set the sample aspect ratio of the sourced video.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="sar"></param>
        /// <returns></returns>
        public static T Sar<T>(this T t, ExpressionValue sar) where T : BaseVideoSource
          => t.SetOption("sar", FFmpegExpression.DefaultInstance.Check(sar));
        /// <summary>
        /// Specify the size of the sourced video.<br></br>
        /// The default value is 320x240.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static T Size<T>(this T t, Size size) where T : BaseVideoSource, IBaseVideoSourceSize
          => t.SetOption("s", $"{size.Width}x{size.Height}");
        /// <summary>
        /// Specify the size of the sourced video.<br></br>
        /// The default value is 320x240.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static T Size<T>(this T t, VideoSizeUtils size) where T : BaseVideoSource, IBaseVideoSourceSize
          => t.SetOption("s", size.GetEnumAttribute<NameAttribute>().Name);
    }
}
