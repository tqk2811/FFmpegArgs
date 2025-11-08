namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S showcwt           A-&gt;V       Convert input audio to a CWT (Continuous Wavelet Transform) spectrum video output.
    /// </summary>
    public class ShowcwtFilterGen : AudioToImageFilter, ISliceThreading
    {
        internal ShowcwtFilterGen(AudioMap input) : base("showcwt", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set video size (default &quot;640x512&quot;)
        /// </summary>
        public ShowcwtFilterGen size(Size size) => this.SetOption("size", $"{size.Width}x{size.Height}");
        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public ShowcwtFilterGen rate(String rate) => this.SetOption("rate", rate.ToStringInv());
        /// <summary>
        ///  set frequency scale (from 0 to 8) (default linear)
        /// </summary>
        public ShowcwtFilterGen scale(ShowcwtFilterGenScale scale) => this.SetOption("scale", scale.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set intensity scale (from 0 to 4) (default log)
        /// </summary>
        public ShowcwtFilterGen iscale(ShowcwtFilterGenIscale iscale) => this.SetOption("iscale", iscale.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set minimum frequency (from 1 to 192000) (default 20)
        /// </summary>
        public ShowcwtFilterGen min(float min) => this.SetOptionRange("min", min, 1, 192000);
        /// <summary>
        ///  set maximum frequency (from 1 to 192000) (default 20000)
        /// </summary>
        public ShowcwtFilterGen max(float max) => this.SetOptionRange("max", max, 1, 192000);
        /// <summary>
        ///  set minimum intensity (from 0 to 1) (default 0)
        /// </summary>
        public ShowcwtFilterGen imin(float imin) => this.SetOptionRange("imin", imin, 0, 1);
        /// <summary>
        ///  set maximum intensity (from 0 to 1) (default 1)
        /// </summary>
        public ShowcwtFilterGen imax(float imax) => this.SetOptionRange("imax", imax, 0, 1);
        /// <summary>
        ///  set logarithmic basis (from 0 to 1) (default 0.0001)
        /// </summary>
        public ShowcwtFilterGen logb(float logb) => this.SetOptionRange("logb", logb, 0, 1);
        /// <summary>
        ///  set frequency deviation (from 0 to 100) (default 1)
        /// </summary>
        public ShowcwtFilterGen deviation(float deviation) => this.SetOptionRange("deviation", deviation, 0, 100);
        /// <summary>
        ///  set pixels per second (from 1 to 1024) (default 64)
        /// </summary>
        public ShowcwtFilterGen pps(int pps) => this.SetOptionRange("pps", pps, 1, 1024);
        /// <summary>
        ///  set output mode (from 0 to 4) (default magnitude)
        /// </summary>
        public ShowcwtFilterGen mode(ShowcwtFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set slide mode (from 0 to 2) (default replace)
        /// </summary>
        public ShowcwtFilterGen slide(ShowcwtFilterGenSlide slide) => this.SetOption("slide", slide.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set direction mode (from 0 to 3) (default lr)
        /// </summary>
        public ShowcwtFilterGen direction(ShowcwtFilterGenDirection direction) => this.SetOption("direction", direction.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set bargraph ratio (from 0 to 1) (default 0)
        /// </summary>
        public ShowcwtFilterGen bar(float bar) => this.SetOptionRange("bar", bar, 0, 1);
        /// <summary>
        ///  set color rotation (from -1 to 1) (default 0)
        /// </summary>
        public ShowcwtFilterGen rotation(float rotation) => this.SetOptionRange("rotation", rotation, -1, 1);
    }

    /// <summary>
    ///  set frequency scale (from 0 to 8) (default linear)
    /// </summary>
    public enum ShowcwtFilterGenScale
    {
        /// <summary>
        /// linear          0            ..FV....... linear
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 0,
        /// <summary>
        /// log             1            ..FV....... logarithmic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("log")]
        log = 1,
        /// <summary>
        /// bark            2            ..FV....... bark
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bark")]
        bark = 2,
        /// <summary>
        /// mel             3            ..FV....... mel
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mel")]
        mel = 3,
        /// <summary>
        /// erbs            4            ..FV....... erbs
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("erbs")]
        erbs = 4,
        /// <summary>
        /// sqrt            5            ..FV....... sqrt
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sqrt")]
        sqrt = 5,
        /// <summary>
        /// cbrt            6            ..FV....... cbrt
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cbrt")]
        cbrt = 6,
        /// <summary>
        /// qdrt            7            ..FV....... qdrt
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("qdrt")]
        qdrt = 7,
        /// <summary>
        /// fm              8            ..FV....... fm
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fm")]
        fm = 8
    }

    /// <summary>
    ///  set intensity scale (from 0 to 4) (default log)
    /// </summary>
    public enum ShowcwtFilterGenIscale
    {
        /// <summary>
        /// linear          1            ..FV....... linear
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("linear")]
        linear = 1,
        /// <summary>
        /// log             0            ..FV....... logarithmic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("log")]
        log = 0,
        /// <summary>
        /// sqrt            2            ..FV....... sqrt
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sqrt")]
        sqrt = 2,
        /// <summary>
        /// cbrt            3            ..FV....... cbrt
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cbrt")]
        cbrt = 3,
        /// <summary>
        /// qdrt            4            ..FV....... qdrt
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("qdrt")]
        qdrt = 4
    }

    /// <summary>
    ///  set output mode (from 0 to 4) (default magnitude)
    /// </summary>
    public enum ShowcwtFilterGenMode
    {
        /// <summary>
        /// magnitude       0            ..FV....... magnitude
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("magnitude")]
        magnitude = 0,
        /// <summary>
        /// phase           1            ..FV....... phase
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("phase")]
        phase = 1,
        /// <summary>
        /// magphase        2            ..FV....... magnitude+phase
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("magphase")]
        magphase = 2,
        /// <summary>
        /// channel         3            ..FV....... color per channel
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("channel")]
        channel = 3,
        /// <summary>
        /// stereo          4            ..FV....... stereo difference
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("stereo")]
        stereo = 4
    }

    /// <summary>
    ///  set slide mode (from 0 to 2) (default replace)
    /// </summary>
    public enum ShowcwtFilterGenSlide
    {
        /// <summary>
        /// replace         0            ..FV....... replace
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("replace")]
        replace = 0,
        /// <summary>
        /// scroll          1            ..FV....... scroll
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("scroll")]
        scroll = 1,
        /// <summary>
        /// frame           2            ..FV....... frame
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("frame")]
        frame = 2
    }

    /// <summary>
    ///  set direction mode (from 0 to 3) (default lr)
    /// </summary>
    public enum ShowcwtFilterGenDirection
    {
        /// <summary>
        /// lr              0            ..FV....... left to right
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lr")]
        lr = 0,
        /// <summary>
        /// rl              1            ..FV....... right to left
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rl")]
        rl = 1,
        /// <summary>
        /// ud              2            ..FV....... up to down
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ud")]
        ud = 2,
        /// <summary>
        /// du              3            ..FV....... down to up
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("du")]
        du = 3
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Convert input audio to a CWT (Continuous Wavelet Transform) spectrum video output.
        /// </summary>
        public static ShowcwtFilterGen ShowcwtFilterGen(this AudioMap input0) => new ShowcwtFilterGen(input0);
    }
}