﻿/*
asetpts AVOptions:
  expr              <string>     ..F.A...... Expression determining the frame timestamp (default "PTS")
 */
namespace FFmpegArgs.Filters.MultimediaFilters
{
    /// <summary>
    /// ... setapts            V->V       Set PTS for the output audio frame.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#setpts_002c-asetpts"/>
    /// </summary>
    public class AsetptsFilter : AudioToAudioFilter
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
        internal AsetptsFilter(Action<FFmpegExpression> expr, AudioMap audioMap) : base("asetpts", audioMap)
        {
            AddMapOut();
            this.SetOption("expr", expr.Run(expression));
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AsetptsFilterExtension
    {
        /// <summary>
        /// Change the PTS (presentation timestamp) of the input frames.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#setpts_002c-asetpts"/>>
        /// </summary>
        /// <param name="audioMap"></param>
        /// <param name="expr">The expression which is evaluated for each frame to construct its timestamp.</param>
        /// <returns></returns>
        public static AsetptsFilter AsetptsFilter(this AudioMap audioMap, Action<FFmpegExpression> expr)
        {
            return new AsetptsFilter(expr, audioMap);
        }


        /// <summary>
        /// Change the PTS (presentation timestamp) of the input frames.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#setpts_002c-asetpts"/>
        /// </summary>
        /// <param name="audioMap"></param>
        /// <param name="expr">The expression which is evaluated for each frame to construct its timestamp.</param>
        /// <returns></returns>
        public static AsetptsFilter AsetptsFilter(this AudioMap audioMap, string expr)
        {
            return new AsetptsFilter(expr.Expression(), audioMap);
        }
    }
}
