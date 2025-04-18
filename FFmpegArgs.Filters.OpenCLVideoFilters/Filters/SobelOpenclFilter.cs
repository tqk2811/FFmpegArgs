/*
sobel_opencl AVOptions:
   planes            <int>        ..FV....... set planes to filter (from 0 to 15) (default 15)
   scale             <float>      ..FV....... set scale (from 0 to 65535) (default 1)
   delta             <float>      ..FV....... set delta (from -65535 to 65535) (default 0)
*/
namespace FFmpegArgs.Filters.OpenCLVideoFilters
{
    /// <summary>
    /// ... sobel_opencl      V->V       Apply sobel operator<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#sobel_005fopencl
    /// </summary>
    public class SobelOpenclFilter : ImageToImageFilter
    {
        internal SobelOpenclFilter(ImageMap imageMap) : base("sobel_opencl", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set which planes to filter. (from 0 to 15) (default 15)
        /// </summary>
        /// <param name="planes"></param>
        /// <returns></returns>
        public SobelOpenclFilter Planes(int planes)
            => this.SetOptionRange("planes", planes, 0, 15);
        /// <summary>
        /// Set value which will be multiplied with filtered result. (from 0 to 65535) (default 1)
        /// </summary>
        /// <param name="scale"></param>
        /// <returns></returns>
        public SobelOpenclFilter Scale(float scale)
            => this.SetOptionRange("scale", scale, 0, 65535);
        /// <summary>
        /// Set value which will be added to filtered result. (from -65535 to 65535) (default 0)
        /// </summary>
        /// <param name="delta"></param>
        /// <returns></returns>
        public SobelOpenclFilter Delta(float delta)
            => this.SetOptionRange("delta", delta, -65535, 65535);

    }
    /// <summary>
    /// 
    /// </summary>
    public static class SobelOpenclFilterExtensions
    {
        /// <summary>
        /// Apply the Sobel operator <see href="https://en.wikipedia.org/wiki/Sobel_operator">Sobel Operator</see> to input video stream.
        /// </summary>
        public static SobelOpenclFilter SobelOpenclFilter(this ImageMap imageMap)
          => new SobelOpenclFilter(imageMap);
    }
}
