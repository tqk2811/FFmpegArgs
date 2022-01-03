using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... asetrate          A->A       Change the sample rate without altering the data.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#asetrate
    /// </summary>
    public class AsetrateFilter : AudioToAudioFilter
    {
        internal AsetrateFilter(AudioMap audioMap) : base("asetrate", audioMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set the output sample rate. Default is 44100 Hz.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public AsetrateFilter SampleRate(int r)
            => this.SetOptionRange("r", r, 0, INT_MAX);

    }

    public static class AsetrateFilterExtensions
    {
        /// <summary>
        /// Set the sample rate without altering the PCM data. This will result in a change of speed and pitch.
        /// </summary>
        public static AsetrateFilter AsetrateFilter(this AudioMap audioMap)
          => new AsetrateFilter(audioMap);

    }
}
