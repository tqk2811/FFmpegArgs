///*

//*/
//namespace FFmpegArgs.Filters.AudioFilters
//{
//    /// <summary>
//    /// <br></br>
//    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#dialoguenhance"/>
//    /// </summary>
//    public class DialoguenhanceFilter : AudioToAudioFilter
//    {
//        internal DialoguenhanceFilter(AudioMap audioMap) : base("dialoguenhance", audioMap)
//        {
//            AddMapOut();
//        }



//    }
//    /// <summary>
//    /// 
//    /// </summary>
//    public static class DialoguenhanceFilterExtensions
//    {
//        /// <summary>
//        /// Enhance dialogue in stereo audio.<br>
//        /// </br>This filter accepts stereo input and produce surround(3.0) channels output.The newly produced front center channel have enhanced speech dialogue originally available in both stereo channels.This filter outputs front left and front right channels same as available in stereo input.<br></br>
//        /// <see href="https://ffmpeg.org/ffmpeg-filters.html#dialoguenhance"/>
//        /// </summary>
//        public static DialoguenhanceFilter DialoguenhanceFilter(this AudioMap audioMap)
//          => new DialoguenhanceFilter(audioMap);
//    }
//}
