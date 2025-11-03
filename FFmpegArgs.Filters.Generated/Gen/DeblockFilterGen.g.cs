namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. deblock           V-&gt;V       Deblock video.
    /// </summary>
    public class DeblockFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal DeblockFilterGen(ImageMap input) : base("deblock", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set type of filter (from 0 to 1) (default strong)
        /// </summary>
        public DeblockFilterGen filter(DeblockFilterGenFilter filter) => this.SetOption("filter", filter.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set size of block (from 4 to 512) (default 8)
        /// </summary>
        public DeblockFilterGen block(int block) => this.SetOptionRange("block", block, 4, 512);
        /// <summary>
        ///  set 1st detection threshold (from 0 to 1) (default 0.098)
        /// </summary>
        public DeblockFilterGen alpha(float alpha) => this.SetOptionRange("alpha", alpha, 0, 1);
        /// <summary>
        ///  set 2nd detection threshold (from 0 to 1) (default 0.05)
        /// </summary>
        public DeblockFilterGen beta(float beta) => this.SetOptionRange("beta", beta, 0, 1);
        /// <summary>
        ///  set 3rd detection threshold (from 0 to 1) (default 0.05)
        /// </summary>
        public DeblockFilterGen gamma(float gamma) => this.SetOptionRange("gamma", gamma, 0, 1);
        /// <summary>
        ///  set 4th detection threshold (from 0 to 1) (default 0.05)
        /// </summary>
        public DeblockFilterGen delta(float delta) => this.SetOptionRange("delta", delta, 0, 1);
        /// <summary>
        ///  set planes to filter (from 0 to 15) (default 15)
        /// </summary>
        public DeblockFilterGen planes(int planes) => this.SetOptionRange("planes", planes, 0, 15);
    }

    /// <summary>
    ///  set type of filter (from 0 to 1) (default strong)
    /// </summary>
    public enum DeblockFilterGenFilter
    {
        /// <summary>
        /// weak            0            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("weak")]
        weak = 0,
        /// <summary>
        /// strong          1            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("strong")]
        strong = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Deblock video.
        /// </summary>
        public static DeblockFilterGen DeblockFilterGen(this ImageMap input0) => new DeblockFilterGen(input0);
    }
}