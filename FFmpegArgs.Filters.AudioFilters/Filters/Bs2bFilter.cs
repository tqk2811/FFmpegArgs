///*

//*/
//namespace FFmpegArgs.Filters.AudioFilters
//{
//    /// <summary>
//    /// <br></br>
//    /// https://ffmpeg.org/ffmpeg-filters.html#bs2b
//    /// </summary>
//    public class Bs2bFilter : AudioToAudioFilter
//    {
//        internal Bs2bFilter(AudioMap audioMap) : base("bs2b", audioMap)
//        {
//            AddMapOut();
//        }



//    }
//    /// <summary>
//    /// 
//    /// </summary>
//    public static class Bs2bFilterExtensions
//    {
//        /// <summary>
//        /// Bauer stereo to binaural transformation, which improves headphone listening of stereo audio records.
//        /// </summary>
//        public static Bs2bFilter Bs2bFilter(this AudioMap audioMap)
//          => new Bs2bFilter(audioMap);
//    }
//}
