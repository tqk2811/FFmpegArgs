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
public class PhotosensitivityFilterGen : ImageToImageFilter
{
internal PhotosensitivityFilterGen(ImageMap input) : base("photosensitivity",input) { AddMapOut(); }
/// <summary>
///  set how many frames to use (from 2 to 240) (default 30)
/// </summary>
public PhotosensitivityFilterGen frames(int frames) => this.SetOptionRange("frames", frames,2,240);
/// <summary>
///  set detection threshold factor (lower is stricter) (from 0.1 to FLT_MAX) (default 1)
/// </summary>
public PhotosensitivityFilterGen threshold(float threshold) => this.SetOptionRange("threshold", threshold,0.1,FLT_MAX);
/// <summary>
///  set pixels to skip when sampling frames (from 1 to 1024) (default 1)
/// </summary>
public PhotosensitivityFilterGen skip(int skip) => this.SetOptionRange("skip", skip,1,1024);
/// <summary>
///  leave frames unchanged (default false)
/// </summary>
public PhotosensitivityFilterGen bypass(bool bypass) => this.SetOption("bypass",bypass.ToFFmpegFlag());
}
public static class PhotosensitivityFilterGenExtensions
{
/// <summary>
/// Filter out photosensitive epilepsy seizure-inducing flashes.
/// </summary>
public static PhotosensitivityFilterGen PhotosensitivityFilterGen(this ImageMap input0) => new PhotosensitivityFilterGen(input0);
/// <summary>
/// Filter out photosensitive epilepsy seizure-inducing flashes.
/// </summary>
public static PhotosensitivityFilterGen PhotosensitivityFilterGen(this ImageMap input0,PhotosensitivityFilterGenConfig config)
{
var result = new PhotosensitivityFilterGen(input0);
if(config?.frames != null) result.frames(config.frames.Value);
if(config?.threshold != null) result.threshold(config.threshold.Value);
if(config?.skip != null) result.skip(config.skip.Value);
if(config?.bypass != null) result.bypass(config.bypass.Value);
return result;
}
}
public class PhotosensitivityFilterGenConfig
{
/// <summary>
///  set how many frames to use (from 2 to 240) (default 30)
/// </summary>
public int? frames { get; set; }
/// <summary>
///  set detection threshold factor (lower is stricter) (from 0.1 to FLT_MAX) (default 1)
/// </summary>
public float? threshold { get; set; }
/// <summary>
///  set pixels to skip when sampling frames (from 1 to 1024) (default 1)
/// </summary>
public int? skip { get; set; }
/// <summary>
///  leave frames unchanged (default false)
/// </summary>
public bool? bypass { get; set; }
}
}
