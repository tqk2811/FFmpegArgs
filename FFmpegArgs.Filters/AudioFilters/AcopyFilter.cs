﻿//using FFmpegArgs.Cores.Maps;
//namespace FFmpegArgs.Filters.AudioFilters
//{
//    /// <summary>
//    /// ... acopy             A->A       Copy the input audio unchanged to the output.<br></br>
//    /// https://ffmpeg.org/ffmpeg-filters.html#acopy
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
//        /// Copy the input audio source unchanged to the output. This is mainly useful for testing purposes.
//        /// </summary>
//        /// <param name="audioMap"></param>
//        /// <returns></returns>
//        public static AcopyFilter AcopyFilter(this AudioMap audioMap) => new AcopyFilter(audioMap);
//    }
//}
