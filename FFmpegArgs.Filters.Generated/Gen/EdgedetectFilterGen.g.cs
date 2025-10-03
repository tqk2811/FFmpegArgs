namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T.. edgedetect        V-&gt;V       Detect and draw edge.
    /// </summary>
    public class EdgedetectFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal EdgedetectFilterGen(ImageMap input) : base("edgedetect", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set high threshold (from 0 to 1) (default 0.196078)
        /// </summary>
        public EdgedetectFilterGen high(double high) => this.SetOptionRange("high", high, 0, 1);
        /// <summary>
        ///  set low threshold (from 0 to 1) (default 0.0784314)
        /// </summary>
        public EdgedetectFilterGen low(double low) => this.SetOptionRange("low", low, 0, 1);
        /// <summary>
        ///  set mode (from 0 to 2) (default wires)
        /// </summary>
        public EdgedetectFilterGen mode(EdgedetectFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set planes to filter (default y+u+v+r+g+b)
        /// </summary>
        public EdgedetectFilterGen planes(EdgedetectFilterGenPlanes planes) => this.SetOption("planes", planes.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set mode (from 0 to 2) (default wires)
    /// </summary>
    public enum EdgedetectFilterGenMode
    {
        /// <summary>
        /// wires           0            ..FV....... white/gray wires on black
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wires")]
        wires = 0,
        /// <summary>
        /// colormix        1            ..FV....... mix colors
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("colormix")]
        colormix = 1,
        /// <summary>
        /// canny           2            ..FV....... detect edges on planes
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("canny")]
        canny = 2
    }

    /// <summary>
    ///  set planes to filter (default y+u+v+r+g+b)
    /// </summary>
    public enum EdgedetectFilterGenPlanes
    {
        /// <summary>
        /// y                            ..FV....... filter luma plane
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("y")]
        y,
        /// <summary>
        /// u                            ..FV....... filter u plane
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("u")]
        u,
        /// <summary>
        /// v                            ..FV....... filter v plane
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("v")]
        v,
        /// <summary>
        /// r                            ..FV....... filter red plane
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("r")]
        r,
        /// <summary>
        /// g                            ..FV....... filter green plane
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("g")]
        g,
        /// <summary>
        /// b                            ..FV....... filter blue plane
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("b")]
        b
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Detect and draw edge.
        /// </summary>
        public static EdgedetectFilterGen EdgedetectFilterGen(this ImageMap input0) => new EdgedetectFilterGen(input0);
    }
}