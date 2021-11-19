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
public class YuvtestsrcFilterGen : SourceImageFilter
{
internal YuvtestsrcFilterGen(FilterGraph input) : base("yuvtestsrc",input) { AddMapOut(); }
/// <summary>
///  set video size (default "320x240")
/// </summary>
public YuvtestsrcFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video size (default "320x240")
/// </summary>
public YuvtestsrcFilterGen s(Size size) => this.SetOption("s",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public YuvtestsrcFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video rate (default "25")
/// </summary>
public YuvtestsrcFilterGen r(Rational r) => this.SetOption("r",r);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public YuvtestsrcFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public YuvtestsrcFilterGen d(TimeSpan d) => this.SetOptionRange("d",d,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public YuvtestsrcFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
public static class YuvtestsrcFilterGenExtensions
{
/// <summary>
/// Generate YUV test pattern.
/// </summary>
public static YuvtestsrcFilterGen YuvtestsrcFilterGen(this FilterGraph input0) => new YuvtestsrcFilterGen(input0);
}
}
