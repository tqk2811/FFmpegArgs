namespace FFmpegArgs.Filters.Expressions
{
    /// <summary>
    /// 
    /// </summary>
    public class TimelineEditingExpression : FFmpegExpression
    {
        /// <summary>
        /// Default instance
        /// </summary>
        public static TimelineEditingExpression Instance { get; } = new TimelineEditingExpression();
        static readonly List<string> variables = new List<string>()
        {
          "t",
          "n",
          "pos",
          "w",
          "h"
        };

        /// <summary>
        /// 
        /// </summary>
        private TimelineEditingExpression() : base(variables)
        {
        }
    }
}
