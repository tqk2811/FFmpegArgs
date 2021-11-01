using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// ... setdar            V->V       Set the frame display aspect ratio.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#setdar_002c-setsar
  /// </summary>
  public class SetDarFilter : ImageToImageFilter
  {
    static readonly IEnumerable<string> _variables = new List<string>()
    {
      "w", "h",
      "a", "sar",
      "dar",
      "hsub", "vsub"
    };
    readonly Expression expression = new Expression();
    internal SetDarFilter(Action<Expression> r, ImageMap imageMap) : base("setdar", imageMap)
    {
      AddMapOut();
      this.SetOption("r", r.Run(expression));
    }

    public SetDarFilter Max(int max)
      => this.SetOption("max", max);
  }

  public static class SetDarFilterExtension
  {
    public static SetDarFilter SetDarFilter(this ImageMap imageMap, Action<Expression> r)
    {
      return new SetDarFilter(r, imageMap);
    }
    public static SetDarFilter SetDarFilter(this ImageMap imageMap, string r)
    {
      return new SetDarFilter(r.Expression(), imageMap);
    }
  }
}
