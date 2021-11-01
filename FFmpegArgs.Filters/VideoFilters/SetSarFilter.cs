using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// ... setsar            V->V       Set the pixel sample aspect ratio.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#setdar_002c-setsar
  /// </summary>
  public class SetSarFilter : ImageToImageFilter
  {
    static readonly IEnumerable<string> _variables = new List<string>()
    {
      "w", "h",
      "a", "sar",
      "dar",
      "hsub", "vsub"
    };
    readonly Expression expression = new Expression();
    internal SetSarFilter(Action<Expression> r, ImageMap imageMap) : base("setsar", imageMap)
    {
      AddMapOut();
      this.SetOption("r", r.Run(expression));
    }

    public SetSarFilter Max(int max)
      => this.SetOption("max", max);

  }

  public static class SetSarFilterExtension
  {
    public static SetSarFilter SetSarFilter(this ImageMap imageMap, Action<Expression> r)
    {
      return new SetSarFilter(r, imageMap);
    }

    public static SetSarFilter SetSarFilter(this ImageMap imageMap, string r)
    {
      return new SetSarFilter(r.Expression(), imageMap);
    }
  }
}
