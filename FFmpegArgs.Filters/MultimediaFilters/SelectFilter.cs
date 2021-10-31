using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Exceptions;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.MultimediaFilters
{
  /// <summary>
  /// ... select            V->N       Select video frames to pass in output.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#select_002c-aselect
  /// </summary>
  public class SelectFilter : ImageToImageFilter
  {
    static readonly IEnumerable<string> _variables = new List<string>()
    {
      "n","selected_n", "prev_selected_n",
      "TB", "pts", "t",
      "prev_pts", "prev_selected_pts", "prev_selected_t",
      "start_pts", "start_t",
      //"pict_type", "interlace_type", //i dont know how to use this
      "key", "pos", "scene",
      "concatdec_select"
    };
    readonly Expression expression = new Expression(_variables);
    internal SelectFilter(Action<Expression> e, int n, IImageMap imageMap) : base("select", imageMap)
    {
      if (n < 1) throw new InvalidRangeException(nameof(n));
      for (int i = 0; i < n; i++) _mapsOut.Add(new ImageMap(FilterGraph, $"f_{FilterIndex}_{i}"));
      this.SetOption("e", e.Run(expression));
      this.SetOption("n", n);
    }
  }

  public static class SelectFilterExtension
  {
    public static SelectFilter SelectFilter(this IImageMap imageMap, Action<Expression> e, int n = 1)
    {
      return new SelectFilter(e, n, imageMap);
    }
    public static SelectFilter SelectFilter(this IImageMap imageMap, string e, int n = 1)
    {
      return new SelectFilter(e.Expression(), n, imageMap);
    }
  }
}
