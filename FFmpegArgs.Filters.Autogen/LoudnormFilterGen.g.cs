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
public class LoudnormFilterGen : AudioToAudioFilter
{
internal LoudnormFilterGen(AudioMap input) : base("loudnorm",input) { AddMapOut(); }
/// <summary>
///  set integrated loudness target (from -70 to -5) (default -24)
/// </summary>
public LoudnormFilterGen I(double I) => this.SetOptionRange("I", I,-70,-5);
/// <summary>
///  set integrated loudness target (from -70 to -5) (default -24)
/// </summary>
public LoudnormFilterGen i(double i) => this.SetOptionRange("i", i,-70,-5);
/// <summary>
///  set loudness range target (from 1 to 20) (default 7)
/// </summary>
public LoudnormFilterGen LRA(double LRA) => this.SetOptionRange("LRA", LRA,1,20);
/// <summary>
///  set loudness range target (from 1 to 20) (default 7)
/// </summary>
public LoudnormFilterGen lra(double lra) => this.SetOptionRange("lra", lra,1,20);
/// <summary>
///  set maximum true peak (from -9 to 0) (default -2)
/// </summary>
public LoudnormFilterGen TP(double TP) => this.SetOptionRange("TP", TP,-9,0);
/// <summary>
///  set maximum true peak (from -9 to 0) (default -2)
/// </summary>
public LoudnormFilterGen tp(double tp) => this.SetOptionRange("tp", tp,-9,0);
/// <summary>
///  measured IL of input file (from -99 to 0) (default 0)
/// </summary>
public LoudnormFilterGen measured_I(double measured_I) => this.SetOptionRange("measured_I", measured_I,-99,0);
/// <summary>
///  measured IL of input file (from -99 to 0) (default 0)
/// </summary>
public LoudnormFilterGen measured_i(double measured_i) => this.SetOptionRange("measured_i", measured_i,-99,0);
/// <summary>
///  measured LRA of input file (from 0 to 99) (default 0)
/// </summary>
public LoudnormFilterGen measured_LRA(double measured_LRA) => this.SetOptionRange("measured_LRA", measured_LRA,0,99);
/// <summary>
///  measured LRA of input file (from 0 to 99) (default 0)
/// </summary>
public LoudnormFilterGen measured_lra(double measured_lra) => this.SetOptionRange("measured_lra", measured_lra,0,99);
/// <summary>
///  measured true peak of input file (from -99 to 99) (default 99)
/// </summary>
public LoudnormFilterGen measured_TP(double measured_TP) => this.SetOptionRange("measured_TP", measured_TP,-99,99);
/// <summary>
///  measured true peak of input file (from -99 to 99) (default 99)
/// </summary>
public LoudnormFilterGen measured_tp(double measured_tp) => this.SetOptionRange("measured_tp", measured_tp,-99,99);
/// <summary>
///  measured threshold of input file (from -99 to 0) (default -70)
/// </summary>
public LoudnormFilterGen measured_thresh(double measured_thresh) => this.SetOptionRange("measured_thresh", measured_thresh,-99,0);
/// <summary>
///  set offset gain (from -99 to 99) (default 0)
/// </summary>
public LoudnormFilterGen offset(double offset) => this.SetOptionRange("offset", offset,-99,99);
/// <summary>
///  normalize linearly if possible (default true)
/// </summary>
public LoudnormFilterGen linear(bool flag) => this.SetOption("linear",flag.ToFFmpegFlag());
/// <summary>
///  treat mono input as dual-mono (default false)
/// </summary>
public LoudnormFilterGen dual_mono(bool flag) => this.SetOption("dual_mono",flag.ToFFmpegFlag());
/// <summary>
///  set print format for stats (from 0 to 2) (default none)
/// </summary>
public LoudnormFilterGen print_format(LoudnormFilterGenPrint_format print_format) => this.SetOption("print_format", print_format.GetAttribute<NameAttribute>().Name);
}
public static class LoudnormFilterGenExtensions
{
/// <summary>
/// EBU R128 loudness normalization
/// </summary>
public static LoudnormFilterGen LoudnormFilterGen(this AudioMap input0) => new LoudnormFilterGen(input0);
}
public enum LoudnormFilterGenPrint_format
{
[Name("none")] none,
[Name("json")] json,
[Name("summary")] summary,
}

}
