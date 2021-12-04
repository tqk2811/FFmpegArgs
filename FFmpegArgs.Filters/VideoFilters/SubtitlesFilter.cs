using FFmpegArgs.Cores.Maps;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... subtitles         V->V       Render text subtitles onto input video using the libass library.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#subtitles
    /// </summary>
    public class SubtitlesFilter : BaseSubtitlesFilter
    {
        internal SubtitlesFilter(ImageMap imageMap) : base("subtitles", imageMap)
        {

        }

        /// <summary>
        /// Set subtitles input character encoding. subtitles filter only. Only useful if not UTF-8.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="charenc"></param>
        /// <returns></returns>
        public SubtitlesFilter Charenc(string charenc)
          => this.SetOption("charenc", charenc);

        /// <summary>
        /// Set subtitles stream index. subtitles filter only.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        /// <param name="si"></param>
        /// <returns></returns>
        public SubtitlesFilter StreamIndex(int si)
          => this.SetOptionRange("si", si, -1, int.MaxValue);
    }

    public static class SubtitlesFilterExtensions
    {
        /// <summary>
        /// Draw subtitles on top of input video using the libass library.<br>
        /// </br>To enable compilation of this filter you need to configure FFmpeg with --enable-libass.This filter also requires a build with libavcodec and libavformat to convert the passed subtitles file to ASS(Advanced Substation Alpha) subtitles format.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <returns></returns>
        public static SubtitlesFilter SubtitlesFilter(this ImageMap imageMap)
          => new SubtitlesFilter(imageMap);

        /// <summary>
        /// Draw subtitles on top of input video using the libass library.<br>
        /// </br>To enable compilation of this filter you need to configure FFmpeg with --enable-libass.This filter also requires a build with libavcodec and libavformat to convert the passed subtitles file to ASS(Advanced Substation Alpha) subtitles format.
        /// </summary>
        public static SubtitlesFilter SubtitlesFilter(this ImageMap imageMap, SubtitlesFilterConfig config)
        {
            var result = new SubtitlesFilter(imageMap);
            if (!string.IsNullOrWhiteSpace(config?.Filename)) result.FileName(config.Filename);
            if (config?.OriginalSize != null) result.OriginalSize(config.OriginalSize.Value);
            if (!string.IsNullOrWhiteSpace(config?.Fontsdir)) result.FontsDir(config.Fontsdir);
            if (config?.Alpha != null) result.Alpha(config.Alpha.Value);
            if (!string.IsNullOrWhiteSpace(config?.Charenc)) result.Charenc(config.Charenc);
            if (config?.StreamIndex != null) result.StreamIndex(config.StreamIndex.Value);
            if (!string.IsNullOrWhiteSpace(config?.ForceStyle)) result.ForceStyle(config.ForceStyle);
            return result;
        }
    }


    public class SubtitlesFilterConfig
    {
        /// <summary>
        ///  set the filename of file to read
        /// </summary>
        public string Filename { get; set; }
        /// <summary>
        ///  set the size of the original video (used to scale fonts)
        /// </summary>
        public Size? OriginalSize { get; set; }
        /// <summary>
        ///  set the directory containing the fonts to read
        /// </summary>
        public string Fontsdir { get; set; }
        /// <summary>
        ///  enable processing of alpha channel (default false)
        /// </summary>
        public bool? Alpha { get; set; }
        /// <summary>
        ///  set input character encoding
        /// </summary>
        public string Charenc { get; set; }
        /// <summary>
        ///  set stream index (from -1 to INT_MAX) (default -1)
        /// </summary>
        public int? StreamIndex { get; set; }
        /// <summary>
        ///  force subtitle style
        /// </summary>
        public string ForceStyle { get; set; }
    }
}
