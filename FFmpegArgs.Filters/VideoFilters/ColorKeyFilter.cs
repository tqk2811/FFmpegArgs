﻿using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Exceptions;
using System;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoFilters
{
  /// <summary>
  /// TSC colorkey          V->V       Turns a certain color into transparency. Operates on RGB colors.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#colorkey
  /// </summary>
  public class ColorKeyFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
  {
    internal ColorKeyFilter(Color color, ImageMap imageMap) : base("colorkey", imageMap)
    {
      AddMapOut();
      this.SetOption("color", color.ToHexStringRGB());
    }

    public ColorKeyFilter Color(Color color)
      => this.SetOption("color", color.ToHexStringRGB());

    public ColorKeyFilter Similarity(float similarity)
      => this.SetOptionRange("similarity", similarity, 0, 1);

    /// <summary>
    /// 0.0 makes pixels either fully transparent, or not transparent at all.
    /// </summary>
    /// <param name="blend"></param>
    /// <returns></returns>
    public ColorKeyFilter Blend(float blend)
      => this.SetOptionRange("blend", blend, 0, 1);
  }

  public static class ColorKeyFilterExtension
  {
    /// <summary>
    /// RGB colorspace color keying.
    /// </summary>
    /// <param name="parent"></param>
    /// <param name="color"></param>
    /// <returns></returns>
    public static ColorKeyFilter ColorKeyFilter(this ImageMap parent, Color color)
      => new ColorKeyFilter(color, parent);
  }
}
