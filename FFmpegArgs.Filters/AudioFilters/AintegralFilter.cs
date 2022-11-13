/*
Nothing
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... aintegral         A->A       Compute integral of input audio.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#aderivative_002c-aintegral"/>
    /// </summary>
    public class AintegralFilter : AudioToAudioFilter
    {
        internal AintegralFilter(AudioMap audioMap) : base("aintegral", audioMap)
        {
            AddMapOut();
        }



    }
    /// <summary>
    /// 
    /// </summary>
    public static class AintegralFilterExtensions
    {
        /// <summary>
        /// Compute derivative/integral of audio stream.<br>
        /// </br>Applying both filters one after another produces original audio.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#aderivative_002c-aintegral"/>
        /// </summary>
        public static AintegralFilter AintegralFilter(this AudioMap audioMap)
          => new AintegralFilter(audioMap);
    }
}
