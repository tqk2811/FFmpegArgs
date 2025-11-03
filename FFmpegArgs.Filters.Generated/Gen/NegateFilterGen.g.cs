namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS negate            V-&gt;V       Negate input video.
    /// </summary>
    public class NegateFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal NegateFilterGen(ImageMap input) : base("negate", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set components to negate (default y+u+v+r+g+b)
        /// </summary>
        public NegateFilterGen components(NegateFilterGenComponents components) => this.SetOption("components", components.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  (default false)
        /// </summary>
        public NegateFilterGen negate_alpha(bool negate_alpha) => this.SetOption("negate_alpha", negate_alpha.ToFFmpegFlag());
    }

    /// <summary>
    ///  set components to negate (default y+u+v+r+g+b)
    /// </summary>
    public enum NegateFilterGenComponents
    {
        /// <summary>
        /// y                            ..FV.....T. set luma component
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("y")]
        y,
        /// <summary>
        /// u                            ..FV.....T. set u component
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("u")]
        u,
        /// <summary>
        /// v                            ..FV.....T. set v component
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("v")]
        v,
        /// <summary>
        /// r                            ..FV.....T. set red component
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("r")]
        r,
        /// <summary>
        /// g                            ..FV.....T. set green component
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("g")]
        g,
        /// <summary>
        /// b                            ..FV.....T. set blue component
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("b")]
        b,
        /// <summary>
        /// a                            ..FV.....T. set alpha component
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("a")]
        a
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Negate input video.
        /// </summary>
        public static NegateFilterGen NegateFilterGen(this ImageMap input0) => new NegateFilterGen(input0);
    }
}