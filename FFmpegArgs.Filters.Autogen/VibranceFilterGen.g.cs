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
public class VibranceFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal VibranceFilterGen(ImageMap input) : base("vibrance",input) { AddMapOut(); }
/// <summary>
///  set the intensity value (from -2 to 2) (default 0)
/// </summary>
public VibranceFilterGen intensity(float intensity) => this.SetOptionRange("intensity", intensity,-2,2);
/// <summary>
///  set the red balance value (from -10 to 10) (default 1)
/// </summary>
public VibranceFilterGen rbal(float rbal) => this.SetOptionRange("rbal", rbal,-10,10);
/// <summary>
///  set the green balance value (from -10 to 10) (default 1)
/// </summary>
public VibranceFilterGen gbal(float gbal) => this.SetOptionRange("gbal", gbal,-10,10);
/// <summary>
///  set the blue balance value (from -10 to 10) (default 1)
/// </summary>
public VibranceFilterGen bbal(float bbal) => this.SetOptionRange("bbal", bbal,-10,10);
/// <summary>
///  set the red luma coefficient (from 0 to 1) (default 0.072186)
/// </summary>
public VibranceFilterGen rlum(float rlum) => this.SetOptionRange("rlum", rlum,0,1);
/// <summary>
///  set the green luma coefficient (from 0 to 1) (default 0.715158)
/// </summary>
public VibranceFilterGen glum(float glum) => this.SetOptionRange("glum", glum,0,1);
/// <summary>
///  set the blue luma coefficient (from 0 to 1) (default 0.212656)
/// </summary>
public VibranceFilterGen blum(float blum) => this.SetOptionRange("blum", blum,0,1);
/// <summary>
///  use alternate colors (default false)
/// </summary>
public VibranceFilterGen alternate(bool flag) => this.SetOption("alternate",flag.ToFFmpegFlag());
}
public static class VibranceFilterGenExtensions
{
/// <summary>
/// Boost or alter saturation.
/// </summary>
public static VibranceFilterGen VibranceFilterGen(this ImageMap input) => new VibranceFilterGen(input);
}
}
