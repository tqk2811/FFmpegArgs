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
public class AsubcutFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AsubcutFilterGen(AudioMap input) : base("asubcut",input) { AddMapOut(); }
/// <summary>
///  set cutoff frequency (from 2 to 200) (default 20)
/// </summary>
public AsubcutFilterGen cutoff(double cutoff) => this.SetOptionRange("cutoff", cutoff,2,200);
/// <summary>
///  set filter order (from 3 to 20) (default 10)
/// </summary>
public AsubcutFilterGen order(int order) => this.SetOptionRange("order", order,3,20);
/// <summary>
///  set input level (from 0 to 1) (default 1)
/// </summary>
public AsubcutFilterGen level(double level) => this.SetOptionRange("level", level,0,1);
}
public static class AsubcutFilterGenExtensions
{
/// <summary>
/// Cut subwoofer frequencies.
/// </summary>
public static AsubcutFilterGen AsubcutFilterGen(this AudioMap input0) => new AsubcutFilterGen(input0);
/// <summary>
/// Cut subwoofer frequencies.
/// </summary>
public static AsubcutFilterGen AsubcutFilterGen(this AudioMap input0,AsubcutFilterGenConfig config)
{
var result = new AsubcutFilterGen(input0);
if(config?.cutoff != null) result.cutoff(config.cutoff.Value);
if(config?.order != null) result.order(config.order.Value);
if(config?.level != null) result.level(config.level.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class AsubcutFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set cutoff frequency (from 2 to 200) (default 20)
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
