///*

// */
//using FFmpegArgs.Cores.Filters;
//using FFmpegArgs.Cores.Maps;
//using FFmpegArgs.Filters.Enums;
//using System;
//using System.Collections.Generic;
//using System.Drawing;
//using System.Linq;
//using System.Text;

//namespace FFmpegArgs.Filters.AudioFilters
//{
//    /// <summary>
//    /// <br></br>
//    /// https://ffmpeg.org/ffmpeg-filters.html#afwtdn
//    /// </summary>
//    public class AfwtdnFilter : AudioToAudioFilter
//    {
//        internal AfwtdnFilter(AudioMap audioMap) : base("afwtdn", audioMap)
//        {
//            AddMapOut();
//        }



//    }

//    /// <summary>
//    /// 
//    /// </summary>
//    public static class AfwtdnFilterExtensions
//    {
//        /// <summary>
//        /// 
//        /// </summary>
//        public static AfwtdnFilter AfwtdnFilter(this AudioMap audioMap)
//          => new AfwtdnFilter(audioMap);
//    }
//}
