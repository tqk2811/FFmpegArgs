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
public class ScrollFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ScrollFilterGen(ImageMap input) : base("scroll",input) { AddMapOut(); }
/// <summary>
///  set the horizontal scrolling speed (from -1 to 1) (default 0)
/// </summary>
public ScrollFilterGen horizontal(float horizontal) => this.SetOptionRange("horizontal", horizontal,-1,1);
/// <summary>
///  set the vertical scrolling speed (from -1 to 1) (default 0)
/// </summary>
public ScrollFilterGen vertical(float vertical) => this.SetOptionRange("vertical", vertical,-1,1);
/// <summary>
///  set initial horizontal position (from 0 to 1) (default 0)
/// </summary>
public ScrollFilterGen hpos(float hpos) => this.SetOptionRange("hpos", hpos,0,1);
/// <summary>
///  set initial vertical position (from 0 to 1) (default 0)
/// </summary>
public ScrollFilterGen vpos(float vpos) => this.SetOptionRange("vpos", vpos,0,1);
}
public static class ScrollFilterGenExtensions
{
/// <summary>
/// Scroll input video.
/// </summary>
public static ScrollFilterGen ScrollFilterGen(this ImageMap input0) => new ScrollFilterGen(input0);
/// <summary>
/// Scroll input video.
/// </summary>
public static ScrollFilterGen ScrollFilterGen(this ImageMap input0,ScrollFilterGenConfig config)
{
var result = new ScrollFilterGen(input0);
if(config?.horizontal != null) result.horizontal(config.horizontal);
if(config?.vertical != null) result.vertical(config.vertical);
if(config?.hpos != null) result.hpos(config.hpos);
if(config?.vpos != null) result.vpos(config.vpos);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class ScrollFilterGenConfig
{
/// <summary>
///  set the horizontal scrolling speed (from -1 to 1) (default 0)
/// </summary>
public float horizontal { get; set; }
/// <summary>
///  set the vertical scrolling speed (from -1 to 1) (default 0)
/// </summary>
public float vertical { get; set; }
/// <summary>
///  set initial horizontal position (from 0 to 1) (default 0)
/// </summary>
public float hpos { get; set; }
/// <summary>
///  set initial vertical position (from 0 to 1) (default 0)
/// </summary>
public float vpos { get; set; }
public string TimelineSupport { get; set; }
}
}
