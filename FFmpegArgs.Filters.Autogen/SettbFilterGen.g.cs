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
public class SettbFilterGen : ImageToImageFilter
{
internal SettbFilterGen(ImageMap input) : base("settb",input) { AddMapOut(); }
/// <summary>
///  set expression determining the output timebase (default "intb")
/// </summary>
public SettbFilterGen expr(string expr) => this.SetOption("expr",expr);
/// <summary>
///  set expression determining the output timebase (default "intb")
/// </summary>
public SettbFilterGen tb(string tb) => this.SetOption("tb",tb);
}
public static class SettbFilterGenExtensions
{
/// <summary>
/// Set timebase for the video output link.
/// </summary>
public static SettbFilterGen SettbFilterGen(this ImageMap input0) => new SettbFilterGen(input0);
}
}
