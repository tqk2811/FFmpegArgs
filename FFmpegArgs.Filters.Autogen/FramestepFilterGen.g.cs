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
public class FramestepFilterGen : ImageToImageFilter,ITimelineSupport
{
internal FramestepFilterGen(ImageMap input) : base("framestep",input) { AddMapOut(); }
/// <summary>
///  set frame step (from 1 to INT_MAX) (default 1)
/// </summary>
public FramestepFilterGen step(int step) => this.SetOptionRange("step", step,1,INT_MAX);
}
public static class FramestepFilterGenExtensions
{
/// <summary>
/// Select one frame every N frames.
/// </summary>
public static FramestepFilterGen FramestepFilterGen(this ImageMap input0) => new FramestepFilterGen(input0);
/// <summary>
/// Select one frame every N frames.
/// </summary>
public static FramestepFilterGen FramestepFilterGen(this ImageMap input0,FramestepFilterGenConfig config)
{
var result = new FramestepFilterGen(input0);
if(config?.step != null) result.step(config.step);
return result;
}
}
public class FramestepFilterGenConfig
{
/// <summary>
///  set frame step (from 1 to INT_MAX) (default 1)
/// </summary>
public int step { get; set; }
}
}
