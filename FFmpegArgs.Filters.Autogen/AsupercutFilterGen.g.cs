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
public class AsupercutFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AsupercutFilterGen(AudioMap input) : base("asupercut",input) { AddMapOut(); }
/// <summary>
///  set cutoff frequency (from 20000 to 192000) (default 20000)
/// </summary>
public AsupercutFilterGen cutoff(double cutoff) => this.SetOptionRange("cutoff", cutoff,20000,192000);
/// <summary>
///  set filter order (from 3 to 20) (default 10)
/// </summary>
public AsupercutFilterGen order(int order) => this.SetOptionRange("order", order,3,20);
/// <summary>
///  set input level (from 0 to 1) (default 1)
/// </summary>
public AsupercutFilterGen level(double level) => this.SetOptionRange("level", level,0,1);
}
public static class AsupercutFilterGenExtensions
{
/// <summary>
/// Cut super frequencies.
/// </summary>
public static AsupercutFilterGen AsupercutFilterGen(this AudioMap input0) => new AsupercutFilterGen(input0);
/// <summary>
/// Cut super frequencies.
/// </summary>
public static AsupercutFilterGen AsupercutFilterGen(this AudioMap input0,AsupercutFilterGenConfig config)
{
var result = new AsupercutFilterGen(input0);
if(config?.cutoff != null) result.cutoff(config.cutoff.Value);
if(config?.order != null) result.order(config.order.Value);
if(config?.level != null) result.level(config.level.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class AsupercutFilterGenConfig
{
/// <summary>
///  set cutoff frequency (from 20000 to 192000) (default 20000)
/// </summary>
public double? cutoff { get; set; }
/// <summary>
///  set filter order (from 3 to 20) (default 10)
/// </summary>
public int? order { get; set; }
/// <summary>
///  set input level (from 0 to 1) (default 1)
/// </summary>
public double? level { get; set; }
public string TimelineSupport { get; set; }
}
}
