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
public class Overlay_openclFilterGen : ImageToImageFilter
{
internal Overlay_openclFilterGen(params ImageMap[] inputs) : base("overlay_opencl",inputs) { AddMapOut(); }
/// <summary>
///  Overlay x position (from 0 to INT_MAX) (default 0)
/// </summary>
public Overlay_openclFilterGen x(int x) => this.SetOptionRange("x", x,0,INT_MAX);
/// <summary>
///  Overlay y position (from 0 to INT_MAX) (default 0)
/// </summary>
public Overlay_openclFilterGen y(int y) => this.SetOptionRange("y", y,0,INT_MAX);
}
public static class Overlay_openclFilterGenExtensions
{
/// <summary>
/// Overlay one video on top of another
/// </summary>
public static Overlay_openclFilterGen Overlay_openclFilterGen(this ImageMap input0, ImageMap input1) => new Overlay_openclFilterGen(input0, input1);
}
}
