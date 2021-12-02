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
public class SmptehdbarsFilterGen : SourceImageFilter
{
internal SmptehdbarsFilterGen(FilterGraph input) : base("smptehdbars",input) { AddMapOut(); }
/// <summary>
///  set video size (default "320x240")
/// </summary>
public SmptehdbarsFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public SmptehdbarsFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public SmptehdbarsFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public SmptehdbarsFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
public static class SmptehdbarsFilterGenExtensions
{
/// <summary>
/// Generate SMPTE HD color bars.
/// </summary>
public static SmptehdbarsFilterGen SmptehdbarsFilterGen(this FilterGraph input0) => new SmptehdbarsFilterGen(input0);
/// <summary>
/// Generate SMPTE HD color bars.
/// </summary>
public static SmptehdbarsFilterGen SmptehdbarsFilterGen(this FilterGraph input0,SmptehdbarsFilterGenConfig config)
{
var result = new SmptehdbarsFilterGen(input0);
if(config?.size != null) result.size(config.size.Value);
if(config?.rate != null) result.rate(config.rate);
if(config?.duration != null) result.duration(config.duration.Value);
if(config?.sar != null) result.sar(config.sar);
return result;
}
}
public class SmptehdbarsFilterGenConfig
{
/// <summary>
///  set video size (default "320x240")
/// </summary>
public Size? size { get; set; }
/// <summary>
///  set video rate (default "25")
/// </summary>
public Rational rate { get; set; }
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public TimeSpan? duration { get; set; }
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public Rational sar { get; set; }
}
}
