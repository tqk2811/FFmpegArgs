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
public class Testsrc2FilterGen : SourceImageFilter
{
internal Testsrc2FilterGen(FilterGraph input) : base("testsrc2",input) { AddMapOut(); }
/// <summary>
///  set video size (default "320x240")
/// </summary>
public Testsrc2FilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video size (default "320x240")
/// </summary>
public Testsrc2FilterGen s(Size size) => this.SetOption("s",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public Testsrc2FilterGen Rate(string r) => this.SetOption("rate", r);
/// <summary>
///  set video rate (default "25")
/// </summary>
public Testsrc2FilterGen rate(int r) => this.SetOptionRange("rate", r, 1, int.MaxValue);
/// <summary>
///  set video rate (default "25")
/// </summary>
public Testsrc2FilterGen R(string r) => this.SetOption("r", r);
/// <summary>
///  set video rate (default "25")
/// </summary>
public Testsrc2FilterGen r(int r) => this.SetOptionRange("r", r, 1, int.MaxValue);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public Testsrc2FilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public Testsrc2FilterGen d(TimeSpan d) => this.SetOptionRange("d",d,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public Testsrc2FilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
/// <summary>
///  set global alpha (opacity) (from 0 to 255) (default 255)
/// </summary>
public Testsrc2FilterGen alpha(int alpha) => this.SetOptionRange("alpha", alpha,0,255);
}
public static class Testsrc2FilterGenExtensions
{
/// <summary>
/// Generate another test pattern.
/// </summary>
public static Testsrc2FilterGen Testsrc2FilterGen(this FilterGraph input0) => new Testsrc2FilterGen(input0);
}
}
