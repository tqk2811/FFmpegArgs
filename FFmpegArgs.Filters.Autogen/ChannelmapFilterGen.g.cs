using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using FFmpegArgs;
using FFmpegArgs.Cores;
using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using FFmpegArgs.Filters;
using FFmpegArgs.Filters.Enums;
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
if(config?.map != null) result.map(config.map);
if(config?.channel_layout != null) result.channel_layout(config.channel_layout);
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
