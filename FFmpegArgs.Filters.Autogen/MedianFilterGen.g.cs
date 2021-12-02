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
public class MedianFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal MedianFilterGen(ImageMap input) : base("median",input) { AddMapOut(); }
/// <summary>
///  set median radius (from 1 to 127) (default 1)
/// </summary>
public MedianFilterGen radius(int radius) => this.SetOptionRange("radius", radius,1,127);
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public MedianFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set median vertical radius (from 0 to 127) (default 0)
/// </summary>
public MedianFilterGen radiusV(int radiusV) => this.SetOptionRange("radiusV", radiusV,0,127);
/// <summary>
///  set median percentile (from 0 to 1) (default 0.5)
/// </summary>
public MedianFilterGen percentile(float percentile) => this.SetOptionRange("percentile", percentile,0,1);
}
public static class MedianFilterGenExtensions
{
/// <summary>
/// Apply Median filter.
/// </summary>
public static MedianFilterGen MedianFilterGen(this ImageMap input0) => new MedianFilterGen(input0);
/// <summary>
/// Apply Median filter.
/// </summary>
public static MedianFilterGen MedianFilterGen(this ImageMap input0,MedianFilterGenConfig config)
{
var result = new MedianFilterGen(input0);
if(config?.radius != null) result.radius(config.radius.Value);
if(config?.planes != null) result.planes(config.planes.Value);
if(config?.radiusV != null) result.radiusV(config.radiusV.Value);
if(config?.percentile != null) result.percentile(config.percentile.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class MedianFilterGenConfig
{
/// <summary>
///  set median radius (from 1 to 127) (default 1)
/// </summary>
public int? radius { get; set; }
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public int? planes { get; set; }
/// <summary>
///  set median vertical radius (from 0 to 127) (default 0)
/// </summary>
public int? radiusV { get; set; }
/// <summary>
///  set median percentile (from 0 to 1) (default 0.5)
/// </summary>
public float? percentile { get; set; }
public string TimelineSupport { get; set; }
}
}
