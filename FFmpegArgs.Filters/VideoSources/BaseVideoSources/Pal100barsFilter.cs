﻿namespace FFmpegArgs.Filters.VideoSources
{
    /// <summary>
    /// ... pal100bars        |->V       Generate PAL 100% color bars.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#allrgb_002c-allyuv_002c-color_002c-haldclutsrc_002c-nullsrc_002c-pal75bars_002c-pal100bars_002c-rgbtestsrc_002c-smptebars_002c-smptehdbars_002c-testsrc_002c-testsrc2_002c-yuvtestsrc
    /// </summary>
    public class Pal100barsFilter : BaseVideoSource, IBaseVideoSourceSize
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGraph"></param>
        internal Pal100barsFilter(IImageFilterGraph filterGraph) : base("pal100bars", filterGraph)
        {
            AddMapOut();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class Pal100barsFilterExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        public static Pal100barsFilter Pal100barsFilter(this IImageFilterGraph filterGraph)
          => new Pal100barsFilter(filterGraph);
    }
}
