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
public class DynaudnormFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal DynaudnormFilterGen(AudioMap input) : base("dynaudnorm",input) { AddMapOut(); }
/// <summary>
///  set the frame length in msec (from 10 to 8000) (default 500)
/// </summary>
public DynaudnormFilterGen framelen(int framelen) => this.SetOptionRange("framelen", framelen,10,8000);
/// <summary>
///  set the filter size (from 3 to 301) (default 31)
/// </summary>
public DynaudnormFilterGen gausssize(int gausssize) => this.SetOptionRange("gausssize", gausssize,3,301);
/// <summary>
///  set the peak value (from 0 to 1) (default 0.95)
/// </summary>
public DynaudnormFilterGen peak(double peak) => this.SetOptionRange("peak", peak,0,1);
/// <summary>
///  set the max amplification (from 1 to 100) (default 10)
/// </summary>
public DynaudnormFilterGen maxgain(double maxgain) => this.SetOptionRange("maxgain", maxgain,1,100);
/// <summary>
///  set the target RMS (from 0 to 1) (default 0)
/// </summary>
public DynaudnormFilterGen targetrms(double targetrms) => this.SetOptionRange("targetrms", targetrms,0,1);
/// <summary>
///  set the target RMS (from 0 to 1) (default 0)
/// </summary>
public DynaudnormFilterGen r(double r) => this.SetOptionRange("r", r,0,1);
/// <summary>
///  set channel coupling (default true)
/// </summary>
public DynaudnormFilterGen coupling(bool flag) => this.SetOption("coupling",flag.ToFFmpegFlag());
/// <summary>
///  set channel coupling (default true)
/// </summary>
public DynaudnormFilterGen n(bool flag) => this.SetOption("n",flag.ToFFmpegFlag());
/// <summary>
///  set DC correction (default false)
/// </summary>
public DynaudnormFilterGen correctdc(bool flag) => this.SetOption("correctdc",flag.ToFFmpegFlag());
/// <summary>
///  set alternative boundary mode (default false)
/// </summary>
public DynaudnormFilterGen altboundary(bool flag) => this.SetOption("altboundary",flag.ToFFmpegFlag());
/// <summary>
///  set alternative boundary mode (default false)
/// </summary>
public DynaudnormFilterGen b(bool flag) => this.SetOption("b",flag.ToFFmpegFlag());
/// <summary>
///  set the compress factor (from 0 to 30) (default 0)
/// </summary>
public DynaudnormFilterGen compress(double compress) => this.SetOptionRange("compress", compress,0,30);
/// <summary>
///  set the compress factor (from 0 to 30) (default 0)
/// </summary>
public DynaudnormFilterGen s(double s) => this.SetOptionRange("s", s,0,30);
/// <summary>
///  set the threshold value (from 0 to 1) (default 0)
/// </summary>
public DynaudnormFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,0,1);
}
public static class DynaudnormFilterGenExtensions
{
/// <summary>
/// Dynamic Audio Normalizer.
/// </summary>
public static DynaudnormFilterGen DynaudnormFilterGen(this AudioMap input0) => new DynaudnormFilterGen(input0);
}
}
