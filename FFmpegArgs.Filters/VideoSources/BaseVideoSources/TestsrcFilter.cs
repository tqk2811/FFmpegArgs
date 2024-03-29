﻿namespace FFmpegArgs.Filters.VideoSources
{
    /// <summary>
    /// ... testsrc           |->V       Generate test pattern.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#allrgb_002c-allyuv_002c-color_002c-haldclutsrc_002c-nullsrc_002c-pal75bars_002c-pal100bars_002c-rgbtestsrc_002c-smptebars_002c-smptehdbars_002c-testsrc_002c-testsrc2_002c-yuvtestsrc
    /// </summary>
    public class TestsrcFilter : BaseVideoSource, IBaseVideoSourceSize
    {
        internal TestsrcFilter(IImageFilterGraph filterGraph) : base("testsrc", filterGraph)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the number of decimals to show in the timestamp, only available in the testsrc source.<br></br>
        /// The displayed timestamp value will correspond to the original timestamp value multiplied by the power of 10 of the specified value.(from 0 to 17) (default 0)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public TestsrcFilter Decimals(int n)
          => this.SetOptionRange("n", n, 0, 17);
    }

    /// <summary>
    /// 
    /// </summary>
    public static class TestsrcFilterExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        public static TestsrcFilter TestsrcFilter(this IImageFilterGraph filterGraph)
          => new TestsrcFilter(filterGraph);
    }
}
