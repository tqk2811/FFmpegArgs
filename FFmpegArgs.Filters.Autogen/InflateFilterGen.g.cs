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
public class InflateFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal InflateFilterGen(ImageMap input) : base("inflate",input) { AddMapOut(); }
/// <summary>
///  set threshold for 1st plane (from 0 to 65535) (default 65535)
/// </summary>
public InflateFilterGen threshold0(int threshold0) => this.SetOptionRange("threshold0", threshold0,0,65535);
/// <summary>
///  set threshold for 2nd plane (from 0 to 65535) (default 65535)
/// </summary>
public InflateFilterGen threshold1(int threshold1) => this.SetOptionRange("threshold1", threshold1,0,65535);
/// <summary>
///  set threshold for 3rd plane (from 0 to 65535) (default 65535)
/// </summary>
public InflateFilterGen threshold2(int threshold2) => this.SetOptionRange("threshold2", threshold2,0,65535);
/// <summary>
///  set threshold for 4th plane (from 0 to 65535) (default 65535)
/// </summary>
public InflateFilterGen threshold3(int threshold3) => this.SetOptionRange("threshold3", threshold3,0,65535);
}
public static class InflateFilterGenExtensions
{
/// <summary>
/// Apply inflate effect.
/// </summary>
public static InflateFilterGen InflateFilterGen(this ImageMap input0) => new InflateFilterGen(input0);
/// <summary>
/// Apply inflate effect.
/// </summary>
public static InflateFilterGen InflateFilterGen(this ImageMap input0,InflateFilterGenConfig config)
{
var result = new InflateFilterGen(input0);
if(config?.threshold0 != null) result.threshold0(config.threshold0.Value);
if(config?.threshold1 != null) result.threshold1(config.threshold1.Value);
if(config?.threshold2 != null) result.threshold2(config.threshold2.Value);
if(config?.threshold3 != null) result.threshold3(config.threshold3.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class InflateFilterGenConfig
{
/// <summary>
///  set threshold for 1st plane (from 0 to 65535) (default 65535)
/// </summary>
public int? threshold0 { get; set; }
/// <summary>
///  set threshold for 2nd plane (from 0 to 65535) (default 65535)
/// </summary>
public int? threshold1 { get; set; }
/// <summary>
///  set threshold for 3rd plane (from 0 to 65535) (default 65535)
/// </summary>
public int? threshold2 { get; set; }
/// <summary>
///  set threshold for 4th plane (from 0 to 65535) (default 65535)
/// </summary>
public int? threshold3 { get; set; }
public string TimelineSupport { get; set; }
}
}
