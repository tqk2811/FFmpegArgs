/*
 select AVOptions:
   expr              <string>     ..FV....... set an expression to use for selecting frames (default "1")
   e                 <string>     ..FV....... set an expression to use for selecting frames (default "1")
   outputs           <int>        ..FV....... set the number of outputs (from 1 to INT_MAX) (default 1)
   n                 <int>        ..FV....... set the number of outputs (from 1 to INT_MAX) (default 1)
 */
namespace FFmpegArgs.Filters.MultimediaFilters
{
    /// <summary>
    /// ... select            V->N       Select video frames to pass in output.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#select_002c-aselect
    /// </summary>
    public class SelectFilter : ImageToImageFilter
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "n","selected_n", "prev_selected_n",
            "TB", "pts", "t",
            "prev_pts", "prev_selected_pts", "prev_selected_t",
            "start_pts", "start_t",
            //"pict_type", "interlace_type", //i dont know how to use this
            "key", "pos", "scene",
            "concatdec_select"
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_variables);
        internal SelectFilter(ExpressionValue e, int n, ImageMap imageMap) : base("select", imageMap)
        {
            if (n < 1) throw new InvalidRangeException(nameof(n));
            AddMultiMapOut(n);
            this.SetOption("e", expression.Check(e));
            this.SetOption("n", n);
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SelectFilterExtension
    {
        /// <summary>
        /// Select frames to pass in output.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="e">Set expression, which is evaluated for each input frame.</param>
        /// <param name="n">Set the number of outputs. The output to which to send the selected frame is based on the result of the evaluation.</param>
        /// <returns></returns>
        public static SelectFilter SelectFilter(this ImageMap imageMap, ExpressionValue e, int n = 1)
            => new SelectFilter(e, n, imageMap);
    }
}
