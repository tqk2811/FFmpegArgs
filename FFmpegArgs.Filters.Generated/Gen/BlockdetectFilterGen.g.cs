namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... blockdetect       V-&gt;V       Blockdetect filter.
    /// </summary>
    public class BlockdetectFilterGen : ImageToImageFilter
    {
        internal BlockdetectFilterGen(ImageMap input) : base("blockdetect", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Minimum period to search for (from 2 to 32) (default 3)
        /// </summary>
        public BlockdetectFilterGen period_min(int period_min) => this.SetOptionRange("period_min", period_min, 2, 32);
        /// <summary>
        ///  Maximum period to search for (from 2 to 64) (default 24)
        /// </summary>
        public BlockdetectFilterGen period_max(int period_max) => this.SetOptionRange("period_max", period_max, 2, 64);
        /// <summary>
        ///  set planes to filter (from 0 to 15) (default 1)
        /// </summary>
        public BlockdetectFilterGen planes(int planes) => this.SetOptionRange("planes", planes, 0, 15);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Blockdetect filter.
        /// </summary>
        public static BlockdetectFilterGen BlockdetectFilterGen(this ImageMap input0) => new BlockdetectFilterGen(input0);
    }
}