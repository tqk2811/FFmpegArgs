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
public class VibratoFilterGen : AudioToAudioFilter
{
internal VibratoFilterGen(AudioMap input) : base("vibrato",input) { AddMapOut(); }
/// <summary>
///  set frequency in hertz (from 0.1 to 20000) (default 5)
/// </summary>
public VibratoFilterGen f(double f) => this.SetOptionRange("f", f,0.1,20000);
/// <summary>
///  set depth as percentage (from 0 to 1) (default 0.5)
/// </summary>
public VibratoFilterGen d(double d) => this.SetOptionRange("d", d,0,1);
}
public static class VibratoFilterGenExtensions
{
/// <summary>
/// Apply vibrato effect.
/// </summary>
public static VibratoFilterGen VibratoFilterGen(this AudioMap input0) => new VibratoFilterGen(input0);
/// <summary>
/// Apply vibrato effect.
/// </summary>
public static VibratoFilterGen VibratoFilterGen(this AudioMap input0,VibratoFilterGenConfig config)
{
var result = new VibratoFilterGen(input0);
if(config?.f != null) result.f(config.f.Value);
if(config?.d != null) result.d(config.d.Value);
return result;
}
}
public class VibratoFilterGenConfig
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
