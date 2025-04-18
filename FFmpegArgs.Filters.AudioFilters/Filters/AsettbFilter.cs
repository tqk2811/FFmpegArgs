/*
 asettb AVOptions:
   expr              <string>     ..F.A...... set expression determining the output timebase (default "intb")
   tb                <string>     ..F.A...... set expression determining the output timebase (default "intb")
 */

namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... asettb            A->A       Set timebase for the audio output link.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#settb_002c-asettb
    /// </summary>
    public class AsettbFilter : AudioToAudioFilter
    {
        private static readonly IEnumerable<string> _variables = new List<string>
        {
            "AVTB","intb","sr"
        };

        private readonly FFmpegExpression expression = new FFmpegExpression(_variables);

        internal AsettbFilter(ExpressionValue expr, AudioMap mapIn) : base("asettb", mapIn)
        {
            AddMapOut();
            this.SetOption("expr", expression.Check(expr));
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AsettbFilterExtension
    {
        /// <summary>
        /// Set the timebase to use for the output frames timestamps. It is mainly useful for testing timebase configuration.
        /// </summary>
        /// <param name="audioMap"></param>
        /// <param name="expr">The expression which is evaluated into the output timebase.</param>
        /// <returns></returns>
        public static AsettbFilter AsettbFilter(this AudioMap audioMap, ExpressionValue expr)
            => new AsettbFilter(expr, audioMap);
    }
}
