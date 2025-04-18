/*
 geq AVOptions:
   lum_expr          <string>     ..FV....... set luminance expression
   lum               <string>     ..FV....... set luminance expression
   cb_expr           <string>     ..FV....... set chroma blue expression
   cb                <string>     ..FV....... set chroma blue expression
   cr_expr           <string>     ..FV....... set chroma red expression
   cr                <string>     ..FV....... set chroma red expression
   alpha_expr        <string>     ..FV....... set alpha expression
   a                 <string>     ..FV....... set alpha expression
   red_expr          <string>     ..FV....... set red expression
   r                 <string>     ..FV....... set red expression
   green_expr        <string>     ..FV....... set green expression
   g                 <string>     ..FV....... set green expression
   blue_expr         <string>     ..FV....... set blue expression
   b                 <string>     ..FV....... set blue expression
   interpolation     <int>        ..FV....... set interpolation method (from 0 to 1) (default bilinear)
     nearest         0            ..FV....... nearest interpolation
     n               0            ..FV....... nearest interpolation
     bilinear        1            ..FV....... bilinear interpolation
     b               1            ..FV....... bilinear interpolation
   i                 <int>        ..FV....... set interpolation method (from 0 to 1) (default bilinear)
     nearest         0            ..FV....... nearest interpolation
     n               0            ..FV....... nearest interpolation
     bilinear        1            ..FV....... bilinear interpolation
     b               1            ..FV....... bilinear interpolation
 */
namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TS. geq               V->V       Apply generic equation to each pixel.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#geq
    /// </summary>
    public class GeqFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        static readonly IEnumerable<string> _variable = new List<string>()
        {
            "N", "X", "Y", "W", "H",
            "SW", "SH", "T"
        };
        static readonly IEnumerable<ShuntingYardFunction> _funcs = new List<ShuntingYardFunction>()
        {
            new ShuntingYardFunction("p","p_2"),
            new ShuntingYardFunction("lum","lum_2"),
            new ShuntingYardFunction("cb","cb_2"),
            new ShuntingYardFunction("cr","cr_2"),
            new ShuntingYardFunction("r","r_2"),
            new ShuntingYardFunction("g","g_2"),
            new ShuntingYardFunction("b","b_2"),
            new ShuntingYardFunction("alpha","alpha_2"),
            new ShuntingYardFunction("psum","psum_2"),
            new ShuntingYardFunction("lumsum","lumsum_2"),
            new ShuntingYardFunction("cbsum","cbsum_2"),
            new ShuntingYardFunction("crsum","crsum_2"),
            new ShuntingYardFunction("rsum","rsum_2"),
            new ShuntingYardFunction("gsum","gsum_2"),
            new ShuntingYardFunction("bsum","bsum_2"),
            new ShuntingYardFunction("alphasum","alphasum_2"),
        };
        readonly FFmpegExpression fFmpegExpression = new FFmpegExpression(_variable, _funcs);
        internal GeqFilter(ImageMap imageMap) : base("geq", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the luminance expression.
        /// </summary>
        /// <param name="lum"></param>
        /// <returns></returns>
        public GeqFilter Lum(ExpressionValue lum)
            => this.SetOption("lum", fFmpegExpression.Check(lum));
        /// <summary>
        /// Set the chrominance blue expression.
        /// </summary>
        /// <param name="cb"></param>
        /// <returns></returns>
        public GeqFilter Cb(ExpressionValue cb)
            => this.SetOption("cb", fFmpegExpression.Check(cb));
        /// <summary>
        /// Set the chrominance red expression.
        /// </summary>
        /// <param name="cr"></param>
        /// <returns></returns>
        public GeqFilter Cr(ExpressionValue cr)
            => this.SetOption("cr", fFmpegExpression.Check(cr));
        /// <summary>
        /// Set the alpha expression.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public GeqFilter A(ExpressionValue a)
            => this.SetOption("a", fFmpegExpression.Check(a));
        /// <summary>
        /// Set the red expression.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public GeqFilter R(ExpressionValue r)
            => this.SetOption("r", fFmpegExpression.Check(r));
        /// <summary>
        /// Set the green expression.
        /// </summary>
        /// <param name="g"></param>
        /// <returns></returns>
        public GeqFilter G(ExpressionValue g)
            => this.SetOption("g", fFmpegExpression.Check(g));
        /// <summary>
        /// Set the blue expression.
        /// </summary>
        /// <param name="b"></param>
        /// <returns></returns>
        public GeqFilter B(ExpressionValue b)
            => this.SetOption("b", fFmpegExpression.Check(b));
    }
    /// <summary>
    /// 
    /// </summary>
    public static class GeqFilterExtensions
    {
        /// <summary>
        /// Apply generic equation to each pixel.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <returns></returns>
        public static GeqFilter GeqFilter(this ImageMap imageMap)
            => new GeqFilter(imageMap);
    }
}
