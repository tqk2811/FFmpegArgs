namespace FFmpegArgs.Filters.Expressions
{
    /// <summary>
    /// 
    /// </summary>
    public class TimelineEditingExpression : FFmpegExpression
    {
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
        public TimelineEditingExpression() : base(variables)
        {
        }
    }
}
