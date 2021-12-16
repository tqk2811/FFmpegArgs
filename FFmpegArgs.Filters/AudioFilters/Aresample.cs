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
    /// ... aresample         A->A       Resample audio data.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#aresample-1
    /// </summary>
    public class AresampleFilter : AudioToAudioFilter, IResamplerOptions
    {
        internal AresampleFilter(AudioMap audioMap) : base("aresample", audioMap)
        {
            AddMapOut();
        }
    }

    public static class AresampleFilterExtensions
    {
        /// <summary>
        /// Resample the input audio to the specified parameters, using the libswresample library. If none are specified then the filter will automatically convert between its input and output.<br>
        /// </br>This filter is also able to stretch/squeeze the audio data to make it match the timestamps or to inject silence / cut out audio to make it match the timestamps, do a combination of both or do neither.
        /// </summary>
        public static AresampleFilter Aresample(this AudioMap audioMap)
          => new AresampleFilter(audioMap);

        /// <summary>
        /// Resample the input audio to the specified parameters, using the libswresample library. If none are specified then the filter will automatically convert between its input and output.<br>
        /// </br>This filter is also able to stretch/squeeze the audio data to make it match the timestamps or to inject silence / cut out audio to make it match the timestamps, do a combination of both or do neither.
        /// </summary>
        public static AresampleFilter Aresample(this AudioMap audioMap, AresampleFilterConfig config)
            => new AresampleFilter(audioMap).ResamplerOptionsFilter(config);
    }

    public class AresampleFilterConfig : ResamplerOptionsConfig
    {

    }
}
