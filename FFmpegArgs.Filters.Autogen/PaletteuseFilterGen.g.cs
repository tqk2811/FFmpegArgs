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
public class PaletteuseFilterGen : ImageToImageFilter
{
internal PaletteuseFilterGen(params ImageMap[] inputs) : base("paletteuse",inputs) { AddMapOut(); }
/// <summary>
///  select dithering mode (from 0 to 5) (default sierra2_4a)
/// </summary>
public PaletteuseFilterGen dither(PaletteuseFilterGenDither dither) => this.SetOption("dither", dither.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set scale for bayer dithering (from 0 to 5) (default 2)
/// </summary>
public PaletteuseFilterGen bayer_scale(int bayer_scale) => this.SetOptionRange("bayer_scale", bayer_scale,0,5);
/// <summary>
///  set frame difference mode (from 0 to 1) (default 0)
/// </summary>
public PaletteuseFilterGen diff_mode(PaletteuseFilterGenDiff_mode diff_mode) => this.SetOption("diff_mode", diff_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  take new palette for each output frame (default false)
/// </summary>
public PaletteuseFilterGen _new(bool flag) => this.SetOption("new",flag.ToFFmpegFlag());
/// <summary>
///  set the alpha threshold for transparency (from 0 to 255) (default 128)
/// </summary>
public PaletteuseFilterGen alpha_threshold(int alpha_threshold) => this.SetOptionRange("alpha_threshold", alpha_threshold,0,255);
/// <summary>
///  save Graphviz graph of the kdtree in specified file
/// </summary>
public PaletteuseFilterGen debug_kdtree(string debug_kdtree) => this.SetOption("debug_kdtree",debug_kdtree);
/// <summary>
///  set reverse colormap color search method (from 0 to 2) (default nns_iterative)
/// </summary>
public PaletteuseFilterGen color_search(PaletteuseFilterGenColor_search color_search) => this.SetOption("color_search", color_search.GetAttribute<NameAttribute>().Name);
/// <summary>
///  compute and print mean error (default false)
/// </summary>
public PaletteuseFilterGen mean_err(bool flag) => this.SetOption("mean_err",flag.ToFFmpegFlag());
/// <summary>
///  test color search accuracy (default false)
/// </summary>
public PaletteuseFilterGen debug_accuracy(bool flag) => this.SetOption("debug_accuracy",flag.ToFFmpegFlag());
}
public static class PaletteuseFilterGenExtensions
{
/// <summary>
/// Use a palette to downsample an input video stream.
/// </summary>
public static PaletteuseFilterGen PaletteuseFilterGen(this ImageMap input0, ImageMap input1) => new PaletteuseFilterGen(input0, input1);
}
public enum PaletteuseFilterGenDither
{
[Name("bayer")] bayer,
[Name("heckbert")] heckbert,
[Name("floyd_steinberg")] floyd_steinberg,
[Name("sierra2")] sierra2,
[Name("sierra2_4a")] sierra2_4a,
}

public enum PaletteuseFilterGenDiff_mode
{
[Name("rectangle")] rectangle,
}

public enum PaletteuseFilterGenColor_search
{
[Name("nns_iterative")] nns_iterative,
[Name("nns_recursive")] nns_recursive,
[Name("bruteforce")] bruteforce,
}

}
