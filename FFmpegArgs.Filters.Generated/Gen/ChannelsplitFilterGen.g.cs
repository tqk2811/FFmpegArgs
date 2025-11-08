namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. channelsplit      A-&gt;N       Split audio into per-channel streams.
    /// </summary>
    public class ChannelsplitFilterGen : AudioToAudioFilter
    {
        internal ChannelsplitFilterGen(AudioMap input, int outputCount) : base("channelsplit", input)
        {
            AddMultiMapOut(outputCount);
        }

        /// <summary>
        ///  Input channel layout. (default &quot;stereo&quot;)
        /// </summary>
        public ChannelsplitFilterGen channel_layout(ChannelLayout channel_layout) => this.SetOption("channel_layout", channel_layout.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Channels to extract. (default &quot;all&quot;)
        /// </summary>
        public ChannelsplitFilterGen channels(String channels) => this.SetOption("channels", channels.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Split audio into per-channel streams.
        /// </summary>
        public static ChannelsplitFilterGen ChannelsplitFilterGen(this AudioMap input0, int outputCount) => new ChannelsplitFilterGen(input0, outputCount);
    }
}