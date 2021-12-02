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
public class NegateFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal NegateFilterGen(ImageMap input) : base("negate",input) { AddMapOut(); }
/// <summary>
///  (default false)
/// </summary>
public NegateFilterGen negate_alpha(bool negate_alpha) => this.SetOption("negate_alpha",negate_alpha.ToFFmpegFlag());
}
public static class NegateFilterGenExtensions
{
/// <summary>
/// Negate input video.
/// </summary>
public static NegateFilterGen NegateFilterGen(this ImageMap input0) => new NegateFilterGen(input0);
/// <summary>
/// Negate input video.
/// </summary>
public static NegateFilterGen NegateFilterGen(this ImageMap input0,NegateFilterGenConfig config)
{
var result = new NegateFilterGen(input0);
if(config?.negate_alpha != null) result.negate_alpha(config.negate_alpha.Value);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class NegateFilterGenConfig
{
/// <summary>
///  (default false)
/// </summary>
public bool? negate_alpha { get; set; }
public string TimelineSupport { get; set; }
}
}
