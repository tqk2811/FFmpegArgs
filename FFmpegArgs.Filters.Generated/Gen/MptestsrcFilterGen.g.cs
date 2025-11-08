namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. mptestsrc         |-&gt;V       Generate various test pattern.
    /// </summary>
    public class MptestsrcFilterGen : SourceToImageFilter
    {
        internal MptestsrcFilterGen(IImageFilterGraph input) : base("mptestsrc", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public MptestsrcFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToString());
        /// <summary>
        ///  set video duration (default -0.000001)
        /// </summary>
        public MptestsrcFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration", duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        ///  set test to perform (from 0 to INT_MAX) (default all)
        /// </summary>
        public MptestsrcFilterGen test(MptestsrcFilterGenTest test) => this.SetOption("test", test.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Set the maximum number of frames generated for each test (from 1 to I64_MAX) (default 30)
        /// </summary>
        public MptestsrcFilterGen max_frames(long max_frames) => this.SetOptionRange("max_frames", max_frames, 1, I64_MAX);
    }

    /// <summary>
    ///  set test to perform (from 0 to INT_MAX) (default all)
    /// </summary>
    public enum MptestsrcFilterGenTest
    {
        /// <summary>
        /// dc_luma         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dc_luma")]
        dc_luma = 0,
        /// <summary>
        /// dc_chroma       1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dc_chroma")]
        dc_chroma = 1,
        /// <summary>
        /// freq_luma       2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("freq_luma")]
        freq_luma = 2,
        /// <summary>
        /// freq_chroma     3            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("freq_chroma")]
        freq_chroma = 3,
        /// <summary>
        /// amp_luma        4            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("amp_luma")]
        amp_luma = 4,
        /// <summary>
        /// amp_chroma      5            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("amp_chroma")]
        amp_chroma = 5,
        /// <summary>
        /// cbp             6            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cbp")]
        cbp = 6,
        /// <summary>
        /// mv              7            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mv")]
        mv = 7,
        /// <summary>
        /// ring1           8            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ring1")]
        ring1 = 8,
        /// <summary>
        /// ring2           9            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ring2")]
        ring2 = 9,
        /// <summary>
        /// all             10           ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("all")]
        all = 10
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Generate various test pattern.
        /// </summary>
        public static MptestsrcFilterGen MptestsrcFilterGen(this IImageFilterGraph input) => new MptestsrcFilterGen(input);
    }
}