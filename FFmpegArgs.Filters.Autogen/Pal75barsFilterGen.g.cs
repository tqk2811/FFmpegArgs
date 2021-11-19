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
public class Pal75barsFilterGen : SourceImageFilter
{
internal Pal75barsFilterGen(FilterGraph input) : base("pal75bars",input) { AddMapOut(); }
/// <summary>
///  set video size (default "320x240")
/// </summary>
public Pal75barsFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video size (default "320x240")
/// </summary>
public Pal75barsFilterGen s(Size size) => this.SetOption("s",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public Pal75barsFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video rate (default "25")
/// </summary>
public Pal75barsFilterGen r(Rational r) => this.SetOption("r",r);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public Pal75barsFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public Pal75barsFilterGen d(TimeSpan d) => this.SetOptionRange("d",d,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public Pal75barsFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
public static class Pal75barsFilterGenExtensions
{
/// <summary>
/// Generate PAL 75% color bars.
/// </summary>
public static Pal75barsFilterGen Pal75barsFilterGen(this FilterGraph input0) => new Pal75barsFilterGen(input0);
}
}
