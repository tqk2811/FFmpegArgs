namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... pad               V->V       Pad the input video.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#pad-1 
    /// </summary>
    public class PadFilter : ImageToImageFilter
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "in_w", "in_h", "iw", "ih",
            "out_w", "out_h", "ow", "oh",
            "x","y","a","sar","dar",
            "hsub", "vsub"
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_variables);
        internal PadFilter(ImageMap imageMap) : base("pad", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Specify the offsets to place the input image at within the padded area, with respect to the top/left border of the output image.<br></br>
        /// The x expression can reference the value set by the y expression, and vice versa.<br></br>
        /// The default value of x and y is 0.<br></br>
        /// If x or y evaluate to a negative number, they’ll be changed so the input image is centered on the padded area.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public PadFilter X(string x) => this.SetOption("x", x.Expression().Run(expression));
        /// <summary>
        /// Specify the offsets to place the input image at within the padded area, with respect to the top/left border of the output image.<br></br>
        /// The x expression can reference the value set by the y expression, and vice versa.<br></br>
        /// The default value of x and y is 0.<br></br>
        /// If x or y evaluate to a negative number, they’ll be changed so the input image is centered on the padded area.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public PadFilter Y(string y) => this.SetOption("y", y.Expression().Run(expression));
        /// <summary>
        /// Specify the offsets to place the input image at within the padded area, with respect to the top/left border of the output image.<br></br>
        /// The x expression can reference the value set by the y expression, and vice versa.<br></br>
        /// The default value of x and y is 0.<br></br>
        /// If x or y evaluate to a negative number, they’ll be changed so the input image is centered on the padded area.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public PadFilter X(Action<FFmpegExpression> x) => this.SetOption("x", x.Run(expression));
        /// <summary>
        /// Specify the offsets to place the input image at within the padded area, with respect to the top/left border of the output image.<br></br>
        /// The x expression can reference the value set by the y expression, and vice versa.<br></br>
        /// The default value of x and y is 0.<br></br>
        /// If x or y evaluate to a negative number, they’ll be changed so the input image is centered on the padded area.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public PadFilter Y(Action<FFmpegExpression> y) => this.SetOption("y", y.Run(expression));
        /// <summary>
        /// Specify an expression for the size of the output image with the paddings added. If the value for width or height is 0, the corresponding input size is used for the output.<br></br>
        /// The width expression can reference the value set by the height expression, and vice versa.<br>
        /// </br>The default value of width and height is 0.
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public PadFilter W(string w) => this.SetOption("w", w.Expression().Run(expression));
        /// <summary>
        /// Specify an expression for the size of the output image with the paddings added. If the value for width or height is 0, the corresponding input size is used for the output.<br></br>
        /// The width expression can reference the value set by the height expression, and vice versa.<br>
        /// </br>The default value of width and height is 0.
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public PadFilter H(string h) => this.SetOption("h", h.Expression().Run(expression));
        /// <summary>
        /// Specify an expression for the size of the output image with the paddings added. If the value for width or height is 0, the corresponding input size is used for the output.<br></br>
        /// The width expression can reference the value set by the height expression, and vice versa.<br>
        /// </br>The default value of width and height is 0.
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public PadFilter W(Action<FFmpegExpression> w) => this.SetOption("w", w.Run(expression));
        /// <summary>
        /// Specify an expression for the size of the output image with the paddings added. If the value for width or height is 0, the corresponding input size is used for the output.<br></br>
        /// The width expression can reference the value set by the height expression, and vice versa.<br>
        /// </br>The default value of width and height is 0.
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public PadFilter H(Action<FFmpegExpression> h) => this.SetOption("h", h.Run(expression));
        /// <summary>
        /// Specify the color of the padded area.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public PadFilter Color(Color color)
          => this.SetOption("color", color.ToHexStringRGBA());
        /// <summary>
        /// Specify when to evaluate width, height, x and y expression.
        /// </summary>
        /// <param name="eval"></param>
        /// <returns></returns>
        public PadFilter Eval(PadEval eval)
          => this.SetOption("eval", eval.ToString().ToLower());
        /// <summary>
        /// Pad to aspect instead to a resolution.
        /// </summary>
        /// <param name="rational"></param>
        /// <returns></returns>
        public PadFilter Aspect(Rational rational)
            => this.SetOption("aspect", rational.Check(0, DBL_MAX));
    }
    public static class PadFilterExtension
    {
        /// <summary>
        /// Add paddings to the input image, and place the original input at the provided x, y coordinates.
        /// </summary>
        public static PadFilter PadFilter(this ImageMap imageMap)
            => new PadFilter(imageMap);
    }
    public enum PadEval
    {
        Init,
        Frame
    }
}
