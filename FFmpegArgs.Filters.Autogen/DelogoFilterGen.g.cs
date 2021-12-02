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
public class DelogoFilterGen : ImageToImageFilter,ITimelineSupport
{
internal DelogoFilterGen(ImageMap input) : base("delogo",input) { AddMapOut(); }
/// <summary>
///  set logo x position (default "-1")
/// </summary>
public DelogoFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  set logo y position (default "-1")
/// </summary>
public DelogoFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  set logo width (default "-1")
/// </summary>
public DelogoFilterGen w(string w) => this.SetOption("w",w);
/// <summary>
///  set logo height (default "-1")
/// </summary>
public DelogoFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  show delogo area (default false)
/// </summary>
public DelogoFilterGen show(bool show) => this.SetOption("show",show.ToFFmpegFlag());
}
public static class DelogoFilterGenExtensions
{
/// <summary>
/// Remove logo from input video.
/// </summary>
public static DelogoFilterGen DelogoFilterGen(this ImageMap input0) => new DelogoFilterGen(input0);
/// <summary>
/// Remove logo from input video.
/// </summary>
public static DelogoFilterGen DelogoFilterGen(this ImageMap input0,DelogoFilterGenConfig config)
{
var result = new DelogoFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.x)) result.x(config.x);
if(!string.IsNullOrWhiteSpace(config?.y)) result.y(config.y);
if(!string.IsNullOrWhiteSpace(config?.w)) result.w(config.w);
if(!string.IsNullOrWhiteSpace(config?.h)) result.h(config.h);
if(config?.show != null) result.show(config.show.Value);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class DelogoFilterGenConfig
{
/// <summary>
///  set logo x position (default "-1")
/// </summary>
public string x { get; set; }
/// <summary>
///  set logo y position (default "-1")
/// </summary>
public string y { get; set; }
/// <summary>
///  set logo width (default "-1")
/// </summary>
public string w { get; set; }
/// <summary>
///  set logo height (default "-1")
/// </summary>
public string h { get; set; }
/// <summary>
///  show delogo area (default false)
/// </summary>
public bool? show { get; set; }
public string TimelineSupport { get; set; }
}
}
