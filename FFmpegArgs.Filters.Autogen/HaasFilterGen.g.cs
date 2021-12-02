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
public class HaasFilterGen : AudioToAudioFilter
{
internal HaasFilterGen(AudioMap input) : base("haas",input) { AddMapOut(); }
/// <summary>
///  set level in (from 0.015625 to 64) (default 1)
/// </summary>
public HaasFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in,0.015625,64);
/// <summary>
///  set level out (from 0.015625 to 64) (default 1)
/// </summary>
public HaasFilterGen level_out(double level_out) => this.SetOptionRange("level_out", level_out,0.015625,64);
/// <summary>
///  set side gain (from 0.015625 to 64) (default 1)
/// </summary>
public HaasFilterGen side_gain(double side_gain) => this.SetOptionRange("side_gain", side_gain,0.015625,64);
/// <summary>
///  set middle source (from 0 to 3) (default mid)
/// </summary>
public HaasFilterGen middle_source(HaasFilterGenMiddle_source middle_source) => this.SetOption("middle_source", middle_source.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set middle phase (default false)
/// </summary>
public HaasFilterGen middle_phase(bool middle_phase) => this.SetOption("middle_phase",middle_phase.ToFFmpegFlag());
/// <summary>
///  set left delay (from 0 to 40) (default 2.05)
/// </summary>
public HaasFilterGen left_delay(double left_delay) => this.SetOptionRange("left_delay", left_delay,0,40);
/// <summary>
///  set left balance (from -1 to 1) (default -1)
/// </summary>
public HaasFilterGen left_balance(double left_balance) => this.SetOptionRange("left_balance", left_balance,-1,1);
/// <summary>
///  set left gain (from 0.015625 to 64) (default 1)
/// </summary>
public HaasFilterGen left_gain(double left_gain) => this.SetOptionRange("left_gain", left_gain,0.015625,64);
/// <summary>
///  set left phase (default false)
/// </summary>
public HaasFilterGen left_phase(bool left_phase) => this.SetOption("left_phase",left_phase.ToFFmpegFlag());
/// <summary>
///  set right delay (from 0 to 40) (default 2.12)
/// </summary>
public HaasFilterGen right_delay(double right_delay) => this.SetOptionRange("right_delay", right_delay,0,40);
/// <summary>
///  set right balance (from -1 to 1) (default 1)
/// </summary>
public HaasFilterGen right_balance(double right_balance) => this.SetOptionRange("right_balance", right_balance,-1,1);
/// <summary>
///  set right gain (from 0.015625 to 64) (default 1)
/// </summary>
public HaasFilterGen right_gain(double right_gain) => this.SetOptionRange("right_gain", right_gain,0.015625,64);
/// <summary>
///  set right phase (default true)
/// </summary>
public HaasFilterGen right_phase(bool right_phase) => this.SetOption("right_phase",right_phase.ToFFmpegFlag());
}
public static class HaasFilterGenExtensions
{
/// <summary>
/// Apply Haas Stereo Enhancer.
/// </summary>
public static HaasFilterGen HaasFilterGen(this AudioMap input0) => new HaasFilterGen(input0);
/// <summary>
/// Apply Haas Stereo Enhancer.
/// </summary>
public static HaasFilterGen HaasFilterGen(this AudioMap input0,HaasFilterGenConfig config)
{
var result = new HaasFilterGen(input0);
if(config?.level_in != null) result.level_in(config.level_in);
if(config?.level_out != null) result.level_out(config.level_out);
if(config?.side_gain != null) result.side_gain(config.side_gain);
if(config?.middle_source != null) result.middle_source(config.middle_source);
if(config?.middle_phase != null) result.middle_phase(config.middle_phase);
if(config?.left_delay != null) result.left_delay(config.left_delay);
if(config?.left_balance != null) result.left_balance(config.left_balance);
if(config?.left_gain != null) result.left_gain(config.left_gain);
if(config?.left_phase != null) result.left_phase(config.left_phase);
if(config?.right_delay != null) result.right_delay(config.right_delay);
if(config?.right_balance != null) result.right_balance(config.right_balance);
if(config?.right_gain != null) result.right_gain(config.right_gain);
if(config?.right_phase != null) result.right_phase(config.right_phase);
return result;
}
}
public class HaasFilterGenConfig
{
/// <summary>
///  set level in (from 0.015625 to 64) (default 1)
/// </summary>
public double level_in { get; set; }
/// <summary>
///  set level out (from 0.015625 to 64) (default 1)
/// </summary>
public double level_out { get; set; }
/// <summary>
///  set side gain (from 0.015625 to 64) (default 1)
/// </summary>
public double side_gain { get; set; }
/// <summary>
///  set middle source (from 0 to 3) (default mid)
/// </summary>
public HaasFilterGenMiddle_source middle_source { get; set; }
/// <summary>
///  set middle phase (default false)
/// </summary>
public bool middle_phase { get; set; }
/// <summary>
///  set left delay (from 0 to 40) (default 2.05)
/// </summary>
public double left_delay { get; set; }
/// <summary>
///  set left balance (from -1 to 1) (default -1)
/// </summary>
public double left_balance { get; set; }
/// <summary>
///  set left gain (from 0.015625 to 64) (default 1)
/// </summary>
public double left_gain { get; set; }
/// <summary>
///  set left phase (default false)
/// </summary>
public bool left_phase { get; set; }
/// <summary>
///  set right delay (from 0 to 40) (default 2.12)
/// </summary>
public double right_delay { get; set; }
/// <summary>
///  set right balance (from -1 to 1) (default 1)
/// </summary>
public double right_balance { get; set; }
/// <summary>
///  set right gain (from 0.015625 to 64) (default 1)
/// </summary>
public double right_gain { get; set; }
/// <summary>
///  set right phase (default true)
/// </summary>
public bool right_phase { get; set; }
}
public enum HaasFilterGenMiddle_source
{
[Name("left")] left,
[Name("right")] right,
[Name("mid")] mid,
[Name("side")] side,
}

}
