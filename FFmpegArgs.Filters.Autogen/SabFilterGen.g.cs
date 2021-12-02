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
public class SabFilterGen : ImageToImageFilter,ITimelineSupport
{
internal SabFilterGen(ImageMap input) : base("sab",input) { AddMapOut(); }
/// <summary>
///  set luma radius (from 0.1 to 4) (default 1)
/// </summary>
public SabFilterGen luma_radius(float luma_radius) => this.SetOptionRange("luma_radius", luma_radius,0.1,4);
/// <summary>
///  set luma radius (from 0.1 to 4) (default 1)
/// </summary>
public SabFilterGen lr(float lr) => this.SetOptionRange("lr", lr,0.1,4);
/// <summary>
///  set luma pre-filter radius (from 0.1 to 2) (default 1)
/// </summary>
public SabFilterGen luma_pre_filter_radius(float luma_pre_filter_radius) => this.SetOptionRange("luma_pre_filter_radius", luma_pre_filter_radius,0.1,2);
/// <summary>
///  set luma pre-filter radius (from 0.1 to 2) (default 1)
/// </summary>
public SabFilterGen lpfr(float lpfr) => this.SetOptionRange("lpfr", lpfr,0.1,2);
/// <summary>
///  set luma strength (from 0.1 to 100) (default 1)
/// </summary>
public SabFilterGen luma_strength(float luma_strength) => this.SetOptionRange("luma_strength", luma_strength,0.1,100);
/// <summary>
///  set luma strength (from 0.1 to 100) (default 1)
/// </summary>
public SabFilterGen ls(float ls) => this.SetOptionRange("ls", ls,0.1,100);
/// <summary>
///  set chroma radius (from -0.9 to 4) (default -0.9)
/// </summary>
public SabFilterGen chroma_radius(float chroma_radius) => this.SetOptionRange("chroma_radius", chroma_radius,-0.9,4);
/// <summary>
///  set chroma radius (from -0.9 to 4) (default -0.9)
/// </summary>
public SabFilterGen cr(float cr) => this.SetOptionRange("cr", cr,-0.9,4);
/// <summary>
///  set chroma pre-filter radius (from -0.9 to 2) (default -0.9)
/// </summary>
public SabFilterGen chroma_pre_filter_radius(float chroma_pre_filter_radius) => this.SetOptionRange("chroma_pre_filter_radius", chroma_pre_filter_radius,-0.9,2);
/// <summary>
///  set chroma pre-filter radius (from -0.9 to 2) (default -0.9)
/// </summary>
public SabFilterGen cpfr(float cpfr) => this.SetOptionRange("cpfr", cpfr,-0.9,2);
/// <summary>
///  set chroma strength (from -0.9 to 100) (default -0.9)
/// </summary>
public SabFilterGen chroma_strength(float chroma_strength) => this.SetOptionRange("chroma_strength", chroma_strength,-0.9,100);
/// <summary>
///  set chroma strength (from -0.9 to 100) (default -0.9)
/// </summary>
public SabFilterGen cs(float cs) => this.SetOptionRange("cs", cs,-0.9,100);
}
public static class SabFilterGenExtensions
{
/// <summary>
/// Apply shape adaptive blur.
/// </summary>
public static SabFilterGen SabFilterGen(this ImageMap input0) => new SabFilterGen(input0);
/// <summary>
/// Apply shape adaptive blur.
/// </summary>
public static SabFilterGen SabFilterGen(this ImageMap input0,SabFilterGenConfig config)
{
var result = new SabFilterGen(input0);
if(config?.luma_radius != null) result.luma_radius(config.luma_radius.Value);
if(config?.lr != null) result.lr(config.lr.Value);
if(config?.luma_pre_filter_radius != null) result.luma_pre_filter_radius(config.luma_pre_filter_radius.Value);
if(config?.lpfr != null) result.lpfr(config.lpfr.Value);
if(config?.luma_strength != null) result.luma_strength(config.luma_strength.Value);
if(config?.ls != null) result.ls(config.ls.Value);
if(config?.chroma_radius != null) result.chroma_radius(config.chroma_radius.Value);
if(config?.cr != null) result.cr(config.cr.Value);
if(config?.chroma_pre_filter_radius != null) result.chroma_pre_filter_radius(config.chroma_pre_filter_radius.Value);
if(config?.cpfr != null) result.cpfr(config.cpfr.Value);
if(config?.chroma_strength != null) result.chroma_strength(config.chroma_strength.Value);
if(config?.cs != null) result.cs(config.cs.Value);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class SabFilterGenConfig
{
/// <summary>
///  set luma radius (from 0.1 to 4) (default 1)
/// </summary>
public float? luma_radius { get; set; }
/// <summary>
///  set luma radius (from 0.1 to 4) (default 1)
/// </summary>
public float? lr { get; set; }
/// <summary>
///  set luma pre-filter radius (from 0.1 to 2) (default 1)
/// </summary>
public float? luma_pre_filter_radius { get; set; }
/// <summary>
///  set luma pre-filter radius (from 0.1 to 2) (default 1)
/// </summary>
public float? lpfr { get; set; }
/// <summary>
///  set luma strength (from 0.1 to 100) (default 1)
/// </summary>
public float? luma_strength { get; set; }
/// <summary>
///  set luma strength (from 0.1 to 100) (default 1)
/// </summary>
public float? ls { get; set; }
/// <summary>
///  set chroma radius (from -0.9 to 4) (default -0.9)
/// </summary>
public float? chroma_radius { get; set; }
/// <summary>
///  set chroma radius (from -0.9 to 4) (default -0.9)
/// </summary>
public float? cr { get; set; }
/// <summary>
///  set chroma pre-filter radius (from -0.9 to 2) (default -0.9)
/// </summary>
public float? chroma_pre_filter_radius { get; set; }
/// <summary>
///  set chroma pre-filter radius (from -0.9 to 2) (default -0.9)
/// </summary>
public float? cpfr { get; set; }
/// <summary>
///  set chroma strength (from -0.9 to 100) (default -0.9)
/// </summary>
public float? chroma_strength { get; set; }
/// <summary>
///  set chroma strength (from -0.9 to 100) (default -0.9)
/// </summary>
public float? cs { get; set; }
public string TimelineSupport { get; set; }
}
}
