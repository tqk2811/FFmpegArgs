using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.MultimediaFilters
{
  /// <summary>
  /// ... setapts            V->V       Set PTS for the output audio frame.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#setpts_002c-asetpts
  /// </summary>
  public class SetAPtsFilter : AudioToAudioFilter
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
    internal SetAPtsFilter(Action<Expression> expr, IAudioMap audioMap) : base("setapts", audioMap)
    {
      AddMapOut();
      this.SetOption("expr", expr.Run(expression));
    }
  }
  public static class SetAPtsFilterExtension
  {
    public static SetAPtsFilter SetAPtsFilter(this IAudioMap audioMap, Action<Expression> expr)
    {
      return new SetAPtsFilter(expr, audioMap);
    }

    public static SetAPtsFilter SetAPtsFilter(this IAudioMap audioMap, string expr)
    {
      return new SetAPtsFilter(expr.Expression(), audioMap);
    }
  }
}
