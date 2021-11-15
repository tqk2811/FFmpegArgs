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
public class AllrgbFilterGen : SourceImageFilter
{
internal AllrgbFilterGen(FilterGraph input) : base("allrgb",input) { AddMapOut(); }
/// <summary>
///  set video rate (default "25")
/// </summary>
public AllrgbFilterGen Rate(string r) => this.SetOption("rate", r);
/// <summary>
///  set video rate (default "25")
/// </summary>
public AllrgbFilterGen rate(int r) => this.SetOptionRange("rate", r, 1, int.MaxValue);
/// <summary>
///  set video rate (default "25")
/// </summary>
public AllrgbFilterGen R(string r) => this.SetOption("r", r);
/// <summary>
///  set video rate (default "25")
/// </summary>
public AllrgbFilterGen r(int r) => this.SetOptionRange("r", r, 1, int.MaxValue);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public AllrgbFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public AllrgbFilterGen d(TimeSpan d) => this.SetOptionRange("d",d,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public AllrgbFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
public static class AllrgbFilterGenExtensions
{
/// <summary>
/// Generate all RGB colors.
/// </summary>
public static AllrgbFilterGen AllrgbFilterGen(this FilterGraph input0) => new AllrgbFilterGen(input0);
}
}
