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
public class TremoloFilterGen : AudioToAudioFilter
{
internal TremoloFilterGen(AudioMap input) : base("tremolo",input) { AddMapOut(); }
/// <summary>
///  set frequency in hertz (from 0.1 to 20000) (default 5)
/// </summary>
public TremoloFilterGen f(double f) => this.SetOptionRange("f", f,0.1,20000);
/// <summary>
///  set depth as percentage (from 0 to 1) (default 0.5)
/// </summary>
public TremoloFilterGen d(double d) => this.SetOptionRange("d", d,0,1);
}
public static class TremoloFilterGenExtensions
{
/// <summary>
/// Apply tremolo effect.
/// </summary>
public static TremoloFilterGen TremoloFilterGen(this AudioMap input0) => new TremoloFilterGen(input0);
/// <summary>
/// Apply tremolo effect.
/// </summary>
public static TremoloFilterGen TremoloFilterGen(this AudioMap input0,TremoloFilterGenConfig config)
{
var result = new TremoloFilterGen(input0);
if(config?.f != null) result.f(config.f.Value);
if(config?.d != null) result.d(config.d.Value);
return result;
}
}
public class TremoloFilterGenConfig
{
/// <summary>
///  set frequency in hertz (from 0.1 to 20000) (default 5)
/// </summary>
public double? f { get; set; }
/// <summary>
///  set depth as percentage (from 0 to 1) (default 0.5)
/// </summary>
public double? d { get; set; }
}
}
