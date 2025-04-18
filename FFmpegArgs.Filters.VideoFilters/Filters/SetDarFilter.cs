/*
setdar AVOptions:
  dar               <string>     ..FV....... set display aspect ratio (default "0")
  ratio             <string>     ..FV....... set display aspect ratio (default "0")
  r                 <string>     ..FV....... set display aspect ratio (default "0")
  max               <int>        ..FV....... set max value for nominator or denominator in the ratio (from 1 to INT_MAX) (default 100)
 */
namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... setdar            V->V       Set the frame display aspect ratio.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#setdar_002c-setsar
    /// </summary>
    public class SetDarFilter : ImageToImageFilter
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "w", "h",
            "a", "sar",
            "dar",
            "hsub", "vsub"
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_variables);
        internal SetDarFilter(ImageMap imageMap) : base("setdar", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the aspect ratio used by the filter.<br>
        /// </br>The parameter can be a floating point number string, an expression, or a string of the form num:den, where num and den are the numerator and denominator of the aspect ratio.If the parameter is not specified, it is assumed the value "0".
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public SetDarFilter Ratio(ExpressionValue r) => this.SetOption("r", expression.Check(r));
        /// <summary>
        /// Set the aspect ratio used by the filter.<br>
        /// </br>The parameter can be a floating point number string, an expression, or a string of the form num:den, where num and den are the numerator and denominator of the aspect ratio.If the parameter is not specified, it is assumed the value "0".
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public SetDarFilter Ratio(Rational r) => this.SetOption("r", $"{r.Numerator}:{r.Denominator}");
        /// <summary>
        /// Set the maximum integer value to use for expressing numerator and denominator when reducing the expressed aspect ratio to a rational. <br>
        /// </br>(from 1 to INT_MAX) (default 100)
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public SetDarFilter Max(int max)
          => this.SetOptionRange("max", max, 1, INT_MAX);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SetDarFilterExtension
    {
        /// <summary>
        /// This is done by changing the specified Sample (aka Pixel) Aspect Ratio, according to the following equation:<br></br>
        /// <b>DAR = HORIZONTAL_RESOLUTION / VERTICAL_RESOLUTION* SAR</b><br>
        /// </br>Keep in mind that the setdar filter does not modify the pixel dimensions of the video frame.Also, the display aspect ratio set by this filter may be changed by later filters in the filterchain, e.g. in case of scaling or if another "setdar" or a "setsar" filter is applied.<br>
        /// </br>The setsar filter sets the Sample(aka Pixel) Aspect Ratio for the filter output video.<br>
        /// </br>Note that as a consequence of the application of this filter, the output display aspect ratio will change according to the equation above.<br>
        /// </br>Keep in mind that the sample aspect ratio set by the setsar filter may be changed by later filters in the filterchain, e.g. if another "setsar" or a "setdar" filter is applied.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="r"></param>
        /// <returns></returns>
        public static SetDarFilter SetDarFilter(this ImageMap imageMap) => new SetDarFilter(imageMap);
    }
}
