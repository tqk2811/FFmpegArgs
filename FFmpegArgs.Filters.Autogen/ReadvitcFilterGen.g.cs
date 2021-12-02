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
public class ReadvitcFilterGen : ImageToImageFilter
{
internal ReadvitcFilterGen(ImageMap input) : base("readvitc",input) { AddMapOut(); }
/// <summary>
///  maximum line numbers to scan for VITC data (from -1 to INT_MAX) (default 45)
/// </summary>
public ReadvitcFilterGen scan_max(int scan_max) => this.SetOptionRange("scan_max", scan_max,-1,INT_MAX);
/// <summary>
///  black color threshold (from 0 to 1) (default 0.2)
/// </summary>
public ReadvitcFilterGen thr_b(double thr_b) => this.SetOptionRange("thr_b", thr_b,0,1);
/// <summary>
///  white color threshold (from 0 to 1) (default 0.6)
/// </summary>
public ReadvitcFilterGen thr_w(double thr_w) => this.SetOptionRange("thr_w", thr_w,0,1);
}
public static class ReadvitcFilterGenExtensions
{
/// <summary>
/// Read vertical interval timecode and write it to frame metadata.
/// </summary>
public static ReadvitcFilterGen ReadvitcFilterGen(this ImageMap input0) => new ReadvitcFilterGen(input0);
/// <summary>
/// Read vertical interval timecode and write it to frame metadata.
/// </summary>
public static ReadvitcFilterGen ReadvitcFilterGen(this ImageMap input0,ReadvitcFilterGenConfig config)
{
var result = new ReadvitcFilterGen(input0);
if(config?.scan_max != null) result.scan_max(config.scan_max);
if(config?.thr_b != null) result.thr_b(config.thr_b);
if(config?.thr_w != null) result.thr_w(config.thr_w);
return result;
}
}
public class ReadvitcFilterGenConfig
{
/// <summary>
///  maximum line numbers to scan for VITC data (from -1 to INT_MAX) (default 45)
/// </summary>
public int scan_max { get; set; }
/// <summary>
///  black color threshold (from 0 to 1) (default 0.2)
/// </summary>
public double thr_b { get; set; }
/// <summary>
///  white color threshold (from 0 to 1) (default 0.6)
/// </summary>
public double thr_w { get; set; }
}
}
