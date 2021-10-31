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
    internal ColorKeyFilter(Color color, IImageMap imageMap) : base("colorkey", imageMap)
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

    public ColorKeyFilter Blend(float blend)
    {
      if (blend < 0 || blend > 1) throw new InvalidRangeException($"Only accept: 0 <= {nameof(blend)} <= 1");
      return this.SetOption("blend", blend);
    }
  }

  public static class ColorKeyFilterExtension
  {
    public static ColorKeyFilter ColorKeyFilter(this IImageMap parent, Color color)
    {
      return new ColorKeyFilter(color, parent ?? throw new ArgumentNullException(nameof(parent)));
    }
  }
}
