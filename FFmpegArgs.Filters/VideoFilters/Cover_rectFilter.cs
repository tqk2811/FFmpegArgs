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
    /// ... cover_rect        V->V       Find and cover a user specified object.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#cover_005frect
    /// </summary>
    public class Cover_rectFilter : ImageToImageFilter
    {
        internal Cover_rectFilter(string filePathOrName, ImageMap imageMap) : base("cover_rect", imageMap)
        {
            AddMapOut();
            this.SetOption("cover", filePathOrName.FiltergraphEscapingLv1().FiltergraphEscapingLv2());
        }

        /// <summary>
        /// Set covering mode.<br></br>
        /// Default value is blur.
        /// </summary>
        /// <param name="mode"></param>
        /// <returns></returns>
        public Cover_rectFilter Mode(Cover_rectMode mode)
            => this.SetOption("mode", mode);
    }

    public static class Cover_rectFilterExtensions
    {
        /// <summary>
        /// Cover a rectangular object
        /// </summary>
        /// <param name="filePathOrName">Filepath of the optional cover image, needs to be in yuv420.</param>
        public static Cover_rectFilter Cover_rectFilter(this ImageMap imageMap,string filePathOrName)
          => new Cover_rectFilter(filePathOrName, imageMap);
    }

    public enum Cover_rectMode
    {
        cover,
        blur
    }
}
