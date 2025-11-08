namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S showspectrumpic   A-&gt;V       Convert input audio to a spectrum video output single picture.
    /// </summary>
    public class ShowspectrumpicFilterGen : AudioToImageFilter, ISliceThreading
    {
        internal ShowspectrumpicFilterGen(AudioMap input) : base("showspectrumpic", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set video size (default &quot;4096x2048&quot;)
        /// </summary>
        public ShowspectrumpicFilterGen size(Size size) => this.SetOption("size", $"{size.Width}x{size.Height}");
        /// <summary>
        ///  set channel display mode (from 0 to 1) (default combined)
        /// </summary>
        public ShowspectrumpicFilterGen mode(ShowspectrumpicFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set channel coloring (from 0 to 14) (default intensity)
        /// </summary>
        public ShowspectrumpicFilterGen color(ShowspectrumpicFilterGenColor color) => this.SetOption("color", color.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set display scale (from 0 to 5) (default log)
        /// </summary>
        public ShowspectrumpicFilterGen scale(ShowspectrumpicFilterGenScale scale) => this.SetOption("scale", scale.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set frequency scale (from 0 to 1) (default lin)
        /// </summary>
        public ShowspectrumpicFilterGen fscale(ShowspectrumpicFilterGenFscale fscale) => this.SetOption("fscale", fscale.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  color saturation multiplier (from -10 to 10) (default 1)
        /// </summary>
        public ShowspectrumpicFilterGen saturation(float saturation) => this.SetOptionRange("saturation", saturation, -10, 10);
        /// <summary>
        ///  set window function (from 0 to 20) (default hann)
        /// </summary>
        public ShowspectrumpicFilterGen win_func(ShowspectrumpicFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set orientation (from 0 to 1) (default vertical)
        /// </summary>
        public ShowspectrumpicFilterGen orientation(ShowspectrumpicFilterGenOrientation orientation) => this.SetOption("orientation", orientation.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set scale gain (from 0 to 128) (default 1)
        /// </summary>
        public ShowspectrumpicFilterGen gain(float gain) => this.SetOptionRange("gain", gain, 0, 128);
        /// <summary>
        ///  draw legend (default true)
        /// </summary>
        public ShowspectrumpicFilterGen legend(bool legend) => this.SetOption("legend", legend.ToFFmpegFlag());
        /// <summary>
        ///  color rotation (from -1 to 1) (default 0)
        /// </summary>
        public ShowspectrumpicFilterGen rotation(float rotation) => this.SetOptionRange("rotation", rotation, -1, 1);
        /// <summary>
        ///  start frequency (from 0 to INT_MAX) (default 0)
        /// </summary>
        public ShowspectrumpicFilterGen start(int start) => this.SetOptionRange("start", start, 0, INT_MAX);
        /// <summary>
        ///  stop frequency (from 0 to INT_MAX) (default 0)
        /// </summary>
        public ShowspectrumpicFilterGen stop(int stop) => this.SetOptionRange("stop", stop, 0, INT_MAX);
        /// <summary>
        ///  set dynamic range in dBFS (from 10 to 200) (default 120)
        /// </summary>
        public ShowspectrumpicFilterGen drange(float drange) => this.SetOptionRange("drange", drange, 10, 200);
        /// <summary>
        ///  set upper limit in dBFS (from -100 to 100) (default 0)
        /// </summary>
        public ShowspectrumpicFilterGen limit(float limit) => this.SetOptionRange("limit", limit, -100, 100);
        /// <summary>
        ///  set opacity strength (from 0 to 10) (default 1)
        /// </summary>
        public ShowspectrumpicFilterGen opacity(float opacity) => this.SetOptionRange("opacity", opacity, 0, 10);
    }

    /// <summary>
    ///  set channel display mode (from 0 to 1) (default combined)
    /// </summary>
    public enum ShowspectrumpicFilterGenMode
    {
        /// <summary>
        /// combined        0            ..FV....... combined mode
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("combined")]
        combined = 0,
        /// <summary>
        /// separate        1            ..FV....... separate mode
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("separate")]
        separate = 1
    }

    /// <summary>
    ///  set channel coloring (from 0 to 14) (default intensity)
    /// </summary>
    public enum ShowspectrumpicFilterGenColor
    {
        /// <summary>
        /// channel         0            ..FV....... separate color for each channel
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("channel")]
        channel = 0,
        /// <summary>
        /// intensity       1            ..FV....... intensity based coloring
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("intensity")]
        intensity = 1,
        /// <summary>
        /// rainbow         2            ..FV....... rainbow based coloring
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rainbow")]
        rainbow = 2,
        /// <summary>
        /// moreland        3            ..FV....... moreland based coloring
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("moreland")]
        moreland = 3,
        /// <summary>
        /// nebulae         4            ..FV....... nebulae based coloring
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nebulae")]
        nebulae = 4,
        /// <summary>
        /// fire            5            ..FV....... fire based coloring
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fire")]
        fire = 5,
        /// <summary>
        /// fiery           6            ..FV....... fiery based coloring
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fiery")]
        fiery = 6,
        /// <summary>
        /// fruit           7            ..FV....... fruit based coloring
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fruit")]
        fruit = 7,
        /// <summary>
        /// cool            8            ..FV....... cool based coloring
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cool")]
        cool = 8,
        /// <summary>
        /// magma           9            ..FV....... magma based coloring
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("magma")]
        magma = 9,
        /// <summary>
        /// green           10           ..FV....... green based coloring
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("green")]
        green = 10,
        /// <summary>
        /// viridis         11           ..FV....... viridis based coloring
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("viridis")]
        viridis = 11,
        /// <summary>
        /// plasma          12           ..FV....... plasma based coloring
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("plasma")]
        plasma = 12,
        /// <summary>
        /// cividis         13           ..FV....... cividis based coloring
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cividis")]
        cividis = 13,
        /// <summary>
        /// terrain         14           ..FV....... terrain based coloring
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("terrain")]
        terrain = 14
    }

    /// <summary>
    ///  set display scale (from 0 to 5) (default log)
    /// </summary>
    public enum ShowspectrumpicFilterGenScale
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
        log = 3,
        /// <summary>
        /// 4thrt           4            ..FV....... 4th root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("4thrt")]
        _4thrt = 4,
        /// <summary>
        /// 5thrt           5            ..FV....... 5th root
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("5thrt")]
        _5thrt = 5
    }

    /// <summary>
    ///  set frequency scale (from 0 to 1) (default lin)
    /// </summary>
    public enum ShowspectrumpicFilterGenFscale
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
        log = 1
    }

    /// <summary>
    ///  set window function (from 0 to 20) (default hann)
    /// </summary>
    public enum ShowspectrumpicFilterGenWin_func
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
    ///  set orientation (from 0 to 1) (default vertical)
    /// </summary>
    public enum ShowspectrumpicFilterGenOrientation
    {
        /// <summary>
        /// vertical        0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vertical")]
        vertical = 0,
        /// <summary>
        /// horizontal      1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("horizontal")]
        horizontal = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Convert input audio to a spectrum video output single picture.
        /// </summary>
        public static ShowspectrumpicFilterGen ShowspectrumpicFilterGen(this AudioMap input0) => new ShowspectrumpicFilterGen(input0);
    }
}