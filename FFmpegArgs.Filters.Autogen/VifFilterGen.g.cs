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
public class VifFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal VifFilterGen(params ImageMap[] inputs) : base("vif",inputs) { AddMapOut(); }
}
public static class VifFilterGenExtensions
{
/// <summary>
/// Calculate the VIF between two video streams.
/// </summary>
public static VifFilterGen VifFilterGen(this ImageMap input0, ImageMap input1) => new VifFilterGen(input0, input1);
/// <summary>
/// Calculate the VIF between two video streams.
/// </summary>
public static VifFilterGen VifFilterGen(this ImageMap input0, ImageMap input1,VifFilterGenConfig config)
{
var result = new VifFilterGen(input0, input1);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class VifFilterGenConfig
{
public string TimelineSupport { get; set; }
}
}
