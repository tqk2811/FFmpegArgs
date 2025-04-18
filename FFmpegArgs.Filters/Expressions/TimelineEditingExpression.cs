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
        public static TimelineEditingExpression Instance { get; }
        static readonly List<string> _variables;
        static TimelineEditingExpression()
        {
            _variables = new List<string>()
            {
                "t",
                "n",
                "pos",
                "w",
                "h"
            };
            Instance = new TimelineEditingExpression(_variables);
        }

        /// <summary>
        /// 
        /// </summary>
        private TimelineEditingExpression(IEnumerable<string> variables) : base(variables)
        {
        }
    }
}
