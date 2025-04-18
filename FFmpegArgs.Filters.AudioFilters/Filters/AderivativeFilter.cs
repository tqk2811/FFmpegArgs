/*
Nothing
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... aderivative       A->A       Compute derivative of input audio.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#aderivative_002c-aintegral
    /// </summary>
    public class AderivativeFilter : AudioToAudioFilter
    {
        internal AderivativeFilter(AudioMap audioMap) : base("aderivative", audioMap)
        {
            AddMapOut();
        }



    }
    /// <summary>
    /// 
    /// </summary>
    public static class AderivativeFilterExtensions
    {
        /// <summary>
        /// Compute derivative/integral of audio stream.<br>
        /// </br>Applying both filters one after another produces original audio.
        /// </summary>
        public static AderivativeFilter AderivativeFilter(this AudioMap audioMap)
          => new AderivativeFilter(audioMap);
    }
}
