using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters.Enums;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoFilters
{
    public class BaseSubtitlesFilter : ImageToImageFilter
    {
        /// <summary>
        /// for <see cref="SubtitlesFilter"/> and <see cref="AssFilter"/>
        /// </summary>
        /// <param name="filterName"></param>
        /// <param name="imageMap"></param>
        internal BaseSubtitlesFilter(string fileName, string filterName, ImageMap imageMap) : base(filterName, imageMap)
        {
            AddMapOut();
            this.SetOption("f", fileName);
        }
    }

    public static class BaseSubtitlesFilterExtension
    {
        /// <summary>
        /// Specify the size of the original video, the video for which the ASS file was composed.<br>
        /// </br>Due to a misdesign in ASS aspect ratio arithmetic, this is necessary to correctly scale the fonts if the aspect ratio has been changed.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="videoSize"></param>
        /// <returns></returns>
        public static T OriginalSize<T>(this T t, VideoSizeUtils videoSize) where T : BaseSubtitlesFilter
          => t.SetOption("original_size", videoSize.GetAttribute<NameAttribute>().Name);

        /// <summary>
        /// Specify the size of the original video, the video for which the ASS file was composed.<br>
        /// </br>Due to a misdesign in ASS aspect ratio arithmetic, this is necessary to correctly scale the fonts if the aspect ratio has been changed.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="videoSize"></param>
        /// <returns></returns>
        public static T OriginalSize<T>(this T t, Size size) where T : BaseSubtitlesFilter
         => t.SetOption("original_size", $"{size.Width}x{size.Height}");

        /// <summary>
        /// Set a directory path containing fonts that can be used by the filter.<br>
        /// </br> These fonts will be used in addition to whatever the font provider uses.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="fontsdir"></param>
        /// <returns></returns>
        public static T FontsDir<T>(this T t, string fontsdir) where T : BaseSubtitlesFilter
         => t.SetOption("fontsdir", fontsdir);

        /// <summary>
        /// Process alpha channel, by default alpha channel is untouched.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="alpha"></param>
        /// <returns></returns>
        public static T Alpha<T>(this T t, bool alpha) where T : BaseSubtitlesFilter
          => t.SetOption("alpha", alpha.ToFFmpegFlag());

        /// <summary>
        /// Override default style or script info parameters of the subtitles.<br>
        /// </br> It accepts a string containing ASS style format KEY=VALUE couples separated by ",".
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="force_style"></param>
        /// <returns></returns>
        public static T ForceStyle<T>(this T t, string force_style) where T : BaseSubtitlesFilter
          => t.SetOption("force_style", force_style);
    }
}
