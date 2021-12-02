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
public class AcueFilterGen : AudioToAudioFilter
{
internal AcueFilterGen(AudioMap input) : base("acue",input) { AddMapOut(); }
/// <summary>
///  cue unix timestamp in microseconds (from 0 to I64_MAX) (default 0)
/// </summary>
public AcueFilterGen cue(long cue) => this.SetOptionRange("cue", cue,0,I64_MAX);
/// <summary>
///  preroll duration in seconds (default 0)
/// </summary>
public AcueFilterGen preroll(TimeSpan preroll) => this.SetOptionRange("preroll",preroll,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  buffer duration in seconds (default 0)
/// </summary>
public AcueFilterGen buffer(TimeSpan buffer) => this.SetOptionRange("buffer",buffer,TimeSpan.Zero,TimeSpan.MaxValue);
}
public static class AcueFilterGenExtensions
{
/// <summary>
/// Delay filtering to match a cue.
/// </summary>
public static AcueFilterGen AcueFilterGen(this AudioMap input0) => new AcueFilterGen(input0);
/// <summary>
/// Delay filtering to match a cue.
/// </summary>
public static AcueFilterGen AcueFilterGen(this AudioMap input0,AcueFilterGenConfig config)
{
var result = new AcueFilterGen(input0);
if(config?.cue != null) result.cue(config.cue.Value);
if(config?.preroll != null) result.preroll(config.preroll.Value);
if(config?.buffer != null) result.buffer(config.buffer.Value);
return result;
}
}
public class AcueFilterGenConfig
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
