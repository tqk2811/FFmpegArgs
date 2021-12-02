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
public class HflipFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal HflipFilterGen(ImageMap input) : base("hflip",input) { AddMapOut(); }
}
public static class HflipFilterGenExtensions
{
/// <summary>
/// Horizontally flip the input video.
/// </summary>
public static HflipFilterGen HflipFilterGen(this ImageMap input0) => new HflipFilterGen(input0);
/// <summary>
/// Horizontally flip the input video.
/// </summary>
public static HflipFilterGen HflipFilterGen(this ImageMap input0,HflipFilterGenConfig config)
{
var result = new HflipFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class HflipFilterGenConfig
:ITimelineSupportConfig
{
public string TimelineSupport { get; set; }
}
}
