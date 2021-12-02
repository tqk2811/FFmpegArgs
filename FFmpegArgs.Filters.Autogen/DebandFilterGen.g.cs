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
public class DebandFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal DebandFilterGen(ImageMap input) : base("deband",input) { AddMapOut(); }
/// <summary>
///  set 1st plane threshold (from 3e-05 to 0.5) (default 0.02)
/// </summary>
public DebandFilterGen _1thr(float _1thr) => this.SetOptionRange("1thr", _1thr,3e-05,0.5);
/// <summary>
///  set 2nd plane threshold (from 3e-05 to 0.5) (default 0.02)
/// </summary>
public DebandFilterGen _2thr(float _2thr) => this.SetOptionRange("2thr", _2thr,3e-05,0.5);
/// <summary>
///  set 3rd plane threshold (from 3e-05 to 0.5) (default 0.02)
/// </summary>
public DebandFilterGen _3thr(float _3thr) => this.SetOptionRange("3thr", _3thr,3e-05,0.5);
/// <summary>
///  set 4th plane threshold (from 3e-05 to 0.5) (default 0.02)
/// </summary>
public DebandFilterGen _4thr(float _4thr) => this.SetOptionRange("4thr", _4thr,3e-05,0.5);
/// <summary>
///  set range (from INT_MIN to INT_MAX) (default 16)
/// </summary>
public DebandFilterGen range(int range) => this.SetOptionRange("range", range,INT_MIN,INT_MAX);
/// <summary>
///  set direction (from -6.28319 to 6.28319) (default 6.28319)
/// </summary>
public DebandFilterGen direction(float direction) => this.SetOptionRange("direction", direction,-6.28319,6.28319);
/// <summary>
///  set blur (default true)
/// </summary>
public DebandFilterGen blur(bool blur) => this.SetOption("blur",blur.ToFFmpegFlag());
/// <summary>
///  set plane coupling (default false)
/// </summary>
public DebandFilterGen coupling(bool coupling) => this.SetOption("coupling",coupling.ToFFmpegFlag());
}
public static class DebandFilterGenExtensions
{
/// <summary>
/// Debands video.
/// </summary>
public static DebandFilterGen DebandFilterGen(this ImageMap input0) => new DebandFilterGen(input0);
/// <summary>
/// Debands video.
/// </summary>
public static DebandFilterGen DebandFilterGen(this ImageMap input0,DebandFilterGenConfig config)
{
var result = new DebandFilterGen(input0);
if(config?._1thr != null) result._1thr(config._1thr);
if(config?._2thr != null) result._2thr(config._2thr);
if(config?._3thr != null) result._3thr(config._3thr);
if(config?._4thr != null) result._4thr(config._4thr);
if(config?.range != null) result.range(config.range);
if(config?.direction != null) result.direction(config.direction);
if(config?.blur != null) result.blur(config.blur);
if(config?.coupling != null) result.coupling(config.coupling);
return result;
}
}
public class DebandFilterGenConfig
{
/// <summary>
///  set 1st plane threshold (from 3e-05 to 0.5) (default 0.02)
/// </summary>
public float _1thr { get; set; }
/// <summary>
///  set 2nd plane threshold (from 3e-05 to 0.5) (default 0.02)
/// </summary>
public float _2thr { get; set; }
/// <summary>
///  set 3rd plane threshold (from 3e-05 to 0.5) (default 0.02)
/// </summary>
public float _3thr { get; set; }
/// <summary>
///  set 4th plane threshold (from 3e-05 to 0.5) (default 0.02)
/// </summary>
public float _4thr { get; set; }
/// <summary>
///  set range (from INT_MIN to INT_MAX) (default 16)
/// </summary>
public int range { get; set; }
/// <summary>
///  set direction (from -6.28319 to 6.28319) (default 6.28319)
/// </summary>
public float direction { get; set; }
/// <summary>
///  set blur (default true)
/// </summary>
public bool blur { get; set; }
/// <summary>
///  set plane coupling (default false)
/// </summary>
public bool coupling { get; set; }
}
}
