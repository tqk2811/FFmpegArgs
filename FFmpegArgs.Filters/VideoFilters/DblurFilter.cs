namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// T.C dblur             V->V       Apply Directional Blur filter.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#dblur
    /// </summary>
    public class DblurFilter : ImageToImageFilter, ITimelineSupport, ICommandSupport
    {
        internal DblurFilter(ImageMap imageMap) : base("dblur", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set angle of directional blur (from 0 to 360) (default 45)
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public DblurFilter Angle(float angle)
            => this.SetOptionRange("angle", angle, 0, 360);
        /// <summary>
        /// Set radius of directional blur (from 1 to 8192) (default 5)
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public DblurFilter Radius(float radius)
           => this.SetOptionRange("radius", radius, 1, 8192);
        /// <summary>
        /// Set which planes to filter. By default all planes are filtered. (from 0 to 15) (default 15)
        /// </summary>
        /// <param name="planes"></param>
        /// <returns></returns>
        public DblurFilter Planes(int planes)
           => this.SetOptionRange("planes", planes, 0, 15);
    }
    public static class DblurFilterExtensions
    {
        /// <summary>
        /// Apply Directional blur filter.
        /// </summary>
        public static DblurFilter DblurFilter(this ImageMap imageMap)
          => new DblurFilter(imageMap);
    }
}
