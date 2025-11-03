namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. settb             V-&gt;V       Set timebase for the video output link.
    /// </summary>
    public class SettbFilterGen : ImageToImageFilter
    {
        internal SettbFilterGen(ImageMap input) : base("settb", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set expression determining the output timebase (default &quot;intb&quot;)
        /// </summary>
        public SettbFilterGen expr(ExpressionValue expr) => this.SetOption("expr", (string)expr);
        /// <summary>
        ///  set expression determining the output timebase (default &quot;intb&quot;)
        /// </summary>
        public SettbFilterGen tb(ExpressionValue tb) => this.SetOption("tb", (string)tb);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Set timebase for the video output link.
        /// </summary>
        public static SettbFilterGen SettbFilterGen(this ImageMap input0) => new SettbFilterGen(input0);
    }
}