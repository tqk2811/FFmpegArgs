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
public class OscilloscopeFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal OscilloscopeFilterGen(ImageMap input) : base("oscilloscope",input) { AddMapOut(); }
/// <summary>
///  set scope x position (from 0 to 1) (default 0.5)
/// </summary>
public OscilloscopeFilterGen x(float x) => this.SetOptionRange("x", x,0,1);
/// <summary>
///  set scope y position (from 0 to 1) (default 0.5)
/// </summary>
public OscilloscopeFilterGen y(float y) => this.SetOptionRange("y", y,0,1);
/// <summary>
///  set scope size (from 0 to 1) (default 0.8)
/// </summary>
public OscilloscopeFilterGen s(float s) => this.SetOptionRange("s", s,0,1);
/// <summary>
///  set scope tilt (from 0 to 1) (default 0.5)
/// </summary>
public OscilloscopeFilterGen t(float t) => this.SetOptionRange("t", t,0,1);
/// <summary>
///  set trace opacity (from 0 to 1) (default 0.8)
/// </summary>
public OscilloscopeFilterGen o(float o) => this.SetOptionRange("o", o,0,1);
/// <summary>
///  set trace x position (from 0 to 1) (default 0.5)
/// </summary>
public OscilloscopeFilterGen tx(float tx) => this.SetOptionRange("tx", tx,0,1);
/// <summary>
///  set trace y position (from 0 to 1) (default 0.9)
/// </summary>
public OscilloscopeFilterGen ty(float ty) => this.SetOptionRange("ty", ty,0,1);
/// <summary>
///  set trace width (from 0.1 to 1) (default 0.8)
/// </summary>
public OscilloscopeFilterGen tw(float tw) => this.SetOptionRange("tw", tw,0.1,1);
/// <summary>
///  set trace height (from 0.1 to 1) (default 0.3)
/// </summary>
public OscilloscopeFilterGen th(float th) => this.SetOptionRange("th", th,0.1,1);
/// <summary>
///  set components to trace (from 0 to 15) (default 7)
/// </summary>
public OscilloscopeFilterGen c(int c) => this.SetOptionRange("c", c,0,15);
/// <summary>
///  draw trace grid (default true)
/// </summary>
public OscilloscopeFilterGen g(bool g) => this.SetOption("g",g.ToFFmpegFlag());
/// <summary>
///  draw statistics (default true)
/// </summary>
public OscilloscopeFilterGen st(bool st) => this.SetOption("st",st.ToFFmpegFlag());
/// <summary>
///  draw scope (default true)
/// </summary>
public OscilloscopeFilterGen sc(bool sc) => this.SetOption("sc",sc.ToFFmpegFlag());
}
public static class OscilloscopeFilterGenExtensions
{
/// <summary>
/// 2D Video Oscilloscope.
/// </summary>
public static OscilloscopeFilterGen OscilloscopeFilterGen(this ImageMap input0) => new OscilloscopeFilterGen(input0);
/// <summary>
/// 2D Video Oscilloscope.
/// </summary>
public static OscilloscopeFilterGen OscilloscopeFilterGen(this ImageMap input0,OscilloscopeFilterGenConfig config)
{
var result = new OscilloscopeFilterGen(input0);
if(config?.x != null) result.x(config.x.Value);
if(config?.y != null) result.y(config.y.Value);
if(config?.s != null) result.s(config.s.Value);
if(config?.t != null) result.t(config.t.Value);
if(config?.o != null) result.o(config.o.Value);
if(config?.tx != null) result.tx(config.tx.Value);
if(config?.ty != null) result.ty(config.ty.Value);
if(config?.tw != null) result.tw(config.tw.Value);
if(config?.th != null) result.th(config.th.Value);
if(config?.c != null) result.c(config.c.Value);
if(config?.g != null) result.g(config.g.Value);
if(config?.st != null) result.st(config.st.Value);
if(config?.sc != null) result.sc(config.sc.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class OscilloscopeFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set scope x position (from 0 to 1) (default 0.5)
/// </summary>
public float? x { get; set; }
/// <summary>
///  set scope y position (from 0 to 1) (default 0.5)
/// </summary>
public float? y { get; set; }
/// <summary>
///  set scope size (from 0 to 1) (default 0.8)
/// </summary>
public float? s { get; set; }
/// <summary>
///  set scope tilt (from 0 to 1) (default 0.5)
/// </summary>
public float? t { get; set; }
/// <summary>
///  set trace opacity (from 0 to 1) (default 0.8)
/// </summary>
public float? o { get; set; }
/// <summary>
///  set trace x position (from 0 to 1) (default 0.5)
/// </summary>
public float? tx { get; set; }
/// <summary>
///  set trace y position (from 0 to 1) (default 0.9)
/// </summary>
public float? ty { get; set; }
/// <summary>
///  set trace width (from 0.1 to 1) (default 0.8)
/// </summary>
public float? tw { get; set; }
/// <summary>
///  set trace height (from 0.1 to 1) (default 0.3)
/// </summary>
public float? th { get; set; }
/// <summary>
///  set components to trace (from 0 to 15) (default 7)
/// </summary>
public int? c { get; set; }
/// <summary>
///  draw trace grid (default true)
/// </summary>
public bool? g { get; set; }
/// <summary>
///  draw statistics (default true)
/// </summary>
public bool? st { get; set; }
/// <summary>
///  draw scope (default true)
/// </summary>
public bool? sc { get; set; }
public string TimelineSupport { get; set; }
}
}
