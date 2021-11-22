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
public class FramerateFilterGen : ImageToImageFilter,ISliceThreading
{
internal FramerateFilterGen(ImageMap input) : base("framerate",input) { AddMapOut(); }
/// <summary>
///  required output frames per second rate (default "50")
/// </summary>
public FramerateFilterGen fps(Rational fps) => this.SetOption("fps",fps);
/// <summary>
///  point to start linear interpolation (from 0 to 255) (default 15)
/// </summary>
public FramerateFilterGen interp_start(int interp_start) => this.SetOptionRange("interp_start", interp_start,0,255);
/// <summary>
///  point to end linear interpolation (from 0 to 255) (default 240)
/// </summary>
public FramerateFilterGen interp_end(int interp_end) => this.SetOptionRange("interp_end", interp_end,0,255);
/// <summary>
///  scene change level (from 0 to 100) (default 8.2)
/// </summary>
public FramerateFilterGen scene(double scene) => this.SetOptionRange("scene", scene,0,100);
/// <summary>
///  set flags (default scene_change_detect+scd)
/// </summary>
public FramerateFilterGen flags(FramerateFilterGenFlags flags) => this.SetOption("flags", flags.GetAttribute<NameAttribute>().Name);
}
public static class FramerateFilterGenExtensions
{
/// <summary>
/// Upsamples or downsamples progressive source between specified frame rates.
/// </summary>
public static FramerateFilterGen FramerateFilterGen(this ImageMap input0) => new FramerateFilterGen(input0);
}
public enum FramerateFilterGenFlags
{
[Name("scene_change_detect")] scene_change_detect,
[Name("scd")] scd,
}

}