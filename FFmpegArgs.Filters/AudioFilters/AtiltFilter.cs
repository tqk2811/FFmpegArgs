///*

//*/
//namespace FFmpegArgs.Filters.AudioFilters
//{
//    /// <summary>
//    /// <br></br>
//    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#atilt"/>
//    /// </summary>
//    public class AtiltFilter : AudioToAudioFilter
//    {
//        internal AtiltFilter(AudioMap audioMap) : base("atilt", audioMap)
//        {
//            AddMapOut();
//        }



//    }
//    /// <summary>
//    /// 
//    /// </summary>
//    public static class AtiltFilterExtensions
//    {
//        /// <summary>
//        /// Apply spectral tilt filter to audio stream.<br>
//        /// </br>This filter apply any spectral roll-off slope over any specified frequency band.<br></br>
//        /// <see href="https://ffmpeg.org/ffmpeg-filters.html#atilt"/>
//        /// </summary>
//        public static AtiltFilter AtiltFilter(this AudioMap audioMap)
//          => new AtiltFilter(audioMap);
//    }
//}
