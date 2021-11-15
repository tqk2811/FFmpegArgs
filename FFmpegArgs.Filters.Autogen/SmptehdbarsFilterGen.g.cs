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
public class SmptehdbarsFilterGen : SourceImageFilter
{
internal SmptehdbarsFilterGen(FilterGraph input) : base("smptehdbars",input) { AddMapOut(); }
/// <summary>
///  set video size (default "320x240")
/// </summary>
public SmptehdbarsFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video size (default "320x240")
/// </summary>
public SmptehdbarsFilterGen s(Size size) => this.SetOption("s",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public SmptehdbarsFilterGen Rate(string r) => this.SetOption("rate", r);
/// <summary>
///  set video rate (default "25")
/// </summary>
public SmptehdbarsFilterGen rate(int r) => this.SetOptionRange("rate", r, 1, int.MaxValue);
/// <summary>
///  set video rate (default "25")
/// </summary>
public SmptehdbarsFilterGen R(string r) => this.SetOption("r", r);
/// <summary>
///  set video rate (default "25")
/// </summary>
public SmptehdbarsFilterGen r(int r) => this.SetOptionRange("r", r, 1, int.MaxValue);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public SmptehdbarsFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public SmptehdbarsFilterGen d(TimeSpan d) => this.SetOptionRange("d",d,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public SmptehdbarsFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
public static class SmptehdbarsFilterGenExtensions
{
/// <summary>
/// Generate SMPTE HD color bars.
/// </summary>
public static SmptehdbarsFilterGen SmptehdbarsFilterGen(this FilterGraph input0) => new SmptehdbarsFilterGen(input0);
}
}
