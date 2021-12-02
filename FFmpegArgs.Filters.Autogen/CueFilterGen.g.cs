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
public class CueFilterGen : ImageToImageFilter
{
internal CueFilterGen(ImageMap input) : base("cue",input) { AddMapOut(); }
/// <summary>
///  cue unix timestamp in microseconds (from 0 to I64_MAX) (default 0)
/// </summary>
public CueFilterGen cue(long cue) => this.SetOptionRange("cue", cue,0,I64_MAX);
/// <summary>
///  preroll duration in seconds (default 0)
/// </summary>
public CueFilterGen preroll(TimeSpan preroll) => this.SetOptionRange("preroll",preroll,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  buffer duration in seconds (default 0)
/// </summary>
public CueFilterGen buffer(TimeSpan buffer) => this.SetOptionRange("buffer",buffer,TimeSpan.Zero,TimeSpan.MaxValue);
}
public static class CueFilterGenExtensions
{
/// <summary>
/// Delay filtering to match a cue.
/// </summary>
public static CueFilterGen CueFilterGen(this ImageMap input0) => new CueFilterGen(input0);
/// <summary>
/// Delay filtering to match a cue.
/// </summary>
public static CueFilterGen CueFilterGen(this ImageMap input0,CueFilterGenConfig config)
{
var result = new CueFilterGen(input0);
if(config?.cue != null) result.cue(config.cue.Value);
if(config?.preroll != null) result.preroll(config.preroll.Value);
if(config?.buffer != null) result.buffer(config.buffer.Value);
return result;
}
}
public class CueFilterGenConfig
{
/// <summary>
///  cue unix timestamp in microseconds (from 0 to I64_MAX) (default 0)
/// </summary>
public long? cue { get; set; }
/// <summary>
///  preroll duration in seconds (default 0)
/// </summary>
public TimeSpan? preroll { get; set; }
/// <summary>
///  buffer duration in seconds (default 0)
/// </summary>
public TimeSpan? buffer { get; set; }
}
}
