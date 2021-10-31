using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// <br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#fps-1
  /// </summary>
  public class FpsFilter : ImageToImageFilter
  {
    static readonly IEnumerable<string> _consts = new List<string>()
    {
      "source_fps",
      "ntsc",
      "pal",
      "film",
      "ntsc_film"
    };
    readonly Expression expression = new Expression(_consts);
    internal FpsFilter(Action<Expression> fps, IImageMap imageMap) : base("fps", imageMap)
    {
      _mapsOut.Add(new ImageMap(this.FilterGraph, $"f_{this.FilterIndex}"));
      this.SetOption("fps", fps.Run(expression));
    }

    public FpsFilter StartTime(double startTime)
      => this.SetOption("start_time", startTime);

    public FpsFilter Round(FpsRound fpsRound)
      => this.SetOption("round", fpsRound);

    public FpsFilter EofAction(FpsEofAction fpsEofAction)
      => this.SetOption("round", fpsEofAction);
  }

  public static class FpsFilterExtension
  {
    public static FpsFilter FpsFilter(this IImageMap imageMap, Action<Expression> fps)
    {
      return new FpsFilter(fps, imageMap);
    }
    public static FpsFilter FpsFilter(this IImageMap imageMap, string fps)
    {
      return new FpsFilter(fps.Expression(), imageMap);
    }
  }

  public enum FpsRound
  {
    zero,
    inf,
    down,
    up,
    near,
  }

  public enum FpsEofAction
  {
    round,
    pass
  }
}
