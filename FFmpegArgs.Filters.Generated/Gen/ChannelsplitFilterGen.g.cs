namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... channelsplit      A->N       Split audio into per-channel streams.
/// </summary>
public class ChannelsplitFilterGen : AudioToAudioFilter
{
internal ChannelsplitFilterGen(int outputCount, AudioMap input) : base("channelsplit",input) { AddMultiMapOut(outputCount); }
/// <summary>
///  Input channel layout. (default "stereo")
/// </summary>
public ChannelsplitFilterGen channel_layout(string channel_layout) => this.SetOption("channel_layout",channel_layout);
/// <summary>
///  Channels to extract. (default "all")
/// </summary>
public ChannelsplitFilterGen channels(string channels) => this.SetOption("channels",channels);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Split audio into per-channel streams.
/// </summary>
public static ChannelsplitFilterGen ChannelsplitFilterGen(this AudioMap input0, int outputCount) => new ChannelsplitFilterGen(outputCount, input0);
}
}
