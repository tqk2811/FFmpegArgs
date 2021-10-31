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
    internal ASelectFilter(Action<Expression> e, IAudioMap audioMap) : base($"aselect", audioMap)
    {
      _mapsOut.Add(new AudioMap(this.FilterGraph, $"f_{FilterIndex}"));
      this.SetOption("e", e.Run(expression));
    }

    /// <summary>
    /// Set the number of outputs. <br></br>
    /// The output to which to send the selected frame is based on the result of the evaluation. <br></br>
    /// Default value is 1.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public ASelectFilter Output(int n)
    {
      if (n < 1) throw new InvalidRangeException($"{nameof(n)} < 1");
      return this.SetOption("n", n);
    }
  }

  public static class ASelectFilterExtension
  {
    public static ASelectFilter ASelectFilter(this IAudioMap audioMap, Action<Expression> e)
    {
      return new ASelectFilter(e, audioMap);
    }
    public static ASelectFilter ASelectFilter(this IAudioMap audioMap, string e)
    {
      return new ASelectFilter(e.Expression(), audioMap);
    }

  }
}
