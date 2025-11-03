namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. spectrumsynth     VV-&gt;A      Convert input spectrum videos to audio output.
    /// </summary>
    public class SpectrumsynthFilterGen : ImageToAudioFilter
    {
        internal SpectrumsynthFilterGen(params ImageMap[] inputs) : base("spectrumsynth", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set sample rate (from 15 to INT_MAX) (default 44100)
        /// </summary>
        public SpectrumsynthFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate, 15, INT_MAX);
        /// <summary>
        ///  set channels (from 1 to 8) (default 1)
        /// </summary>
        public SpectrumsynthFilterGen channels(int channels) => this.SetOptionRange("channels", channels, 1, 8);
        /// <summary>
        ///  set input amplitude scale (from 0 to 1) (default log)
        /// </summary>
        public SpectrumsynthFilterGen scale(SpectrumsynthFilterGenScale scale) => this.SetOption("scale", scale.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set input sliding mode (from 0 to 3) (default fullframe)
        /// </summary>
        public SpectrumsynthFilterGen slide(SpectrumsynthFilterGenSlide slide) => this.SetOption("slide", slide.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set window function (from 0 to 20) (default rect)
        /// </summary>
        public SpectrumsynthFilterGen win_func(SpectrumsynthFilterGenWin_func win_func) => this.SetOption("win_func", win_func.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set window overlap (from 0 to 1) (default 1)
        /// </summary>
        public SpectrumsynthFilterGen overlap(float overlap) => this.SetOptionRange("overlap", overlap, 0, 1);
        /// <summary>
        ///  set orientation (from 0 to 1) (default vertical)
        /// </summary>
        public SpectrumsynthFilterGen orientation(SpectrumsynthFilterGenOrientation orientation) => this.SetOption("orientation", orientation.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set input amplitude scale (from 0 to 1) (default log)
    /// </summary>
    public enum SpectrumsynthFilterGenScale
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
    ///  set input sliding mode (from 0 to 3) (default fullframe)
    /// </summary>
    public enum SpectrumsynthFilterGenSlide
    {
        /// <summary>
        /// replace         0            ..FV....... consume old columns with new
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("replace")]
        replace = 0,
        /// <summary>
        /// scroll          1            ..FV....... consume only most right column
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("scroll")]
        scroll = 1,
        /// <summary>
        /// fullframe       2            ..FV....... consume full frames
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fullframe")]
        fullframe = 2,
        /// <summary>
        /// rscroll         3            ..FV....... consume only most left column
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rscroll")]
        rscroll = 3
    }

    /// <summary>
    ///  set window function (from 0 to 20) (default rect)
    /// </summary>
    public enum SpectrumsynthFilterGenWin_func
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

    /// <summary>
    ///  set orientation (from 0 to 1) (default vertical)
    /// </summary>
    public enum SpectrumsynthFilterGenOrientation
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
        /// Convert input spectrum videos to audio output.
        /// </summary>
        public static SpectrumsynthFilterGen SpectrumsynthFilterGen(this ImageMap input0, ImageMap input1) => new SpectrumsynthFilterGen(input0, input1);
    }
}