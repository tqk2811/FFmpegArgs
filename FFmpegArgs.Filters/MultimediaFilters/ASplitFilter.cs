using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Exceptions;
using System;

namespace FFmpegArgs.Filters.MultimediaFilters
{
  /// <summary>
  /// ... asplit            A->N       Pass on the audio input to N audio outputs.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#split_002c-asplit 
  /// </summary>
  public class ASplitFilter : AudioToAudioFilter
  {
    internal ASplitFilter(int number, IAudioMap audioMap) : base("asplit", audioMap)
    {
      if (number <= 0) throw new InvalidRangeException($"{nameof(number)} <= 0");
      for (int i = 0; i < number; i++)
      {
        _mapsOut.Add(new AudioMap(this.FilterGraph, $"f_{FilterIndex}_{i}"));
      }
      this.SetOption("outputs", number);//libavfilter/split.c
    }
  }

  public static class ASplitFilterExtension
  {
    public static ASplitFilter ASplit(this IAudioMap audioMap, int number)
    {
      return new ASplitFilter(number, audioMap ?? throw new ArgumentNullException(nameof(audioMap)));
    }
  }
}
