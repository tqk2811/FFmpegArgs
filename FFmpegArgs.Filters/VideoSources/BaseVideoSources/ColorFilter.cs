using System.Drawing;

namespace FFmpegArgs.Filters.VideoSources
{
    /// <summary>
    /// ..C color             |->V       Provide an uniformly colored input.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#allrgb_002c-allyuv_002c-color_002c-haldclutsrc_002c-nullsrc_002c-pal75bars_002c-pal100bars_002c-rgbtestsrc_002c-smptebars_002c-smptehdbars_002c-testsrc_002c-testsrc2_002c-yuvtestsrc
    /// </summary>
    public class ColorFilter : BaseVideoSource, ICommandSupport, IBaseVideoSourceSize
    {
        internal ColorFilter(FilterGraph filterGraph) : base("color", filterGraph)
        {
            AddMapOut();
        }

        public ColorFilter Color(Color color)
          => this.SetOption("c", color.ToHexStringRGBA());
    }

    public static class ColorFilterExtension
    {
        public static ColorFilter Color(this FilterGraph filterGraph)
          => new ColorFilter(filterGraph);
    }
}
