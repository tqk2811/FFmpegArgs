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
public class PsnrFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal PsnrFilterGen(params ImageMap[] inputs) : base("psnr",inputs) { AddMapOut(); }
/// <summary>
///  Set file where to store per-frame difference information
/// </summary>
public PsnrFilterGen stats_file(string stats_file) => this.SetOption("stats_file",stats_file);
/// <summary>
///  Set file where to store per-frame difference information
/// </summary>
public PsnrFilterGen f(string f) => this.SetOption("f",f);
/// <summary>
///  Set the format version for the stats file. (from 1 to 2) (default 1)
/// </summary>
public PsnrFilterGen stats_version(int stats_version) => this.SetOptionRange("stats_version", stats_version,1,2);
/// <summary>
///  Add raw stats (max values) to the output log. (default false)
/// </summary>
public PsnrFilterGen output_max(bool output_max) => this.SetOption("output_max",output_max.ToFFmpegFlag());
}
public static class PsnrFilterGenExtensions
{
/// <summary>
/// Calculate the PSNR between two video streams.
/// </summary>
public static PsnrFilterGen PsnrFilterGen(this ImageMap input0, ImageMap input1) => new PsnrFilterGen(input0, input1);
/// <summary>
/// Calculate the PSNR between two video streams.
/// </summary>
public static PsnrFilterGen PsnrFilterGen(this ImageMap input0, ImageMap input1,PsnrFilterGenConfig config)
{
var result = new PsnrFilterGen(input0, input1);
if(!string.IsNullOrWhiteSpace(config?.stats_file)) result.stats_file(config.stats_file);
if(!string.IsNullOrWhiteSpace(config?.f)) result.f(config.f);
if(config?.stats_version != null) result.stats_version(config.stats_version.Value);
if(config?.output_max != null) result.output_max(config.output_max.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class PsnrFilterGenConfig
{
/// <summary>
///  Set file where to store per-frame difference information
/// </summary>
public string stats_file { get; set; }
/// <summary>
///  Set file where to store per-frame difference information
/// </summary>
public string f { get; set; }
/// <summary>
///  Set the format version for the stats file. (from 1 to 2) (default 1)
/// </summary>
public int? stats_version { get; set; }
/// <summary>
///  Add raw stats (max values) to the output log. (default false)
/// </summary>
public bool? output_max { get; set; }
public string TimelineSupport { get; set; }
}
}
