/*
avgblur_opencl AVOptions:
   sizeX             <int>        ..FV....... set horizontal size (from 1 to 1024) (default 1)
   planes            <int>        ..FV....... set planes to filter (from 0 to 15) (default 15)
   sizeY             <int>        ..FV....... set vertical size (from 0 to 1024) (default 0)
*/
namespace FFmpegArgs.Filters.OpenCLVideoFilters
{
    /// <summary>
    /// ... avgblur_opencl    V->V       Apply average blur filter<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#avgblur_005fopencl
    /// </summary>
    public class AvgblurOpenclFilter : ImageToImageFilter
    {
        internal AvgblurOpenclFilter(ImageMap imageMap) : base("avgblur_opencl", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set horizontal radius size. Range is [1, 1024] and default value is 1.
        /// </summary>
        /// <param name="sizeX"></param>
        /// <returns></returns>
        public AvgblurOpenclFilter SizeX(int sizeX)
            => this.SetOptionRange("sizeX", sizeX, 1, 1024);

        /// <summary>
        /// Set which planes to filter. Default value is 15, by which all planes are processed.
        /// </summary>
        /// <param name="planes"></param>
        /// <returns></returns>
        public AvgblurOpenclFilter Planes(int planes)
            => this.SetOptionRange("planes", planes, 0, 15);

        /// <summary>
        /// Set vertical radius size. Range is [1, 1024] and default value is 0. If zero, sizeX value will be used.
        /// </summary>
        /// <param name="sizeY"></param>
        /// <returns></returns>
        public AvgblurOpenclFilter SizeY(int sizeY)
            => this.SetOptionRange("sizeY", sizeY, 0, 1024);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AvgblurOpenclFilterExtensions
    {
        /// <summary>
        /// Apply average blur filter.
        /// </summary>
        public static AvgblurOpenclFilter AvgblurOpenclFilter(this ImageMap imageMap)
          => new AvgblurOpenclFilter(imageMap);
    }
}
