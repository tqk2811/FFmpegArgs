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
///  Video format (default none)
/// </summary>
public OpenclsrcFilterGen format(PixFmt format) => this.SetOption("format",format.ToString());
/// <summary>
///  Video frame rate (default "25")
/// </summary>
public OpenclsrcFilterGen rate(Rational rate) => this.SetOption("rate",rate);
}
public static class OpenclsrcFilterGenExtensions
{
/// <summary>
/// Generate video using an OpenCL program
/// </summary>
public static OpenclsrcFilterGen OpenclsrcFilterGen(this FilterGraph input0) => new OpenclsrcFilterGen(input0);
/// <summary>
/// Generate video using an OpenCL program
/// </summary>
public static OpenclsrcFilterGen OpenclsrcFilterGen(this FilterGraph input0,OpenclsrcFilterGenConfig config)
{
var result = new OpenclsrcFilterGen(input0);
if(config?.source != null) result.source(config.source);
if(config?.kernel != null) result.kernel(config.kernel);
if(config?.size != null) result.size(config.size);
if(config?.format != null) result.format(config.format);
if(config?.rate != null) result.rate(config.rate);
return result;
}
}
public class OpenclsrcFilterGenConfig
{
/// <summary>
///  OpenCL program source file
/// </summary>
public string source { get; set; }
/// <summary>
///  Kernel name in program
/// </summary>
public string kernel { get; set; }
/// <summary>
///  Video size
/// </summary>
public Size size { get; set; }
/// <summary>
///  Video format (default none)
/// </summary>
public PixFmt format { get; set; }
/// <summary>
///  Video frame rate (default "25")
/// </summary>
public Rational rate { get; set; }
}
}
