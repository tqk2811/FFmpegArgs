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
public class RealtimeFilterGen : ImageToImageFilter
{
internal RealtimeFilterGen(ImageMap input) : base("realtime",input) { AddMapOut(); }
/// <summary>
///  sleep time limit (default 2)
/// </summary>
public RealtimeFilterGen limit(TimeSpan limit) => this.SetOptionRange("limit",limit,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  speed factor (from DBL_MIN to DBL_MAX) (default 1)
/// </summary>
public RealtimeFilterGen speed(double speed) => this.SetOptionRange("speed", speed,DBL_MIN,DBL_MAX);
}
public static class RealtimeFilterGenExtensions
{
/// <summary>
/// Slow down filtering to match realtime.
/// </summary>
public static RealtimeFilterGen RealtimeFilterGen(this ImageMap input) => new RealtimeFilterGen(input);
}
}
