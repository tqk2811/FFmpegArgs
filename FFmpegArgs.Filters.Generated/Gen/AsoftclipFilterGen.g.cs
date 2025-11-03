namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS asoftclip         A-&gt;A       Audio Soft Clipper.
    /// </summary>
    public class AsoftclipFilterGen : AudioToAudioFilter, ITimelineSupport, ISliceThreading
    {
        internal AsoftclipFilterGen(AudioMap input) : base("asoftclip", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set softclip type (from -1 to 7) (default tanh)
        /// </summary>
        public AsoftclipFilterGen type(AsoftclipFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set softclip threshold (from 1e-06 to 1) (default 1)
        /// </summary>
        public AsoftclipFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold, 1e-06, 1);
        /// <summary>
        ///  set softclip output gain (from 1e-06 to 16) (default 1)
        /// </summary>
        public AsoftclipFilterGen output(double output) => this.SetOptionRange("output", output, 1e-06, 16);
        /// <summary>
        ///  set softclip parameter (from 0.01 to 3) (default 1)
        /// </summary>
        public AsoftclipFilterGen param(double param) => this.SetOptionRange("param", param, 0.01, 3);
        /// <summary>
        ///  set oversample factor (from 1 to 64) (default 1)
        /// </summary>
        public AsoftclipFilterGen oversample(int oversample) => this.SetOptionRange("oversample", oversample, 1, 64);
    }

    /// <summary>
    ///  set softclip type (from -1 to 7) (default tanh)
    /// </summary>
    public enum AsoftclipFilterGenType
    {
        /// <summary>
        /// hard            -1           ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hard")]
        hard = -1,
        /// <summary>
        /// tanh            0            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tanh")]
        tanh = 0,
        /// <summary>
        /// atan            1            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("atan")]
        atan = 1,
        /// <summary>
        /// cubic           2            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cubic")]
        cubic = 2,
        /// <summary>
        /// exp             3            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("exp")]
        exp = 3,
        /// <summary>
        /// alg             4            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("alg")]
        alg = 4,
        /// <summary>
        /// quintic         5            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("quintic")]
        quintic = 5,
        /// <summary>
        /// sin             6            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sin")]
        sin = 6,
        /// <summary>
        /// erf             7            ..F.A....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("erf")]
        erf = 7
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Audio Soft Clipper.
        /// </summary>
        public static AsoftclipFilterGen AsoftclipFilterGen(this AudioMap input0) => new AsoftclipFilterGen(input0);
    }
}