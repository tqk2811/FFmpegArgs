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
public class Tlut2FilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal Tlut2FilterGen(ImageMap input) : base("tlut2",input) { AddMapOut(); }
/// <summary>
///  set component #0 expression (default "x")
/// </summary>
public Tlut2FilterGen c0(string c0) => this.SetOption("c0",c0);
/// <summary>
///  set component #1 expression (default "x")
/// </summary>
public Tlut2FilterGen c1(string c1) => this.SetOption("c1",c1);
/// <summary>
///  set component #2 expression (default "x")
/// </summary>
public Tlut2FilterGen c2(string c2) => this.SetOption("c2",c2);
/// <summary>
///  set component #3 expression (default "x")
/// </summary>
public Tlut2FilterGen c3(string c3) => this.SetOption("c3",c3);
}
public static class Tlut2FilterGenExtensions
{
/// <summary>
/// Compute and apply a lookup table from two successive frames.
/// </summary>
public static Tlut2FilterGen Tlut2FilterGen(this ImageMap input0) => new Tlut2FilterGen(input0);
/// <summary>
/// Compute and apply a lookup table from two successive frames.
/// </summary>
public static Tlut2FilterGen Tlut2FilterGen(this ImageMap input0,Tlut2FilterGenConfig config)
{
var result = new Tlut2FilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.c0)) result.c0(config.c0);
if(!string.IsNullOrWhiteSpace(config?.c1)) result.c1(config.c1);
if(!string.IsNullOrWhiteSpace(config?.c2)) result.c2(config.c2);
if(!string.IsNullOrWhiteSpace(config?.c3)) result.c3(config.c3);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class Tlut2FilterGenConfig
{
/// <summary>
///  set component #0 expression (default "x")
/// </summary>
public string c0 { get; set; }
/// <summary>
///  set component #1 expression (default "x")
/// </summary>
public string c1 { get; set; }
/// <summary>
///  set component #2 expression (default "x")
/// </summary>
public string c2 { get; set; }
/// <summary>
///  set component #3 expression (default "x")
/// </summary>
public string c3 { get; set; }
public string TimelineSupport { get; set; }
}
}
