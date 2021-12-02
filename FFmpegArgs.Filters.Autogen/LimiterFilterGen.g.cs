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
public class LimiterFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal LimiterFilterGen(ImageMap input) : base("limiter",input) { AddMapOut(); }
/// <summary>
///  set min value (from 0 to 65535) (default 0)
/// </summary>
public LimiterFilterGen min(int min) => this.SetOptionRange("min", min,0,65535);
/// <summary>
///  set max value (from 0 to 65535) (default 65535)
/// </summary>
public LimiterFilterGen max(int max) => this.SetOptionRange("max", max,0,65535);
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public LimiterFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
public static class LimiterFilterGenExtensions
{
/// <summary>
/// Limit pixels components to the specified range.
/// </summary>
public static LimiterFilterGen LimiterFilterGen(this ImageMap input0) => new LimiterFilterGen(input0);
/// <summary>
/// Limit pixels components to the specified range.
/// </summary>
public static LimiterFilterGen LimiterFilterGen(this ImageMap input0,LimiterFilterGenConfig config)
{
var result = new LimiterFilterGen(input0);
if(config?.min != null) result.min(config.min);
if(config?.max != null) result.max(config.max);
if(config?.planes != null) result.planes(config.planes);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class LimiterFilterGenConfig
{
/// <summary>
///  set min value (from 0 to 65535) (default 0)
/// </summary>
public int min { get; set; }
/// <summary>
///  set max value (from 0 to 65535) (default 65535)
/// </summary>
public int max { get; set; }
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public int planes { get; set; }
public string TimelineSupport { get; set; }
}
}
