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
public class AllyuvFilterGen : SourceImageFilter
{
internal AllyuvFilterGen(FilterGraph input) : base("allyuv",input) { AddMapOut(); }
/// <summary>
///  set video rate (default "25")
/// </summary>
public AllyuvFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public AllyuvFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public AllyuvFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
public static class AllyuvFilterGenExtensions
{
/// <summary>
/// Generate all yuv colors.
/// </summary>
public static AllyuvFilterGen AllyuvFilterGen(this FilterGraph input0) => new AllyuvFilterGen(input0);
}
}
