namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S showspatial       A-&gt;V       Convert input audio to a spatial video output.
    /// </summary>
    public class ShowspatialFilterGen : AudioToImageFilter, ISliceThreading
    {
        internal ShowspatialFilterGen(AudioMap input) : base("showspatial", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set video size (default &quot;512x512&quot;)
        /// </summary>
        public ShowspatialFilterGen size(Size size) => this.SetOption("size", Inv($"{size.Width}x{size.Height}"));
        /// <summary>
        ///  set window size (from 1024 to 65536) (default 4096)
        /// </summary>
        public ShowspatialFilterGen win_size(int win_size) => this.SetOptionRange("win_size", win_size, 1024, 65536);
        /// <summary>
        ///  set window function (from 0 to 20) (default hann)
        /// </summary>
        public ShowspatialFilterGen win_func(ShowspatialFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public ShowspatialFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToStringInv());
    }

    /// <summary>
    ///  set window function (from 0 to 20) (default hann)
    /// </summary>
    public enum ShowspatialFilterGenWin_func
    {
        /// <summary>
        /// rect            0            ..FV....... Rectangular
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rect")]
        rect = 0,
        /// <summary>
        /// bartlett        4            ..FV....... Bartlett
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bartlett")]
        bartlett = 4,
        /// <summary>
        /// hann            1            ..FV....... Hann
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hann")]
        hann = 1,
        /// <summary>
        /// hanning         1            ..FV....... Hanning
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hanning")]
        hanning = 1,
        /// <summary>
        /// hamming         2            ..FV....... Hamming
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hamming")]
        hamming = 2,
        /// <summary>
        /// blackman        3            ..FV....... Blackman
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blackman")]
        blackman = 3,
        /// <summary>
        /// welch           5            ..FV....... Welch
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("welch")]
        welch = 5,
        /// <summary>
        /// flattop         6            ..FV....... Flat-top
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("flattop")]
        flattop = 6,
        /// <summary>
        /// bharris         7            ..FV....... Blackman-Harris
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bharris")]
        bharris = 7,
        /// <summary>
        /// bnuttall        8            ..FV....... Blackman-Nuttall
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bnuttall")]
        bnuttall = 8,
        /// <summary>
        /// bhann           11           ..FV....... Bartlett-Hann
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bhann")]
        bhann = 11,
        /// <summary>
        /// sine            9            ..FV....... Sine
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sine")]
        sine = 9,
        /// <summary>
        /// nuttall         10           ..FV....... Nuttall
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nuttall")]
        nuttall = 10,
        /// <summary>
        /// lanczos         12           ..FV....... Lanczos
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lanczos")]
        lanczos = 12,
        /// <summary>
        /// gauss           13           ..FV....... Gauss
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gauss")]
        gauss = 13,
        /// <summary>
        /// tukey           14           ..FV....... Tukey
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tukey")]
        tukey = 14,
        /// <summary>
        /// dolph           15           ..FV....... Dolph-Chebyshev
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dolph")]
        dolph = 15,
        /// <summary>
        /// cauchy          16           ..FV....... Cauchy
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cauchy")]
        cauchy = 16,
        /// <summary>
        /// parzen          17           ..FV....... Parzen
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("parzen")]
        parzen = 17,
        /// <summary>
        /// poisson         18           ..FV....... Poisson
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("poisson")]
        poisson = 18,
        /// <summary>
        /// bohman          19           ..FV....... Bohman
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bohman")]
        bohman = 19,
        /// <summary>
        /// kaiser          20           ..FV....... Kaiser
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("kaiser")]
        kaiser = 20
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Convert input audio to a spatial video output.
        /// </summary>
        public static ShowspatialFilterGen ShowspatialFilterGen(this AudioMap input0) => new ShowspatialFilterGen(input0);
    }
}