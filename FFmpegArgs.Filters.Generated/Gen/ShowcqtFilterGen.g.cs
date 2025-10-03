namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... showcqt           A-&gt;V       Convert input audio to a CQT (Constant/Clamped Q Transform) spectrum video output.
    /// </summary>
    public class ShowcqtFilterGen : AudioToImageFilter
    {
        internal ShowcqtFilterGen(AudioMap input) : base("showcqt", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set video size (default &quot;1920x1080&quot;)
        /// </summary>
        public ShowcqtFilterGen size(Size size) => this.SetOption("size", $"{size.Width}x{size.Height}");
        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public ShowcqtFilterGen fps(Rational fps) => this.SetOption("fps", fps.ToString());
        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public ShowcqtFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToString());
        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public ShowcqtFilterGen r(Rational r) => this.SetOption("r", r.ToString());
        /// <summary>
        ///  set bargraph height (from -1 to INT_MAX) (default -1)
        /// </summary>
        public ShowcqtFilterGen bar_h(int bar_h) => this.SetOptionRange("bar_h", bar_h, -1, INT_MAX);
        /// <summary>
        ///  set axis height (from -1 to INT_MAX) (default -1)
        /// </summary>
        public ShowcqtFilterGen axis_h(int axis_h) => this.SetOptionRange("axis_h", axis_h, -1, INT_MAX);
        /// <summary>
        ///  set sonogram height (from -1 to INT_MAX) (default -1)
        /// </summary>
        public ShowcqtFilterGen sono_h(int sono_h) => this.SetOptionRange("sono_h", sono_h, -1, INT_MAX);
        /// <summary>
        ///  set fullhd size (default true)
        /// </summary>
        public ShowcqtFilterGen fullhd(bool fullhd) => this.SetOption("fullhd", fullhd.ToFFmpegFlag());
        /// <summary>
        ///  set sonogram volume (default &quot;16&quot;)
        /// </summary>
        public ShowcqtFilterGen sono_v(String sono_v) => this.SetOption("sono_v", sono_v.ToString());
        /// <summary>
        ///  set sonogram volume (default &quot;16&quot;)
        /// </summary>
        public ShowcqtFilterGen volume(String volume) => this.SetOption("volume", volume.ToString());
        /// <summary>
        ///  set bargraph volume (default &quot;sono_v&quot;)
        /// </summary>
        public ShowcqtFilterGen bar_v(String bar_v) => this.SetOption("bar_v", bar_v.ToString());
        /// <summary>
        ///  set bargraph volume (default &quot;sono_v&quot;)
        /// </summary>
        public ShowcqtFilterGen volume2(String volume2) => this.SetOption("volume2", volume2.ToString());
        /// <summary>
        ///  set sonogram gamma (from 1 to 7) (default 3)
        /// </summary>
        public ShowcqtFilterGen sono_g(float sono_g) => this.SetOptionRange("sono_g", sono_g, 1, 7);
        /// <summary>
        ///  set sonogram gamma (from 1 to 7) (default 3)
        /// </summary>
        public ShowcqtFilterGen gamma(float gamma) => this.SetOptionRange("gamma", gamma, 1, 7);
        /// <summary>
        ///  set bargraph gamma (from 1 to 7) (default 1)
        /// </summary>
        public ShowcqtFilterGen bar_g(float bar_g) => this.SetOptionRange("bar_g", bar_g, 1, 7);
        /// <summary>
        ///  set bargraph gamma (from 1 to 7) (default 1)
        /// </summary>
        public ShowcqtFilterGen gamma2(float gamma2) => this.SetOptionRange("gamma2", gamma2, 1, 7);
        /// <summary>
        ///  set bar transparency (from 0 to 1) (default 1)
        /// </summary>
        public ShowcqtFilterGen bar_t(float bar_t) => this.SetOptionRange("bar_t", bar_t, 0, 1);
        /// <summary>
        ///  set timeclamp (from 0.002 to 1) (default 0.17)
        /// </summary>
        public ShowcqtFilterGen timeclamp(double timeclamp) => this.SetOptionRange("timeclamp", timeclamp, 0.002, 1);
        /// <summary>
        ///  set timeclamp (from 0.002 to 1) (default 0.17)
        /// </summary>
        public ShowcqtFilterGen tc(double tc) => this.SetOptionRange("tc", tc, 0.002, 1);
        /// <summary>
        ///  set attack time (from 0 to 1) (default 0)
        /// </summary>
        public ShowcqtFilterGen attack(double attack) => this.SetOptionRange("attack", attack, 0, 1);
        /// <summary>
        ///  set base frequency (from 10 to 100000) (default 20.0152)
        /// </summary>
        public ShowcqtFilterGen basefreq(double basefreq) => this.SetOptionRange("basefreq", basefreq, 10, 100000);
        /// <summary>
        ///  set end frequency (from 10 to 100000) (default 20495.6)
        /// </summary>
        public ShowcqtFilterGen endfreq(double endfreq) => this.SetOptionRange("endfreq", endfreq, 10, 100000);
        /// <summary>
        ///  set coeffclamp (from 0.1 to 10) (default 1)
        /// </summary>
        public ShowcqtFilterGen coeffclamp(float coeffclamp) => this.SetOptionRange("coeffclamp", coeffclamp, 0.1, 10);
        /// <summary>
        ///  set tlength (default &quot;384*tc/(384+tc*f)&quot;)
        /// </summary>
        public ShowcqtFilterGen tlength(String tlength) => this.SetOption("tlength", tlength.ToString());
        /// <summary>
        ///  set transform count (from 1 to 30) (default 6)
        /// </summary>
        public ShowcqtFilterGen count(int count) => this.SetOptionRange("count", count, 1, 30);
        /// <summary>
        ///  set frequency count (from 0 to 10) (default 0)
        /// </summary>
        public ShowcqtFilterGen fcount(int fcount) => this.SetOptionRange("fcount", fcount, 0, 10);
        /// <summary>
        ///  set axis font file
        /// </summary>
        public ShowcqtFilterGen fontfile(String fontfile) => this.SetOption("fontfile", fontfile.ToString());
        /// <summary>
        ///  set axis font
        /// </summary>
        public ShowcqtFilterGen font(String font) => this.SetOption("font", font.ToString());
        /// <summary>
        ///  set font color (default &quot;st(0, (midi(f)-59.5)/12);st(1, if(between(ld(0),0,1), 0.5-0.5*cos(2*PI*ld(0)), 0));r(1-ld(1)) + b(ld(1))&quot;)
        /// </summary>
        public ShowcqtFilterGen fontcolor(String fontcolor) => this.SetOption("fontcolor", fontcolor.ToString());
        /// <summary>
        ///  set axis image
        /// </summary>
        public ShowcqtFilterGen axisfile(String axisfile) => this.SetOption("axisfile", axisfile.ToString());
        /// <summary>
        ///  draw axis (default true)
        /// </summary>
        public ShowcqtFilterGen axis(bool axis) => this.SetOption("axis", axis.ToFFmpegFlag());
        /// <summary>
        ///  draw axis (default true)
        /// </summary>
        public ShowcqtFilterGen text(bool text) => this.SetOption("text", text.ToFFmpegFlag());
        /// <summary>
        ///  set color space (from 0 to INT_MAX) (default unspecified)
        /// </summary>
        public ShowcqtFilterGen csp(ShowcqtFilterGenCsp csp) => this.SetOption("csp", csp.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set color scheme (default &quot;1|0.5|0|0|0.5|1&quot;)
        /// </summary>
        public ShowcqtFilterGen cscheme(String cscheme) => this.SetOption("cscheme", cscheme.ToString());
    }

    /// <summary>
    ///  set color space (from 0 to INT_MAX) (default unspecified)
    /// </summary>
    public enum ShowcqtFilterGenCsp
    {
        /// <summary>
        /// unspecified     2            ..FV....... unspecified
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("unspecified")]
        unspecified = 2,
        /// <summary>
        /// bt709           1            ..FV....... bt709
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt709")]
        bt709 = 1,
        /// <summary>
        /// fcc             4            ..FV....... fcc
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fcc")]
        fcc = 4,
        /// <summary>
        /// bt470bg         5            ..FV....... bt470bg
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt470bg")]
        bt470bg = 5,
        /// <summary>
        /// smpte170m       6            ..FV....... smpte170m
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte170m")]
        smpte170m = 6,
        /// <summary>
        /// smpte240m       7            ..FV....... smpte240m
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("smpte240m")]
        smpte240m = 7,
        /// <summary>
        /// bt2020ncl       9            ..FV....... bt2020ncl
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bt2020ncl")]
        bt2020ncl = 9
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Convert input audio to a CQT (Constant/Clamped Q Transform) spectrum video output.
        /// </summary>
        public static ShowcqtFilterGen ShowcqtFilterGen(this AudioMap input0) => new ShowcqtFilterGen(input0);
    }
}