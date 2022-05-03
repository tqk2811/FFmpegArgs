namespace FFmpegArgs.Filters.VideoSources
{
    /// <summary>
    /// ... rgbtestsrc        |->V       Generate RGB test pattern.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#allrgb_002c-allyuv_002c-color_002c-haldclutsrc_002c-nullsrc_002c-pal75bars_002c-pal100bars_002c-rgbtestsrc_002c-smptebars_002c-smptehdbars_002c-testsrc_002c-testsrc2_002c-yuvtestsrc
    /// </summary>
    public class RgbtestsrcFilter : BaseVideoSource, IBaseVideoSourceSize
    {
        internal RgbtestsrcFilter(IImageFilterGraph filterGraph) : base("rgbtestsrc", filterGraph)
        {
            AddMapOut();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class RgbtestsrcFilterExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        public static RgbtestsrcFilter RgbtestsrcFilter(this IImageFilterGraph filterGraph)
          => new RgbtestsrcFilter(filterGraph);
    }
}
