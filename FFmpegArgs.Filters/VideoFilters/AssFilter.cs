using FFmpegArgs.Cores.Maps;
using System.Drawing;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// ... ass               V->V       Render ASS subtitles onto input video using the libass library.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#ass
    /// </summary>
    public class AssFilter : BaseSubtitlesFilter
    {
        internal AssFilter(ImageMap imageMap) : base("ass", imageMap)
        {

        }

        /// <summary>
        /// Set the shaping engine
        /// </summary>
        /// <param name="shaping"></param>
        /// <returns></returns>
        public AssFilter Shaping(AssFilterShaping shaping)
          => this.SetOption("shaping", shaping);
    }

    public static class AssFilterExtensions
    {
        /// <summary>
        /// Same as the <see cref="BaseSubtitlesFilter"/> filter, except that it doesn’t require libavcodec and libavformat to work. On the other hand, it is limited to ASS (Advanced Substation Alpha) subtitles files.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <returns></returns>
        public static AssFilter AssFilter(this ImageMap imageMap)
          => new AssFilter(imageMap);

        /// <summary>
        /// Same as the <see cref="BaseSubtitlesFilter"/> filter, except that it doesn’t require libavcodec and libavformat to work. On the other hand, it is limited to ASS (Advanced Substation Alpha) subtitles files.
        /// </summary>
        public static AssFilter AssFilter(this ImageMap input0, AssFilterConfig config)
        {
            var result = new AssFilter(input0);
            if (!string.IsNullOrWhiteSpace(config?.Filename)) result.FileName(config.Filename);
            if (config?.OriginalSize != null) result.OriginalSize(config.OriginalSize.Value);
            if (!string.IsNullOrWhiteSpace(config?.FontsDir)) result.FontsDir(config.FontsDir);
            if (config?.Alpha != null) result.Alpha(config.Alpha.Value);
            if (config?.Shaping != null) result.Shaping(config.Shaping.Value);
            return result;
        }
    }

    public class AssFilterConfig
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
        public string FontsDir { get; set; }
        /// <summary>
        ///  enable processing of alpha channel (default false)
        /// </summary>
        public bool? Alpha { get; set; }
        /// <summary>
        ///  set shaping engine (from -1 to 1) (default auto)
        /// </summary>
        public AssFilterShaping? Shaping { get; set; }
    }

    public enum AssFilterShaping
    {
        /// <summary>
        /// The default libass shaping engine, which is the best available.
        /// </summary>
        auto,
        /// <summary>
        /// Fast, font-agnostic shaper that can do only substitutions
        /// </summary>
        simple,
        /// <summary>
        /// Slower shaper using OpenType for substitutions and positioning
        /// </summary>
        complex
    }
}
