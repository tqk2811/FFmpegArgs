namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... pad               V-&gt;V       Pad the input video.
    /// </summary>
    public class PadFilterGen : ImageToImageFilter
    {
        internal PadFilterGen(ImageMap input) : base("pad", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the pad area width expression (default &quot;iw&quot;)
        /// </summary>
        public PadFilterGen width(ExpressionValue width) => this.SetOption("width", (string)width);
        /// <summary>
        ///  set the pad area height expression (default &quot;ih&quot;)
        /// </summary>
        public PadFilterGen height(ExpressionValue height) => this.SetOption("height", (string)height);
        /// <summary>
        ///  set the x offset expression for the input image position (default &quot;0&quot;)
        /// </summary>
        public PadFilterGen x(ExpressionValue x) => this.SetOption("x", (string)x);
        /// <summary>
        ///  set the y offset expression for the input image position (default &quot;0&quot;)
        /// </summary>
        public PadFilterGen y(ExpressionValue y) => this.SetOption("y", (string)y);
        /// <summary>
        ///  set the color of the padded area border (default &quot;black&quot;)
        /// </summary>
        public PadFilterGen color(Color color) => this.SetOption("color", color.ToHexStringRGBA());
        /// <summary>
        ///  specify when to evaluate expressions (from 0 to 1) (default init)
        /// </summary>
        public PadFilterGen eval(PadFilterGenEval eval) => this.SetOption("eval", eval.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  pad to fit an aspect instead of a resolution (from 0 to DBL_MAX) (default 0/1)
        /// </summary>
        public PadFilterGen aspect(Rational aspect) => this.SetOption("aspect", aspect.Check(0, DBL_MAX));
    }

    /// <summary>
    ///  specify when to evaluate expressions (from 0 to 1) (default init)
    /// </summary>
    public enum PadFilterGenEval
    {
        /// <summary>
        /// init            0            ..FV....... eval expressions once during initialization
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("init")]
        init = 0,
        /// <summary>
        /// frame           1            ..FV....... eval expressions during initialization and per-frame
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("frame")]
        frame = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Pad the input video.
        /// </summary>
        public static PadFilterGen PadFilterGen(this ImageMap input0) => new PadFilterGen(input0);
    }
}