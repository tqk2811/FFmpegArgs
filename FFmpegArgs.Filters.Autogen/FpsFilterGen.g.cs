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
public class FpsFilterGen : ImageToImageFilter
{
internal FpsFilterGen(ImageMap input) : base("fps",input) { AddMapOut(); }
/// <summary>
///  A string describing desired output framerate (default "25")
/// </summary>
public FpsFilterGen Fps(string r) => this.SetOption("fps", r);
/// <summary>
///  A string describing desired output framerate (default "25")
/// </summary>
public FpsFilterGen fps(int r) => this.SetOptionRange("fps", r, 1, int.MaxValue);
/// <summary>
///  Assume the first PTS should be this value. (from -DBL_MAX to DBL_MAX) (default DBL_MAX)
/// </summary>
public FpsFilterGen start_time(double start_time) => this.SetOptionRange("start_time", start_time,-DBL_MAX,DBL_MAX);
/// <summary>
///  set rounding method for timestamps (from 0 to 5) (default near)
/// </summary>
public FpsFilterGen round(FpsFilterGenRound round) => this.SetOption("round", round.GetAttribute<NameAttribute>().Name);
/// <summary>
///  action performed for last frame (from 0 to 1) (default round)
/// </summary>
public FpsFilterGen eof_action(FpsFilterGenEof_action eof_action) => this.SetOption("eof_action", eof_action.GetAttribute<NameAttribute>().Name);
}
public static class FpsFilterGenExtensions
{
/// <summary>
/// Force constant framerate.
/// </summary>
public static FpsFilterGen FpsFilterGen(this ImageMap input0) => new FpsFilterGen(input0);
}
public enum FpsFilterGenRound
{
[Name("zero")] zero,
[Name("inf")] inf,
[Name("down")] down,
[Name("up")] up,
[Name("near")] near,
}

public enum FpsFilterGenEof_action
{
[Name("round")] round,
[Name("pass")] pass,
}

}
