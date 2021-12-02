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
public class DeesserFilterGen : AudioToAudioFilter,ITimelineSupport
{
internal DeesserFilterGen(AudioMap input) : base("deesser",input) { AddMapOut(); }
/// <summary>
///  set intensity (from 0 to 1) (default 0)
/// </summary>
public DeesserFilterGen i(double i) => this.SetOptionRange("i", i,0,1);
/// <summary>
///  set max deessing (from 0 to 1) (default 0.5)
/// </summary>
public DeesserFilterGen m(double m) => this.SetOptionRange("m", m,0,1);
/// <summary>
///  set frequency (from 0 to 1) (default 0.5)
/// </summary>
public DeesserFilterGen f(double f) => this.SetOptionRange("f", f,0,1);
/// <summary>
///  set output mode (from 0 to 2) (default o)
/// </summary>
public DeesserFilterGen s(DeesserFilterGenS s) => this.SetOption("s", s.GetAttribute<NameAttribute>().Name);
}
public static class DeesserFilterGenExtensions
{
/// <summary>
/// Apply de-essing to the audio.
/// </summary>
public static DeesserFilterGen DeesserFilterGen(this AudioMap input0) => new DeesserFilterGen(input0);
/// <summary>
/// Apply de-essing to the audio.
/// </summary>
public static DeesserFilterGen DeesserFilterGen(this AudioMap input0,DeesserFilterGenConfig config)
{
var result = new DeesserFilterGen(input0);
if(config?.i != null) result.i(config.i.Value);
if(config?.m != null) result.m(config.m.Value);
if(config?.f != null) result.f(config.f.Value);
if(config?.s != null) result.s(config.s.Value);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class DeesserFilterGenConfig
{
/// <summary>
///  set intensity (from 0 to 1) (default 0)
/// </summary>
public double? i { get; set; }
/// <summary>
///  set max deessing (from 0 to 1) (default 0.5)
/// </summary>
public double? m { get; set; }
/// <summary>
///  set frequency (from 0 to 1) (default 0.5)
/// </summary>
public double? f { get; set; }
/// <summary>
///  set output mode (from 0 to 2) (default o)
/// </summary>
public DeesserFilterGenS? s { get; set; }
public string TimelineSupport { get; set; }
}
public enum DeesserFilterGenS
{
[Name("i")] i,
[Name("o")] o,
[Name("e")] e,
}

}
