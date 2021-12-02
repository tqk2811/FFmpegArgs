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
public class MidequalizerFilterGen : ImageToImageFilter,ITimelineSupport
{
internal MidequalizerFilterGen(params ImageMap[] inputs) : base("midequalizer",inputs) { AddMapOut(); }
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public MidequalizerFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
public static class MidequalizerFilterGenExtensions
{
/// <summary>
/// Apply Midway Equalization.
/// </summary>
public static MidequalizerFilterGen MidequalizerFilterGen(this ImageMap input0, ImageMap input1) => new MidequalizerFilterGen(input0, input1);
/// <summary>
/// Apply Midway Equalization.
/// </summary>
public static MidequalizerFilterGen MidequalizerFilterGen(this ImageMap input0, ImageMap input1,MidequalizerFilterGenConfig config)
{
var result = new MidequalizerFilterGen(input0, input1);
if(config?.planes != null) result.planes(config.planes.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class MidequalizerFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public int? planes { get; set; }
public string TimelineSupport { get; set; }
}
}
