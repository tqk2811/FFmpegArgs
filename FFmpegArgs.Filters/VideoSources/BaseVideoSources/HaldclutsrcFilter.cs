namespace FFmpegArgs.Filters.VideoSources
{
    /// <summary>
    /// ... haldclutsrc       |->V       Provide an identity Hald CLUT<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#allrgb_002c-allyuv_002c-color_002c-haldclutsrc_002c-nullsrc_002c-pal75bars_002c-pal100bars_002c-rgbtestsrc_002c-smptebars_002c-smptehdbars_002c-testsrc_002c-testsrc2_002c-yuvtestsrc
    /// </summary>
    public class HaldclutsrcFilter : BaseVideoSource
    {
        internal HaldclutsrcFilter(FilterGraph filterGraph) : base("haldclutsrc", filterGraph)
        {
            AddMapOut();
        }

        /// <summary>
        /// Specify the level of the Hald CLUT, only available in the haldclutsrc source.<br>
        /// </br> A level of N generates a picture of N*N*N by N*N*N pixels to be used as identity matrix for 3D lookup tables.<br>
        /// </br> Each component is coded on a 1/(N*N) scale. (from 2 to 16) (default 6)
        /// </summary>
        /// <param name="level"></param>
        /// <returns></returns>
        public HaldclutsrcFilter Level(int level)
          => this.SetOptionRange("level", level, 2, 16);
    }

    public static class HaldclutsrcFilterExtensions
    {
        public static HaldclutsrcFilter HaldclutsrcFilter(this FilterGraph filterGraph)
          => new HaldclutsrcFilter(filterGraph);
    }
}
