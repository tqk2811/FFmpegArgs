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
public class CasFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal CasFilterGen(ImageMap input) : base("cas",input) { AddMapOut(); }
/// <summary>
///  set the sharpening strength (from 0 to 1) (default 0)
/// </summary>
public CasFilterGen strength(float strength) => this.SetOptionRange("strength", strength,0,1);
/// <summary>
///  set what planes to filter (default 7)
/// </summary>
public CasFilterGen planes(CasFilterGenPlanes planes) => this.SetOption("planes", planes.GetAttribute<NameAttribute>().Name);
}
public static class CasFilterGenExtensions
{
/// <summary>
/// Contrast Adaptive Sharpen.
/// </summary>
public static CasFilterGen CasFilterGen(this ImageMap input0) => new CasFilterGen(input0);
/// <summary>
/// Contrast Adaptive Sharpen.
/// </summary>
public static CasFilterGen CasFilterGen(this ImageMap input0,CasFilterGenConfig config)
{
var result = new CasFilterGen(input0);
if(config?.strength != null) result.strength(config.strength);
if(config?.planes != null) result.planes(config.planes);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class CasFilterGenConfig
{
/// <summary>
///  set the sharpening strength (from 0 to 1) (default 0)
/// </summary>
public float strength { get; set; }
/// <summary>
///  set what planes to filter (default 7)
/// </summary>
public CasFilterGenPlanes planes { get; set; }
public string TimelineSupport { get; set; }
}
public enum CasFilterGenPlanes
{
}

}
