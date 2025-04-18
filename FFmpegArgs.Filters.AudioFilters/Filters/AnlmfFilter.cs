///*

//*/
//namespace FFmpegArgs.Filters.AudioFilters
//{
//    /// <summary>
//    /// .SC anlms             AA->A      Apply Normalized Least-Mean-Squares algorithm to first audio stream.<br></br>
//    /// https://ffmpeg.org/ffmpeg-filters.html#anlmf_002c-anlms
//    /// </summary>
//    public class AnlmfFilter : AudioToAudioFilter
//    {
//        internal AnlmfFilter(AudioMap audioMap) : base("anlmf", audioMap)
//        {
//            AddMapOut();
//        }
//    }
//    /// <summary>
//    /// 
//    /// </summary>
//    public static class AnlmfFilterExtensions
//    {
//        /// <summary>
//        /// 
//        /// </summary>
//        public static AnlmfFilter AnlmfFilter(this AudioMap audioMap)
//          => new AnlmfFilter(audioMap);
//    }
//}
