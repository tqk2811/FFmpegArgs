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
public class AsuperpassFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AsuperpassFilterGen(AudioMap input) : base("asuperpass",input) { AddMapOut(); }
/// <summary>
///  set center frequency (from 2 to 999999) (default 1000)
/// </summary>
public AsuperpassFilterGen centerf(double centerf) => this.SetOptionRange("centerf", centerf,2,999999);
/// <summary>
///  set filter order (from 4 to 20) (default 4)
/// </summary>
public AsuperpassFilterGen order(int order) => this.SetOptionRange("order", order,4,20);
/// <summary>
///  set Q-factor (from 0.01 to 100) (default 1)
/// </summary>
public AsuperpassFilterGen qfactor(double qfactor) => this.SetOptionRange("qfactor", qfactor,0.01,100);
/// <summary>
///  set input level (from 0 to 2) (default 1)
/// </summary>
public AsuperpassFilterGen level(double level) => this.SetOptionRange("level", level,0,2);
}
public static class AsuperpassFilterGenExtensions
{
/// <summary>
/// Apply high order Butterworth band-pass filter.
/// </summary>
public static AsuperpassFilterGen AsuperpassFilterGen(this AudioMap input0) => new AsuperpassFilterGen(input0);
/// <summary>
/// Apply high order Butterworth band-pass filter.
/// </summary>
public static AsuperpassFilterGen AsuperpassFilterGen(this AudioMap input0,AsuperpassFilterGenConfig config)
{
var result = new AsuperpassFilterGen(input0);
if(config?.centerf != null) result.centerf(config.centerf.Value);
if(config?.order != null) result.order(config.order.Value);
if(config?.qfactor != null) result.qfactor(config.qfactor.Value);
if(config?.level != null) result.level(config.level.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class AsuperpassFilterGenConfig
{
/// <summary>
///  set center frequency (from 2 to 999999) (default 1000)
/// </summary>
public double? centerf { get; set; }
/// <summary>
///  set filter order (from 4 to 20) (default 4)
/// </summary>
public int? order { get; set; }
/// <summary>
///  set Q-factor (from 0.01 to 100) (default 1)
/// </summary>
public double? qfactor { get; set; }
/// <summary>
///  set input level (from 0 to 2) (default 1)
/// </summary>
public double? level { get; set; }
public string TimelineSupport { get; set; }
}
}
