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
public static LutyuvFilterGen LutyuvFilterGen(this ImageMap input) => new LutyuvFilterGen(input);
}
}
