namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS shufflepixels     V-&gt;V       Shuffle video pixels.
    /// </summary>
    public class ShufflepixelsFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal ShufflepixelsFilterGen(ImageMap input) : base("shufflepixels", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set shuffle direction (from 0 to 1) (default forward)
        /// </summary>
        public ShufflepixelsFilterGen direction(ShufflepixelsFilterGenDirection direction) => this.SetOption("direction", direction.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set shuffle mode (from 0 to 2) (default horizontal)
        /// </summary>
        public ShufflepixelsFilterGen mode(ShufflepixelsFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set block width (from 1 to 8000) (default 10)
        /// </summary>
        public ShufflepixelsFilterGen width(int width) => this.SetOptionRange("width", width, 1, 8000);
        /// <summary>
        ///  set block height (from 1 to 8000) (default 10)
        /// </summary>
        public ShufflepixelsFilterGen height(int height) => this.SetOptionRange("height", height, 1, 8000);
        /// <summary>
        ///  set random seed (from -1 to UINT32_MAX) (default -1)
        /// </summary>
        public ShufflepixelsFilterGen seed(long seed) => this.SetOptionRange("seed", seed, -1, UINT32_MAX);
    }

    /// <summary>
    ///  set shuffle direction (from 0 to 1) (default forward)
    /// </summary>
    public enum ShufflepixelsFilterGenDirection
    {
        /// <summary>
        /// forward         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("forward")]
        forward = 0,
        /// <summary>
        /// inverse         1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("inverse")]
        inverse = 1
    }

    /// <summary>
    ///  set shuffle mode (from 0 to 2) (default horizontal)
    /// </summary>
    public enum ShufflepixelsFilterGenMode
    {
        /// <summary>
        /// horizontal      0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("horizontal")]
        horizontal = 0,
        /// <summary>
        /// vertical        1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vertical")]
        vertical = 1,
        /// <summary>
        /// block           2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("block")]
        block = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Shuffle video pixels.
        /// </summary>
        public static ShufflepixelsFilterGen ShufflepixelsFilterGen(this ImageMap input0) => new ShufflepixelsFilterGen(input0);
    }
}