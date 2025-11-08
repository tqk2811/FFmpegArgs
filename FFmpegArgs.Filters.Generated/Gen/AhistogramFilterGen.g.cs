namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. ahistogram        A-&gt;V       Convert input audio to histogram video output.
    /// </summary>
    public class AhistogramFilterGen : AudioToImageFilter
    {
        internal AhistogramFilterGen(AudioMap input) : base("ahistogram", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set method to display channels (from 0 to 1) (default single)
        /// </summary>
        public AhistogramFilterGen dmode(AhistogramFilterGenDmode dmode) => this.SetOption("dmode", dmode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public AhistogramFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToStringInv());
        /// <summary>
        ///  set video size (default &quot;hd720&quot;)
        /// </summary>
        public AhistogramFilterGen size(Size size) => this.SetOption("size", $"{size.Width}x{size.Height}");
        /// <summary>
        ///  set display scale (from 0 to 4) (default log)
        /// </summary>
        public AhistogramFilterGen scale(AhistogramFilterGenScale scale) => this.SetOption("scale", scale.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set amplitude scale (from 0 to 1) (default log)
        /// </summary>
        public AhistogramFilterGen ascale(AhistogramFilterGenAscale ascale) => this.SetOption("ascale", ascale.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  how much frames to accumulate (from -1 to 100) (default 1)
        /// </summary>
        public AhistogramFilterGen acount(int acount) => this.SetOptionRange("acount", acount, -1, 100);
        /// <summary>
        ///  set histogram ratio of window height (from 0 to 1) (default 0.1)
        /// </summary>
        public AhistogramFilterGen rheight(float rheight) => this.SetOptionRange("rheight", rheight, 0, 1);
        /// <summary>
        ///  set sonogram sliding (from 0 to 1) (default replace)
        /// </summary>
        public AhistogramFilterGen slide(AhistogramFilterGenSlide slide) => this.SetOption("slide", slide.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set histograms mode (from 0 to 1) (default abs)
        /// </summary>
        public AhistogramFilterGen hmode(AhistogramFilterGenHmode hmode) => this.SetOption("hmode", hmode.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set method to display channels (from 0 to 1) (default single)
    /// </summary>
    public enum AhistogramFilterGenDmode
    {
        /// <summary>
        /// single          0            ..FV....... all channels use single histogram
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("single")]
        single = 0,
        /// <summary>
        /// separate        1            ..FV....... each channel have own histogram
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("separate")]
        separate = 1
    }

    /// <summary>
    ///  set display scale (from 0 to 4) (default log)
    /// </summary>
    public enum AhistogramFilterGenScale
    {
        /// <summary>
        /// log             3            ..FV....... logarithmic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("log")]
        log = 3,
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
        /// lin             0            ..FV....... linear
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lin")]
        lin = 0,
        /// <summary>
        /// rlog            4            ..FV....... reverse logarithmic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rlog")]
        rlog = 4
    }

    /// <summary>
    ///  set amplitude scale (from 0 to 1) (default log)
    /// </summary>
    public enum AhistogramFilterGenAscale
    {
        /// <summary>
        /// log             1            ..FV....... logarithmic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("log")]
        log = 1,
        /// <summary>
        /// lin             0            ..FV....... linear
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lin")]
        lin = 0
    }

    /// <summary>
    ///  set sonogram sliding (from 0 to 1) (default replace)
    /// </summary>
    public enum AhistogramFilterGenSlide
    {
        /// <summary>
        /// replace         0            ..FV....... replace old rows with new
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("replace")]
        replace = 0,
        /// <summary>
        /// scroll          1            ..FV....... scroll from top to bottom
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("scroll")]
        scroll = 1
    }

    /// <summary>
    ///  set histograms mode (from 0 to 1) (default abs)
    /// </summary>
    public enum AhistogramFilterGenHmode
    {
        /// <summary>
        /// abs             0            ..FV....... use absolute samples
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("abs")]
        abs = 0,
        /// <summary>
        /// sign            1            ..FV....... use unchanged samples
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sign")]
        sign = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Convert input audio to histogram video output.
        /// </summary>
        public static AhistogramFilterGen AhistogramFilterGen(this AudioMap input0) => new AhistogramFilterGen(input0);
    }
}