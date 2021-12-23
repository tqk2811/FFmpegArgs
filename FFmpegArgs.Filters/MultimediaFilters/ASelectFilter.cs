using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Exceptions;
using FFmpegArgs.Expressions;
using System;
using System.Collections.Generic;

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
        internal ASelectFilter(Action<FFmpegExpression> e, int n, AudioMap audioMap) : base($"aselect", audioMap)
        {
            if (n < 1) throw new InvalidRangeException(nameof(n));
            AddMultiMapOut(n);
            this.SetOption("e", e.Run(expression));
            this.SetOption("n", n);
        }
    }

    public static class ASelectFilterExtension
    {
        /// <summary>
        /// Select frames to pass in output.
        /// </summary>
        /// <param name="audioMap"></param>
        /// <param name="e">Set expression, which is evaluated for each input frame.</param>
        /// <param name="n">Set the number of outputs. The output to which to send the selected frame is based on the result of the evaluation. Default value is 1.</param>
        /// <returns></returns>
        public static ASelectFilter ASelectFilter(this AudioMap audioMap, Action<FFmpegExpression> e, int n)
            => new ASelectFilter(e, n, audioMap);

        /// <summary>
        /// Select frames to pass in output.
        /// </summary>
        /// <param name="audioMap"></param>
        /// <param name="e">Set expression, which is evaluated for each input frame.</param>
        /// <param name="n">Set the number of outputs. The output to which to send the selected frame is based on the result of the evaluation. Default value is 1.</param>
        /// <returns></returns>
        public static ASelectFilter ASelectFilter(this AudioMap audioMap, string e, int n)
                => new ASelectFilter(e.Expression(), n, audioMap);
    }
}
