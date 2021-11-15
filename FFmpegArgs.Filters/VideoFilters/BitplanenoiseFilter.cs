using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// T.. bitplanenoise     V->V       Measure bit plane noise.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#bitplanenoise
    /// </summary>
    public class BitplanenoiseFilter : ImageToImageFilter, ITimelineSupport
    {
        internal BitplanenoiseFilter(ImageMap imageMap) : base("bitplanenoise", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set which plane to analyze. Default is 1.<br>
        /// </br>..FV....... set bit plane to use for measuring noise (from 1 to 16) (default 1)
        /// </summary>
        /// <param name="bitplane"></param>
        /// <returns></returns>
        public BitplanenoiseFilter Bitplane(int bitplane)
          => this.SetOptionRange("bitplane", bitplane, 0, 16);

        /// <summary>
        /// Filter out noisy pixels from bitplane set above. Default is disabled.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public BitplanenoiseFilter filter(bool flag)
          => this.SetOption("filter", flag.ToFFmpegFlag());
    }

    public static class BitplanenoiseFilterExtensions
    {
        /// <summary>
        /// Show and measure bit plane noise.
        /// </summary>
        public static BitplanenoiseFilter BitplanenoiseFilter(this ImageMap imageMap)
          => new BitplanenoiseFilter(imageMap);
    }
}
