namespace FFmpegArgs.Filters.VideoSources
{
    /// <summary>
    /// ... allyuv            |->V       Generate all yuv colors.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#allrgb_002c-allyuv_002c-color_002c-haldclutsrc_002c-nullsrc_002c-pal75bars_002c-pal100bars_002c-rgbtestsrc_002c-smptebars_002c-smptehdbars_002c-testsrc_002c-testsrc2_002c-yuvtestsrc
    /// </summary>
    public class AllyuvFilter : BaseVideoSource
    {
        internal AllyuvFilter(FilterGraph filterGraph) : base("allyuv", filterGraph)
        {
            AddMapOut();
        }
    }
    public static class AllyuvFilterExtensions
    {
        public static AllyuvFilter AllyuvFilter(this FilterGraph filterGraph)
          => new AllyuvFilter(filterGraph);
    }
}
