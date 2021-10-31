using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Exceptions;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.MultimediaFilters
{
  /// <summary>
  /// ... aselect           A->N       Select audio frames to pass in output.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#select_002c-aselect
  /// </summary>
  public class ASelectFilter : AudioToAudioFilter
  {
    static readonly IEnumerable<string> _variables = new List<string>()
    {
      "n","selected_n", "prev_selected_n",
      "TB", "pts", "t",
      "prev_pts", "prev_selected_pts", "prev_selected_t",
      "start_pts", "start_t",
      "consumed_sample_n ", "samples_n", "sample_rate",
      "key", "pos",
      "concatdec_select"
    };
    readonly Expression expression = new Expression(_variables);
    internal ASelectFilter(Action<Expression> e, int n, IAudioMap audioMap) : base($"aselect", audioMap)
    {
      if (n < 1) throw new InvalidRangeException(nameof(n));
      AddMultiMapOut(n);
      this.SetOption("e", e.Run(expression)); 
      this.SetOption("n", n);
    }
  }

  public static class ASelectFilterExtension
  {
    public static ASelectFilter ASelectFilter(this IAudioMap audioMap, Action<Expression> e, int n)
    {
      return new ASelectFilter(e, n, audioMap);
    }
    public static ASelectFilter ASelectFilter(this IAudioMap audioMap, string e, int n)
    {
      return new ASelectFilter(e.Expression(), n, audioMap);
    }

  }
}
