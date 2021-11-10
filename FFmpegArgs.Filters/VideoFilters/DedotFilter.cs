using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters.Enums;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TS. dedot             V->V       Reduce cross-luminance and cross-color.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#dedot
    /// </summary>
    public class DedotFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal DedotFilter(ImageMap imageMap) : base("dedot", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set mode of operation. Can be combination of dotcrawl for cross-luminance reduction and/or rainbows for cross-color reduction.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public DedotFilter M(string mode)
            => this.SetOption("m", mode);

        /// <summary>
        /// Set spatial luma threshold. Lower values increases reduction of cross-luminance.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public DedotFilter Lt(string mode)
           => this.SetOption("lt", mode);

        /// <summary>
        /// Set tolerance for temporal luma.Higher values increases reduction of cross-luminance.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public DedotFilter Tl(string mode)
           => this.SetOption("tl", mode);

        /// <summary>
        /// Set tolerance for chroma temporal variation. Higher values increases reduction of cross-color.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public DedotFilter Tc(string mode)
           => this.SetOption("tc", mode);

        /// <summary>
        /// Set temporal chroma threshold. Lower values increases reduction of cross-color.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public DedotFilter Ct(string mode)
           => this.SetOption("ct", mode);

    }

    public static class DedotFilterExtensions
    {
        /// <summary>
        /// Reduce cross-luminance (dot-crawl) and cross-color (rainbows) from video.
        /// </summary>
        public static DedotFilter DedotFilter(this ImageMap imageMap)
          => new DedotFilter(imageMap);
    }
}
