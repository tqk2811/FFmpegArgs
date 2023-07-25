/*
 aselect AVOptions:
   expr              <string>     ..F.A...... set an expression to use for selecting frames (default "1")
   e                 <string>     ..F.A...... set an expression to use for selecting frames (default "1")
   outputs           <int>        ..F.A...... set the number of outputs (from 1 to INT_MAX) (default 1)
   n                 <int>        ..F.A...... set the number of outputs (from 1 to INT_MAX) (default 1)
 */
namespace FFmpegArgs.Filters.MultimediaFilters
{
    /// <summary>
    /// ... aselect           A->N       Select audio frames to pass in output.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#select_002c-aselect
    /// </summary>
    public class ASelectFilter : AudioToAudioFilter
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "n","selected_n", "prev_selected_n",
            "TB", "pts", "t",
            "prev_pts", "prev_selected_pts", "prev_selected_t",
            "start_pts", "start_t",
            "consumed_sample_n ", "samples_n", "sample_rate",
            "key", "pos",
            "concatdec_select"
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_variables);
        internal ASelectFilter(ExpressionValue e, int n, AudioMap audioMap) : base($"aselect", audioMap)
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
    public static class ASelectFilterExtension
    {
        /// <summary>
        /// Select frames to pass in output.
        /// </summary>
        /// <param name="audioMap"></param>
        /// <param name="e">Set expression, which is evaluated for each input frame.</param>
        /// <param name="n">Set the number of outputs. The output to which to send the selected frame is based on the result of the evaluation. Default value is 1.</param>
        /// <returns></returns>
        public static ASelectFilter ASelectFilter(this AudioMap audioMap, ExpressionValue e, int n)
            => new ASelectFilter(e, n, audioMap);
    }
}
