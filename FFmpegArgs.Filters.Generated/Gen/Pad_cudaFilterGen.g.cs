namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. pad_cuda          V-&gt;V       CUDA-based GPU padding filter
    /// </summary>
    public class Pad_cudaFilterGen : ImageToImageFilter
    {
        internal Pad_cudaFilterGen(ImageMap input) : base("pad_cuda", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the pad area width expression (default &quot;iw&quot;)
        /// </summary>
        public Pad_cudaFilterGen width(ExpressionValue width) => this.SetOption("width", (string)width);
        /// <summary>
        ///  set the pad area height expression (default &quot;ih&quot;)
        /// </summary>
        public Pad_cudaFilterGen height(ExpressionValue height) => this.SetOption("height", (string)height);
        /// <summary>
        ///  set the x offset expression for the input image position (default &quot;0&quot;)
        /// </summary>
        public Pad_cudaFilterGen x(ExpressionValue x) => this.SetOption("x", (string)x);
        /// <summary>
        ///  set the y offset expression for the input image position (default &quot;0&quot;)
        /// </summary>
        public Pad_cudaFilterGen y(ExpressionValue y) => this.SetOption("y", (string)y);
        /// <summary>
        ///  set the color of the padded area border (default &quot;black&quot;)
        /// </summary>
        public Pad_cudaFilterGen color(Color color) => this.SetOption("color", color.ToHexStringRGBA());
        /// <summary>
        ///  specify when to evaluate expressions (from 0 to 1) (default init)
        /// </summary>
        public Pad_cudaFilterGen eval(Pad_cudaFilterGenEval eval) => this.SetOption("eval", eval.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  pad to fit an aspect instead of a resolution (from 0 to DBL_MAX) (default 0/1)
        /// </summary>
        public Pad_cudaFilterGen aspect(Rational aspect) => this.SetOption("aspect", aspect.Check(0, DBL_MAX));
    }

    /// <summary>
    ///  specify when to evaluate expressions (from 0 to 1) (default init)
    /// </summary>
    public enum Pad_cudaFilterGenEval
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
        /// CUDA-based GPU padding filter
        /// </summary>
        public static Pad_cudaFilterGen Pad_cudaFilterGen(this ImageMap input0) => new Pad_cudaFilterGen(input0);
    }
}