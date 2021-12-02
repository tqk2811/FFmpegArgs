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
public class AtadenoiseFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AtadenoiseFilterGen(ImageMap input) : base("atadenoise",input) { AddMapOut(); }
/// <summary>
///  set threshold A for 1st plane (from 0 to 0.3) (default 0.02)
/// </summary>
public AtadenoiseFilterGen _0a(float _0a) => this.SetOptionRange("0a", _0a,0,0.3);
/// <summary>
///  set threshold B for 1st plane (from 0 to 5) (default 0.04)
/// </summary>
public AtadenoiseFilterGen _0b(float _0b) => this.SetOptionRange("0b", _0b,0,5);
/// <summary>
///  set threshold A for 2nd plane (from 0 to 0.3) (default 0.02)
/// </summary>
public AtadenoiseFilterGen _1a(float _1a) => this.SetOptionRange("1a", _1a,0,0.3);
/// <summary>
///  set threshold B for 2nd plane (from 0 to 5) (default 0.04)
/// </summary>
public AtadenoiseFilterGen _1b(float _1b) => this.SetOptionRange("1b", _1b,0,5);
/// <summary>
///  set threshold A for 3rd plane (from 0 to 0.3) (default 0.02)
/// </summary>
public AtadenoiseFilterGen _2a(float _2a) => this.SetOptionRange("2a", _2a,0,0.3);
/// <summary>
///  set threshold B for 3rd plane (from 0 to 5) (default 0.04)
/// </summary>
public AtadenoiseFilterGen _2b(float _2b) => this.SetOptionRange("2b", _2b,0,5);
/// <summary>
///  set how many frames to use (from 5 to 129) (default 9)
/// </summary>
public AtadenoiseFilterGen s(int s) => this.SetOptionRange("s", s,5,129);
/// <summary>
///  set what planes to filter (default 7)
/// </summary>
public AtadenoiseFilterGen p(AtadenoiseFilterGenP p) => this.SetOption("p", p.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set variant of algorithm (from 0 to 1) (default p)
/// </summary>
public AtadenoiseFilterGen a(AtadenoiseFilterGenA a) => this.SetOption("a", a.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set sigma for 1st plane (from 0 to 32767) (default 32767)
/// </summary>
public AtadenoiseFilterGen _0s(float _0s) => this.SetOptionRange("0s", _0s,0,32767);
/// <summary>
///  set sigma for 2nd plane (from 0 to 32767) (default 32767)
/// </summary>
public AtadenoiseFilterGen _1s(float _1s) => this.SetOptionRange("1s", _1s,0,32767);
/// <summary>
///  set sigma for 3rd plane (from 0 to 32767) (default 32767)
/// </summary>
public AtadenoiseFilterGen _2s(float _2s) => this.SetOptionRange("2s", _2s,0,32767);
}
public static class AtadenoiseFilterGenExtensions
{
/// <summary>
/// Apply an Adaptive Temporal Averaging Denoiser.
/// </summary>
public static AtadenoiseFilterGen AtadenoiseFilterGen(this ImageMap input0) => new AtadenoiseFilterGen(input0);
/// <summary>
/// Apply an Adaptive Temporal Averaging Denoiser.
/// </summary>
public static AtadenoiseFilterGen AtadenoiseFilterGen(this ImageMap input0,AtadenoiseFilterGenConfig config)
{
var result = new AtadenoiseFilterGen(input0);
if(config?._0a != null) result._0a(config._0a.Value);
if(config?._0b != null) result._0b(config._0b.Value);
if(config?._1a != null) result._1a(config._1a.Value);
if(config?._1b != null) result._1b(config._1b.Value);
if(config?._2a != null) result._2a(config._2a.Value);
if(config?._2b != null) result._2b(config._2b.Value);
if(config?.s != null) result.s(config.s.Value);
if(config?.p != null) result.p(config.p.Value);
if(config?.a != null) result.a(config.a.Value);
if(config?._0s != null) result._0s(config._0s.Value);
if(config?._1s != null) result._1s(config._1s.Value);
if(config?._2s != null) result._2s(config._2s.Value);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class AtadenoiseFilterGenConfig
{
/// <summary>
///  set threshold A for 1st plane (from 0 to 0.3) (default 0.02)
/// </summary>
public float? _0a { get; set; }
/// <summary>
///  set threshold B for 1st plane (from 0 to 5) (default 0.04)
/// </summary>
public float? _0b { get; set; }
/// <summary>
///  set threshold A for 2nd plane (from 0 to 0.3) (default 0.02)
/// </summary>
public float? _1a { get; set; }
/// <summary>
///  set threshold B for 2nd plane (from 0 to 5) (default 0.04)
/// </summary>
public float? _1b { get; set; }
/// <summary>
///  set threshold A for 3rd plane (from 0 to 0.3) (default 0.02)
/// </summary>
public float? _2a { get; set; }
/// <summary>
///  set threshold B for 3rd plane (from 0 to 5) (default 0.04)
/// </summary>
public float? _2b { get; set; }
/// <summary>
///  set how many frames to use (from 5 to 129) (default 9)
/// </summary>
public int? s { get; set; }
/// <summary>
///  set what planes to filter (default 7)
/// </summary>
public AtadenoiseFilterGenP? p { get; set; }
/// <summary>
///  set variant of algorithm (from 0 to 1) (default p)
/// </summary>
public AtadenoiseFilterGenA? a { get; set; }
/// <summary>
///  set sigma for 1st plane (from 0 to 32767) (default 32767)
/// </summary>
public float? _0s { get; set; }
/// <summary>
///  set sigma for 2nd plane (from 0 to 32767) (default 32767)
/// </summary>
public float? _1s { get; set; }
/// <summary>
///  set sigma for 3rd plane (from 0 to 32767) (default 32767)
/// </summary>
public float? _2s { get; set; }
public string TimelineSupport { get; set; }
}
public enum AtadenoiseFilterGenP
{
}

public enum AtadenoiseFilterGenA
{
[Name("p")] p,
[Name("s")] s,
}

}
