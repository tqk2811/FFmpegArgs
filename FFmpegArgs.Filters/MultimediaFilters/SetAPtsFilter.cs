using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.MultimediaFilters
{
    /// <summary>
    /// ... setapts            V->V       Set PTS for the output audio frame.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#setpts_002c-asetpts
    /// </summary>
    public class SetAPtsFilter : AudioToAudioFilter
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "FRAME_RATE","FR",
            "PTS",
            "N",
            "NB_CONSUMED_SAMPLES",
            "NB_SAMPLES", "S",
            "SAMPLE_RATE", "SR",
            "STARTPTS",
            "STARTT",
            "INTERLACED",
            "T",
            "POS",
            "PREV_INPTS",
            "PREV_INT",
            "PREV_OUTPTS",
            "PREV_OUTT",
            "RTCTIME",
            "RTCSTART",
            "TB"
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_variables);
        internal SetAPtsFilter(Action<FFmpegExpression> expr, AudioMap audioMap) : base("setapts", audioMap)
        {
            AddMapOut();
            this.SetOption("expr", expr.Run(expression));
        }
    }
    public static class SetAPtsFilterExtension
    {
        /// <summary>
        /// Change the PTS (presentation timestamp) of the input frames.
        /// </summary>
        /// <param name="audioMap"></param>
        /// <param name="expr">The expression which is evaluated for each frame to construct its timestamp.</param>
        /// <returns></returns>
        public static SetAPtsFilter SetAPtsFilter(this AudioMap audioMap, Action<FFmpegExpression> expr)
        {
            return new SetAPtsFilter(expr, audioMap);
        }

        /// <summary>
        /// Change the PTS (presentation timestamp) of the input frames.
        /// </summary>
        /// <param name="audioMap"></param>
        /// <param name="expr">The expression which is evaluated for each frame to construct its timestamp.</param>
        /// <returns></returns>
        public static SetAPtsFilter SetAPtsFilter(this AudioMap audioMap, string expr)
        {
            return new SetAPtsFilter(expr.Expression(), audioMap);
        }
    }
}
