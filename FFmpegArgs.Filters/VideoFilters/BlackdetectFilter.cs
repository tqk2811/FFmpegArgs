namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// .S. blackdetect       V->V       Detect video intervals that are (almost) black.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#blackdetect
    /// </summary>
    public class BlackdetectFilter : ImageToImageFilter, ISliceThreading
    {
        internal BlackdetectFilter(ImageMap imageMap) : base("blackdetect", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the minimum detected black duration expressed in seconds. It must be a non-negative floating point number.<br></br>
        /// Default value is 2.0.
        /// </summary>
        /// <param name="duration"></param>
        /// <returns></returns>
        public BlackdetectFilter BlackMinDuration(TimeSpan duration)
          => this.SetOptionRange("d", duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        /// Set the threshold for considering a picture "black". Express the minimum value for the ratio: nb_black_pixels / nb_pixels <br></br>
        /// for which a picture is considered black. Default value is 0.98.
        /// </summary>
        /// <param name="pic_th"></param>
        /// <returns></returns>
        public BlackdetectFilter PictureBlackRatioTh(double pic_th)
          => this.SetOptionRange("pic_th", pic_th, 0, 1);
        /// <summary>
        /// Set the threshold for considering a pixel "black".<br></br>
        /// The threshold expresses the maximum pixel luminance value for which a pixel is considered "black". The provided value is scaled according to the following equation:<br></br>
        /// absolute_threshold = luminance_minimum_value + pixel_black_th * luminance_range_size <br></br>
        /// luminance_range_size and luminance_minimum_value depend on the input video format, the range is [0-255] for YUV full-range formats and [16-235] for YUV non full-range formats.<br></br>
        /// Default value is 0.10.
        /// </summary>
        /// <param name="pix_th"></param>
        /// <returns></returns>
        public BlackdetectFilter PixelBlackTh(double pix_th)
          => this.SetOptionRange("pix_th", pix_th, 0, 1);
    }
    public static class BlackdetectFilterExtensions
    {
        /// <summary>
        /// Detect video intervals that are (almost) completely black. Can be useful to detect chapter transitions, commercials, or invalid recordings.<br></br>
        /// The filter outputs its detection analysis to both the log as well as frame metadata.If a black segment of at least the specified minimum duration is found, a line with the start and end timestamps as well as duration is printed to the log with level info.In addition, a log line with level debug is printed per frame showing the black amount detected for that frame.<br></br>
        /// The filter also attaches metadata to the first frame of a black segment with key lavfi.black_start and to the first frame after the black segment ends with key lavfi.black_end.The value is the frame’s timestamp. This metadata is added regardless of the minimum duration specified.
        /// </summary>
        public static BlackdetectFilter BlackdetectFilter(this ImageMap imageMap)
          => new BlackdetectFilter(imageMap);
    }
}
