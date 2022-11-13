///*

//*/
//namespace FFmpegArgs.Filters.AudioFilters
//{
//    /// <summary>
//    /// <br></br>
//    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#aspectralstats"/>
//    /// </summary>
//    public class AspectralstatsFilter : AudioToAudioFilter
//    {
//        internal AspectralstatsFilter(AudioMap audioMap) : base("aspectralstats", audioMap)
//        {
//            AddMapOut();
//        }



//    }
//    /// <summary>
//    /// 
//    /// </summary>
//    public static class AspectralstatsFilterExtensions
//    {
//        /// <summary>
//        /// Display frequency domain statistical information about the audio channels. Statistics are calculated and stored as metadata for each audio channel and for each audio frame.<br></br>
//        /// <see href="https://ffmpeg.org/ffmpeg-filters.html#aspectralstats"/>
//        /// </summary>
//        public static AspectralstatsFilter AspectralstatsFilter(this AudioMap audioMap)
//          => new AspectralstatsFilter(audioMap);
//    }
//}
