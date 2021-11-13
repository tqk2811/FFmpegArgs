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
///  set the peak value (from 0 to 1) (default 0.95)
/// </summary>
public SpeechnormFilterGen p(double p) => this.SetOptionRange("p", p,0,1);
/// <summary>
///  set the max expansion factor (from 1 to 50) (default 2)
/// </summary>
public SpeechnormFilterGen expansion(double expansion) => this.SetOptionRange("expansion", expansion,1,50);
/// <summary>
///  set the max expansion factor (from 1 to 50) (default 2)
/// </summary>
public SpeechnormFilterGen e(double e) => this.SetOptionRange("e", e,1,50);
/// <summary>
///  set the max compression factor (from 1 to 50) (default 2)
/// </summary>
public SpeechnormFilterGen compression(double compression) => this.SetOptionRange("compression", compression,1,50);
/// <summary>
///  set the max compression factor (from 1 to 50) (default 2)
/// </summary>
public SpeechnormFilterGen c(double c) => this.SetOptionRange("c", c,1,50);
/// <summary>
///  set the threshold value (from 0 to 1) (default 0)
/// </summary>
public SpeechnormFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,0,1);
/// <summary>
///  set the threshold value (from 0 to 1) (default 0)
/// </summary>
public SpeechnormFilterGen t(double t) => this.SetOptionRange("t", t,0,1);
/// <summary>
///  set the expansion raising amount (from 0 to 1) (default 0.001)
/// </summary>
public SpeechnormFilterGen raise(double raise) => this.SetOptionRange("raise", raise,0,1);
/// <summary>
///  set the expansion raising amount (from 0 to 1) (default 0.001)
/// </summary>
public SpeechnormFilterGen r(double r) => this.SetOptionRange("r", r,0,1);
/// <summary>
///  set the compression raising amount (from 0 to 1) (default 0.001)
/// </summary>
public SpeechnormFilterGen fall(double fall) => this.SetOptionRange("fall", fall,0,1);
/// <summary>
///  set the compression raising amount (from 0 to 1) (default 0.001)
/// </summary>
public SpeechnormFilterGen f(double f) => this.SetOptionRange("f", f,0,1);
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
public SpeechnormFilterGen invert(bool flag) => this.SetOption("invert",flag.ToFFmpegFlag());
/// <summary>
///  set inverted filtering (default false)
/// </summary>
public SpeechnormFilterGen i(bool flag) => this.SetOption("i",flag.ToFFmpegFlag());
/// <summary>
///  set linked channels filtering (default false)
/// </summary>
public SpeechnormFilterGen link(bool flag) => this.SetOption("link",flag.ToFFmpegFlag());
/// <summary>
///  set linked channels filtering (default false)
/// </summary>
public SpeechnormFilterGen l(bool flag) => this.SetOption("l",flag.ToFFmpegFlag());
}
public static class SpeechnormFilterGenExtensions
{
/// <summary>
/// Speech Normalizer.
/// </summary>
public static SpeechnormFilterGen SpeechnormFilterGen(this AudioMap input0) => new SpeechnormFilterGen(input0);
}
}
