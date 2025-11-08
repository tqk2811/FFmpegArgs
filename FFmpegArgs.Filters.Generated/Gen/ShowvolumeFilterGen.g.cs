namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. showvolume        A-&gt;V       Convert input audio volume to video output.
    /// </summary>
    public class ShowvolumeFilterGen : AudioToImageFilter
    {
        internal ShowvolumeFilterGen(AudioMap input) : base("showvolume", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set video rate (default &quot;25&quot;)
        /// </summary>
        public ShowvolumeFilterGen rate(Rational rate) => this.SetOption("rate", rate.ToString());
        /// <summary>
        ///  set border width (from 0 to 5) (default 1)
        /// </summary>
        public ShowvolumeFilterGen b(int b) => this.SetOptionRange("b", b, 0, 5);
        /// <summary>
        ///  set channel width (from 80 to 8192) (default 400)
        /// </summary>
        public ShowvolumeFilterGen w(int w) => this.SetOptionRange("w", w, 80, 8192);
        /// <summary>
        ///  set channel height (from 1 to 900) (default 20)
        /// </summary>
        public ShowvolumeFilterGen h(int h) => this.SetOptionRange("h", h, 1, 900);
        /// <summary>
        ///  set fade (from 0 to 1) (default 0.95)
        /// </summary>
        public ShowvolumeFilterGen f(double f) => this.SetOptionRange("f", f, 0, 1);
        /// <summary>
        ///  set volume color expression (default &quot;PEAK*255+floor((1-PEAK)*255)*256+0xff000000&quot;)
        /// </summary>
        public ShowvolumeFilterGen c(ExpressionValue c) => this.SetOption("c", (string)c);
        /// <summary>
        ///  display channel names (default true)
        /// </summary>
        public ShowvolumeFilterGen t(bool t) => this.SetOption("t", t.ToFFmpegFlag());
        /// <summary>
        ///  display volume value (default true)
        /// </summary>
        public ShowvolumeFilterGen v(bool v) => this.SetOption("v", v.ToFFmpegFlag());
        /// <summary>
        ///  duration for max value display (from 0 to 9000) (default 0)
        /// </summary>
        public ShowvolumeFilterGen dm(double dm) => this.SetOptionRange("dm", dm, 0, 9000);
        /// <summary>
        ///  set color of the max value line (default &quot;orange&quot;)
        /// </summary>
        public ShowvolumeFilterGen dmc(Color dmc) => this.SetOption("dmc", dmc.ToHexStringRGBA());
        /// <summary>
        ///  set orientation (from 0 to 1) (default h)
        /// </summary>
        public ShowvolumeFilterGen o(ShowvolumeFilterGenO o) => this.SetOption("o", o.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set step size (from 0 to 5) (default 0)
        /// </summary>
        public ShowvolumeFilterGen s(int s) => this.SetOptionRange("s", s, 0, 5);
        /// <summary>
        ///  set background opacity (from 0 to 1) (default 0)
        /// </summary>
        public ShowvolumeFilterGen p(float p) => this.SetOptionRange("p", p, 0, 1);
        /// <summary>
        ///  set mode (from 0 to 1) (default p)
        /// </summary>
        public ShowvolumeFilterGen m(ShowvolumeFilterGenM m) => this.SetOption("m", m.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set display scale (from 0 to 1) (default lin)
        /// </summary>
        public ShowvolumeFilterGen ds(ShowvolumeFilterGenDs ds) => this.SetOption("ds", ds.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set orientation (from 0 to 1) (default h)
    /// </summary>
    public enum ShowvolumeFilterGenO
    {
        /// <summary>
        /// h               0            ..FV....... horizontal
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("h")]
        h = 0,
        /// <summary>
        /// v               1            ..FV....... vertical
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("v")]
        v = 1
    }

    /// <summary>
    ///  set mode (from 0 to 1) (default p)
    /// </summary>
    public enum ShowvolumeFilterGenM
    {
        /// <summary>
        /// p               0            ..FV....... peak
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("p")]
        p = 0,
        /// <summary>
        /// r               1            ..FV....... rms
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("r")]
        r = 1
    }

    /// <summary>
    ///  set display scale (from 0 to 1) (default lin)
    /// </summary>
    public enum ShowvolumeFilterGenDs
    {
        /// <summary>
        /// lin             0            ..FV....... linear
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lin")]
        lin = 0,
        /// <summary>
        /// log             1            ..FV....... log
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("log")]
        log = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Convert input audio volume to video output.
        /// </summary>
        public static ShowvolumeFilterGen ShowvolumeFilterGen(this AudioMap input0) => new ShowvolumeFilterGen(input0);
    }
}