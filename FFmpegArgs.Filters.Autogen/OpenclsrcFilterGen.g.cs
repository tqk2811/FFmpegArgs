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
public class OpenclsrcFilterGen : SourceImageFilter
{
internal OpenclsrcFilterGen(FilterGraph input) : base("openclsrc",input) { AddMapOut(); }
/// <summary>
///  OpenCL program source file
/// </summary>
public OpenclsrcFilterGen source(string source) => this.SetOption("source",source);
/// <summary>
///  Kernel name in program
/// </summary>
public OpenclsrcFilterGen kernel(string kernel) => this.SetOption("kernel",kernel);
/// <summary>
///  Video size
/// </summary>
public OpenclsrcFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  Video size
/// </summary>
public OpenclsrcFilterGen s(Size size) => this.SetOption("s",$"{size.Width}x{size.Height}");
/// <summary>
///  Video format (default none)
/// </summary>
public OpenclsrcFilterGen format(PixFmt format) => this.SetOption("format",format.ToString());
/// <summary>
///  Video frame rate (default "25")
/// </summary>
public OpenclsrcFilterGen Rate(string r) => this.SetOption("rate", r);
/// <summary>
///  Video frame rate (default "25")
/// </summary>
public OpenclsrcFilterGen rate(int r) => this.SetOptionRange("rate", r, 1, int.MaxValue);
/// <summary>
///  Video frame rate (default "25")
/// </summary>
public OpenclsrcFilterGen R(string r) => this.SetOption("r", r);
/// <summary>
///  Video frame rate (default "25")
/// </summary>
public OpenclsrcFilterGen r(int r) => this.SetOptionRange("r", r, 1, int.MaxValue);
}
public static class OpenclsrcFilterGenExtensions
{
/// <summary>
/// Generate video using an OpenCL program
/// </summary>
public static OpenclsrcFilterGen OpenclsrcFilterGen(this FilterGraph input0) => new OpenclsrcFilterGen(input0);
}
}
