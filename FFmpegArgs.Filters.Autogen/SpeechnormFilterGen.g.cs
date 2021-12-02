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
public class SpeechnormFilterGen : AudioToAudioFilter,ICommandSupport
{
internal SpeechnormFilterGen(AudioMap input) : base("speechnorm",input) { AddMapOut(); }
/// <summary>
///  set the peak value (from 0 to 1) (default 0.95)
/// </summary>
public SpeechnormFilterGen peak(double peak) => this.SetOptionRange("peak", peak,0,1);
/// <summary>
///  set the max expansion factor (from 1 to 50) (default 2)
/// </summary>
public SpeechnormFilterGen expansion(double expansion) => this.SetOptionRange("expansion", expansion,1,50);
/// <summary>
///  set the max compression factor (from 1 to 50) (default 2)
/// </summary>
public SpeechnormFilterGen compression(double compression) => this.SetOptionRange("compression", compression,1,50);
/// <summary>
///  set the threshold value (from 0 to 1) (default 0)
/// </summary>
public SpeechnormFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,0,1);
/// <summary>
///  set the expansion raising amount (from 0 to 1) (default 0.001)
/// </summary>
public SpeechnormFilterGen raise(double raise) => this.SetOptionRange("raise", raise,0,1);
/// <summary>
///  set the compression raising amount (from 0 to 1) (default 0.001)
/// </summary>
public SpeechnormFilterGen fall(double fall) => this.SetOptionRange("fall", fall,0,1);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public SpeechnormFilterGen channels(AV_CH_LAYOUT channels) => this.SetOption("channels",channels.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public SpeechnormFilterGen h(AV_CH_LAYOUT h) => this.SetOption("h",h.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set inverted filtering (default false)
/// </summary>
public SpeechnormFilterGen invert(bool invert) => this.SetOption("invert",invert.ToFFmpegFlag());
/// <summary>
///  set linked channels filtering (default false)
/// </summary>
public SpeechnormFilterGen link(bool link) => this.SetOption("link",link.ToFFmpegFlag());
}
public static class SpeechnormFilterGenExtensions
{
/// <summary>
/// Speech Normalizer.
/// </summary>
public static SpeechnormFilterGen SpeechnormFilterGen(this AudioMap input0) => new SpeechnormFilterGen(input0);
/// <summary>
/// Speech Normalizer.
/// </summary>
public static SpeechnormFilterGen SpeechnormFilterGen(this AudioMap input0,SpeechnormFilterGenConfig config)
{
var result = new SpeechnormFilterGen(input0);
if(config?.peak != null) result.peak(config.peak.Value);
if(config?.expansion != null) result.expansion(config.expansion.Value);
if(config?.compression != null) result.compression(config.compression.Value);
if(config?.threshold != null) result.threshold(config.threshold.Value);
if(config?.raise != null) result.raise(config.raise.Value);
if(config?.fall != null) result.fall(config.fall.Value);
if(config?.channels != null) result.channels(config.channels.Value);
if(config?.h != null) result.h(config.h.Value);
if(config?.invert != null) result.invert(config.invert.Value);
if(config?.link != null) result.link(config.link.Value);
return result;
}
}
public class SpeechnormFilterGenConfig
{
/// <summary>
///  set the peak value (from 0 to 1) (default 0.95)
/// </summary>
public double? peak { get; set; }
/// <summary>
///  set the max expansion factor (from 1 to 50) (default 2)
/// </summary>
public double? expansion { get; set; }
/// <summary>
///  set the max compression factor (from 1 to 50) (default 2)
/// </summary>
public double? compression { get; set; }
/// <summary>
///  set the threshold value (from 0 to 1) (default 0)
/// </summary>
public double? threshold { get; set; }
/// <summary>
///  set the expansion raising amount (from 0 to 1) (default 0.001)
/// </summary>
public double? raise { get; set; }
/// <summary>
///  set the compression raising amount (from 0 to 1) (default 0.001)
/// </summary>
public double? fall { get; set; }
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public AV_CH_LAYOUT? channels { get; set; }
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public AV_CH_LAYOUT? h { get; set; }
/// <summary>
///  set inverted filtering (default false)
/// </summary>
public bool? invert { get; set; }
/// <summary>
///  set linked channels filtering (default false)
/// </summary>
public bool? link { get; set; }
}
}
