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
public class HueFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal HueFilterGen(ImageMap input) : base("hue",input) { AddMapOut(); }
/// <summary>
///  set the hue angle degrees expression
/// </summary>
public HueFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  set the saturation expression (default "1")
/// </summary>
public HueFilterGen s(string s) => this.SetOption("s",s);
/// <summary>
///  set the hue angle radians expression
/// </summary>
public HueFilterGen H(string H) => this.SetOption("H",H);
/// <summary>
///  set the brightness expression (default "0")
/// </summary>
public HueFilterGen b(string b) => this.SetOption("b",b);
}
public static class HueFilterGenExtensions
{
/// <summary>
/// Adjust the hue and saturation of the input video.
/// </summary>
public static HueFilterGen HueFilterGen(this ImageMap input0) => new HueFilterGen(input0);
/// <summary>
/// Adjust the hue and saturation of the input video.
/// </summary>
public static HueFilterGen HueFilterGen(this ImageMap input0,HueFilterGenConfig config)
{
var result = new HueFilterGen(input0);
if(config?.h != null) result.h(config.h);
if(config?.s != null) result.s(config.s);
if(config?.H != null) result.H(config.H);
if(config?.b != null) result.b(config.b);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class HueFilterGenConfig
{
/// <summary>
///  set the hue angle degrees expression
/// </summary>
public string h { get; set; }
/// <summary>
///  set the saturation expression (default "1")
/// </summary>
public string s { get; set; }
/// <summary>
///  set the hue angle radians expression
/// </summary>
public string H { get; set; }
/// <summary>
///  set the brightness expression (default "0")
/// </summary>
public string b { get; set; }
public string TimelineSupport { get; set; }
}
}
