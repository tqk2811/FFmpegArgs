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
public class AlimiterFilterGen : AudioToAudioFilter
{
internal AlimiterFilterGen(AudioMap input) : base("alimiter",input) { AddMapOut(); }
/// <summary>
///  set input level (from 0.015625 to 64) (default 1)
/// </summary>
public AlimiterFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in,0.015625,64);
/// <summary>
///  set output level (from 0.015625 to 64) (default 1)
/// </summary>
public AlimiterFilterGen level_out(double level_out) => this.SetOptionRange("level_out", level_out,0.015625,64);
/// <summary>
///  set limit (from 0.0625 to 1) (default 1)
/// </summary>
public AlimiterFilterGen limit(double limit) => this.SetOptionRange("limit", limit,0.0625,1);
/// <summary>
///  set attack (from 0.1 to 80) (default 5)
/// </summary>
public AlimiterFilterGen attack(double attack) => this.SetOptionRange("attack", attack,0.1,80);
/// <summary>
///  set release (from 1 to 8000) (default 50)
/// </summary>
public AlimiterFilterGen release(double release) => this.SetOptionRange("release", release,1,8000);
/// <summary>
///  enable asc (default false)
/// </summary>
public AlimiterFilterGen asc(bool asc) => this.SetOption("asc",asc.ToFFmpegFlag());
/// <summary>
///  set asc level (from 0 to 1) (default 0.5)
/// </summary>
public AlimiterFilterGen asc_level(double asc_level) => this.SetOptionRange("asc_level", asc_level,0,1);
/// <summary>
///  auto level (default true)
/// </summary>
public AlimiterFilterGen level(bool level) => this.SetOption("level",level.ToFFmpegFlag());
}
public static class AlimiterFilterGenExtensions
{
/// <summary>
/// Audio lookahead limiter.
/// </summary>
public static AlimiterFilterGen AlimiterFilterGen(this AudioMap input0) => new AlimiterFilterGen(input0);
/// <summary>
/// Audio lookahead limiter.
/// </summary>
public static AlimiterFilterGen AlimiterFilterGen(this AudioMap input0,AlimiterFilterGenConfig config)
{
var result = new AlimiterFilterGen(input0);
if(config?.level_in != null) result.level_in(config.level_in.Value);
if(config?.level_out != null) result.level_out(config.level_out.Value);
if(config?.limit != null) result.limit(config.limit.Value);
if(config?.attack != null) result.attack(config.attack.Value);
if(config?.release != null) result.release(config.release.Value);
if(config?.asc != null) result.asc(config.asc.Value);
if(config?.asc_level != null) result.asc_level(config.asc_level.Value);
if(config?.level != null) result.level(config.level.Value);
return result;
}
}
public class AlimiterFilterGenConfig
{
/// <summary>
///  set input level (from 0.015625 to 64) (default 1)
/// </summary>
public double? level_in { get; set; }
/// <summary>
///  set output level (from 0.015625 to 64) (default 1)
/// </summary>
public double? level_out { get; set; }
/// <summary>
///  set limit (from 0.0625 to 1) (default 1)
/// </summary>
public double? limit { get; set; }
/// <summary>
///  set attack (from 0.1 to 80) (default 5)
/// </summary>
public double? attack { get; set; }
/// <summary>
///  set release (from 1 to 8000) (default 50)
/// </summary>
public double? release { get; set; }
/// <summary>
///  enable asc (default false)
/// </summary>
public bool? asc { get; set; }
/// <summary>
///  set asc level (from 0 to 1) (default 0.5)
/// </summary>
public double? asc_level { get; set; }
/// <summary>
///  auto level (default true)
/// </summary>
public bool? level { get; set; }
}
}
