namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... channelmap        A->A       Remap audio channels.
/// </summary>
public class ChannelmapFilterGen : AudioToAudioFilter
{
internal ChannelmapFilterGen(AudioMap input) : base("channelmap",input) { AddMapOut(); }
/// <summary>
///  A comma-separated list of input channel numbers in output order.
/// </summary>
public ChannelmapFilterGen map(string map) => this.SetOption("map",map);
/// <summary>
///  Output channel layout.
/// </summary>
public ChannelmapFilterGen channel_layout(string channel_layout) => this.SetOption("channel_layout",channel_layout);
}
/// <summary>
/// </summary>
public static class ChannelmapFilterGenExtensions
{
/// <summary>
/// Remap audio channels.
/// </summary>
public static ChannelmapFilterGen ChannelmapFilterGen(this AudioMap input0) => new ChannelmapFilterGen(input0);
}
}
