namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... afireqsrc         |-&gt;A       Generate a FIR equalizer coefficients audio stream.
    /// </summary>
    public class AfireqsrcFilterGen : SourceToAudioFilter
    {
        internal AfireqsrcFilterGen(IAudioFilterGraph input) : base("afireqsrc", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set equalizer preset (from -1 to 17) (default flat)
        /// </summary>
        public AfireqsrcFilterGen preset(AfireqsrcFilterGenPreset preset) => this.SetOption("preset", preset.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set gain values per band (default &quot;0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0&quot;)
        /// </summary>
        public AfireqsrcFilterGen gains(String gains) => this.SetOption("gains", gains.ToString());
        /// <summary>
        ///  set central frequency values per band (default &quot;25 40 63 100 160 250 400 630 1000 1600 2500 4000 6300 10000 16000 24000&quot;)
        /// </summary>
        public AfireqsrcFilterGen bands(String bands) => this.SetOption("bands", bands.ToString());
        /// <summary>
        ///  set number of taps (from 16 to 65535) (default 4096)
        /// </summary>
        public AfireqsrcFilterGen taps(int taps) => this.SetOptionRange("taps", taps, 16, 65535);
        /// <summary>
        ///  set sample rate (from 1 to INT_MAX) (default 44100)
        /// </summary>
        public AfireqsrcFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate, 1, INT_MAX);
        /// <summary>
        ///  set sample rate (from 1 to INT_MAX) (default 44100)
        /// </summary>
        public AfireqsrcFilterGen r(int r) => this.SetOptionRange("r", r, 1, INT_MAX);
        /// <summary>
        ///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
        /// </summary>
        public AfireqsrcFilterGen nb_samples(int nb_samples) => this.SetOptionRange("nb_samples", nb_samples, 1, INT_MAX);
        /// <summary>
        ///  set the interpolation (from 0 to 1) (default linear)
        /// </summary>
        public AfireqsrcFilterGen interp(AfireqsrcFilterGenInterp interp) => this.SetOption("interp", interp.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set the phase (from 0 to 1) (default min)
        /// </summary>
        public AfireqsrcFilterGen phase(AfireqsrcFilterGenPhase phase) => this.SetOption("phase", phase.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set the phase (from 0 to 1) (default min)
        /// </summary>
        public AfireqsrcFilterGen h(AfireqsrcFilterGenH h) => this.SetOption("h", h.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set equalizer preset (from -1 to 17) (default flat)
    /// </summary>
    public enum AfireqsrcFilterGenPreset
    {
        /// <summary>
        /// custom          -1           ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("custom")]
        custom = -1,
        /// <summary>
        /// flat            0            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("flat")]
        flat = 0,
        /// <summary>
        /// acoustic        1            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("acoustic")]
        acoustic = 1,
        /// <summary>
        /// bass            2            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bass")]
        bass = 2,
        /// <summary>
        /// beats           3            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("beats")]
        beats = 3,
        /// <summary>
        /// classic         4            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("classic")]
        classic = 4,
        /// <summary>
        /// clear           5            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("clear")]
        clear = 5,
        /// <summary>
        /// deep bass       6            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("deep bass")]
        deep_bass = 6,
        /// <summary>
        /// dubstep         7            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dubstep")]
        dubstep = 7,
        /// <summary>
        /// electronic      8            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("electronic")]
        electronic = 8,
        /// <summary>
        /// hardstyle       9            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hardstyle")]
        hardstyle = 9,
        /// <summary>
        /// hip-hop         10           ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hip-hop")]
        hip_hop = 10,
        /// <summary>
        /// jazz            11           ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("jazz")]
        jazz = 11,
        /// <summary>
        /// metal           12           ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("metal")]
        metal = 12,
        /// <summary>
        /// movie           13           ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("movie")]
        movie = 13,
        /// <summary>
        /// pop             14           ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pop")]
        pop = 14,
        /// <summary>
        /// r&amp;b             15           ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("r&b")]
        r_And_b = 15,
        /// <summary>
        /// rock            16           ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rock")]
        rock = 16,
        /// <summary>
        /// vocal booster   17           ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vocal booster")]
        vocal_booster = 17
    }

    /// <summary>
    ///  set the interpolation (from 0 to 1) (default linear)
    /// </summary>
    public enum AfireqsrcFilterGenInterp
    {
        /// <summary>
        /// linear          0            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 0,
        /// <summary>
        /// cubic           1            ..F.A......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cubic")]
        cubic = 1
    }

    /// <summary>
    ///  set the phase (from 0 to 1) (default min)
    /// </summary>
    public enum AfireqsrcFilterGenPhase
    {
        /// <summary>
        /// linear          0            ..F.A...... linear phase
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 0,
        /// <summary>
        /// min             1            ..F.A...... minimum phase
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("min")]
        min = 1
    }

    /// <summary>
    ///  set the phase (from 0 to 1) (default min)
    /// </summary>
    public enum AfireqsrcFilterGenH
    {
        /// <summary>
        /// linear          0            ..F.A...... linear phase
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 0,
        /// <summary>
        /// min             1            ..F.A...... minimum phase
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("min")]
        min = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Generate a FIR equalizer coefficients audio stream.
        /// </summary>
        public static AfireqsrcFilterGen AfireqsrcFilterGen(this IAudioFilterGraph input) => new AfireqsrcFilterGen(input);
    }
}