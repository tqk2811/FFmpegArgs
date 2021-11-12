using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... subtitles         V->V       Render text subtitles onto input video using the libass library.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#subtitles
    /// </summary>
    public class SubtitlesFilter : BaseSubtitlesFilter
    {
        internal SubtitlesFilter(string fileName, ImageMap imageMap) : base(fileName, "subtitles", imageMap)
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
          => this.SetOptionRange("si", si, 0, int.MaxValue);
    }

    public static class SubtitlesFilterExtensions
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="imageMap"></param>
        /// <param name="fileName">File name or full path</param>
        /// <returns></returns>
        public static SubtitlesFilter SubtitlesFilter(this ImageMap imageMap, string fileName)
          => new SubtitlesFilter(fileName, imageMap);
    }
}
