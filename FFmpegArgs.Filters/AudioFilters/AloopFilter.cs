/*
aloop AVOptions:
  loop              <int>        ..F.A...... number of loops (from -1 to INT_MAX) (default 0)
  size              <int64>      ..F.A...... max number of samples to loop (from 0 to INT_MAX) (default 0)
  start             <int64>      ..F.A...... set the loop start sample (from 0 to I64_MAX) (default 0)
 */
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    ///  ... aloop             A->A       Loop audio samples.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#aloop
    /// </summary>
    public class AloopFilter : AudioToAudioFilter
    {
        internal AloopFilter(AudioMap audioMap) : base("aloop", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the number of loops. Setting this value to -1 will result in infinite loops. (from -1 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="loop"></param>
        /// <returns></returns>
        public AloopFilter Loop(int loop) => this.SetOptionRange("loop", loop, -1, INT_MAX);
        /// <summary>
        /// Set maximal number of samples. (from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public AloopFilter Size(long size) => this.SetOptionRange("size", size, 0, INT_MAX);
        /// <summary>
        /// Set first sample of loop. (from 0 to I64_MAX) (default 0)
        /// </summary>
        /// <param name="start"></param>
        /// <returns></returns>
        public AloopFilter Start(long start) => this.SetOptionRange("start", start, 0, I64_MAX);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AloopFilterExtensions
    {
        /// <summary>
        /// Loop audio samples.
        /// </summary>
        public static AloopFilter AloopFilter(this AudioMap audioMap)
          => new AloopFilter(audioMap);
    }
}
