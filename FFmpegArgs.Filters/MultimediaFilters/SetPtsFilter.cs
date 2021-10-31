using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;

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
    readonly Expression expression = new Expression(_variables);
    internal SetPtsFilter(Action<Expression> expr, IImageMap imageMap) : base("setpts", imageMap)
    {
      AddMapOut();
      this.SetOption("expr", expr.Run(expression));
    }
  }


  public static class SetPtsFilterExtension
  {
    public static SetPtsFilter SetPtsFilter(this IImageMap imageMap, Action<Expression> expr)
    {
      return new SetPtsFilter(expr, imageMap);
    }
    public static SetPtsFilter SetPtsFilter(this IImageMap imageMap, string expr)
    {
      return new SetPtsFilter(expr.Expression(), imageMap);
    }
  }
}
