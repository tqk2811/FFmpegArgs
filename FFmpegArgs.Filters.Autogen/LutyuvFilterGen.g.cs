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
public class LutyuvFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal LutyuvFilterGen(ImageMap input) : base("lutyuv",input) { AddMapOut(); }
/// <summary>
///  set component #0 expression (default "clipval")
/// </summary>
public LutyuvFilterGen c0(string c0) => this.SetOption("c0",c0);
/// <summary>
///  set component #1 expression (default "clipval")
/// </summary>
public LutyuvFilterGen c1(string c1) => this.SetOption("c1",c1);
/// <summary>
///  set component #2 expression (default "clipval")
/// </summary>
public LutyuvFilterGen c2(string c2) => this.SetOption("c2",c2);
/// <summary>
///  set component #3 expression (default "clipval")
/// </summary>
public LutyuvFilterGen c3(string c3) => this.SetOption("c3",c3);
/// <summary>
///  set Y expression (default "clipval")
/// </summary>
public LutyuvFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  set U expression (default "clipval")
/// </summary>
public LutyuvFilterGen u(string u) => this.SetOption("u",u);
/// <summary>
///  set V expression (default "clipval")
/// </summary>
public LutyuvFilterGen v(string v) => this.SetOption("v",v);
/// <summary>
///  set R expression (default "clipval")
/// </summary>
public LutyuvFilterGen r(string r) => this.SetOption("r",r);
/// <summary>
///  set G expression (default "clipval")
/// </summary>
public LutyuvFilterGen g(string g) => this.SetOption("g",g);
/// <summary>
///  set B expression (default "clipval")
/// </summary>
public LutyuvFilterGen b(string b) => this.SetOption("b",b);
/// <summary>
///  set A expression (default "clipval")
/// </summary>
public LutyuvFilterGen a(string a) => this.SetOption("a",a);
}
public static class LutyuvFilterGenExtensions
{
/// <summary>
/// Compute and apply a lookup table to the YUV input video.
/// </summary>
public static LutyuvFilterGen LutyuvFilterGen(this ImageMap input0) => new LutyuvFilterGen(input0);
/// <summary>
/// Compute and apply a lookup table to the YUV input video.
/// </summary>
public static LutyuvFilterGen LutyuvFilterGen(this ImageMap input0,LutyuvFilterGenConfig config)
{
var result = new LutyuvFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.c0)) result.c0(config.c0);
if(!string.IsNullOrWhiteSpace(config?.c1)) result.c1(config.c1);
if(!string.IsNullOrWhiteSpace(config?.c2)) result.c2(config.c2);
if(!string.IsNullOrWhiteSpace(config?.c3)) result.c3(config.c3);
if(!string.IsNullOrWhiteSpace(config?.y)) result.y(config.y);
if(!string.IsNullOrWhiteSpace(config?.u)) result.u(config.u);
if(!string.IsNullOrWhiteSpace(config?.v)) result.v(config.v);
if(!string.IsNullOrWhiteSpace(config?.r)) result.r(config.r);
if(!string.IsNullOrWhiteSpace(config?.g)) result.g(config.g);
if(!string.IsNullOrWhiteSpace(config?.b)) result.b(config.b);
if(!string.IsNullOrWhiteSpace(config?.a)) result.a(config.a);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class LutyuvFilterGenConfig
{
/// <summary>
///  set component #0 expression (default "clipval")
/// </summary>
public string c0 { get; set; }
/// <summary>
///  set component #1 expression (default "clipval")
/// </summary>
public string c1 { get; set; }
/// <summary>
///  set component #2 expression (default "clipval")
/// </summary>
public string c2 { get; set; }
/// <summary>
///  set component #3 expression (default "clipval")
/// </summary>
public string c3 { get; set; }
/// <summary>
///  set Y expression (default "clipval")
/// </summary>
public string y { get; set; }
/// <summary>
///  set U expression (default "clipval")
/// </summary>
public string u { get; set; }
/// <summary>
///  set V expression (default "clipval")
/// </summary>
public string v { get; set; }
/// <summary>
///  set R expression (default "clipval")
/// </summary>
public string r { get; set; }
/// <summary>
///  set G expression (default "clipval")
/// </summary>
public string g { get; set; }
/// <summary>
///  set B expression (default "clipval")
/// </summary>
public string b { get; set; }
/// <summary>
///  set A expression (default "clipval")
/// </summary>
public string a { get; set; }
public string TimelineSupport { get; set; }
}
}
