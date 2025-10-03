namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... showfreqs         A-&gt;V       Convert input audio to a frequencies video output.
    /// </summary>
    public class ShowfreqsFilterGen : AudioToImageFilter
    {
        internal ShowfreqsFilterGen(AudioMap input) : base("showfreqs", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set video size (default &quot;1024x512&quot;)
        /// </summary>
        public ShowfreqsFilterGen size(Size size) => this.SetOption("size", $"{size.Width}x{size.Height}");
        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public ShowfreqsFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToString());
        /// <summary>
        ///  set display mode (from 0 to 2) (default bar)
        /// </summary>
        public ShowfreqsFilterGen mode(ShowfreqsFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set amplitude scale (from 0 to 3) (default log)
        /// </summary>
        public ShowfreqsFilterGen ascale(ShowfreqsFilterGenAscale ascale) => this.SetOption("ascale", ascale.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set frequency scale (from 0 to 2) (default lin)
        /// </summary>
        public ShowfreqsFilterGen fscale(ShowfreqsFilterGenFscale fscale) => this.SetOption("fscale", fscale.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set window size (from 16 to 65536) (default 2048)
        /// </summary>
        public ShowfreqsFilterGen win_size(int win_size) => this.SetOptionRange("win_size", win_size, 16, 65536);
        /// <summary>
        ///  set window function (from 0 to 20) (default hann)
        /// </summary>
        public ShowfreqsFilterGen win_func(ShowfreqsFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set window overlap (from 0 to 1) (default 1)
        /// </summary>
        public ShowfreqsFilterGen overlap(float overlap) => this.SetOptionRange("overlap", overlap, 0, 1);
        /// <summary>
        ///  set time averaging (from 0 to INT_MAX) (default 1)
        /// </summary>
        public ShowfreqsFilterGen averaging(int averaging) => this.SetOptionRange("averaging", averaging, 0, INT_MAX);
        /// <summary>
        ///  set channels colors (default &quot;red|green|blue|yellow|orange|lime|pink|magenta|brown&quot;)
        /// </summary>
        public ShowfreqsFilterGen colors(String colors) => this.SetOption("colors", colors.ToString());
        /// <summary>
        ///  set channel mode (from 0 to 1) (default combined)
        /// </summary>
        public ShowfreqsFilterGen cmode(ShowfreqsFilterGenCmode cmode) => this.SetOption("cmode", cmode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set minimum amplitude (from FLT_MIN to 1e-06) (default 1e-06)
        /// </summary>
        public ShowfreqsFilterGen minamp(float minamp) => this.SetOptionRange("minamp", minamp, FLT_MIN, 1e-06);
        /// <summary>
        ///  set data mode (from 0 to 2) (default magnitude)
        /// </summary>
        public ShowfreqsFilterGen data(ShowfreqsFilterGenData data) => this.SetOption("data", data.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set channels to draw (default &quot;all&quot;)
        /// </summary>
        public ShowfreqsFilterGen channels(String channels) => this.SetOption("channels", channels.ToString());
    }

    /// <summary>
    ///  set display mode (from 0 to 2) (default bar)
    /// </summary>
    public enum ShowfreqsFilterGenMode
    {
        /// <summary>
        /// line            0            ..FV....... show lines
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("line")]
        line = 0,
        /// <summary>
        /// bar             1            ..FV....... show bars
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bar")]
        bar = 1,
        /// <summary>
        /// dot             2            ..FV....... show dots
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dot")]
        dot = 2
    }

    /// <summary>
    ///  set amplitude scale (from 0 to 3) (default log)
    /// </summary>
    public enum ShowfreqsFilterGenAscale
    {
        /// <summary>
        /// lin             0            ..FV....... linear
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lin")]
        lin = 0,
        /// <summary>
        /// sqrt            1            ..FV....... square root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sqrt")]
        sqrt = 1,
        /// <summary>
        /// cbrt            2            ..FV....... cubic root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cbrt")]
        cbrt = 2,
        /// <summary>
        /// log             3            ..FV....... logarithmic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("log")]
        log = 3
    }

    /// <summary>
    ///  set frequency scale (from 0 to 2) (default lin)
    /// </summary>
    public enum ShowfreqsFilterGenFscale
    {
        /// <summary>
        /// lin             0            ..FV....... linear
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lin")]
        lin = 0,
        /// <summary>
        /// log             1            ..FV....... logarithmic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("log")]
        log = 1,
        /// <summary>
        /// rlog            2            ..FV....... reverse logarithmic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rlog")]
        rlog = 2
    }

    /// <summary>
    ///  set window function (from 0 to 20) (default hann)
    /// </summary>
    public enum ShowfreqsFilterGenWin_func
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

    /// <summary>
    ///  set channel mode (from 0 to 1) (default combined)
    /// </summary>
    public enum ShowfreqsFilterGenCmode
    {
        /// <summary>
        /// combined        0            ..FV....... show all channels in same window
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("combined")]
        combined = 0,
        /// <summary>
        /// separate        1            ..FV....... show each channel in own window
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("separate")]
        separate = 1
    }

    /// <summary>
    ///  set data mode (from 0 to 2) (default magnitude)
    /// </summary>
    public enum ShowfreqsFilterGenData
    {
        /// <summary>
        /// magnitude       0            ..FV....... show magnitude
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("magnitude")]
        magnitude = 0,
        /// <summary>
        /// phase           1            ..FV....... show phase
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("phase")]
        phase = 1,
        /// <summary>
        /// delay           2            ..FV....... show group delay
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("delay")]
        delay = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Convert input audio to a frequencies video output.
        /// </summary>
        public static ShowfreqsFilterGen ShowfreqsFilterGen(this AudioMap input0) => new ShowfreqsFilterGen(input0);
    }
}