namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... setdar            V-&gt;V       Set the frame display aspect ratio.
    /// </summary>
    public class SetdarFilterGen : ImageToImageFilter
    {
        internal SetdarFilterGen(ImageMap input) : base("setdar", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set display aspect ratio (default &quot;0&quot;)
        /// </summary>
        public SetdarFilterGen dar(String dar) => this.SetOption("dar", dar.ToString());
        /// <summary>
        ///  set display aspect ratio (default &quot;0&quot;)
        /// </summary>
        public SetdarFilterGen ratio(String ratio) => this.SetOption("ratio", ratio.ToString());
        /// <summary>
        ///  set display aspect ratio (default &quot;0&quot;)
        /// </summary>
        public SetdarFilterGen r(String r) => this.SetOption("r", r.ToString());
        /// <summary>
        ///  set max value for nominator or denominator in the ratio (from 1 to INT_MAX) (default 100)
        /// </summary>
        public SetdarFilterGen max(int max) => this.SetOptionRange("max", max, 1, INT_MAX);
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Set the frame display aspect ratio.
        /// </summary>
        public static SetdarFilterGen SetdarFilterGen(this ImageMap input0) => new SetdarFilterGen(input0);
    }
}