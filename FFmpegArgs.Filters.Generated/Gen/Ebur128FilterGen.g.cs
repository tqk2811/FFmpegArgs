namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... ebur128           A-&gt;N       EBU R128 scanner.
    /// </summary>
    public class Ebur128FilterGen : AudioToAudioFilter
    {
        internal Ebur128FilterGen(AudioMap input, int outputCount) : base("ebur128", input)
        {
            AddMultiMapOut(outputCount);
        }

        /// <summary>
        ///  set video output (default false)
        /// </summary>
        public Ebur128FilterGen video(bool video) => this.SetOption("video", video.ToFFmpegFlag());
        /// <summary>
        ///  set video size (default &quot;640x480&quot;)
        /// </summary>
        public Ebur128FilterGen size(Size size) => this.SetOption("size", $"{size.Width}x{size.Height}");
        /// <summary>
        ///  set scale meter (+9 to +18) (from 9 to 18) (default 9)
        /// </summary>
        public Ebur128FilterGen meter(int meter) => this.SetOptionRange("meter", meter, 9, 18);
        /// <summary>
        ///  force frame logging level (from INT_MIN to INT_MAX) (default -1)
        /// </summary>
        public Ebur128FilterGen framelog(Ebur128FilterGenFramelog framelog) => this.SetOption("framelog", framelog.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  inject metadata in the filtergraph (default false)
        /// </summary>
        public Ebur128FilterGen metadata(bool metadata) => this.SetOption("metadata", metadata.ToFFmpegFlag());
        /// <summary>
        ///  set peak mode (default 0)
        /// </summary>
        public Ebur128FilterGen peak(Ebur128FilterGenPeak peak) => this.SetOption("peak", peak.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  treat mono input files as dual-mono (default false)
        /// </summary>
        public Ebur128FilterGen dualmono(bool dualmono) => this.SetOption("dualmono", dualmono.ToFFmpegFlag());
        /// <summary>
        ///  set a specific pan law for dual-mono files (from -10 to 0) (default -3.0103)
        /// </summary>
        public Ebur128FilterGen panlaw(double panlaw) => this.SetOptionRange("panlaw", panlaw, -10, 0);
        /// <summary>
        ///  set a specific target level in LUFS (-23 to 0) (from -23 to 0) (default -23)
        /// </summary>
        public Ebur128FilterGen target(int target) => this.SetOptionRange("target", target, -23, 0);
        /// <summary>
        ///  set gauge display type (from 0 to 1) (default momentary)
        /// </summary>
        public Ebur128FilterGen gauge(Ebur128FilterGenGauge gauge) => this.SetOption("gauge", gauge.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  sets display method for the stats (from 0 to 1) (default absolute)
        /// </summary>
        public Ebur128FilterGen scale(Ebur128FilterGenScale scale) => this.SetOption("scale", scale.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  integrated loudness (LUFS) (from -DBL_MAX to DBL_MAX) (default 0)
        /// </summary>
        public Ebur128FilterGen integrated(double integrated) => this.SetOptionRange("integrated", integrated, -DBL_MAX, DBL_MAX);
        /// <summary>
        ///  loudness range (LU) (from -DBL_MAX to DBL_MAX) (default 0)
        /// </summary>
        public Ebur128FilterGen range(double range) => this.SetOptionRange("range", range, -DBL_MAX, DBL_MAX);
        /// <summary>
        ///  LRA low (LUFS) (from -DBL_MAX to DBL_MAX) (default 0)
        /// </summary>
        public Ebur128FilterGen lra_low(double lra_low) => this.SetOptionRange("lra_low", lra_low, -DBL_MAX, DBL_MAX);
        /// <summary>
        ///  LRA high (LUFS) (from -DBL_MAX to DBL_MAX) (default 0)
        /// </summary>
        public Ebur128FilterGen lra_high(double lra_high) => this.SetOptionRange("lra_high", lra_high, -DBL_MAX, DBL_MAX);
        /// <summary>
        ///  sample peak (dBFS) (from -DBL_MAX to DBL_MAX) (default 0)
        /// </summary>
        public Ebur128FilterGen sample_peak(double sample_peak) => this.SetOptionRange("sample_peak", sample_peak, -DBL_MAX, DBL_MAX);
        /// <summary>
        ///  true peak (dBFS) (from -DBL_MAX to DBL_MAX) (default 0)
        /// </summary>
        public Ebur128FilterGen true_peak(double true_peak) => this.SetOptionRange("true_peak", true_peak, -DBL_MAX, DBL_MAX);
    }

    /// <summary>
    ///  force frame logging level (from INT_MIN to INT_MAX) (default -1)
    /// </summary>
    public enum Ebur128FilterGenFramelog
    {
        /// <summary>
        /// quiet           -8           ..FVA...... logging disabled
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("quiet")]
        quiet = -8,
        /// <summary>
        /// info            32           ..FVA...... information logging level
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("info")]
        info = 32,
        /// <summary>
        /// verbose         40           ..FVA...... verbose logging level
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("verbose")]
        verbose = 40
    }

    /// <summary>
    ///  set peak mode (default 0)
    /// </summary>
    public enum Ebur128FilterGenPeak
    {
        /// <summary>
        /// none                         ..F.A...... disable any peak mode
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none,
        /// <summary>
        /// sample                       ..F.A...... enable peak-sample mode
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sample")]
        sample,
        /// <summary>
        /// true                         ..F.A...... enable true-peak mode
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("true")]
        _true
    }

    /// <summary>
    ///  set gauge display type (from 0 to 1) (default momentary)
    /// </summary>
    public enum Ebur128FilterGenGauge
    {
        /// <summary>
        /// momentary       0            ..FV....... display momentary value
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("momentary")]
        momentary = 0,
        /// <summary>
        /// m               0            ..FV....... display momentary value
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("m")]
        m = 0,
        /// <summary>
        /// shortterm       1            ..FV....... display short-term value
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("shortterm")]
        shortterm = 1,
        /// <summary>
        /// s               1            ..FV....... display short-term value
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s")]
        s = 1
    }

    /// <summary>
    ///  sets display method for the stats (from 0 to 1) (default absolute)
    /// </summary>
    public enum Ebur128FilterGenScale
    {
        /// <summary>
        /// absolute        0            ..FV....... display absolute values (LUFS)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("absolute")]
        absolute = 0,
        /// <summary>
        /// LUFS            0            ..FV....... display absolute values (LUFS)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("LUFS")]
        LUFS = 0,
        /// <summary>
        /// relative        1            ..FV....... display values relative to target (LU)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("relative")]
        relative = 1,
        /// <summary>
        /// LU              1            ..FV....... display values relative to target (LU)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("LU")]
        LU = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// EBU R128 scanner.
        /// </summary>
        public static Ebur128FilterGen Ebur128FilterGen(this AudioMap input0, int outputCount) => new Ebur128FilterGen(input0, outputCount);
    }
}