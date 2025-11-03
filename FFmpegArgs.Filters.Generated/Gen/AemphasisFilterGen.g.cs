namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS aemphasis         A-&gt;A       Audio emphasis.
    /// </summary>
    public class AemphasisFilterGen : AudioToAudioFilter, ITimelineSupport, ISliceThreading
    {
        internal AemphasisFilterGen(AudioMap input) : base("aemphasis", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set input gain (from 0 to 64) (default 1)
        /// </summary>
        public AemphasisFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in, 0, 64);
        /// <summary>
        ///  set output gain (from 0 to 64) (default 1)
        /// </summary>
        public AemphasisFilterGen level_out(double level_out) => this.SetOptionRange("level_out", level_out, 0, 64);
        /// <summary>
        ///  set filter mode (from 0 to 1) (default reproduction)
        /// </summary>
        public AemphasisFilterGen mode(AemphasisFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set filter type (from 0 to 8) (default cd)
        /// </summary>
        public AemphasisFilterGen type(AemphasisFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set filter mode (from 0 to 1) (default reproduction)
    /// </summary>
    public enum AemphasisFilterGenMode
    {
        /// <summary>
        /// reproduction    0            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("reproduction")]
        reproduction = 0,
        /// <summary>
        /// production      1            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("production")]
        production = 1
    }

    /// <summary>
    ///  set filter type (from 0 to 8) (default cd)
    /// </summary>
    public enum AemphasisFilterGenType
    {
        /// <summary>
        /// col             0            ..F.A....T. Columbia
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("col")]
        col = 0,
        /// <summary>
        /// emi             1            ..F.A....T. EMI
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("emi")]
        emi = 1,
        /// <summary>
        /// bsi             2            ..F.A....T. BSI (78RPM)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bsi")]
        bsi = 2,
        /// <summary>
        /// riaa            3            ..F.A....T. RIAA
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("riaa")]
        riaa = 3,
        /// <summary>
        /// cd              4            ..F.A....T. Compact Disc (CD)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cd")]
        cd = 4,
        /// <summary>
        /// 50fm            5            ..F.A....T. 50┬╡s (FM)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("50fm")]
        _50fm = 5,
        /// <summary>
        /// 75fm            6            ..F.A....T. 75┬╡s (FM)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("75fm")]
        _75fm = 6,
        /// <summary>
        /// 50kf            7            ..F.A....T. 50┬╡s (FM-KF)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("50kf")]
        _50kf = 7,
        /// <summary>
        /// 75kf            8            ..F.A....T. 75┬╡s (FM-KF)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("75kf")]
        _75kf = 8
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Audio emphasis.
        /// </summary>
        public static AemphasisFilterGen AemphasisFilterGen(this AudioMap input0) => new AemphasisFilterGen(input0);
    }
}