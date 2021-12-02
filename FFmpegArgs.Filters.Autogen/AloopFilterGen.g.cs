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
public class AloopFilterGen : AudioToAudioFilter
{
internal AloopFilterGen(AudioMap input) : base("aloop",input) { AddMapOut(); }
/// <summary>
///  number of loops (from -1 to INT_MAX) (default 0)
/// </summary>
public AloopFilterGen loop(int loop) => this.SetOptionRange("loop", loop,-1,INT_MAX);
/// <summary>
///  max number of samples to loop (from 0 to INT_MAX) (default 0)
/// </summary>
public AloopFilterGen size(long size) => this.SetOptionRange("size", size,0,INT_MAX);
/// <summary>
///  set the loop start sample (from 0 to I64_MAX) (default 0)
/// </summary>
public AloopFilterGen start(long start) => this.SetOptionRange("start", start,0,I64_MAX);
}
public static class AloopFilterGenExtensions
{
/// <summary>
/// Loop audio samples.
/// </summary>
public static AloopFilterGen AloopFilterGen(this AudioMap input0) => new AloopFilterGen(input0);
/// <summary>
/// Loop audio samples.
/// </summary>
public static AloopFilterGen AloopFilterGen(this AudioMap input0,AloopFilterGenConfig config)
{
var result = new AloopFilterGen(input0);
if(config?.loop != null) result.loop(config.loop.Value);
if(config?.size != null) result.size(config.size.Value);
if(config?.start != null) result.start(config.start.Value);
return result;
}
}
public class AloopFilterGenConfig
{
/// <summary>
///  number of loops (from -1 to INT_MAX) (default 0)
/// </summary>
public int? loop { get; set; }
/// <summary>
///  max number of samples to loop (from 0 to INT_MAX) (default 0)
/// </summary>
public long? size { get; set; }
/// <summary>
///  set the loop start sample (from 0 to I64_MAX) (default 0)
/// </summary>
public long? start { get; set; }
}
}
