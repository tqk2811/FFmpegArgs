namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS. afftfilt          A-&gt;A       Apply arbitrary expressions to samples in frequency domain.
    /// </summary>
    public class AfftfiltFilterGen : AudioToAudioFilter, ITimelineSupport, ISliceThreading
    {
        internal AfftfiltFilterGen(AudioMap input) : base("afftfilt", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set channels real expressions (default &quot;re&quot;)
        /// </summary>
        public AfftfiltFilterGen real(ExpressionValue real) => this.SetOption("real", (string)real);
        /// <summary>
        ///  set channels imaginary expressions (default &quot;im&quot;)
        /// </summary>
        public AfftfiltFilterGen imag(ExpressionValue imag) => this.SetOption("imag", (string)imag);
        /// <summary>
        ///  set window size (from 16 to 131072) (default 4096)
        /// </summary>
        public AfftfiltFilterGen win_size(int win_size) => this.SetOptionRange("win_size", win_size, 16, 131072);
        /// <summary>
        ///  set window function (from 0 to 20) (default hann)
        /// </summary>
        public AfftfiltFilterGen win_func(AfftfiltFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set window overlap (from 0 to 1) (default 0.75)
        /// </summary>
        public AfftfiltFilterGen overlap(float overlap) => this.SetOptionRange("overlap", overlap, 0, 1);
    }

    /// <summary>
    ///  set window function (from 0 to 20) (default hann)
    /// </summary>
    public enum AfftfiltFilterGenWin_func
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
        /// Apply arbitrary expressions to samples in frequency domain.
        /// </summary>
        public static AfftfiltFilterGen AfftfiltFilterGen(this AudioMap input0) => new AfftfiltFilterGen(input0);
    }
}