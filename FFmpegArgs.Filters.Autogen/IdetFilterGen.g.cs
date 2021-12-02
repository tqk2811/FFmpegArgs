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
public class IdetFilterGen : ImageToImageFilter
{
internal IdetFilterGen(ImageMap input) : base("idet",input) { AddMapOut(); }
/// <summary>
///  set interlacing threshold (from -1 to FLT_MAX) (default 1.04)
/// </summary>
public IdetFilterGen intl_thres(float intl_thres) => this.SetOptionRange("intl_thres", intl_thres,-1,FLT_MAX);
/// <summary>
///  set progressive threshold (from -1 to FLT_MAX) (default 1.5)
/// </summary>
public IdetFilterGen prog_thres(float prog_thres) => this.SetOptionRange("prog_thres", prog_thres,-1,FLT_MAX);
/// <summary>
///  set repeat threshold (from -1 to FLT_MAX) (default 3)
/// </summary>
public IdetFilterGen rep_thres(float rep_thres) => this.SetOptionRange("rep_thres", rep_thres,-1,FLT_MAX);
/// <summary>
///  half life of cumulative statistics (from -1 to INT_MAX) (default 0)
/// </summary>
public IdetFilterGen half_life(float half_life) => this.SetOptionRange("half_life", half_life,-1,INT_MAX);
/// <summary>
///  set number of frames to use to determine if the interlace flag is accurate (from 0 to INT_MAX) (default 0)
/// </summary>
public IdetFilterGen analyze_interlaced_flag(int analyze_interlaced_flag) => this.SetOptionRange("analyze_interlaced_flag", analyze_interlaced_flag,0,INT_MAX);
}
public static class IdetFilterGenExtensions
{
/// <summary>
/// Interlace detect Filter.
/// </summary>
public static IdetFilterGen IdetFilterGen(this ImageMap input0) => new IdetFilterGen(input0);
/// <summary>
/// Interlace detect Filter.
/// </summary>
public static IdetFilterGen IdetFilterGen(this ImageMap input0,IdetFilterGenConfig config)
{
var result = new IdetFilterGen(input0);
if(config?.intl_thres != null) result.intl_thres(config.intl_thres);
if(config?.prog_thres != null) result.prog_thres(config.prog_thres);
if(config?.rep_thres != null) result.rep_thres(config.rep_thres);
if(config?.half_life != null) result.half_life(config.half_life);
if(config?.analyze_interlaced_flag != null) result.analyze_interlaced_flag(config.analyze_interlaced_flag);
return result;
}
}
public class IdetFilterGenConfig
{
/// <summary>
///  set interlacing threshold (from -1 to FLT_MAX) (default 1.04)
/// </summary>
public float intl_thres { get; set; }
/// <summary>
///  set progressive threshold (from -1 to FLT_MAX) (default 1.5)
/// </summary>
public float prog_thres { get; set; }
/// <summary>
///  set repeat threshold (from -1 to FLT_MAX) (default 3)
/// </summary>
public float rep_thres { get; set; }
/// <summary>
///  half life of cumulative statistics (from -1 to INT_MAX) (default 0)
/// </summary>
public float half_life { get; set; }
/// <summary>
///  set number of frames to use to determine if the interlace flag is accurate (from 0 to INT_MAX) (default 0)
/// </summary>
public int analyze_interlaced_flag { get; set; }
}
}
