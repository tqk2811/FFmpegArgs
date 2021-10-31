using System.Collections.Generic;

namespace FFmpegArgs.Utils
{
  public class TimelineEditingExpression : Expression
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
