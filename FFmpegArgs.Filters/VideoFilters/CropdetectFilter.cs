using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// T.. cropdetect        V->V       Auto-detect crop size.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#cropdetect
    /// </summary>
    public class CropdetectFilter : ImageToImageFilter, ITimelineSupport
    {
        internal CropdetectFilter(ImageMap imageMap) : base("cropdetect", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set higher black value threshold,  An intensity value greater to the set value is considered non-black<br></br>
        /// You can also specify a value between 0.0 and 1.0 which will be scaled depending on the bitdepth of the pixel format.<br>
        /// </br>(from 0 to 65535) (default 0.0941176)
        /// </summary>
        /// <param name="limit"></param>
        /// <returns></returns>
        public CropdetectFilter Limit(float limit)
            => this.SetOptionRange("limit", limit, 0, 65535);

        /// <summary>
        /// The value which the width/height should be divisible by. It defaults to 16. The offset is automatically adjusted to center the video.<br>
        /// </br> Use 2 to get only even dimensions (needed for 4:2:2 video). 16 is best when encoding to most video codecs.
        /// </summary>
        /// <param name="round"></param>
        /// <returns></returns>
        public CropdetectFilter Round(int round)
            => this.SetOptionRange("round", round, 0, int.MaxValue);

        /// <summary>
        /// Recalculate the crop area after this many frames (from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="reset"></param>
        /// <returns></returns>
        public CropdetectFilter Reset(int reset)
            => this.SetOptionRange("reset", reset, 0, int.MaxValue);


        /// <summary>
        /// Set the number of initial frames for which evaluation is skipped. Default is 2. Range is 0 to INT_MAX.
        /// </summary>
        /// <param name="skip"></param>
        /// <returns></returns>
        public CropdetectFilter Skip(int skip)
            => this.SetOptionRange("skip", skip, 0, int.MaxValue);

        /// <summary>
        /// Set the counter that determines after how many frames cropdetect will reset the previously detected largest video area and start over to detect the current optimal crop area.<br>
        /// </br> Default value is 0.<br>
        /// </br>This can be useful when channel logos distort the video area. 0 indicates ’never reset’, and returns the largest area encountered during playback.
        /// </summary>
        /// <param name="reset"></param>
        /// <returns></returns>
        public CropdetectFilter ResetCount(int reset)
            => this.SetOptionRange("reset", reset, 0, int.MaxValue);
    }

    public static class CropdetectFilterExtensions
    {
        /// <summary>
        /// Auto-detect the crop size.<br></br>
        /// It calculates the necessary cropping parameters and prints the recommended parameters via the logging system.The detected dimensions correspond to the non-black area of the input video.
        /// </summary>
        public static CropdetectFilter CropdetectFilter(this ImageMap imageMap)
          => new CropdetectFilter(imageMap);
    }
}
