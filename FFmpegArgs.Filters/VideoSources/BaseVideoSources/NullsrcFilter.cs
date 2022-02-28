namespace FFmpegArgs.Filters.VideoSources
{
    /// <summary>
    /// ... nullsrc           |->V       Null video source, return unprocessed video frames.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#allrgb_002c-allyuv_002c-color_002c-haldclutsrc_002c-nullsrc_002c-pal75bars_002c-pal100bars_002c-rgbtestsrc_002c-smptebars_002c-smptehdbars_002c-testsrc_002c-testsrc2_002c-yuvtestsrc
    /// </summary>
    public class NullsrcFilter : BaseVideoSource, IBaseVideoSourceSize
    {
        internal NullsrcFilter(BaseFilterGraph filterGraph) : base("nullsrc", filterGraph)
        {
            AddMapOut();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class NullsrcFilterExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        public static NullsrcFilter NullsrcFilter(this BaseFilterGraph filterGraph)
          => new NullsrcFilter(filterGraph);
    }
}
