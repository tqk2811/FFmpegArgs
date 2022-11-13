/*

*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... areverse          A->A       Reverse an audio clip.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#areverse"/>
    /// </summary>
    public class AreverseFilter : AudioToAudioFilter
    {
        internal AreverseFilter(AudioMap audioMap) : base("areverse", audioMap)
        {
            AddMapOut();
        }
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AreverseFilterExtensions
    {
        /// <summary>
        /// Reverse an audio clip.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#areverse"/>
        /// </summary>
        public static AreverseFilter AreverseFilter(this AudioMap audioMap)
          => new AreverseFilter(audioMap);
    }
}
