using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Exceptions;
using FFmpegArgs.Filters.Enums;
using System.Collections.Generic;
using System.Linq;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... format            V->V       Convert the input video to one of the specified pixel formats.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#format-1 
    /// </summary>
    public class FormatFilter : ImageToImageFilter
    {
        internal FormatFilter(IEnumerable<string> pixFmts, ImageMap imageMap) : base("format", imageMap)
        {
            if (pixFmts.Count() == 0) throw new InvalidRangeException(nameof(pixFmts));
            AddMapOut();
            this.SetOption("pix_fmts", string.Join("|", pixFmts));
        }
    }

    public static class FormatFilterExtension
    {
        public static FormatFilter FormatFilter(this ImageMap imageMap, params PixFmt[] pixFmts)
        {
            return new FormatFilter(pixFmts.Select(x => x.ToString()), imageMap);
        }

        public static FormatFilter FormatFilter(this ImageMap imageMap, params string[] pixFmts)
        {
            return new FormatFilter(pixFmts, imageMap);
        }
    }
}
