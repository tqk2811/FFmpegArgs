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
public class RgbtestsrcFilterGen : SourceImageFilter
{
internal RgbtestsrcFilterGen(FilterGraph input) : base("rgbtestsrc",input) { AddMapOut(); }
/// <summary>
///  set video size (default "320x240")
/// </summary>
public RgbtestsrcFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video size (default "320x240")
/// </summary>
public RgbtestsrcFilterGen s(Size size) => this.SetOption("s",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public RgbtestsrcFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video rate (default "25")
/// </summary>
public RgbtestsrcFilterGen r(Rational r) => this.SetOption("r",r);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public RgbtestsrcFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public RgbtestsrcFilterGen d(TimeSpan d) => this.SetOptionRange("d",d,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public RgbtestsrcFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
/// <summary>
///  set complement colors (default false)
/// </summary>
public RgbtestsrcFilterGen complement(bool flag) => this.SetOption("complement",flag.ToFFmpegFlag());
/// <summary>
///  set complement colors (default false)
/// </summary>
public RgbtestsrcFilterGen co(bool flag) => this.SetOption("co",flag.ToFFmpegFlag());
}
public static class RgbtestsrcFilterGenExtensions
{
/// <summary>
/// Generate RGB test pattern.
/// </summary>
public static RgbtestsrcFilterGen RgbtestsrcFilterGen(this FilterGraph input0) => new RgbtestsrcFilterGen(input0);
}
}
