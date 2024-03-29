﻿namespace FFmpegArgs.Filters.VideoSources
{
    /// <summary>
    /// ... pal75bars         |->V       Generate PAL 75% color bars.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#allrgb_002c-allyuv_002c-color_002c-haldclutsrc_002c-nullsrc_002c-pal75bars_002c-pal100bars_002c-rgbtestsrc_002c-smptebars_002c-smptehdbars_002c-testsrc_002c-testsrc2_002c-yuvtestsrc
    /// </summary>
    public class Pal75barsFilter : BaseVideoSource, IBaseVideoSourceSize
    {
        internal Pal75barsFilter(IImageFilterGraph filterGraph) : base("pal75bars", filterGraph)
        {
            AddMapOut();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Pal75barsFilterExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        public static Pal75barsFilter Pal75barsFilter(this IImageFilterGraph filterGraph)
          => new Pal75barsFilter(filterGraph);
    }
}
