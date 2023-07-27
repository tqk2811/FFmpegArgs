/*
pad_opencl AVOptions:
   width             <string>     ..FV....... set the pad area width (default "iw")
   w                 <string>     ..FV....... set the pad area width (default "iw")
   height            <string>     ..FV....... set the pad area height (default "ih")
   h                 <string>     ..FV....... set the pad area height (default "ih")
   x                 <string>     ..FV....... set the x offset for the input image position (default "0")
   y                 <string>     ..FV....... set the y offset for the input image position (default "0")
   color             <color>      ..FV....... set the color of the padded area border (default "black")
   aspect            <rational>   ..FV....... pad to fit an aspect instead of a resolution (from 0 to 32767) (default 0/1)
*/
namespace FFmpegArgs.Filters.OpenCLVideoFilters
{
    /// <summary>
    /// ... pad_opencl        V->V       Pad the input video.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#pad_005fopencl
    /// </summary>
    public class PadOpenclFilter : ImageToImageFilter
    {
        static readonly IEnumerable<string> _variables = new string[]
        {
            "in_w", "in_h", "iw", "ih", "out_w", "out_h", "ow", "oh",
            "x", "y", "a", "sar", "dar"
        };
        readonly FFmpegExpression expression = new FFmpegExpression();
        internal PadOpenclFilter(ImageMap imageMap) : base("pad_opencl", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Specify an expression for the size of the output image with the paddings added. If the value for width or height is 0, the corresponding input size is used for the output.<br>
        /// </br>The width expression can reference the value set by the height expression, and vice versa.<br>
        /// </br>The default value of width and height is 0.
        /// </summary>
        /// <param name="width"></param>
        /// <returns></returns>
        public PadOpenclFilter Width(ExpressionValue width)
            => this.SetOption("w", expression.Check(width));
        /// <summary>
        /// Specify an expression for the size of the output image with the paddings added. If the value for width or height is 0, the corresponding input size is used for the output.<br>
        /// </br>The width expression can reference the value set by the height expression, and vice versa.<br>
        /// </br>The default value of width and height is 0.
        /// </summary>
        /// <param name="height"></param>
        /// <returns></returns>
        public PadOpenclFilter Height(ExpressionValue height)
            => this.SetOption("h", expression.Check(height));
        /// <summary>
        /// Specify the color of the padded area. Default <b>black</b>
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public PadOpenclFilter Color(Color color)
            => this.SetOption("color", color.ToHexStringRGBA());
        /// <summary>
        /// Pad to an aspect instead to a resolution.
        /// </summary>
        /// <param name="rational"></param>
        /// <returns></returns>
        public PadOpenclFilter Aspect(Rational rational)
            => this.SetOption("aspect", rational.Check(0, 32767));
    }
    /// <summary>
    /// 
    /// </summary>
    public static class PadOpenclFilterExtensions
    {
        /// <summary>
        /// Add paddings to the input image, and place the original input at the provided x, y coordinates.
        /// </summary>
        public static PadOpenclFilter PadOpenclFilter(this ImageMap imageMap)
          => new PadOpenclFilter(imageMap);
    }
}
