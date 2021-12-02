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
public class AevalFilterGen : AudioToAudioFilter,ITimelineSupport
{
internal AevalFilterGen(AudioMap input) : base("aeval",input) { AddMapOut(); }
/// <summary>
///  set the '|'-separated list of channels expressions
/// </summary>
public AevalFilterGen exprs(string exprs) => this.SetOption("exprs",exprs);
/// <summary>
///  set channel layout
/// </summary>
public AevalFilterGen channel_layout(string channel_layout) => this.SetOption("channel_layout",channel_layout);
}
public static class AevalFilterGenExtensions
{
/// <summary>
/// Filter audio signal according to a specified expression.
/// </summary>
public static AevalFilterGen AevalFilterGen(this AudioMap input0) => new AevalFilterGen(input0);
/// <summary>
/// Filter audio signal according to a specified expression.
/// </summary>
public static AevalFilterGen AevalFilterGen(this AudioMap input0,AevalFilterGenConfig config)
{
var result = new AevalFilterGen(input0);
if(config?.exprs != null) result.exprs(config.exprs);
if(config?.channel_layout != null) result.channel_layout(config.channel_layout);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class AevalFilterGenConfig
{
/// <summary>
///  set the '|'-separated list of channels expressions
/// </summary>
public string exprs { get; set; }
/// <summary>
///  set channel layout
/// </summary>
public string channel_layout { get; set; }
public string TimelineSupport { get; set; }
}
}
