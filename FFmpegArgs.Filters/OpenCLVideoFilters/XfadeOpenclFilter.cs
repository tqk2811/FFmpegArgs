/*
xfade_opencl AVOptions:
   transition        <int>        ..FV....... set cross fade transition (from 0 to 9) (default fade)
     custom          0            ..FV....... custom transition
     fade            1            ..FV....... fade transition
     wipeleft        2            ..FV....... wipe left transition
     wiperight       3            ..FV....... wipe right transition
     wipeup          4            ..FV....... wipe up transition
     wipedown        5            ..FV....... wipe down transition
     slideleft       6            ..FV....... slide left transition
     slideright      7            ..FV....... slide right transition
     slideup         8            ..FV....... slide up transition
     slidedown       9            ..FV....... slide down transition
   source            <string>     ..FV....... set OpenCL program source file for custom transition
   kernel            <string>     ..FV....... set kernel name in program file for custom transition
   duration          <duration>   ..FV....... set cross fade duration (default 1)
   offset            <duration>   ..FV....... set cross fade start relative to first input stream (default 0)
*/
namespace FFmpegArgs.Filters.OpenCLVideoFilters
{
    /// <summary>
    /// ... xfade_opencl      VV->V      Cross fade one video with another video.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#xfade_005fopencl
    /// </summary>
    public class XfadeOpenclFilter : ImageToImageFilter
    {
        internal XfadeOpenclFilter(ImageMap imageMap) : base("xfade_opencl", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set one of possible transition effects.
        /// </summary>
        /// <param name="transition"></param>
        /// <returns></returns>
        public XfadeOpenclFilter Transition(XfadeOpenclTransition transition)
            => this.SetOption("transition", transition);
        /// <summary>
        /// OpenCL program source file for custom transition.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public XfadeOpenclFilter Source(string source)
            => this.SetOption("source", source);
        /// <summary>
        /// Set name of kernel to use for custom transition from program source file.
        /// </summary>
        /// <param name="kernel"></param>
        /// <returns></returns>
        public XfadeOpenclFilter Kernel(string kernel)
            => this.SetOption("kernel", kernel);
        /// <summary>
        /// Set duration of video transition.
        /// </summary>
        /// <param name="duration"></param>
        /// <returns></returns>
        public XfadeOpenclFilter Duration(TimeSpan duration)
           => this.SetOptionRange("duration", duration, TimeSpan.Zero, TimeSpan.MaxValue);
        /// <summary>
        /// Set time of start of transition relative to first video.
        /// </summary>
        /// <param name="offset"></param>
        /// <returns></returns>
        public XfadeOpenclFilter Offset(TimeSpan offset)
           => this.SetOptionRange("offset", offset, TimeSpan.Zero, TimeSpan.MaxValue);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class XfadeOpenclFilterExtensions
    {
        /// <summary>
        /// Cross fade two videos with custom transition effect by using OpenCL.
        /// </summary>
        public static XfadeOpenclFilter XfadeOpenclFilter(this ImageMap imageMap)
          => new XfadeOpenclFilter(imageMap);
    }
    /// <summary>
    /// 
    /// </summary>
    public enum XfadeOpenclTransition
    {
        /// <summary>
        /// custom transition<br>
        /// </br>Select custom transition effect, the actual transition description will be picked from source and kernel options.
        /// </summary>
        custom,
        /// <summary>
        /// fade transition
        /// </summary>
        fade,
        /// <summary>
        /// wipe left transition
        /// </summary>
        wipeleft,
        /// <summary>
        /// wipe right transition
        /// </summary>
        wiperight,
        /// <summary>
        /// wipe up transition
        /// </summary>
        wipeup,
        /// <summary>
        /// wipe down transition
        /// </summary>
        wipedown,
        /// <summary>
        /// slide left transition
        /// </summary>
        slideleft,
        /// <summary>
        /// slide right transition
        /// </summary>
        slideright,
        /// <summary>
        /// slide up transition
        /// </summary>
        slideup,
        /// <summary>
        /// slide down transition
        /// </summary>
        slidedown

    }
}
