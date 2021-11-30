using FFmpegArgs.Cores.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Filters.AudioFilters
{
    public class AmixFilter : AudioToAudioFilter
    {
        internal AmixFilter(params AudioMap[] audioMaps) : base("amix",audioMaps)
        {
            if (audioMaps.Length < 2) throw new ArgumentException($"audioMaps as least 2 items");
            this.SetOption("inputs", audioMaps.Length);
        }

        /// <summary>
        /// How to determine the end-of-stream.
        /// </summary>
        /// <param name="duration"></param>
        /// <returns></returns>
        public AmixFilter Duration(AmixDuration duration)
            => this.SetOption("duration", duration);

        /// <summary>
        /// dropout_transition <float>      ..F.A...... Transition time, in seconds, for volume renormalization when an input stream ends. (from 0 to INT_MAX) (default 2)
        /// </summary>
        /// <param name="dropout_transition"></param>
        /// <returns></returns>
        public AmixFilter DropoutTransition(float dropout_transition)
            => this.SetOptionRange("dropout_transition", dropout_transition, 0, INT_MAX);

        /// <summary>
        /// Specify weight of each input audio stream as sequence. Each weight is separated by space. By default all inputs have same weight.<br>
        /// </br>Set weight for each input. (default "1 1")
        /// </summary>
        /// <param name="weights"></param>
        /// <returns></returns>
        public AmixFilter Weights(string weights)
            => this.SetOption("weights", weights);

        /// <summary>
        /// Always scale inputs instead of only doing summation of samples. Beware of heavy clipping if inputs are not normalized prior or after filtering by this filter if this option is disabled. By default is enabled.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public AmixFilter Normalize(bool flag)
            => this.SetOption("normalize", flag.ToFFmpegFlag());
    }


    public static class AmixFilterExtensions
    {
        /// <summary>
        /// Mixes multiple audio inputs into a single output.<br>
        /// </br>Note that this filter only supports float samples(the amerge and pan audio filters support many formats). If the amix input has integer samples then aresample will be automatically inserted to perform the conversion to float samples.
        /// </summary>
        /// <param name="audioMap0"></param>
        /// <param name="audioMaps"></param>
        /// <returns></returns>
        public static AmixFilter AmixFilter(this AudioMap audioMap0, params AudioMap[] audioMaps)
        {
            List<AudioMap> audioMapsList = new List<AudioMap>() { audioMap0 };
            audioMapsList.AddRange(audioMaps);
            return new AmixFilter(audioMapsList.ToArray());
        }


        /// <summary>
        /// Mixes multiple audio inputs into a single output.<br>
        /// </br>Note that this filter only supports float samples(the amerge and pan audio filters support many formats). If the amix input has integer samples then aresample will be automatically inserted to perform the conversion to float samples.
        /// </summary>
        /// <param name="audioMaps"></param>
        /// <returns></returns>
        public static AmixFilter AmixFilter(this IEnumerable<AudioMap> audioMaps)
            => new AmixFilter(audioMaps.ToArray());

        /// <summary>
        /// Mixes multiple audio inputs into a single output.<br>
        /// </br>Note that this filter only supports float samples(the amerge and pan audio filters support many formats). If the amix input has integer samples then aresample will be automatically inserted to perform the conversion to float samples.
        /// </summary>
        /// <param name="audioMaps"></param>
        /// <returns></returns>
        public static AmixFilter AmixFilter(this AudioMap[] audioMaps)
            => new AmixFilter(audioMaps);
    }


    public enum AmixDuration
    {
        /// <summary>
        /// The duration of the longest input. (default)
        /// </summary>
        longest,
        /// <summary>
        /// The duration of the shortest input.
        /// </summary>
        shortest,
        /// <summary>
        /// The duration of the first input.
        /// </summary>
        first
    }
}
