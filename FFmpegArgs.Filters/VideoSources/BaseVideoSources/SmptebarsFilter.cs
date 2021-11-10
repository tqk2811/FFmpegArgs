namespace FFmpegArgs.Filters.VideoSources
{
  /// <summary>
  /// ... smptebars         |->V       Generate SMPTE color bars.<br>
  /// </br>https://ffmpeg.org/ffmpeg-filters.html#allrgb_002c-allyuv_002c-color_002c-haldclutsrc_002c-nullsrc_002c-pal75bars_002c-pal100bars_002c-rgbtestsrc_002c-smptebars_002c-smptehdbars_002c-testsrc_002c-testsrc2_002c-yuvtestsrc
  /// </summary>
  public class SmptebarsFilter : BaseVideoSource, IBaseVideoSourceSize
  {
    internal SmptebarsFilter(FilterGraph filterGraph) : base("smptebars", filterGraph)
    {
      AddMapOut();
    }
  }

  public static class SmptebarsFilterExtensions
  {
    public static SmptebarsFilter SmptebarsFilter(this FilterGraph filterGraph)
      => new SmptebarsFilter(filterGraph);
  }
}
