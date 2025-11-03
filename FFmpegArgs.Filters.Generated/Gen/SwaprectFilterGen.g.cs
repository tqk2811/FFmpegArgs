namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. swaprect          V-&gt;V       Swap 2 rectangular objects in video.
    /// </summary>
    public class SwaprectFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal SwaprectFilterGen(ImageMap input) : base("swaprect", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set rect width (default &quot;w/2&quot;)
        /// </summary>
        public SwaprectFilterGen w(String w) => this.SetOption("w", w.ToStringInv());
        /// <summary>
        ///  set rect height (default &quot;h/2&quot;)
        /// </summary>
        public SwaprectFilterGen h(String h) => this.SetOption("h", h.ToStringInv());
        /// <summary>
        ///  set 1st rect x top left coordinate (default &quot;w/2&quot;)
        /// </summary>
        public SwaprectFilterGen x1(String x1) => this.SetOption("x1", x1.ToStringInv());
        /// <summary>
        ///  set 1st rect y top left coordinate (default &quot;h/2&quot;)
        /// </summary>
        public SwaprectFilterGen y1(String y1) => this.SetOption("y1", y1.ToStringInv());
        /// <summary>
        ///  set 2nd rect x top left coordinate (default &quot;0&quot;)
        /// </summary>
        public SwaprectFilterGen x2(String x2) => this.SetOption("x2", x2.ToStringInv());
        /// <summary>
        ///  set 2nd rect y top left coordinate (default &quot;0&quot;)
        /// </summary>
        public SwaprectFilterGen y2(String y2) => this.SetOption("y2", y2.ToStringInv());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Swap 2 rectangular objects in video.
        /// </summary>
        public static SwaprectFilterGen SwaprectFilterGen(this ImageMap input0) => new SwaprectFilterGen(input0);
    }
}