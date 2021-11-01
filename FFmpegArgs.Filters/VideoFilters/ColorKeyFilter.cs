using FFmpegArgs.Cores.Maps;
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
      _mapsOut.Add(new ImageMap(this.FilterGraph, $"f_{this.FilterIndex}"));
      this.SetOption("color", color.ToHexStringRGB());
    }

    public ColorKeyFilter Color(Color color)
      => this.SetOption("color", color.ToHexStringRGB());

    public ColorKeyFilter Similarity(float similarity)
    {
      if (similarity < 0 || similarity > 1) throw new InvalidRangeException($"Only accept: 0 <= {nameof(similarity)} <= 1");
      return this.SetOption("similarity", similarity);
    }

    /// <summary>
    /// 0.0 makes pixels either fully transparent, or not transparent at all.
    /// </summary>
    /// <param name="blend"></param>
    /// <returns></returns>
    public ColorKeyFilter Blend(float blend)
    {
      if (blend < 0 || blend > 1) throw new InvalidRangeException($"Only accept: 0 <= {nameof(blend)} <= 1");
      return this.SetOption("blend", blend);
    }
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
    {
      return new ColorKeyFilter(color, parent ?? throw new ArgumentNullException(nameof(parent)));
    }
  }
}
