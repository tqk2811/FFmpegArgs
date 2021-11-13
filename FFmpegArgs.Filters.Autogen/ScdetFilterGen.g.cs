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
public class ScdetFilterGen : ImageToImageFilter
{
internal ScdetFilterGen(ImageMap input) : base("scdet",input) { AddMapOut(); }
/// <summary>
///  set scene change detect threshold (from 0 to 100) (default 10)
/// </summary>
public ScdetFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,0,100);
/// <summary>
///  set scene change detect threshold (from 0 to 100) (default 10)
/// </summary>
public ScdetFilterGen t(double t) => this.SetOptionRange("t", t,0,100);
/// <summary>
///  Set the flag to pass scene change frames (default false)
/// </summary>
public ScdetFilterGen sc_pass(bool flag) => this.SetOption("sc_pass",flag.ToFFmpegFlag());
/// <summary>
///  Set the flag to pass scene change frames (default false)
/// </summary>
public ScdetFilterGen s(bool flag) => this.SetOption("s",flag.ToFFmpegFlag());
}
public static class ScdetFilterGenExtensions
{
/// <summary>
/// Detect video scene change
/// </summary>
public static ScdetFilterGen ScdetFilterGen(this ImageMap input) => new ScdetFilterGen(input);
}
}
