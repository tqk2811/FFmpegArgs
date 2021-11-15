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
public class NullsrcFilterGen : SourceImageFilter
{
internal NullsrcFilterGen(FilterGraph input) : base("nullsrc",input) { AddMapOut(); }
/// <summary>
///  set video size (default "320x240")
/// </summary>
public NullsrcFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video size (default "320x240")
/// </summary>
public NullsrcFilterGen s(Size size) => this.SetOption("s",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public NullsrcFilterGen Rate(string r) => this.SetOption("rate", r);
/// <summary>
///  set video rate (default "25")
/// </summary>
public NullsrcFilterGen rate(int r) => this.SetOptionRange("rate", r, 1, int.MaxValue);
/// <summary>
///  set video rate (default "25")
/// </summary>
public NullsrcFilterGen R(string r) => this.SetOption("r", r);
/// <summary>
///  set video rate (default "25")
/// </summary>
public NullsrcFilterGen r(int r) => this.SetOptionRange("r", r, 1, int.MaxValue);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public NullsrcFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public NullsrcFilterGen d(TimeSpan d) => this.SetOptionRange("d",d,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public NullsrcFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
public static class NullsrcFilterGenExtensions
{
/// <summary>
/// Null video source, return unprocessed video frames.
/// </summary>
public static NullsrcFilterGen NullsrcFilterGen(this FilterGraph input0) => new NullsrcFilterGen(input0);
}
}
