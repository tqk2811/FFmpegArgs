using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... blackframe        V->V       Detect frames that are (almost) black.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#blackframe
    /// </summary>
    public class BlackframeFilter : ImageToImageFilter
    {
        internal BlackframeFilter(ImageMap imageMap) : base("", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// The percentage of the pixels that have to be below the threshold; it defaults to 98.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public BlackframeFilter Amount(float amount)
          => this.SetOptionRange("amount", amount, 0, 100);

        /// <summary>
        /// The threshold below which a pixel value is considered black; it defaults to 32.
        /// </summary>
        /// <param name="thresh"></param>
        /// <returns></returns>
        public BlackframeFilter Threshold(int thresh)
          => this.SetOptionRange("thresh", thresh, 0, int.MaxValue);
    }

    public static class BlackframeFilterExtensions
    {
        /// <summary>
        /// Detect frames that are (almost) completely black. Can be useful to detect chapter transitions or commercials.<br>
        /// </br> Output lines consist of the frame number of the detected frame, the percentage of blackness, the position in the file if known or -1 and the timestamp in seconds.
        /// In order to display the output lines, you need to set the loglevel at least to the AV_LOG_INFO value.<br></br>
        /// This filter exports frame metadata lavfi.blackframe.pblack.The value represents the percentage of pixels in the picture that are below the threshold value.
        /// </summary>
        public static BlackframeFilter BlackframeFilter(this ImageMap imageMap)
          => new BlackframeFilter(imageMap);
    }
}
