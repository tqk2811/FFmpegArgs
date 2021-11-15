using FFmpegArgs.Cores.Maps;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC avgblur           V->V       Apply Average Blur filter.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#avgblur
    /// </summary>
    public class AvgblurFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal AvgblurFilter(ImageMap imageMap) : base("avgblur", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set horizontal radius size.<br>
        /// </br>(from 1 to 1024) (default 1)
        /// </summary>
        /// <param name="sizeX"></param>
        /// <returns></returns>
        public AvgblurFilter SizeX(int sizeX)
          => this.SetOptionRange("sizeX", sizeX, 1, 1024);

        /// <summary>
        /// Set which planes to filter. By default all planes are filtered.<br>
        /// </br>(from 0 to 15) (default 15)
        /// </summary>
        /// <param name="planes"></param>
        /// <returns></returns>
        public AvgblurFilter Planes(int planes)
          => this.SetOptionRange("planes", planes, 0, 15);


        /// <summary>
        /// Set vertical radius size, if zero it will be same as sizeX.<br>
        /// </br> (from 0 to 1024) (default 0)
        /// </summary>
        /// <param name="sizeY"></param>
        /// <returns></returns>
        public AvgblurFilter SizeY(int sizeY)
         => this.SetOptionRange("sizeY", sizeY, 0, 1024);
    }

    public static class AvgblurFilterExtensions
    {
        /// <summary>
        /// Apply average blur filter.
        /// </summary>
        /// <param name="imageMap"></param>
        /// <returns></returns>
        public static AvgblurFilter AvgblurFilter(this ImageMap imageMap)
          => new AvgblurFilter(imageMap);
    }
}
