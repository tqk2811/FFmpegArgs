///*

//*/
//namespace FFmpegArgs.Filters.AudioFilters
//{
//    /// <summary>
//    /// ... ashowinfo         A->A       Show textual information for each audio frame.<br></br>
//    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#ashowinfo"/>
//    /// </summary>
//    public class AshowinfoFilter : AudioToAudioFilter
//    {
//        internal AshowinfoFilter(AudioMap audioMap) : base("ashowinfo", audioMap)
//        {
//            AddMapOut();
//        }



//    }
//    /// <summary>
//    /// 
//    /// </summary>
//    public static class AshowinfoFilterExtensions
//    {
//        /// <summary>
//        /// Show a line containing various information for each input audio frame. The input audio is not modified.<br>
//        /// </br>The shown line contains a sequence of key/value pairs of the form key:value.<br></br>
//        /// <see href="https://ffmpeg.org/ffmpeg-filters.html#ashowinfo"/>
//        /// </summary>
//        public static AshowinfoFilter AshowinfoFilter(this AudioMap audioMap)
//          => new AshowinfoFilter(audioMap);
//    }
//}
