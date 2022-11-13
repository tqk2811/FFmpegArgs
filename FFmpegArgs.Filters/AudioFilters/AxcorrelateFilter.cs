/*
axcorrelate AVOptions:
  size              <int>        ..F.A...... set segment size (from 2 to 131072) (default 256)
  algo              <int>        ..F.A...... set alghorithm (from 0 to 1) (default slow)
     slow            0            ..F.A...... slow algorithm
     fast            1            ..F.A...... fast algorithm
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... axcorrelate       AA->A      Cross-correlate two audio streams.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#axcorrelate"/>
    /// </summary>
    public class AxcorrelateFilter : AudioToAudioFilter
    {
        internal AxcorrelateFilter(AudioMap audioMap) : base("axcorrelate", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set size of segment over which cross-correlation is calculated. Default is 256. Allowed range is from 2 to 131072.
        /// </summary>
        /// <param name="size"></param>
        /// <returns></returns>
        public AxcorrelateFilter Size(int size)
            => this.SetOptionRange("size", size, 2, 131072);

        /// <summary>
        /// Set algorithm for cross-correlation. Can be slow or fast. Default is slow. Fast algorithm assumes mean values over any given segment are always zero and thus need much less calculations to make. This is generally not true, but is valid for typical audio streams.
        /// </summary>
        /// <param name="algo"></param>
        /// <returns></returns>
        public AxcorrelateFilter Algo(AxcorrelateAlgo algo)
            => this.SetOption("algo", algo);

    }
    /// <summary>
    /// 
    /// </summary>
    public static class AxcorrelateFilterExtensions
    {
        /// <summary>
        /// Calculate normalized windowed cross-correlation between two input audio streams.<br>
        /// </br>Resulted samples are always between -1 and 1 inclusive.If result is 1 it means two input samples are highly correlated in that selected segment.Result 0 means they are not correlated at all.If result is -1 it means two input samples are out of phase, which means they cancel each other.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#axcorrelate"/>
        /// </summary>
        public static AxcorrelateFilter AxcorrelateFilter(this AudioMap audioMap)
          => new AxcorrelateFilter(audioMap);
    }


#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public enum AxcorrelateAlgo
    {
        slow,
        fast
    }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
}
