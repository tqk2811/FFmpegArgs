using FFmpegArgs.Cores.Maps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... amerge            N->A       Merge two or more audio streams into a single multi-channel stream.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#amerge-1
    /// </summary>
    public class AmergeFilter : AudioToAudioFilter
    {
        internal AmergeFilter(params AudioMap[] audioMaps) : base("amerge",audioMaps)
        {
            if (audioMaps.Length < 2) throw new ArgumentException($"audioMaps as least 2 items");
            this.SetOption("inputs", audioMaps.Length);
        }
    }

    public static class AmergeFilterExtensions
    {
        /// <summary>
        /// Merge two or more audio streams into a single multi-channel stream.<br>
        /// </br>If the channel layouts of the inputs are disjoint, and therefore compatible, the channel layout of the output will be set accordingly and the channels will be reordered as necessary. If the channel layouts of the inputs are not disjoint, the output will have all the channels of the first input then all the channels of the second input, in that order, and the channel layout of the output will be the default value corresponding to the total number of channels.<br>
        /// </br>For example, if the first input is in 2.1 (FL+FR+LF) and the second input is FC+BL+BR, then the output will be in 5.1, with the channels in the following order: a1, a2, b1, a3, b2, b3(a1 is the first channel of the first input, b1 is the first channel of the second input).<br>
        /// </br>On the other hand, if both input are in stereo, the output channels will be in the default order: a1, a2, b1, b2, and the channel layout will be arbitrarily set to 4.0, which may or may not be the expected value.<br>
        /// </br>All inputs must have the same sample rate, and format.<br>
        /// </br>If inputs do not have the same duration, the output will stop with the shortest.
        /// </summary>
        /// <param name="audioMap0"></param>
        /// <param name="audioMaps"></param>
        /// <returns></returns>
        public static AmergeFilter AmergeFilter(this AudioMap audioMap0, params AudioMap[] audioMaps)
        {
            List<AudioMap> audioMapsList = new List<AudioMap>() { audioMap0 };
            audioMapsList.AddRange(audioMaps);
            return new AmergeFilter(audioMapsList.ToArray());
        }


        /// <summary>
        /// Merge two or more audio streams into a single multi-channel stream.<br>
        /// </br>If the channel layouts of the inputs are disjoint, and therefore compatible, the channel layout of the output will be set accordingly and the channels will be reordered as necessary. If the channel layouts of the inputs are not disjoint, the output will have all the channels of the first input then all the channels of the second input, in that order, and the channel layout of the output will be the default value corresponding to the total number of channels.<br>
        /// </br>For example, if the first input is in 2.1 (FL+FR+LF) and the second input is FC+BL+BR, then the output will be in 5.1, with the channels in the following order: a1, a2, b1, a3, b2, b3(a1 is the first channel of the first input, b1 is the first channel of the second input).<br>
        /// </br>On the other hand, if both input are in stereo, the output channels will be in the default order: a1, a2, b1, b2, and the channel layout will be arbitrarily set to 4.0, which may or may not be the expected value.<br>
        /// </br>All inputs must have the same sample rate, and format.<br>
        /// </br>If inputs do not have the same duration, the output will stop with the shortest.
        /// </summary>
        /// <param name="audioMaps"></param>
        /// <returns></returns>
        public static AmergeFilter AmergeFilter(this IEnumerable<AudioMap> audioMaps)
            => new AmergeFilter(audioMaps.ToArray());

        /// <summary>
        /// Merge two or more audio streams into a single multi-channel stream.<br>
        /// </br>If the channel layouts of the inputs are disjoint, and therefore compatible, the channel layout of the output will be set accordingly and the channels will be reordered as necessary. If the channel layouts of the inputs are not disjoint, the output will have all the channels of the first input then all the channels of the second input, in that order, and the channel layout of the output will be the default value corresponding to the total number of channels.<br>
        /// </br>For example, if the first input is in 2.1 (FL+FR+LF) and the second input is FC+BL+BR, then the output will be in 5.1, with the channels in the following order: a1, a2, b1, a3, b2, b3(a1 is the first channel of the first input, b1 is the first channel of the second input).<br>
        /// </br>On the other hand, if both input are in stereo, the output channels will be in the default order: a1, a2, b1, b2, and the channel layout will be arbitrarily set to 4.0, which may or may not be the expected value.<br>
        /// </br>All inputs must have the same sample rate, and format.<br>
        /// </br>If inputs do not have the same duration, the output will stop with the shortest.
        /// </summary>
        /// <param name="audioMaps"></param>
        /// <returns></returns>
        public static AmergeFilter AmergeFilter(this AudioMap[] audioMaps)
            => new AmergeFilter(audioMaps);
    }
}
