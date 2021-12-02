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
public class ThresholdFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal ThresholdFilterGen(params ImageMap[] inputs) : base("threshold",inputs) { AddMapOut(); }
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public ThresholdFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
public static class ThresholdFilterGenExtensions
{
/// <summary>
/// Threshold first video stream using other video streams.
/// </summary>
public static ThresholdFilterGen ThresholdFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2, ImageMap input3) => new ThresholdFilterGen(input0, input1, input2, input3);
/// <summary>
/// Threshold first video stream using other video streams.
/// </summary>
public static ThresholdFilterGen ThresholdFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2, ImageMap input3,ThresholdFilterGenConfig config)
{
var result = new ThresholdFilterGen(input0, input1, input2, input3);
if(config?.planes != null) result.planes(config.planes);
return result;
}
}
public class ThresholdFilterGenConfig
{
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public int planes { get; set; }
}
}
