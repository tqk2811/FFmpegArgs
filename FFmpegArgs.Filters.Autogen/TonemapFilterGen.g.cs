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
public class TonemapFilterGen : ImageToImageFilter,ISliceThreading
{
internal TonemapFilterGen(ImageMap input) : base("tonemap",input) { AddMapOut(); }
/// <summary>
///  tonemap algorithm selection (from 0 to 6) (default none)
/// </summary>
public TonemapFilterGen tonemap(TonemapFilterGenTonemap tonemap) => this.SetOption("tonemap", tonemap.GetAttribute<NameAttribute>().Name);
/// <summary>
///  tonemap parameter (from DBL_MIN to DBL_MAX) (default nan)
/// </summary>
public TonemapFilterGen param(double param) => this.SetOptionRange("param", param,DBL_MIN,DBL_MAX);
/// <summary>
///  desaturation strength (from 0 to DBL_MAX) (default 2)
/// </summary>
public TonemapFilterGen desat(double desat) => this.SetOptionRange("desat", desat,0,DBL_MAX);
/// <summary>
///  signal peak override (from 0 to DBL_MAX) (default 0)
/// </summary>
public TonemapFilterGen peak(double peak) => this.SetOptionRange("peak", peak,0,DBL_MAX);
}
public static class TonemapFilterGenExtensions
{
/// <summary>
/// Conversion to/from different dynamic ranges.
/// </summary>
public static TonemapFilterGen TonemapFilterGen(this ImageMap input) => new TonemapFilterGen(input);
}
public enum TonemapFilterGenTonemap
{
[Name("none")] none,
[Name("linear")] linear,
[Name("gamma")] gamma,
[Name("clip")] clip,
[Name("reinhard")] reinhard,
[Name("hable")] hable,
[Name("mobius")] mobius,
}

}
