namespace FFmpegArgs.Filters.VideoSources
{
  /// <summary>
  /// ... allrgb            |->V       Generate all RGB colors.<br>
  /// </br>https://ffmpeg.org/ffmpeg-filters.html#allrgb_002c-allyuv_002c-color_002c-haldclutsrc_002c-nullsrc_002c-pal75bars_002c-pal100bars_002c-rgbtestsrc_002c-smptebars_002c-smptehdbars_002c-testsrc_002c-testsrc2_002c-yuvtestsrc
  /// </summary>
  public class AllrgbFilter : BaseVideoSource
  {
    internal AllrgbFilter(FilterGraph filterGraph) : base("allrgb", filterGraph)
    {
      AddMapOut();
    }
  }
  public static class AllrgbFilterExtensions
  {
    public static AllrgbFilter AllrgbFilter(this FilterGraph filterGraph)
      => new AllrgbFilter(filterGraph);
  }
}
