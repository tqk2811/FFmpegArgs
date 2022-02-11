namespace FFmpegArgs.Filters.VideoSources
{
    /// <summary>
    /// ... smptehdbars       |->V       Generate SMPTE HD color bars.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#allrgb_002c-allyuv_002c-color_002c-haldclutsrc_002c-nullsrc_002c-pal75bars_002c-pal100bars_002c-rgbtestsrc_002c-smptebars_002c-smptehdbars_002c-testsrc_002c-testsrc2_002c-yuvtestsrc
    /// </summary>
    public class SmptehdbarsFilter : BaseVideoSource, IBaseVideoSourceSize
    {
        internal SmptehdbarsFilter(IFilterGraph filterGraph) : base("smptehdbars", filterGraph)
        {
            AddMapOut();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class SmptehdbarsFilterExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        public static SmptehdbarsFilter SmptehdbarsFilter(this IFilterGraph filterGraph)
          => new SmptehdbarsFilter(filterGraph);
    }
}
