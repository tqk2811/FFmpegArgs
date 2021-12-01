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
public class Program_openclFilterGen : SourceImageFilter
{
internal Program_openclFilterGen(FilterGraph input) : base("program_opencl",input) { AddMapOut(); }
/// <summary>
///  OpenCL program source file
/// </summary>
public Program_openclFilterGen source(string source) => this.SetOption("source",source);
/// <summary>
///  Kernel name in program
/// </summary>
public Program_openclFilterGen kernel(string kernel) => this.SetOption("kernel",kernel);
/// <summary>
///  Number of inputs (from 1 to INT_MAX) (default 1)
/// </summary>
public Program_openclFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs,1,INT_MAX);
/// <summary>
///  Video size
/// </summary>
public Program_openclFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
}
public static class Program_openclFilterGenExtensions
{
/// <summary>
/// Filter video using an OpenCL program
/// </summary>
public static Program_openclFilterGen Program_openclFilterGen(this FilterGraph input0) => new Program_openclFilterGen(input0);
}
}
