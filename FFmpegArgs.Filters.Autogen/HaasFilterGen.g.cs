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
public HaasFilterGen middle_phase(bool flag) => this.SetOption("middle_phase",flag.ToFFmpegFlag());
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
public HaasFilterGen left_phase(bool flag) => this.SetOption("left_phase",flag.ToFFmpegFlag());
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
public HaasFilterGen right_phase(bool flag) => this.SetOption("right_phase",flag.ToFFmpegFlag());
}
public static class HaasFilterGenExtensions
{
/// <summary>
/// Apply Haas Stereo Enhancer.
/// </summary>
public static HaasFilterGen HaasFilterGen(this AudioMap input) => new HaasFilterGen(input);
}
public enum HaasFilterGenMiddle_source
{
[Name("left")] left,
[Name("right")] right,
[Name("mid")] mid,
[Name("side")] side,
}

}
