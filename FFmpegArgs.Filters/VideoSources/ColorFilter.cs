using FFmpegArgs.Cores.Maps;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoSources
{
  /// <summary>
  /// ..C color             |->V       Provide an uniformly colored input.<br></br>
  /// https://ffmpeg.org/ffmpeg-filters.html#allrgb_002c-allyuv_002c-color_002c-haldclutsrc_002c-nullsrc_002c-pal75bars_002c-pal100bars_002c-rgbtestsrc_002c-smptebars_002c-smptehdbars_002c-testsrc_002c-testsrc2_002c-yuvtestsrc
  /// </summary>
  public class ColorFilter : SourceImageFilter, ICommandSupport
  {
    internal ColorFilter(FilterGraph filterGraph, Color color, int width, int height) : base("color", filterGraph)
    {
      _mapsOut.Add(new ImageMap(this.FilterGraph, $"f_{FilterIndex}"));
      this.SetOption("c", color.ToHexStringRGBA());
      this.SetOption("s", $"{width}x{height}");
    }
  }

  public static class ColorFilterExtension
  {
    public static ColorFilter Color(this FilterGraph filterGraph, Color color, int width, int height)
    {
      return new ColorFilter(filterGraph, color, width, height);
    }
  }
}
