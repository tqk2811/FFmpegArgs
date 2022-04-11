/*
deshake_opencl AVOptions:
   tripod            <boolean>    ..FV....... simulates a tripod by preventing any camera movement whatsoever from the original frame (default false)
   debug             <boolean>    ..FV....... turn on additional debugging information (default false)
   adaptive_crop     <boolean>    ..FV....... attempt to subtly crop borders to reduce mirrored content (default true)
   refine_features   <boolean>    ..FV....... refine feature point locations at a sub-pixel level (default true)
   smooth_strength   <float>      ..FV....... smoothing strength (0 attempts to adaptively determine optimal strength) (from 0 to 1) (default 0)
   smooth_window_multiplier <float>      ..FV....... multiplier for number of frames to buffer for motion data (from 0.1 to 10) (default 2)
*/
namespace FFmpegArgs.Filters.OpenCLVideoFilters
{
    /// <summary>
    /// ... deshake_opencl    V->V       Feature-point based video stabilization filter<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#deshake_005fopencl
    /// </summary>
    public class DeshakeOpenclFilter : ImageToImageFilter
    {
        internal DeshakeOpenclFilter(ImageMap imageMap) : base("deshake_opencl", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Simulates a tripod by preventing any camera movement whatsoever from the original frame.<br>
        /// </br> Defaults false
        /// </summary>
        /// <param name="tripod"></param>
        /// <returns></returns>
        public DeshakeOpenclFilter Tripod(bool tripod)
            => this.SetOption("tripod", tripod.ToFFmpegFlag());
        /// <summary>
        /// Whether or not additional debug info should be displayed, both in the processed output and in the console.<br>
        /// </br>Note that in order to see console debug output you will also need to pass -v verbose to ffmpeg.<br>
        /// </br>Viewing point matches in the output video is only supported for RGB input.<br>
        /// </br>Defaults false
        /// </summary>
        /// <param name="debug"></param>
        /// <returns></returns>
        public DeshakeOpenclFilter Debug(bool debug)
            => this.SetOption("debug", debug.ToFFmpegFlag());
        /// <summary>
        /// Whether or not to do a tiny bit of cropping at the borders to cut down on the amount of mirrored pixels.<br>
        /// </br>Defaults true
        /// </summary>
        /// <param name="adaptive_crop"></param>
        /// <returns></returns>
        public DeshakeOpenclFilter AdaptiveCrop(bool adaptive_crop)
            => this.SetOption("adaptive_crop", adaptive_crop.ToFFmpegFlag());
        /// <summary>
        /// Whether or not feature points should be refined at a sub-pixel level.<br>
        /// </br>This can be turned off for a slight performance gain at the cost of precision.<br>
        /// </br>Defaults true.
        /// </summary>
        /// <param name="refine_features"></param>
        /// <returns></returns>
        public DeshakeOpenclFilter RefineFeatures(bool refine_features)
            => this.SetOption("refine_features", refine_features.ToFFmpegFlag());
        /// <summary>
        /// The strength of the smoothing applied to the camera path from 0.0 to 1.0.<br>
        /// </br>1.0 is the maximum smoothing strength while values less than that result in less smoothing.<br>
        /// </br>0.0 causes the filter to adaptively choose a smoothing strength on a per-frame basis.<br>
        /// </br>Defaults 0.0.
        /// </summary>
        /// <param name="smooth_strength"></param>
        /// <returns></returns>
        public DeshakeOpenclFilter SmoothStrength(float smooth_strength)
            => this.SetOptionRange("smooth_strength", smooth_strength, 0, 1);
        /// <summary>
        /// Controls the size of the smoothing window (the number of frames buffered to determine motion information from).<br>
        /// </br>The size of the smoothing window is determined by multiplying the framerate of the video by this number.<br>
        /// </br>Acceptable values range from 0.1 to 10.0.<br>
        /// </br>Larger values increase the amount of motion data available for determining how to smooth the camera path, potentially improving smoothness, but also increase latency and memory usage.<br>
        /// </br>Defaults 2.0.
        /// </summary>
        /// <param name="smooth_window_multiplier"></param>
        /// <returns></returns>
        public DeshakeOpenclFilter SmoothWindowMultiplier(float smooth_window_multiplier)
            => this.SetOptionRange("smooth_window_multiplier", smooth_window_multiplier, 0.1, 10);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class DeshakeOpenclFilterExtensions
    {
        /// <summary>
        /// Feature-point based video stabilization filter.
        /// </summary>
        public static DeshakeOpenclFilter DeshakeOpenclFilter(this ImageMap imageMap)
          => new DeshakeOpenclFilter(imageMap);
    }
}
