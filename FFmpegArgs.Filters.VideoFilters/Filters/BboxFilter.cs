namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// T.C bbox              V->V       Compute bounding box for each frame.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#bbox
    /// </summary>
    public class BboxFilter : ImageToImageFilter
    {
        internal BboxFilter(ImageMap imageMap) : base("bbox", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the minimal luminance value. (from 0 to 65535) Default is 16.
        /// </summary>
        /// <param name="min_val"></param>
        /// <returns></returns>
        public BboxFilter MinVal(int min_val)
          => this.SetOptionRange("min_val", min_val, 0, 65535);
    }
    public static class BboxFilterExtensions
    {
        /// <summary>
        /// Compute the bounding box for the non-black pixels in the input frame luminance plane.<br></br>
        /// This filter computes the bounding box containing all the pixels with a luminance value greater than the minimum allowed value.The parameters describing the bounding box are printed on the filter log.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <returns></returns>
        public static BboxFilter BboxFilter(this ImageMap imageMap)
          => new BboxFilter(imageMap);
    }
}
