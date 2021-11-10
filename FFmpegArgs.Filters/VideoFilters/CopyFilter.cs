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
    /// ... copy              V->V       Copy the input video unchanged to the output.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#copy
    /// </summary>
    public class CopyFilter : ImageToImageFilter
    {
        internal CopyFilter(ImageMap imageMap) : base("copy", imageMap)
        {
            AddMapOut();
            IsAllowEmptyOption = true;
        }
    }

    public static class CopyFilterExtensions
    {
        /// <summary>
        /// Copy the input video source unchanged to the output. This is mainly useful for testing purposes.
        /// </summary>
        public static CopyFilter CopyFilter(this ImageMap imageMap)
          => new CopyFilter(imageMap);
    }
}
