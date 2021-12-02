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
public class PixscopeFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal PixscopeFilterGen(ImageMap input) : base("pixscope",input) { AddMapOut(); }
/// <summary>
///  set scope x offset (from 0 to 1) (default 0.5)
/// </summary>
public PixscopeFilterGen x(float x) => this.SetOptionRange("x", x,0,1);
/// <summary>
///  set scope y offset (from 0 to 1) (default 0.5)
/// </summary>
public PixscopeFilterGen y(float y) => this.SetOptionRange("y", y,0,1);
/// <summary>
///  set scope width (from 1 to 80) (default 7)
/// </summary>
public PixscopeFilterGen w(int w) => this.SetOptionRange("w", w,1,80);
/// <summary>
///  set scope height (from 1 to 80) (default 7)
/// </summary>
public PixscopeFilterGen h(int h) => this.SetOptionRange("h", h,1,80);
/// <summary>
///  set window opacity (from 0 to 1) (default 0.5)
/// </summary>
public PixscopeFilterGen o(float o) => this.SetOptionRange("o", o,0,1);
/// <summary>
///  set window x offset (from -1 to 1) (default -1)
/// </summary>
public PixscopeFilterGen wx(float wx) => this.SetOptionRange("wx", wx,-1,1);
/// <summary>
///  set window y offset (from -1 to 1) (default -1)
/// </summary>
public PixscopeFilterGen wy(float wy) => this.SetOptionRange("wy", wy,-1,1);
}
public static class PixscopeFilterGenExtensions
{
/// <summary>
/// Pixel data analysis.
/// </summary>
public static PixscopeFilterGen PixscopeFilterGen(this ImageMap input0) => new PixscopeFilterGen(input0);
/// <summary>
/// Pixel data analysis.
/// </summary>
public static PixscopeFilterGen PixscopeFilterGen(this ImageMap input0,PixscopeFilterGenConfig config)
{
var result = new PixscopeFilterGen(input0);
if(config?.x != null) result.x(config.x);
if(config?.y != null) result.y(config.y);
if(config?.w != null) result.w(config.w);
if(config?.h != null) result.h(config.h);
if(config?.o != null) result.o(config.o);
if(config?.wx != null) result.wx(config.wx);
if(config?.wy != null) result.wy(config.wy);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class PixscopeFilterGenConfig
{
/// <summary>
///  set scope x offset (from 0 to 1) (default 0.5)
/// </summary>
public float x { get; set; }
/// <summary>
///  set scope y offset (from 0 to 1) (default 0.5)
/// </summary>
public float y { get; set; }
/// <summary>
///  set scope width (from 1 to 80) (default 7)
/// </summary>
public int w { get; set; }
/// <summary>
///  set scope height (from 1 to 80) (default 7)
/// </summary>
public int h { get; set; }
/// <summary>
///  set window opacity (from 0 to 1) (default 0.5)
/// </summary>
public float o { get; set; }
/// <summary>
///  set window x offset (from -1 to 1) (default -1)
/// </summary>
public float wx { get; set; }
/// <summary>
///  set window y offset (from -1 to 1) (default -1)
/// </summary>
public float wy { get; set; }
public string TimelineSupport { get; set; }
}
}
