/*
roberts_opencl AVOptions:
   planes            <int>        ..FV....... set planes to filter (from 0 to 15) (default 15)
   scale             <float>      ..FV....... set scale (from 0 to 65535) (default 1)
   delta             <float>      ..FV....... set delta (from -65535 to 65535) (default 0)
*/
namespace FFmpegArgs.Filters.OpenCLVideoFilters
{
    /// <summary>
    /// ... roberts_opencl    V->V       Apply roberts operator<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#roberts_005fopencl
    /// </summary>
    public class RobertsOpenclFilter : ImageToImageFilter
    {
        internal RobertsOpenclFilter(ImageMap imageMap) : base("roberts_opencl", imageMap)
        {
            AddMapOut();
        }


        /// <summary>
        /// Set which planes to filter. (from 0 to 15) (default 15)
        /// </summary>
        /// <param name="planes"></param>
        /// <returns></returns>
        public RobertsOpenclFilter Planes(int planes)
            => this.SetOptionRange("planes", planes, 0, 15);
        /// <summary>
        /// Set value which will be multiplied with filtered result. (from 0 to 65535) (default 1)
        /// </summary>
        /// <param name="scale"></param>
        /// <returns></returns>
        public RobertsOpenclFilter Scale(float scale)
            => this.SetOptionRange("scale", scale, 0, 65535);
        /// <summary>
        /// Set value which will be added to filtered result. (from -65535 to 65535) (default 0)
        /// </summary>
        /// <param name="delta"></param>
        /// <returns></returns>
        public RobertsOpenclFilter Delta(float delta)
            => this.SetOptionRange("delta", delta, -65535, 65535);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class RobertsOpenclFilterExtensions
    {
        /// <summary>
        /// Apply the Roberts cross operator <see href="https://en.wikipedia.org/wiki/Roberts_cross">Roberts Cross</see> to input video stream.
        /// </summary>
        public static RobertsOpenclFilter RobertsOpenclFilter(this ImageMap imageMap)
          => new RobertsOpenclFilter(imageMap);
    }
}
