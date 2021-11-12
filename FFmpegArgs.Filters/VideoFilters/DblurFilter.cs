using FFmpegArgs.Cores.Maps;

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
        /// Set angle of directional blur. Default is 45.
        /// </summary>
        /// <param name="angle"></param>
        /// <returns></returns>
        public DblurFilter Angle(int angle)
            => this.SetOptionRange("angle", angle, int.MinValue, int.MaxValue);

        /// <summary>
        /// Set radius of directional blur. Default is 5.
        /// </summary>
        /// <param name="radius"></param>
        /// <returns></returns>
        public DblurFilter Radius(int radius)
           => this.SetOptionRange("radius", radius, int.MinValue, int.MaxValue);

        /// <summary>
        /// Set which planes to filter. By default all planes are filtered.
        /// </summary>
        /// <param name="planes"></param>
        /// <returns></returns>
        public DblurFilter Planes(int planes)
           => this.SetOptionRange("planes", planes, int.MinValue, int.MaxValue);

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
