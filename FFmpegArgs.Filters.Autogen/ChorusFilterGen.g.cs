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
public class ChorusFilterGen : AudioToAudioFilter
{
internal ChorusFilterGen(AudioMap input) : base("chorus",input) { AddMapOut(); }
/// <summary>
///  set input gain (from 0 to 1) (default 0.4)
/// </summary>
public ChorusFilterGen in_gain(float in_gain) => this.SetOptionRange("in_gain", in_gain,0,1);
/// <summary>
///  set output gain (from 0 to 1) (default 0.4)
/// </summary>
public ChorusFilterGen out_gain(float out_gain) => this.SetOptionRange("out_gain", out_gain,0,1);
/// <summary>
///  set delays
/// </summary>
public ChorusFilterGen delays(string delays) => this.SetOption("delays",delays);
/// <summary>
///  set decays
/// </summary>
public ChorusFilterGen decays(string decays) => this.SetOption("decays",decays);
/// <summary>
///  set speeds
/// </summary>
public ChorusFilterGen speeds(string speeds) => this.SetOption("speeds",speeds);
/// <summary>
///  set depths
/// </summary>
public ChorusFilterGen depths(string depths) => this.SetOption("depths",depths);
}
public static class ChorusFilterGenExtensions
{
/// <summary>
/// Add a chorus effect to the audio.
/// </summary>
public static ChorusFilterGen ChorusFilterGen(this AudioMap input0) => new ChorusFilterGen(input0);
/// <summary>
/// Add a chorus effect to the audio.
/// </summary>
public static ChorusFilterGen ChorusFilterGen(this AudioMap input0,ChorusFilterGenConfig config)
{
var result = new ChorusFilterGen(input0);
if(config?.in_gain != null) result.in_gain(config.in_gain.Value);
if(config?.out_gain != null) result.out_gain(config.out_gain.Value);
if(!string.IsNullOrWhiteSpace(config?.delays)) result.delays(config.delays);
if(!string.IsNullOrWhiteSpace(config?.decays)) result.decays(config.decays);
if(!string.IsNullOrWhiteSpace(config?.speeds)) result.speeds(config.speeds);
if(!string.IsNullOrWhiteSpace(config?.depths)) result.depths(config.depths);
return result;
}
}
public class ChorusFilterGenConfig
{
/// <summary>
///  set input gain (from 0 to 1) (default 0.4)
/// </summary>
public float? in_gain { get; set; }
/// <summary>
///  set output gain (from 0 to 1) (default 0.4)
/// </summary>
public float? out_gain { get; set; }
/// <summary>
///  set delays
/// </summary>
public string delays { get; set; }
/// <summary>
///  set decays
/// </summary>
public string decays { get; set; }
/// <summary>
///  set speeds
/// </summary>
public string speeds { get; set; }
/// <summary>
///  set depths
/// </summary>
public string depths { get; set; }
}
}
