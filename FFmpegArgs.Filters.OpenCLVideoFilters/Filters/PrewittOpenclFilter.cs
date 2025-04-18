/*
prewitt_opencl AVOptions:
   planes            <int>        ..FV....... set planes to filter (from 0 to 15) (default 15)
   scale             <float>      ..FV....... set scale (from 0 to 65535) (default 1)
   delta             <float>      ..FV....... set delta (from -65535 to 65535) (default 0)
*/
namespace FFmpegArgs.Filters.OpenCLVideoFilters
{
    /// <summary>
    /// ... prewitt_opencl    V->V       Apply prewitt operator<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#prewitt_005fopencl
    /// </summary>
    public class PrewittOpenclFilter : ImageToImageFilter
    {
        internal PrewittOpenclFilter(ImageMap imageMap) : base("prewitt_opencl", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set which planes to filter. (from 0 to 15) (default 15)
        /// </summary>
        /// <param name="planes"></param>
        /// <returns></returns>
        public PrewittOpenclFilter Planes(int planes)
            => this.SetOptionRange("planes", planes, 0, 15);
        /// <summary>
        /// Set value which will be multiplied with filtered result. (from 0 to 65535) (default 1)
        /// </summary>
        /// <param name="scale"></param>
        /// <returns></returns>
        public PrewittOpenclFilter Scale(float scale)
            => this.SetOptionRange("scale", scale, 0, 65535);
        /// <summary>
        /// Set value which will be added to filtered result. (from -65535 to 65535) (default 0)
        /// </summary>
        /// <param name="delta"></param>
        /// <returns></returns>
        public PrewittOpenclFilter Delta(float delta)
            => this.SetOptionRange("delta", delta, -65535, 65535);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class PrewittOpenclFilterExtensions
    {
        /// <summary>
        /// Apply the Prewitt operator <see href="https://en.wikipedia.org/wiki/Prewitt_operator">Prewitt Operator</see> to input video stream.
        /// </summary>
        public static PrewittOpenclFilter PrewittOpenclFilter(this ImageMap imageMap)
          => new PrewittOpenclFilter(imageMap);
    }
}
