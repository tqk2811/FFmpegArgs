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
public class HysteresisFilterGen : ImageToImageFilter,ITimelineSupport
{
internal HysteresisFilterGen(params ImageMap[] inputs) : base("hysteresis",inputs) { AddMapOut(); }
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public HysteresisFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set threshold (from 0 to 65535) (default 0)
/// </summary>
public HysteresisFilterGen threshold(int threshold) => this.SetOptionRange("threshold", threshold,0,65535);
}
public static class HysteresisFilterGenExtensions
{
/// <summary>
/// Grow first stream into second stream by connecting components.
/// </summary>
public static HysteresisFilterGen HysteresisFilterGen(this ImageMap input0, ImageMap input1) => new HysteresisFilterGen(input0, input1);
/// <summary>
/// Grow first stream into second stream by connecting components.
/// </summary>
public static HysteresisFilterGen HysteresisFilterGen(this ImageMap input0, ImageMap input1,HysteresisFilterGenConfig config)
{
var result = new HysteresisFilterGen(input0, input1);
if(config?.planes != null) result.planes(config.planes);
if(config?.threshold != null) result.threshold(config.threshold);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class HysteresisFilterGenConfig
{
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public int planes { get; set; }
/// <summary>
///  set threshold (from 0 to 65535) (default 0)
/// </summary>
public int threshold { get; set; }
public string TimelineSupport { get; set; }
}
}
