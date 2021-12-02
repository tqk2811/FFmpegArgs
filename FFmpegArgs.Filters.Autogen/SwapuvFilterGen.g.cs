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
public class SwapuvFilterGen : ImageToImageFilter,ITimelineSupport
{
internal SwapuvFilterGen(ImageMap input) : base("swapuv",input) { AddMapOut(); }
}
public static class SwapuvFilterGenExtensions
{
/// <summary>
/// Swap U and V components.
/// </summary>
public static SwapuvFilterGen SwapuvFilterGen(this ImageMap input0) => new SwapuvFilterGen(input0);
/// <summary>
/// Swap U and V components.
/// </summary>
public static SwapuvFilterGen SwapuvFilterGen(this ImageMap input0,SwapuvFilterGenConfig config)
{
var result = new SwapuvFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class SwapuvFilterGenConfig
{
public string TimelineSupport { get; set; }
}
}
