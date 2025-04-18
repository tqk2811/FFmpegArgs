namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TS. colormatrix       V->V       Convert color matrix.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#colormatrix
    /// </summary>
    public class ColormatrixFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal ColormatrixFilter(ColormatrixType src, ColormatrixType dst, ImageMap imageMap) : base("colormatrix", imageMap)
        {
            AddMapOut();
            this.SetOption("src", src);
            this.SetOption("dst", dst);
        }
    }
    public static class ColormatrixFilterExtensions
    {
        /// <summary>
        /// Convert color matrix.
        /// </summary>
        public static ColormatrixFilter ColormatrixFilter(this ImageMap imageMap, ColormatrixType src, ColormatrixType dst)
          => new ColormatrixFilter(src, dst, imageMap);
    }
    public enum ColormatrixType
    {
        bt709,
        fcc,
        bt601,
        bt470,
        bt470bg,
        smpte170m,
        smpte240m,
        bt2020
    }
}
