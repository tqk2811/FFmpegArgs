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
public class SsimFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal SsimFilterGen(params ImageMap[] inputs) : base("ssim",inputs) { AddMapOut(); }
/// <summary>
///  Set file where to store per-frame difference information
/// </summary>
public SsimFilterGen stats_file(string stats_file) => this.SetOption("stats_file",stats_file);
/// <summary>
///  Set file where to store per-frame difference information
/// </summary>
public SsimFilterGen f(string f) => this.SetOption("f",f);
}
public static class SsimFilterGenExtensions
{
/// <summary>
/// Calculate the SSIM between two video streams.
/// </summary>
public static SsimFilterGen SsimFilterGen(this ImageMap input0, ImageMap input1) => new SsimFilterGen(input0, input1);
/// <summary>
/// Calculate the SSIM between two video streams.
/// </summary>
public static SsimFilterGen SsimFilterGen(this ImageMap input0, ImageMap input1,SsimFilterGenConfig config)
{
var result = new SsimFilterGen(input0, input1);
if(!string.IsNullOrWhiteSpace(config?.stats_file)) result.stats_file(config.stats_file);
if(!string.IsNullOrWhiteSpace(config?.f)) result.f(config.f);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class SsimFilterGenConfig
{
/// <summary>
///  Set file where to store per-frame difference information
/// </summary>
public string stats_file { get; set; }
/// <summary>
///  Set file where to store per-frame difference information
/// </summary>
public string f { get; set; }
public string TimelineSupport { get; set; }
}
}
