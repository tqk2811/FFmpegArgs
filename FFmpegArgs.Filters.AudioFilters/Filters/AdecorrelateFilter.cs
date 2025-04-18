/*
adecorrelate AVOptions:
   stages            <int>        ..F.A...... set filtering stages (from 1 to 16) (default 6)
   seed              <int64>      ..F.A...... set random seed (from -1 to UINT32_MAX) (default -1)
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// TS. adecorrelate      A->A       Apply decorrelation to input audio.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#adecorrelate
    /// </summary>
    public class AdecorrelateFilter : AudioToAudioFilter, ITimelineSupport, ISliceThreading
    {
        internal AdecorrelateFilter(AudioMap audioMap) : base("adecorrelate", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set decorrelation stages of filtering. Allowed range is from 1 to 16. Default value is 6.
        /// </summary>
        /// <param name="stages"></param>
        /// <returns></returns>
        public AdecorrelateFilter Stages(int stages)
            => this.SetOptionRange("stages", stages, 1, 16);

        /// <summary>
        /// Set random seed used for setting delay in samples across channels. (from -1 to UINT32_MAX) (default -1)
        /// </summary>
        /// <param name="seed"></param>
        /// <returns></returns>
        public AdecorrelateFilter Seed(long seed)
            => this.SetOptionRange("seed", seed, -1, UINT32_MAX);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AdecorrelateFilterExtensions
    {
        /// <summary>
        /// Apply decorrelation to input audio stream.
        /// </summary>
        public static AdecorrelateFilter AdecorrelateFilter(this AudioMap audioMap)
          => new AdecorrelateFilter(audioMap);
    }
}
