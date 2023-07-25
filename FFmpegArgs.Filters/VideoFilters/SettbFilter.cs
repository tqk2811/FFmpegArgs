/*
 settb AVOptions:
   expr              <string>     ..FV....... set expression determining the output timebase (default "intb")
   tb                <string>     ..FV....... set expression determining the output timebase (default "intb")
 */
namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... settb             V->V       Set timebase for the video output link.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#settb_002c-asettb
    /// </summary>
    public class SettbFilter : ImageToImageFilter
    {
        private static readonly IEnumerable<string> _variables = new List<string>
        {
            "AVTB","intb","sr"
        };

        private readonly FFmpegExpression expression = new FFmpegExpression(_variables);

        internal SettbFilter(Action<FFmpegExpression> expr, ImageMap mapIn) : base("settb", mapIn)
        {
            AddMapOut();
            this.SetOption("expr", expr.Run(expression));
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SettbFilterExtension
    {
        /// <summary>
        /// Set the timebase to use for the output frames timestamps. It is mainly useful for testing timebase configuration.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="expr">The expression which is evaluated into the output timebase.</param>
        /// <returns></returns>
        public static SettbFilter SettbFilter(this ImageMap imageMap, Action<FFmpegExpression> expr)
            => new SettbFilter(expr, imageMap);
        /// <summary>
        /// Set the timebase to use for the output frames timestamps. It is mainly useful for testing timebase configuration.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="expr">The expression which is evaluated into the output timebase.</param>
        /// <returns></returns>
        public static SettbFilter SettbFilter(this ImageMap imageMap, string expr)
            => new SettbFilter(expr.Expression(), imageMap);
    }
}
