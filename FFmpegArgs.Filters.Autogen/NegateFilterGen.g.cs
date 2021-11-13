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
public NegateFilterGen negate_alpha(bool flag) => this.SetOption("negate_alpha",flag.ToFFmpegFlag());
}
public static class NegateFilterGenExtensions
{
/// <summary>
/// Negate input video.
/// </summary>
public static NegateFilterGen NegateFilterGen(this ImageMap input0) => new NegateFilterGen(input0);
}
}
