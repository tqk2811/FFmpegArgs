//using FFmpegArgs.Cores.Maps;
//namespace FFmpegArgs.Filters.AudioFilters
//{
//    /// <summary>
//    /// ... acopy             A->A       Copy the input audio unchanged to the output.<br></br>
//    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#acopy"/>
//    /// </summary>
//    public class AcopyFilter : AudioToAudioFilter
//    {
//        internal AcopyFilter(AudioMap audioMap) : base("acopy", audioMap)
//        {
//            AddMapOut();
//        }
//    }
//    public static class AcopyFilterExtension
//    {
//        /// <summary>
//        /// Copy the input audio source unchanged to the output. This is mainly useful for testing purposes.<br>
//        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#acopy"/>
//        /// </summary>
//        /// <param name="audioMap"></param>
//        /// <returns></returns>
//        public static AcopyFilter AcopyFilter(this AudioMap audioMap) => new AcopyFilter(audioMap);
//    }
//}
