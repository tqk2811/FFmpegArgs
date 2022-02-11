namespace FFmpegArgs.Filters.VideoSources
{
    /// <summary>
    /// ... testsrc2          |->V       Generate another test pattern.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#allrgb_002c-allyuv_002c-color_002c-haldclutsrc_002c-nullsrc_002c-pal75bars_002c-pal100bars_002c-rgbtestsrc_002c-smptebars_002c-smptehdbars_002c-testsrc_002c-testsrc2_002c-yuvtestsrc
    /// </summary>
    public class Testsrc2Filter : BaseVideoSource, IBaseVideoSourceSize
    {
        internal Testsrc2Filter(IFilterGraph filterGraph) : base("testsrc2", filterGraph)
        {
            AddMapOut();
        }
        /// <summary>
        /// Specify the alpha (opacity) of the background, only available in the testsrc2 source.<br>
        /// </br> The value must be between 0 (fully transparent) and 255 (fully opaque, the default).
        /// </summary>
        /// <param name="alpha"></param>
        /// <returns></returns>
        public Testsrc2Filter Alpha(int alpha)
          => this.SetOptionRange("alpha", alpha, 0, 255);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Testsrc2FilterExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        public static Testsrc2Filter Testsrc2Filter(this IFilterGraph filterGraph)
          => new Testsrc2Filter(filterGraph);
    }
}
