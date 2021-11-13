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
public class ShearFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ShearFilterGen(ImageMap input) : base("shear",input) { AddMapOut(); }
/// <summary>
///  set x shear factor (from -2 to 2) (default 0)
/// </summary>
public ShearFilterGen shx(float shx) => this.SetOptionRange("shx", shx,-2,2);
/// <summary>
///  set y shear factor (from -2 to 2) (default 0)
/// </summary>
public ShearFilterGen shy(float shy) => this.SetOptionRange("shy", shy,-2,2);
/// <summary>
///  set background fill color (default "black")
/// </summary>
public ShearFilterGen fillcolor(string fillcolor) => this.SetOption("fillcolor",fillcolor);
/// <summary>
///  set background fill color (default "black")
/// </summary>
public ShearFilterGen c(string c) => this.SetOption("c",c);
/// <summary>
///  set interpolation (from 0 to 1) (default bilinear)
/// </summary>
public ShearFilterGen interp(ShearFilterGenInterp interp) => this.SetOption("interp", interp.GetAttribute<NameAttribute>().Name);
}
public static class ShearFilterGenExtensions
{
/// <summary>
/// Shear transform the input image.
/// </summary>
public static ShearFilterGen ShearFilterGen(this ImageMap input0) => new ShearFilterGen(input0);
}
public enum ShearFilterGenInterp
{
[Name("nearest")] nearest,
[Name("bilinear")] bilinear,
}

}
