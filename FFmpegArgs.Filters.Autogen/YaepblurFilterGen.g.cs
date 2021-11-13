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
public class YaepblurFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal YaepblurFilterGen(ImageMap input) : base("yaepblur",input) { AddMapOut(); }
/// <summary>
///  set window radius (from 0 to INT_MAX) (default 3)
/// </summary>
public YaepblurFilterGen radius(int radius) => this.SetOptionRange("radius", radius,0,INT_MAX);
/// <summary>
///  set window radius (from 0 to INT_MAX) (default 3)
/// </summary>
public YaepblurFilterGen r(int r) => this.SetOptionRange("r", r,0,INT_MAX);
/// <summary>
///  set planes to filter (from 0 to 15) (default 1)
/// </summary>
public YaepblurFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set planes to filter (from 0 to 15) (default 1)
/// </summary>
public YaepblurFilterGen p(int p) => this.SetOptionRange("p", p,0,15);
/// <summary>
///  set blur strength (from 1 to INT_MAX) (default 128)
/// </summary>
public YaepblurFilterGen sigma(int sigma) => this.SetOptionRange("sigma", sigma,1,INT_MAX);
/// <summary>
///  set blur strength (from 1 to INT_MAX) (default 128)
/// </summary>
public YaepblurFilterGen s(int s) => this.SetOptionRange("s", s,1,INT_MAX);
}
public static class YaepblurFilterGenExtensions
{
/// <summary>
/// Yet another edge preserving blur filter.
/// </summary>
public static YaepblurFilterGen YaepblurFilterGen(this ImageMap input0) => new YaepblurFilterGen(input0);
}
}
