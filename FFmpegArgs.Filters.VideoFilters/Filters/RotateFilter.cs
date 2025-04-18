/*
rotate AVOptions:
  angle             <string>     ..FV.....T. set angle (in radians) (default "0")
  a                 <string>     ..FV.....T. set angle (in radians) (default "0")
  out_w             <string>     ..FV....... set output width expression (default "iw")
  ow                <string>     ..FV....... set output width expression (default "iw")
  out_h             <string>     ..FV....... set output height expression (default "ih")
  oh                <string>     ..FV....... set output height expression (default "ih")
  fillcolor         <string>     ..FV....... set background fill color (default "black")
  c                 <string>     ..FV....... set background fill color (default "black")
  bilinear          <boolean>    ..FV....... use bilinear interpolation (default true)
 */
namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC rotate            V->V       Rotate the input image.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#rotate 
    /// </summary>
    public class RotateFilter : ImageToImageFilter, ICommandSupport, ITimelineSupport, ISliceThreading
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "n", "t",
            "hsub","vsub",
            "in_w", "iw",
            "in_h","ih",
            "out_w", "ow",
            "out_h", "oh"
        };
        static readonly IEnumerable<ShuntingYardFunction> _func = new List<ShuntingYardFunction>()
        {
            new ShuntingYardFunction("rotw","rotw_1"),
            new ShuntingYardFunction("roth","roth_1"),
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_variables, _func);
        internal RotateFilter(ImageMap imageMap) : base("rotate", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set an expression for the angle by which to rotate the input video clockwise, expressed as a number of radians. A negative value will result in a counter-clockwise rotation. By default it is set to "0".<br>
        /// </br>This expression is evaluated for each frame.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public RotateFilter Angle(ExpressionValue a)
            => this.SetOption("a", expression.Check(a));
        /// <summary>
        /// Set the output width expression, default value is "iw". This expression is evaluated just once during configuration.
        /// </summary>
        /// <param name="ow"></param>
        /// <returns></returns>
        public RotateFilter OW(ExpressionValue ow)
            => this.SetOption("ow", expression.Check(ow));
        /// <summary>
        /// Set the output height expression, default value is "ih". This expression is evaluated just once during configuration.
        /// </summary>
        /// <param name="oh"></param>
        /// <returns></returns>
        public RotateFilter OH(ExpressionValue oh)
            => this.SetOption("oh", expression.Check(oh));
        /// <summary>
        /// Enable bilinear interpolation if set to 1, a value of 0 disables it. Default value is 1.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public RotateFilter Bilinear(bool flag)
          => this.SetOption("bilinear", flag.ToFFmpegFlag());
        /// <summary>
        /// Set the color used to fill the output area not covered by the rotated image. If the special value "none" is selected then no background is printed (useful for example if the background is never shown).
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public RotateFilter FillColor(Color color)
           => this.SetOption("c", color.ToHexStringRGBA());
    }
    /// <summary>
    /// 
    /// </summary>
    public static class RotateFilterExtension
    {
        /// <summary>
        /// Rotate video by an arbitrary angle expressed in radians.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <returns></returns>
        public static RotateFilter RotateFilter(this ImageMap imageMap) => new RotateFilter(imageMap);
    }
}
