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
        public DedotFilter M(DedotFilteringMode mode)
            => this.SetOption("m", mode);
        /// <summary>
        /// Set spatial luma threshold. Lower values increases reduction of cross-luminance. (from 0 to 1) (default 0.079)
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public DedotFilter Lt(float val)
           => this.SetOptionRange("lt", val, 0, 1);
        /// <summary>
        /// Set tolerance for temporal luma.Higher values increases reduction of cross-luminance. (from 0 to 1) (default 0.079)
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public DedotFilter Tl(float val)
           => this.SetOptionRange("tl", val, 0, 1);
        /// <summary>
        /// Set tolerance for chroma temporal variation. Higher values increases reduction of cross-color. (from 0 to 1) (default 0.058)
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public DedotFilter Tc(float val)
           => this.SetOptionRange("tc", val, 0, 1);
        /// <summary>
        /// Set temporal chroma threshold. Lower values increases reduction of cross-color. (from 0 to 1) (default 0.019)
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public DedotFilter Ct(float val)
           => this.SetOptionRange("ct", val, 0, 1);
    }
    public static class DedotFilterExtensions
    {
        /// <summary>
        /// Reduce cross-luminance (dot-crawl) and cross-color (rainbows) from video.
        /// </summary>
        public static DedotFilter DedotFilter(this ImageMap imageMap)
          => new DedotFilter(imageMap);
    }
    public enum DedotFilteringMode
    {
        dotcrawl,
        rainbows
    }
}
