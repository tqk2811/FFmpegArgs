namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. hilbert           |-&gt;A       Generate a Hilbert transform FIR coefficients.
    /// </summary>
    public class HilbertFilterGen : SourceToAudioFilter
    {
        internal HilbertFilterGen(IAudioFilterGraph input) : base("hilbert", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set sample rate (from 1 to INT_MAX) (default 44100)
        /// </summary>
        public HilbertFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate, 1, INT_MAX);
        /// <summary>
        ///  set sample rate (from 1 to INT_MAX) (default 44100)
        /// </summary>
        public HilbertFilterGen r(int r) => this.SetOptionRange("r", r, 1, INT_MAX);
        /// <summary>
        ///  set number of taps (from 11 to 65535) (default 22051)
        /// </summary>
        public HilbertFilterGen taps(int taps) => this.SetOptionRange("taps", taps, 11, 65535);
        /// <summary>
        ///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
        /// </summary>
        public HilbertFilterGen nb_samples(int nb_samples) => this.SetOptionRange("nb_samples", nb_samples, 1, INT_MAX);
        /// <summary>
        ///  set window function (from 0 to 20) (default blackman)
        /// </summary>
        public HilbertFilterGen win_func(HilbertFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set window function (from 0 to 20) (default blackman)
    /// </summary>
    public enum HilbertFilterGenWin_func
    {
        /// <summary>
        /// rect            0            ..F.A...... Rectangular
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rect")]
        rect = 0,
        /// <summary>
        /// bartlett        4            ..F.A...... Bartlett
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bartlett")]
        bartlett = 4,
        /// <summary>
        /// hann            1            ..F.A...... Hann
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hann")]
        hann = 1,
        /// <summary>
        /// hanning         1            ..F.A...... Hanning
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hanning")]
        hanning = 1,
        /// <summary>
        /// hamming         2            ..F.A...... Hamming
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hamming")]
        hamming = 2,
        /// <summary>
        /// blackman        3            ..F.A...... Blackman
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blackman")]
        blackman = 3,
        /// <summary>
        /// welch           5            ..F.A...... Welch
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("welch")]
        welch = 5,
        /// <summary>
        /// flattop         6            ..F.A...... Flat-top
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("flattop")]
        flattop = 6,
        /// <summary>
        /// bharris         7            ..F.A...... Blackman-Harris
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bharris")]
        bharris = 7,
        /// <summary>
        /// bnuttall        8            ..F.A...... Blackman-Nuttall
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bnuttall")]
        bnuttall = 8,
        /// <summary>
        /// bhann           11           ..F.A...... Bartlett-Hann
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bhann")]
        bhann = 11,
        /// <summary>
        /// sine            9            ..F.A...... Sine
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sine")]
        sine = 9,
        /// <summary>
        /// nuttall         10           ..F.A...... Nuttall
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nuttall")]
        nuttall = 10,
        /// <summary>
        /// lanczos         12           ..F.A...... Lanczos
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lanczos")]
        lanczos = 12,
        /// <summary>
        /// gauss           13           ..F.A...... Gauss
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gauss")]
        gauss = 13,
        /// <summary>
        /// tukey           14           ..F.A...... Tukey
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tukey")]
        tukey = 14,
        /// <summary>
        /// dolph           15           ..F.A...... Dolph-Chebyshev
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dolph")]
        dolph = 15,
        /// <summary>
        /// cauchy          16           ..F.A...... Cauchy
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cauchy")]
        cauchy = 16,
        /// <summary>
        /// parzen          17           ..F.A...... Parzen
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("parzen")]
        parzen = 17,
        /// <summary>
        /// poisson         18           ..F.A...... Poisson
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("poisson")]
        poisson = 18,
        /// <summary>
        /// bohman          19           ..F.A...... Bohman
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bohman")]
        bohman = 19,
        /// <summary>
        /// kaiser          20           ..F.A...... Kaiser
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("kaiser")]
        kaiser = 20
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Generate a Hilbert transform FIR coefficients.
        /// </summary>
        public static HilbertFilterGen HilbertFilterGen(this IAudioFilterGraph input) => new HilbertFilterGen(input);
    }
}