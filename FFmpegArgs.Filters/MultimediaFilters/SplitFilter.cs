using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Exceptions;
using System;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// ... split             V->N       Pass on the input to N video outputs.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#split_002c-asplit 
  /// </summary>
  public class SplitFilter : ImageToImageFilter
  {
    internal SplitFilter(int number, IImageMap imageMap) : base("split", imageMap)
    {
      if (number <= 0) throw new InvalidRangeException($"{nameof(number)} <= 0");
      AddMultiMapOut(number);
      this.SetOption("outputs", number);//libavfilter/split.c
    }
  }

  public static class SplitFilterExtension
  {
    public static SplitFilter SplitFilter(this IImageMap imageMap, int number)
    {
      return new SplitFilter(number, imageMap ?? throw new ArgumentNullException(nameof(imageMap)));
    }
  }
}
