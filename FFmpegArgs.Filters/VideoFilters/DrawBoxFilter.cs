/*
 drawbox AVOptions:
   x                 <string>     ..FV.....T. set horizontal position of the left box edge (default "0")
   y                 <string>     ..FV.....T. set vertical position of the top box edge (default "0")
   width             <string>     ..FV.....T. set width of the box (default "0")
   w                 <string>     ..FV.....T. set width of the box (default "0")
   height            <string>     ..FV.....T. set height of the box (default "0")
   h                 <string>     ..FV.....T. set height of the box (default "0")
   color             <string>     ..FV.....T. set color of the box (default "black")
   c                 <string>     ..FV.....T. set color of the box (default "black")
   thickness         <string>     ..FV.....T. set the box thickness (default "3")
   t                 <string>     ..FV.....T. set the box thickness (default "3")
   replace           <boolean>    ..FV.....T. replace color & alpha (default false)
   box_source        <string>     ..FV.....T. use datas from bounding box in side data
 */
namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// T.C drawbox           V->V       Draw a colored box on the input video.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#drawbox 
    /// </summary>
    public class DrawBoxFilter : ImageToImageFilter, ITimelineSupport, ICommandSupport
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "dar",
            "hsub", "vsub",
            "in_h", "ih",
            "in_w", "iw",
            "sar",
            "x", "y",
            "w", "h",
            "t"
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_variables);
        internal DrawBoxFilter(ImageMap imageMap) : base("drawbox", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// The expressions which specify the top left corner coordinates of the box. It defaults to 0.
        /// </summary>
        public DrawBoxFilter X(ExpressionValue x)
            => this.SetOption("x", expression.Check(x));
        /// <summary>
        /// The expressions which specify the top left corner coordinates of the box. It defaults to 0.
        /// </summary>
        public DrawBoxFilter Y(ExpressionValue y)
            => this.SetOption("y", expression.Check(y));
        /// <summary>
        /// The expressions which specify the width and height of the box; if 0 they are interpreted as the input width and height. It defaults to 0.
        /// </summary>
        public DrawBoxFilter W(ExpressionValue w)
            => this.SetOption("w", expression.Check(w));
        /// <summary>
        /// The expressions which specify the width and height of the box; if 0 they are interpreted as the input width and height. It defaults to 0.
        /// </summary>
        public DrawBoxFilter H(ExpressionValue h)
            => this.SetOption("h", expression.Check(h));
        /// <summary>
        /// Specify the color of the box to write. If the special value invert is used, the box edge color is the same as the video with inverted luma.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public DrawBoxFilter Color(Color color)
            => this.SetOption("c", color.ToHexStringRGBA());
        /// <summary>
        /// The expression which sets the thickness of the box edge. A value of fill will create a filled box. Default value is 3.
        /// </summary>
        public DrawBoxFilter ThicknessFill()
          => this.SetOption("t", "fill");
        /// <summary>
        /// The expression which sets the thickness of the box edge. A value of fill will create a filled box. Default value is 3.
        /// </summary>
        public DrawBoxFilter Thickness(ExpressionValue t)
          => this.SetOption("t", expression.Check(t));
        /// <summary>
        /// Applicable if the input has alpha. With value 1, the pixels of the painted box will overwrite the video’s color and alpha pixels. Default is 0, which composites the box onto the input, leaving the video’s alpha intact.
        /// </summary>
        public DrawBoxFilter Replace(bool replace)
           => this.SetOption("replace", replace.ToFFmpegFlag());
    }
    /// <summary>
    /// 
    /// </summary>
    public static class DrawBoxFilterExtension
    {
        /// <summary>
        /// Draw a colored box on the input video.
        /// </summary>
        public static DrawBoxFilter DrawBoxFilter(this ImageMap imageMap)
            => new DrawBoxFilter(imageMap ?? throw new ArgumentNullException(nameof(imageMap)));
    }
}
