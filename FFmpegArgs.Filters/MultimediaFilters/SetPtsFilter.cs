/*
setpts AVOptions:
  expr              <string>     ..FV....... Expression determining the frame timestamp (default "PTS")
 */
namespace FFmpegArgs.Filters.MultimediaFilters
{
    /// <summary>
    /// ... setpts            V->V       Set PTS for the output video frame.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#setpts_002c-asetpts
    /// </summary>
    public class SetPtsFilter : ImageToImageFilter
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
        internal SetPtsFilter(Action<FFmpegExpression> expr, ImageMap imageMap) : base("setpts", imageMap)
        {
            AddMapOut();
            this.SetOption("expr", expr.Run(expression));
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SetPtsFilterExtension
    {
        /// <summary>
        /// Change the PTS (presentation timestamp) of the input frames.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="expr">The expression which is evaluated for each frame to construct its timestamp.</param>
        /// <returns></returns>
        public static SetPtsFilter SetPtsFilter(this ImageMap imageMap, Action<FFmpegExpression> expr)
        {
            return new SetPtsFilter(expr, imageMap);
        }
        /// <summary>
        /// Change the PTS (presentation timestamp) of the input frames.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="expr">The expression which is evaluated for each frame to construct its timestamp.</param>
        /// <returns></returns>
        public static SetPtsFilter SetPtsFilter(this ImageMap imageMap, string expr)
        {
            return new SetPtsFilter(expr.Expression(), imageMap);
        }
    }
}
