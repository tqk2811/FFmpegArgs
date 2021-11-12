namespace FFmpegArgs.Filters.VideoSources
{
    /// <summary>
    /// ... yuvtestsrc        |->V       Generate YUV test pattern.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#allrgb_002c-allyuv_002c-color_002c-haldclutsrc_002c-nullsrc_002c-pal75bars_002c-pal100bars_002c-rgbtestsrc_002c-smptebars_002c-smptehdbars_002c-testsrc_002c-testsrc2_002c-yuvtestsrc
    /// </summary>
    public class YuvtestsrcFilter : BaseVideoSource, IBaseVideoSourceSize
    {
        internal YuvtestsrcFilter(FilterGraph filterGraph) : base("yuvtestsrc", filterGraph)
        {
            AddMapOut();
        }
    }

    public static class YuvtestsrcFilterExtensions
    {
        public static YuvtestsrcFilter YuvtestsrcFilter(this FilterGraph filterGraph)
          => new YuvtestsrcFilter(filterGraph);
    }
}
