namespace FFmpegArgs.Filters.Autogens
{
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
public static class ChannelmapFilterGenExtensions
{
/// <summary>
/// Remap audio channels.
/// </summary>
public static ChannelmapFilterGen ChannelmapFilterGen(this AudioMap input0) => new ChannelmapFilterGen(input0);
/// <summary>
/// Remap audio channels.
/// </summary>
public static ChannelmapFilterGen ChannelmapFilterGen(this AudioMap input0,ChannelmapFilterGenConfig config)
{
var result = new ChannelmapFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.map)) result.map(config.map);
if(!string.IsNullOrWhiteSpace(config?.channel_layout)) result.channel_layout(config.channel_layout);
return result;
}
}
public class ChannelmapFilterGenConfig
{
/// <summary>
///  A comma-separated list of input channel numbers in output order.
/// </summary>
public string map { get; set; }
/// <summary>
///  Output channel layout.
/// </summary>
public string channel_layout { get; set; }
}
}
