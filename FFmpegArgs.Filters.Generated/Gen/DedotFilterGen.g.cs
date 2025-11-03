namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS dedot             V-&gt;V       Reduce cross-luminance and cross-color.
    /// </summary>
    public class DedotFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal DedotFilterGen(ImageMap input) : base("dedot", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set filtering mode (default dotcrawl+rainbows)
        /// </summary>
        public DedotFilterGen m(DedotFilterGenM m) => this.SetOption("m", m.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set spatial luma threshold (from 0 to 1) (default 0.079)
        /// </summary>
        public DedotFilterGen lt(float lt) => this.SetOptionRange("lt", lt, 0, 1);
        /// <summary>
        ///  set tolerance for temporal luma (from 0 to 1) (default 0.079)
        /// </summary>
        public DedotFilterGen tl(float tl) => this.SetOptionRange("tl", tl, 0, 1);
        /// <summary>
        ///  set tolerance for chroma temporal variation (from 0 to 1) (default 0.058)
        /// </summary>
        public DedotFilterGen tc(float tc) => this.SetOptionRange("tc", tc, 0, 1);
        /// <summary>
        ///  set temporal chroma threshold (from 0 to 1) (default 0.019)
        /// </summary>
        public DedotFilterGen ct(float ct) => this.SetOptionRange("ct", ct, 0, 1);
    }

    /// <summary>
    ///  set filtering mode (default dotcrawl+rainbows)
    /// </summary>
    public enum DedotFilterGenM
    {
        /// <summary>
        /// dotcrawl                     ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dotcrawl")]
        dotcrawl,
        /// <summary>
        /// rainbows                     ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rainbows")]
        rainbows
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Reduce cross-luminance and cross-color.
        /// </summary>
        public static DedotFilterGen DedotFilterGen(this ImageMap input0) => new DedotFilterGen(input0);
    }
}