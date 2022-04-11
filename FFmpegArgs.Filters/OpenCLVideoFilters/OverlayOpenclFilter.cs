/*
overlay_opencl AVOptions:
   x                 <int>        ..FV....... Overlay x position (from 0 to INT_MAX) (default 0)
   y                 <int>        ..FV....... Overlay y position (from 0 to INT_MAX) (default 0)
*/
namespace FFmpegArgs.Filters.OpenCLVideoFilters
{
    /// <summary>
    /// ... overlay_opencl    VV->V      Overlay one video on top of another<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#overlay_005fopencl
    /// </summary>
    public class OverlayOpenclFilter : ImageToImageFilter
    {
        internal OverlayOpenclFilter(params ImageMap[] imageMaps) : base("overlay_opencl", imageMaps)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the x coordinate of the overlaid video on the main video.<br>
        /// </br>(from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public OverlayOpenclFilter X(int x)
            => this.SetOptionRange("x", x, 0, INT_MAX);
        /// <summary>
        /// Set the y coordinate of the overlaid video on the main video.<br>
        /// </br>(from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="y"></param>
        /// <returns></returns>
        public OverlayOpenclFilter Y(int y)
            => this.SetOptionRange("y", y, 0, INT_MAX);

    }
    /// <summary>
    /// 
    /// </summary>
    public static class OverlayOpenclFilterExtensions
    {
        /// <summary>
        /// Overlay one video on top of another.<br>
        /// </br>It takes two inputs and has one output.The first input is the "main" video on which the second input is overlaid.This filter requires same memory layout for all the inputs.So, format conversion may be needed.
        /// </summary>
        public static OverlayOpenclFilter OverlayOpenclFilter(this ImageMap first, ImageMap second)
          => new OverlayOpenclFilter(first, second);
        /// <summary>
        /// Overlay one video on top of another.<br>
        /// </br>It takes two inputs and has one output.The first input is the "main" video on which the second input is overlaid.This filter requires same memory layout for all the inputs.So, format conversion may be needed.
        /// </summary>
        /// <param name="second"></param>
        /// <param name="first"></param>
        /// <returns></returns>
        public static OverlayOpenclFilter OverlayOpenclFilterOn(this ImageMap second, ImageMap first)
          => new OverlayOpenclFilter(first, second);
    }
}
