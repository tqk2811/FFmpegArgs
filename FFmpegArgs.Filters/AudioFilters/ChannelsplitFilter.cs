/*
channelsplit AVOptions:
  channel_layout    <string>     ..F.A...... Input channel layout. (default "stereo")
  channels          <string>     ..F.A...... Channels to extract. (default "all")
*/
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... channelsplit      A->N       Split audio into per-channel streams.<br></br>
    /// <see href="https://ffmpeg.org/ffmpeg-filters.html#channelsplit"/>
    /// </summary>
    public class ChannelsplitFilter : AudioToAudioFilter
    {
        internal ChannelsplitFilter(AudioMap audioMap, int outputCount, ChannelLayout channelLayout, string channels) : base("channelsplit", audioMap)
        {
            if (outputCount < 1) throw new ArgumentException($"{nameof(outputCount)} must be greater than 0");
            AddMultiMapOut(outputCount);
            this.SetOption("channel_layout", channelLayout.GetEnumAttribute<NameAttribute>().Name);
            if (!string.IsNullOrWhiteSpace(channels)) this.SetOption("channels", channels);
        }

    }
    /// <summary>
    /// 
    /// </summary>
    public static class ChannelsplitFilterExtensions
    {
        /// <summary>
        /// Split each channel from an input audio stream into a separate output stream.<br>
        /// </br><see href="https://ffmpeg.org/ffmpeg-filters.html#channelsplit"/>
        /// </summary>
        /// <param name="audioMap"></param>
        /// <param name="outputCount"></param>
        /// <param name="channelLayout"></param>
        /// <param name="channels">Select channel from <see cref="ChannelLayout"/><br></br>Default 'all'</param>
        /// <returns></returns>
        [Obsolete("Need more information")]
        public static ChannelsplitFilter ChannelsplitFilter(
            this AudioMap audioMap, 
            int outputCount, 
            ChannelLayout channelLayout, 
            string channels = null)
          => new ChannelsplitFilter(audioMap, outputCount, channelLayout, channels);
    }
}
