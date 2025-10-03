namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... addroi            V-&gt;V       Add region of interest to frame.
    /// </summary>
    public class AddroiFilterGen : ImageToImageFilter
    {
        internal AddroiFilterGen(ImageMap input) : base("addroi", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Region distance from left edge of frame. (default &quot;0&quot;)
        /// </summary>
        public AddroiFilterGen x(String x) => this.SetOption("x", x.ToString());
        /// <summary>
        ///  Region distance from top edge of frame. (default &quot;0&quot;)
        /// </summary>
        public AddroiFilterGen y(String y) => this.SetOption("y", y.ToString());
        /// <summary>
        ///  Region width. (default &quot;0&quot;)
        /// </summary>
        public AddroiFilterGen w(String w) => this.SetOption("w", w.ToString());
        /// <summary>
        ///  Region height. (default &quot;0&quot;)
        /// </summary>
        public AddroiFilterGen h(String h) => this.SetOption("h", h.ToString());
        /// <summary>
        ///  Quantisation offset to apply in the region. (from -1 to 1) (default -1/10)
        /// </summary>
        public AddroiFilterGen qoffset(Rational qoffset) => this.SetOption("qoffset", qoffset.Check(-1, 1));
        /// <summary>
        ///  Remove any existing regions of interest before adding the new one. (default false)
        /// </summary>
        public AddroiFilterGen clear(bool clear) => this.SetOption("clear", clear.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Add region of interest to frame.
        /// </summary>
        public static AddroiFilterGen AddroiFilterGen(this ImageMap input0) => new AddroiFilterGen(input0);
    }
}