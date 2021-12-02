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
public class AfadeFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal AfadeFilterGen(AudioMap input) : base("afade",input) { AddMapOut(); }
/// <summary>
///  set the fade direction (from 0 to 1) (default in)
/// </summary>
public AfadeFilterGen type(AfadeFilterGenType type) => this.SetOption("type", type.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set number of first sample to start fading (from 0 to I64_MAX) (default 0)
/// </summary>
public AfadeFilterGen start_sample(long start_sample) => this.SetOptionRange("start_sample", start_sample,0,I64_MAX);
/// <summary>
///  set number of first sample to start fading (from 0 to I64_MAX) (default 0)
/// </summary>
public AfadeFilterGen ss(long ss) => this.SetOptionRange("ss", ss,0,I64_MAX);
/// <summary>
///  set number of samples for fade duration (from 1 to I64_MAX) (default 44100)
/// </summary>
public AfadeFilterGen nb_samples(long nb_samples) => this.SetOptionRange("nb_samples", nb_samples,1,I64_MAX);
/// <summary>
///  set number of samples for fade duration (from 1 to I64_MAX) (default 44100)
/// </summary>
public AfadeFilterGen ns(long ns) => this.SetOptionRange("ns", ns,1,I64_MAX);
/// <summary>
///  set time to start fading (default 0)
/// </summary>
public AfadeFilterGen start_time(TimeSpan start_time) => this.SetOptionRange("start_time",start_time,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set fade duration (default 0)
/// </summary>
public AfadeFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set fade curve type (from -1 to 18) (default tri)
/// </summary>
public AfadeFilterGen curve(AfadeFilterGenCurve curve) => this.SetOption("curve", curve.GetAttribute<NameAttribute>().Name);
}
public static class AfadeFilterGenExtensions
{
/// <summary>
/// Fade in/out input audio.
/// </summary>
public static AfadeFilterGen AfadeFilterGen(this AudioMap input0) => new AfadeFilterGen(input0);
/// <summary>
/// Fade in/out input audio.
/// </summary>
public static AfadeFilterGen AfadeFilterGen(this AudioMap input0,AfadeFilterGenConfig config)
{
var result = new AfadeFilterGen(input0);
if(config?.type != null) result.type(config.type);
if(config?.start_sample != null) result.start_sample(config.start_sample);
if(config?.ss != null) result.ss(config.ss);
if(config?.nb_samples != null) result.nb_samples(config.nb_samples);
if(config?.ns != null) result.ns(config.ns);
if(config?.start_time != null) result.start_time(config.start_time);
if(config?.duration != null) result.duration(config.duration);
if(config?.curve != null) result.curve(config.curve);
return result;
}
}
public class AfadeFilterGenConfig
{
/// <summary>
///  set the fade direction (from 0 to 1) (default in)
/// </summary>
public AfadeFilterGenType type { get; set; }
/// <summary>
///  set number of first sample to start fading (from 0 to I64_MAX) (default 0)
/// </summary>
public long start_sample { get; set; }
/// <summary>
///  set number of first sample to start fading (from 0 to I64_MAX) (default 0)
/// </summary>
public long ss { get; set; }
/// <summary>
///  set number of samples for fade duration (from 1 to I64_MAX) (default 44100)
/// </summary>
public long nb_samples { get; set; }
/// <summary>
///  set number of samples for fade duration (from 1 to I64_MAX) (default 44100)
/// </summary>
public long ns { get; set; }
/// <summary>
///  set time to start fading (default 0)
/// </summary>
public TimeSpan start_time { get; set; }
/// <summary>
///  set fade duration (default 0)
/// </summary>
public TimeSpan duration { get; set; }
/// <summary>
///  set fade curve type (from -1 to 18) (default tri)
/// </summary>
public AfadeFilterGenCurve curve { get; set; }
}
public enum AfadeFilterGenType
{
[Name("in")] _in,
[Name("out")] _out,
}

public enum AfadeFilterGenCurve
{
[Name("nofade")] nofade,
[Name("tri")] tri,
[Name("qsin")] qsin,
[Name("esin")] esin,
[Name("hsin")] hsin,
[Name("log")] log,
[Name("ipar")] ipar,
[Name("qua")] qua,
[Name("cub")] cub,
[Name("squ")] squ,
[Name("cbr")] cbr,
[Name("par")] par,
[Name("exp")] exp,
[Name("iqsin")] iqsin,
[Name("ihsin")] ihsin,
[Name("dese")] dese,
[Name("desi")] desi,
[Name("losi")] losi,
[Name("sinc")] sinc,
[Name("isinc")] isinc,
}

}
