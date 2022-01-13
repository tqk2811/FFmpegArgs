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
