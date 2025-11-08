namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. vignette          V-&gt;V       Make or reverse a vignette effect.
    /// </summary>
    public class VignetteFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal VignetteFilterGen(ImageMap input) : base("vignette", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set lens angle (default &quot;PI/5&quot;)
        /// </summary>
        public VignetteFilterGen angle(String angle) => this.SetOption("angle", angle.ToString());
        /// <summary>
        ///  set circle center position on x-axis (default &quot;w/2&quot;)
        /// </summary>
        public VignetteFilterGen x0(String x0) => this.SetOption("x0", x0.ToString());
        /// <summary>
        ///  set circle center position on y-axis (default &quot;h/2&quot;)
        /// </summary>
        public VignetteFilterGen y0(String y0) => this.SetOption("y0", y0.ToString());
        /// <summary>
        ///  set forward/backward mode (from 0 to 1) (default forward)
        /// </summary>
        public VignetteFilterGen mode(VignetteFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  specify when to evaluate expressions (from 0 to 1) (default init)
        /// </summary>
        public VignetteFilterGen eval(VignetteFilterGenEval eval) => this.SetOption("eval", eval.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set dithering (default true)
        /// </summary>
        public VignetteFilterGen dither(bool dither) => this.SetOption("dither", dither.ToFFmpegFlag());
        /// <summary>
        ///  set aspect ratio (from 0 to DBL_MAX) (default 1/1)
        /// </summary>
        public VignetteFilterGen aspect(Rational aspect) => this.SetOption("aspect", aspect.Check(0, DBL_MAX));
    }

    /// <summary>
    ///  set forward/backward mode (from 0 to 1) (default forward)
    /// </summary>
    public enum VignetteFilterGenMode
    {
        /// <summary>
        /// forward         0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("forward")]
        forward = 0,
        /// <summary>
        /// backward        1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("backward")]
        backward = 1
    }

    /// <summary>
    ///  specify when to evaluate expressions (from 0 to 1) (default init)
    /// </summary>
    public enum VignetteFilterGenEval
    {
        /// <summary>
        /// init            0            ..FV....... eval expressions once during initialization
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("init")]
        init = 0,
        /// <summary>
        /// frame           1            ..FV....... eval expressions for each frame
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("frame")]
        frame = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Make or reverse a vignette effect.
        /// </summary>
        public static VignetteFilterGen VignetteFilterGen(this ImageMap input0) => new VignetteFilterGen(input0);
    }
}