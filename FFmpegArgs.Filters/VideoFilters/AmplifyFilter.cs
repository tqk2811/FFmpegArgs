using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC amplify           V->V       Amplify changes between successive video frames.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#amplify
    /// </summary>
    public class AmplifyFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal AmplifyFilter(ImageMap imageMap) : base("amplify", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set frame radius. Default is 2. Allowed range is from 1 to 63.<br>
        /// </br> For example radius of 3 will instruct filter to calculate average of 7 frames.
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public AmplifyFilter Radius(int radius)
          => this.SetOptionRange("radius", radius, 1, 63);

        /// <summary>
        /// Set factor to amplify difference. Default is 2. Allowed range is from 0 to 65535.
        /// </summary>
        /// <param name="factor"></param>
        /// <returns></returns>
        public AmplifyFilter Factor(int factor)
          => this.SetOptionRange("factor", factor, 0, 65535);

        /// <summary>
        /// Set threshold for difference amplification. Any difference greater or equal to this value will not alter source pixel.<br>
        /// </br> Default is 10. Allowed range is from 0 to 65535.
        /// </summary>
        /// <param name="threshold"></param>
        /// <returns></returns>
        public AmplifyFilter Threshold(int threshold)
          => this.SetOptionRange("threshold", threshold, 0, 65535);

        /// <summary>
        /// Set tolerance for difference amplification. Any difference lower to this value will not alter source pixel.<br>
        /// </br> Default is 0. Allowed range is from 0 to 65535.
        /// </summary>
        /// <param name="tolerance"></param>
        /// <returns></returns>
        public AmplifyFilter Tolerance(int tolerance)
          => this.SetOptionRange("tolerance", tolerance, 0, 65535);

        /// <summary>
        /// Set lower limit for changing source pixel. Default is 65535. Allowed range is from 0 to 65535.<br>
        /// </br> This option controls maximum possible value that will decrease source pixel value.
        /// </summary>
        /// <param name="low"></param>
        /// <returns></returns>
        public AmplifyFilter Low(int low)
          => this.SetOptionRange("low", low, 0, 65535);

        /// <summary>
        /// Set high limit for changing source pixel. Default is 65535. Allowed range is from 0 to 65535.<br>
        /// </br> This option controls maximum possible value that will increase source pixel value.
        /// </summary>
        /// <param name="high"></param>
        /// <returns></returns>
        public AmplifyFilter High(int high)
          => this.SetOptionRange("high", high, 0, 65535);

        /// <summary>
        /// Set which planes to filter. Default is all. Allowed range is from 0 to 15.
        /// </summary>
        /// <param name="planes"></param>
        /// <returns></returns>
        public AmplifyFilter Planes(int planes)
          => this.SetOptionRange("planes", planes, 0, 15);
    }

    public static class AmplifyFilterExtensions
    {
        /// <summary>
        /// Amplify differences between current pixel and pixels of adjacent frames in same pixel location.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <returns></returns>
        public static AmplifyFilter AmplifyFilter(this ImageMap imageMap)
          => new AmplifyFilter(imageMap);
    }
}
