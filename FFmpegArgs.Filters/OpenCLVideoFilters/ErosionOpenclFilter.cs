/*
erosion_opencl AVOptions:
   threshold0        <float>      ..FV....... set threshold for 1st plane (from 0 to 65535) (default 65535)
   threshold1        <float>      ..FV....... set threshold for 2nd plane (from 0 to 65535) (default 65535)
   threshold2        <float>      ..FV....... set threshold for 3rd plane (from 0 to 65535) (default 65535)
   threshold3        <float>      ..FV....... set threshold for 4th plane (from 0 to 65535) (default 65535)
   coordinates       <int>        ..FV....... set coordinates (from 0 to 255) (default 255)
*/
namespace FFmpegArgs.Filters.OpenCLVideoFilters
{
    /// <summary>
    /// ... erosion_opencl    V->V       Apply erosion effect<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#erosion_005fopencl
    /// </summary>
    public class ErosionOpenclFilter : ImageToImageFilter
    {
        internal ErosionOpenclFilter(ImageMap imageMap) : base("erosion_opencl", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Limit the maximum change for each plane. If 0, plane will remain unchanged.<br>
        /// </br>(from 0 to 65535) (default 65535)
        /// </summary>
        /// <param name="threshold0"></param>
        /// <returns></returns>
        public ErosionOpenclFilter Threshold0(float threshold0)
            => this.SetOptionRange("threshold0", threshold0, 0, 65535);

        /// <summary>
        /// Limit the maximum change for each plane. If 0, plane will remain unchanged.<br>
        /// </br>(from 0 to 65535) (default 65535)
        /// </summary>
        /// <param name="threshold1"></param>
        /// <returns></returns>
        public ErosionOpenclFilter Threshold1(float threshold1)
            => this.SetOptionRange("threshold1", threshold1, 0, 65535);
        /// <summary>
        /// Limit the maximum change for each plane. If 0, plane will remain unchanged.<br>
        /// </br>(from 0 to 65535) (default 65535)
        /// </summary>
        /// <param name="threshold2"></param>
        /// <returns></returns>
        public ErosionOpenclFilter Threshold2(float threshold2)
            => this.SetOptionRange("threshold2", threshold2, 0, 65535);
        /// <summary>
        /// Limit the maximum change for each plane. If 0, plane will remain unchanged.<br>
        /// </br>(from 0 to 65535) (default 65535)
        /// </summary>
        /// <param name="threshold3"></param>
        /// <returns></returns>
        public ErosionOpenclFilter Threshold3(float threshold3)
            => this.SetOptionRange("threshold3", threshold3, 0, 65535);

        /// <summary>
        /// Flag which specifies the pixel to refer to. Range is [0, 255] and default value is 255, i.e. all eight pixels are used.<br>
        /// </br>Flags to local 3x3 coordinates region centered on x:<br>
        /// </br>1 2 3<br>
        /// </br>4 x 5<br>
        /// </br>6 7 8
        /// </summary>
        /// <param name="coordinates"></param>
        /// <returns></returns>
        public ErosionOpenclFilter Coordinates(int coordinates)
            => this.SetOptionRange("coordinates", coordinates, 0, 255);

    }
    /// <summary>
    /// 
    /// </summary>
    public static class ErosionOpenclFilterExtensions
    {
        /// <summary>
        /// Apply erosion effect to the video.<br>
        /// </br>This filter replaces the pixel by the local(3x3) minimum.
        /// </summary>
        public static ErosionOpenclFilter ErosionOpenclFilter(this ImageMap imageMap)
          => new ErosionOpenclFilter(imageMap);
    }
}
