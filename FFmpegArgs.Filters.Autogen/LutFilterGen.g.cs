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
public class LutFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal LutFilterGen(ImageMap input) : base("lut",input) { AddMapOut(); }
/// <summary>
///  set component #0 expression (default "clipval")
/// </summary>
public LutFilterGen c0(string c0) => this.SetOption("c0",c0);
/// <summary>
///  set component #1 expression (default "clipval")
/// </summary>
public LutFilterGen c1(string c1) => this.SetOption("c1",c1);
/// <summary>
///  set component #2 expression (default "clipval")
/// </summary>
public LutFilterGen c2(string c2) => this.SetOption("c2",c2);
/// <summary>
///  set component #3 expression (default "clipval")
/// </summary>
public LutFilterGen c3(string c3) => this.SetOption("c3",c3);
/// <summary>
///  set Y expression (default "clipval")
/// </summary>
public LutFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  set U expression (default "clipval")
/// </summary>
public LutFilterGen u(string u) => this.SetOption("u",u);
/// <summary>
///  set V expression (default "clipval")
/// </summary>
public LutFilterGen v(string v) => this.SetOption("v",v);
/// <summary>
///  set R expression (default "clipval")
/// </summary>
public LutFilterGen r(string r) => this.SetOption("r",r);
/// <summary>
///  set G expression (default "clipval")
/// </summary>
public LutFilterGen g(string g) => this.SetOption("g",g);
/// <summary>
///  set B expression (default "clipval")
/// </summary>
public LutFilterGen b(string b) => this.SetOption("b",b);
/// <summary>
///  set A expression (default "clipval")
/// </summary>
public LutFilterGen a(string a) => this.SetOption("a",a);
}
public static class LutFilterGenExtensions
{
/// <summary>
/// Compute and apply a lookup table to the RGB/YUV input video.
/// </summary>
public static LutFilterGen LutFilterGen(this ImageMap input0) => new LutFilterGen(input0);
/// <summary>
/// Compute and apply a lookup table to the RGB/YUV input video.
/// </summary>
public static LutFilterGen LutFilterGen(this ImageMap input0,LutFilterGenConfig config)
{
var result = new LutFilterGen(input0);
if(config?.c0 != null) result.c0(config.c0);
if(config?.c1 != null) result.c1(config.c1);
if(config?.c2 != null) result.c2(config.c2);
if(config?.c3 != null) result.c3(config.c3);
if(config?.y != null) result.y(config.y);
if(config?.u != null) result.u(config.u);
if(config?.v != null) result.v(config.v);
if(config?.r != null) result.r(config.r);
if(config?.g != null) result.g(config.g);
if(config?.b != null) result.b(config.b);
if(config?.a != null) result.a(config.a);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class LutFilterGenConfig
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
