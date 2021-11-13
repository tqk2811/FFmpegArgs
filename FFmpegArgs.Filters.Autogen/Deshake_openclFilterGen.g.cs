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
public class Deshake_openclFilterGen : ImageToImageFilter
{
internal Deshake_openclFilterGen(ImageMap input) : base("deshake_opencl",input) { AddMapOut(); }
/// <summary>
///  simulates a tripod by preventing any camera movement whatsoever from the original frame (default false)
/// </summary>
public Deshake_openclFilterGen tripod(bool flag) => this.SetOption("tripod",flag.ToFFmpegFlag());
/// <summary>
///  turn on additional debugging information (default false)
/// </summary>
public Deshake_openclFilterGen debug(bool flag) => this.SetOption("debug",flag.ToFFmpegFlag());
/// <summary>
///  attempt to subtly crop borders to reduce mirrored content (default true)
/// </summary>
public Deshake_openclFilterGen adaptive_crop(bool flag) => this.SetOption("adaptive_crop",flag.ToFFmpegFlag());
/// <summary>
///  refine feature point locations at a sub-pixel level (default true)
/// </summary>
public Deshake_openclFilterGen refine_features(bool flag) => this.SetOption("refine_features",flag.ToFFmpegFlag());
/// <summary>
///  smoothing strength (0 attempts to adaptively determine optimal strength) (from 0 to 1) (default 0)
/// </summary>
public Deshake_openclFilterGen smooth_strength(float smooth_strength) => this.SetOptionRange("smooth_strength", smooth_strength,0,1);
/// <summary>
///  multiplier for number of frames to buffer for motion data (from 0.1 to 10) (default 2)
/// </summary>
public Deshake_openclFilterGen smooth_window_multiplier(float smooth_window_multiplier) => this.SetOptionRange("smooth_window_multiplier", smooth_window_multiplier,0.1,10);
}
public static class Deshake_openclFilterGenExtensions
{
/// <summary>
/// Feature-point based video stabilization filter
/// </summary>
public static Deshake_openclFilterGen Deshake_openclFilterGen(this ImageMap input) => new Deshake_openclFilterGen(input);
}
}
