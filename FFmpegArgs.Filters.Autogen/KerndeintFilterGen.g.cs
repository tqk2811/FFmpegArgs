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
public class KerndeintFilterGen : ImageToImageFilter
{
internal KerndeintFilterGen(ImageMap input) : base("kerndeint",input) { AddMapOut(); }
/// <summary>
///  set the threshold (from 0 to 255) (default 10)
/// </summary>
public KerndeintFilterGen thresh(int thresh) => this.SetOptionRange("thresh", thresh,0,255);
/// <summary>
///  set the map (default false)
/// </summary>
public KerndeintFilterGen map(bool flag) => this.SetOption("map",flag.ToFFmpegFlag());
/// <summary>
///  set the order (default false)
/// </summary>
public KerndeintFilterGen order(bool flag) => this.SetOption("order",flag.ToFFmpegFlag());
/// <summary>
///  set sharpening (default false)
/// </summary>
public KerndeintFilterGen sharp(bool flag) => this.SetOption("sharp",flag.ToFFmpegFlag());
/// <summary>
///  set twoway (default false)
/// </summary>
public KerndeintFilterGen twoway(bool flag) => this.SetOption("twoway",flag.ToFFmpegFlag());
}
public static class KerndeintFilterGenExtensions
{
/// <summary>
/// Apply kernel deinterlacing to the input.
/// </summary>
public static KerndeintFilterGen KerndeintFilterGen(this ImageMap input) => new KerndeintFilterGen(input);
}
}
