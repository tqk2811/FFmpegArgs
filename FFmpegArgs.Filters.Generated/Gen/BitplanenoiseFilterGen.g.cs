namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. bitplanenoise     V-&gt;V       Measure bit plane noise.
    /// </summary>
    public class BitplanenoiseFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal BitplanenoiseFilterGen(ImageMap input) : base("bitplanenoise", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set bit plane to use for measuring noise (from 1 to 16) (default 1)
        /// </summary>
        public BitplanenoiseFilterGen bitplane(int bitplane) => this.SetOptionRange("bitplane", bitplane, 1, 16);
        /// <summary>
        ///  show noisy pixels (default false)
        /// </summary>
        public BitplanenoiseFilterGen filter(bool filter) => this.SetOption("filter", filter.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Measure bit plane noise.
        /// </summary>
        public static BitplanenoiseFilterGen BitplanenoiseFilterGen(this ImageMap input0) => new BitplanenoiseFilterGen(input0);
    }
}