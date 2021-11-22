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
public class DblurFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal DblurFilterGen(ImageMap input) : base("dblur",input) { AddMapOut(); }
/// <summary>
///  set angle (from 0 to 360) (default 45)
/// </summary>
public DblurFilterGen angle(float angle) => this.SetOptionRange("angle", angle,0,360);
/// <summary>
///  set radius (from 1 to 8192) (default 5)
/// </summary>
public DblurFilterGen radius(float radius) => this.SetOptionRange("radius", radius,1,8192);
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public DblurFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
public static class DblurFilterGenExtensions
{
/// <summary>
/// Apply Directional Blur filter.
/// </summary>
public static DblurFilterGen DblurFilterGen(this ImageMap input0) => new DblurFilterGen(input0);
}
}