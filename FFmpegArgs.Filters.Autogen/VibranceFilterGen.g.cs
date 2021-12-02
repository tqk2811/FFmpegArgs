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
public VibranceFilterGen alternate(bool alternate) => this.SetOption("alternate",alternate.ToFFmpegFlag());
}
public static class VibranceFilterGenExtensions
{
/// <summary>
/// Boost or alter saturation.
/// </summary>
public static VibranceFilterGen VibranceFilterGen(this ImageMap input0) => new VibranceFilterGen(input0);
/// <summary>
/// Boost or alter saturation.
/// </summary>
public static VibranceFilterGen VibranceFilterGen(this ImageMap input0,VibranceFilterGenConfig config)
{
var result = new VibranceFilterGen(input0);
if(config?.intensity != null) result.intensity(config.intensity);
if(config?.rbal != null) result.rbal(config.rbal);
if(config?.gbal != null) result.gbal(config.gbal);
if(config?.bbal != null) result.bbal(config.bbal);
if(config?.rlum != null) result.rlum(config.rlum);
if(config?.glum != null) result.glum(config.glum);
if(config?.blum != null) result.blum(config.blum);
if(config?.alternate != null) result.alternate(config.alternate);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class VibranceFilterGenConfig
{
/// <summary>
///  set the intensity value (from -2 to 2) (default 0)
/// </summary>
public float intensity { get; set; }
/// <summary>
///  set the red balance value (from -10 to 10) (default 1)
/// </summary>
public float rbal { get; set; }
/// <summary>
///  set the green balance value (from -10 to 10) (default 1)
/// </summary>
public float gbal { get; set; }
/// <summary>
///  set the blue balance value (from -10 to 10) (default 1)
/// </summary>
public float bbal { get; set; }
/// <summary>
///  set the red luma coefficient (from 0 to 1) (default 0.072186)
/// </summary>
public float rlum { get; set; }
/// <summary>
///  set the green luma coefficient (from 0 to 1) (default 0.715158)
/// </summary>
public float glum { get; set; }
/// <summary>
///  set the blue luma coefficient (from 0 to 1) (default 0.212656)
/// </summary>
public float blum { get; set; }
/// <summary>
///  use alternate colors (default false)
/// </summary>
public bool alternate { get; set; }
public string TimelineSupport { get; set; }
}
}
