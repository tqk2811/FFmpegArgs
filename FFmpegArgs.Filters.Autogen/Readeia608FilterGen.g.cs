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
public class Readeia608FilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal Readeia608FilterGen(ImageMap input) : base("readeia608",input) { AddMapOut(); }
/// <summary>
///  set from which line to scan for codes (from 0 to INT_MAX) (default 0)
/// </summary>
public Readeia608FilterGen scan_min(int scan_min) => this.SetOptionRange("scan_min", scan_min,0,INT_MAX);
/// <summary>
///  set to which line to scan for codes (from 0 to INT_MAX) (default 29)
/// </summary>
public Readeia608FilterGen scan_max(int scan_max) => this.SetOptionRange("scan_max", scan_max,0,INT_MAX);
/// <summary>
///  set ratio of width reserved for sync code detection (from 0.1 to 0.7) (default 0.27)
/// </summary>
public Readeia608FilterGen spw(float spw) => this.SetOptionRange("spw", spw,0.1,0.7);
/// <summary>
///  check and apply parity bit (default false)
/// </summary>
public Readeia608FilterGen chp(bool chp) => this.SetOption("chp",chp.ToFFmpegFlag());
/// <summary>
///  lowpass line prior to processing (default true)
/// </summary>
public Readeia608FilterGen lp(bool lp) => this.SetOption("lp",lp.ToFFmpegFlag());
}
public static class Readeia608FilterGenExtensions
{
/// <summary>
/// Read EIA-608 Closed Caption codes from input video and write them to frame metadata.
/// </summary>
public static Readeia608FilterGen Readeia608FilterGen(this ImageMap input0) => new Readeia608FilterGen(input0);
/// <summary>
/// Read EIA-608 Closed Caption codes from input video and write them to frame metadata.
/// </summary>
public static Readeia608FilterGen Readeia608FilterGen(this ImageMap input0,Readeia608FilterGenConfig config)
{
var result = new Readeia608FilterGen(input0);
if(config?.scan_min != null) result.scan_min(config.scan_min.Value);
if(config?.scan_max != null) result.scan_max(config.scan_max.Value);
if(config?.spw != null) result.spw(config.spw.Value);
if(config?.chp != null) result.chp(config.chp.Value);
if(config?.lp != null) result.lp(config.lp.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class Readeia608FilterGenConfig
{
/// <summary>
///  set from which line to scan for codes (from 0 to INT_MAX) (default 0)
/// </summary>
public int? scan_min { get; set; }
/// <summary>
///  set to which line to scan for codes (from 0 to INT_MAX) (default 29)
/// </summary>
public int? scan_max { get; set; }
/// <summary>
///  set ratio of width reserved for sync code detection (from 0.1 to 0.7) (default 0.27)
/// </summary>
public float? spw { get; set; }
/// <summary>
///  check and apply parity bit (default false)
/// </summary>
public bool? chp { get; set; }
/// <summary>
///  lowpass line prior to processing (default true)
/// </summary>
public bool? lp { get; set; }
public string TimelineSupport { get; set; }
}
}
