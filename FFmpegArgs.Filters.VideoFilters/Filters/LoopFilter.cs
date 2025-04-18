/*
loop AVOptions:
  loop              <int>        ..FV....... number of loops (from -1 to INT_MAX) (default 0)
  size              <int64>      ..FV....... max number of frames to loop (from 0 to 32767) (default 0)
  start             <int64>      ..FV....... set the loop start frame (from 0 to I64_MAX) (default 0)
 */
namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    ///  ... loop              V->V       Loop video frames.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#loop
    /// </summary>
    public class LoopFilter : ImageToImageFilter
    {
        internal LoopFilter(ImageMap imageMap) : base("loop", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the number of loops. Setting this value to -1 will result in infinite loops. (from -1 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="loop"></param>
        /// <returns></returns>
        public LoopFilter Loop(int loop) => this.SetOptionRange("loop", loop, -1, INT_MAX);
        /// <summary>
        /// Set maximal size in number of frames. (from 0 to 32767) (default 0)
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public LoopFilter Size(long size) => this.SetOptionRange("size", size, 0, 32767);
        /// <summary>
        /// Set first frame of loop. (from 0 to I64_MAX) (default 0)
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        public LoopFilter Start(long start) => this.SetOptionRange("start", start, 0, I64_MAX);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class LoopFilterExtensions
    {
        /// <summary>
        /// Loop video frames.
        /// </summary>
        public static LoopFilter LoopFilter(this ImageMap imageMap)
          => new LoopFilter(imageMap);
    }
}
