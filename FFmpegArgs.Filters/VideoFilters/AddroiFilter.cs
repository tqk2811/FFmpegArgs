﻿using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// ... addroi            V->V       Add region of interest to frame.<br>
  /// </br>https://ffmpeg.org/ffmpeg-filters.html#addroi
  /// </summary>
  public class AddroiFilter : ImageToImageFilter
  {
    static readonly IEnumerable<string> _variables = new List<string>()
    {
      "iw", "ih", 
    };
    readonly Expression expression = new Expression();
    internal AddroiFilter(ImageMap imageMap) : base("addroi", imageMap)
    {
      AddMapOut();
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="x">Region distance in pixels from the left edge of the frame.</param>
    /// <param name="y">Region distance in pixels from the top edge of the frame.</param>
    /// <returns></returns>
    public AddroiFilter Postion(string x, string y)
      => this.SetOption("x", x.Expression().Run(expression))
      .SetOption("y", y.Expression().Run(expression));
    /// <summary>
    /// 
    /// </summary>
    /// <param name="x">Region distance in pixels from the left edge of the frame.</param>
    /// <param name="y">Region distance in pixels from the top edge of the frame.</param>
    /// <returns></returns>
    public AddroiFilter Postion(Action<Expression> x, Action<Expression> y)
      => this.SetOption("x", x.Run(expression))
      .SetOption("y", y.Run(expression));

    /// <summary>
    /// 
    /// </summary>
    /// <param name="w">Region width in pixels.</param>
    /// <param name="h">Region height in pixels.</param>
    /// <returns></returns>
    public AddroiFilter Size(string w, string h)
      => this.SetOption("w", w.Expression().Run(expression))
      .SetOption("h", h.Expression().Run(expression));

    /// <summary>
    /// 
    /// </summary>
    /// <param name="w">Region width in pixels.</param>
    /// <param name="h">Region height in pixels.</param>
    /// <returns></returns>
    public AddroiFilter Size(Action<Expression> w, Action<Expression> h)
      => this.SetOption("w", w.Run(expression))
      .SetOption("h", h.Run(expression));

    /// <summary>
    /// Quantisation offset to apply within the region.<br></br>
    /// This must be a real value in the range -1 to +1. A value of zero indicates no quality change.A negative value asks for better quality (less quantisation), while a positive value asks for worse quality (greater quantisation).<br></br>
    /// The range is calibrated so that the extreme values indicate the largest possible offset - if the rest of the frame is encoded with the worst possible quality, an offset of -1 indicates that this region should be encoded with the best possible quality anyway. Intermediate values are then interpolated in some codec-dependent way.<br></br>
    /// For example, in 10-bit H.264 the quantisation parameter varies between -12 and 51. A typical qoffset value of -1/10 therefore indicates that this region should be encoded with a QP around one-tenth of the full range better than the rest of the frame. So, if most of the frame were to be encoded with a QP of around 30, this region would get a QP of around 24 (an offset of approximately -1/10 * (51 - -12) = -6.3). An extreme value of -1 would indicate that this region should be encoded with the best possible quality regardless of the treatment of the rest of the frame - that is, should be encoded at a QP of -12.
    /// </summary>
    /// <param name="qoffset"></param>
    /// <returns></returns>
    public AddroiFilter Qoffset(float qoffset)
      => this.SetOptionRange("qoffset", qoffset, float.MinValue, float.MaxValue);

    /// <summary>
    /// If set to true, remove any existing regions of interest marked on the frame before adding the new one.
    /// </summary>
    /// <param name="flag"></param>
    /// <returns></returns>
    public AddroiFilter Clear(bool flag)
      => this.SetOption("clear", flag.ToFFmpegFlag());
  }

  public static class AddroiFilterExtensions
  {
    /// <summary>
    /// Mark a region of interest in a video frame.<br></br>
    /// The frame data is passed through unchanged, but metadata is attached to the frame indicating regions of interest which can affect the behaviour of later encoding.Multiple regions can be marked by applying the filter multiple times.
    /// </summary>
    /// <param name="imageMap"></param>
    /// <returns></returns>
    public static AddroiFilter AddroiFilter(this ImageMap imageMap)
      => new AddroiFilter(imageMap);
  }
}
