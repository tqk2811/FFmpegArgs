/*
amix AVOptions:
  inputs            <int>        ..F.A...... Number of inputs. (from 1 to 32767) (default 2)
  duration          <int>        ..F.A...... How to determine the end-of-stream. (from 0 to 2) (default longest)
     longest         0            ..F.A...... Duration of longest input.
     shortest        1            ..F.A...... Duration of shortest input.
     first           2            ..F.A...... Duration of first input.
  dropout_transition <float>      ..F.A...... Transition time, in seconds, for volume renormalization when an input stream ends. (from 0 to INT_MAX) (default 2)
  weights           <string>     ..F.A....T. Set weight for each input. (default "1 1")
  normalize         <boolean>    ..F.A....T. Scale inputs (default true)
 */
using FFmpegArgs.Cores.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ..C amix              N->A       Audio mixing.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#amix
    /// </summary>
    public class AmixFilter : AudioToAudioFilter, ICommandSupport
    {
        internal AmixFilter(params AudioMap[] audioMaps) : base("amix",audioMaps)
        {
            if (audioMaps.Length < 2) throw new ArgumentException($"audioMaps as least 2 items");
            AddMapOut();
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
        /// Transition time, in seconds, for volume renormalization when an input stream ends. (from 0 to INT_MAX) (default 2)
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

    /// <summary>
    /// 
    /// </summary>
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

    /// <summary>
    /// 
    /// </summary>
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
