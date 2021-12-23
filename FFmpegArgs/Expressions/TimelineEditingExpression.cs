using System.Collections.Generic;

namespace FFmpegArgs.Expressions
{
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



        public TimelineEditingExpression() : base(variables)
        {

        }
    }
}
