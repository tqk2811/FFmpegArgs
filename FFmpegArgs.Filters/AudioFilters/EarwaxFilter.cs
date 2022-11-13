/*

*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... earwax            A->A       Widen the stereo image.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#earwax"/>
    /// </summary>
    public class EarwaxFilter : AudioToAudioFilter
    {
        internal EarwaxFilter(AudioMap audioMap) : base("earwax", audioMap)
        {
            AddMapOut();
        }



    }
    /// <summary>
    /// 
    /// </summary>
    public static class EarwaxFilterExtensions
    {
        /// <summary>
        /// Make audio easier to listen to on headphones.<br>
        /// </br>This filter adds ‘cues’ to 44.1kHz stereo(i.e.audio CD format) audio so that when listened to on headphones the stereo image is moved from inside your head(standard for headphones) to outside and in front of the listener(standard for speakers).<br>
        /// </br>Ported from SoX.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#earwax"/>
        /// </summary>
        public static EarwaxFilter EarwaxFilter(this AudioMap audioMap)
          => new EarwaxFilter(audioMap);
    }
}
