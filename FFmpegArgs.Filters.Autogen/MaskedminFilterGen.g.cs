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
public class MaskedminFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal MaskedminFilterGen(params ImageMap[] inputs) : base("maskedmin",inputs) { AddMapOut(); }
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public MaskedminFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
public static class MaskedminFilterGenExtensions
{
/// <summary>
/// Apply filtering with minimum difference of two streams.
/// </summary>
public static MaskedminFilterGen MaskedminFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2) => new MaskedminFilterGen(input0, input1, input2);
/// <summary>
/// Apply filtering with minimum difference of two streams.
/// </summary>
public static MaskedminFilterGen MaskedminFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2,MaskedminFilterGenConfig config)
{
var result = new MaskedminFilterGen(input0, input1, input2);
if(config?.planes != null) result.planes(config.planes.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class MaskedminFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public int? planes { get; set; }
public string TimelineSupport { get; set; }
}
}
