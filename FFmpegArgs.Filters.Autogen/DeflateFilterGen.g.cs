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
public class DeflateFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal DeflateFilterGen(ImageMap input) : base("deflate",input) { AddMapOut(); }
/// <summary>
///  set threshold for 1st plane (from 0 to 65535) (default 65535)
/// </summary>
public DeflateFilterGen threshold0(int threshold0) => this.SetOptionRange("threshold0", threshold0,0,65535);
/// <summary>
///  set threshold for 2nd plane (from 0 to 65535) (default 65535)
/// </summary>
public DeflateFilterGen threshold1(int threshold1) => this.SetOptionRange("threshold1", threshold1,0,65535);
/// <summary>
///  set threshold for 3rd plane (from 0 to 65535) (default 65535)
/// </summary>
public DeflateFilterGen threshold2(int threshold2) => this.SetOptionRange("threshold2", threshold2,0,65535);
/// <summary>
///  set threshold for 4th plane (from 0 to 65535) (default 65535)
/// </summary>
public DeflateFilterGen threshold3(int threshold3) => this.SetOptionRange("threshold3", threshold3,0,65535);
}
public static class DeflateFilterGenExtensions
{
/// <summary>
/// Apply deflate effect.
/// </summary>
public static DeflateFilterGen DeflateFilterGen(this ImageMap input0) => new DeflateFilterGen(input0);
/// <summary>
/// Apply deflate effect.
/// </summary>
public static DeflateFilterGen DeflateFilterGen(this ImageMap input0,DeflateFilterGenConfig config)
{
var result = new DeflateFilterGen(input0);
if(config?.threshold0 != null) result.threshold0(config.threshold0);
if(config?.threshold1 != null) result.threshold1(config.threshold1);
if(config?.threshold2 != null) result.threshold2(config.threshold2);
if(config?.threshold3 != null) result.threshold3(config.threshold3);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class DeflateFilterGenConfig
{
/// <summary>
///  set threshold for 1st plane (from 0 to 65535) (default 65535)
/// </summary>
public int threshold0 { get; set; }
/// <summary>
///  set threshold for 2nd plane (from 0 to 65535) (default 65535)
/// </summary>
public int threshold1 { get; set; }
/// <summary>
///  set threshold for 3rd plane (from 0 to 65535) (default 65535)
/// </summary>
public int threshold2 { get; set; }
/// <summary>
///  set threshold for 4th plane (from 0 to 65535) (default 65535)
/// </summary>
public int threshold3 { get; set; }
public string TimelineSupport { get; set; }
}
}
