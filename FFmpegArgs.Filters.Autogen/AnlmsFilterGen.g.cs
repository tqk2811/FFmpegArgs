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
public class AnlmsFilterGen : AudioToAudioFilter,ISliceThreading,ICommandSupport
{
internal AnlmsFilterGen(params AudioMap[] inputs) : base("anlms",inputs) { AddMapOut(); }
/// <summary>
///  set the filter order (from 1 to 32767) (default 256)
/// </summary>
public AnlmsFilterGen order(int order) => this.SetOptionRange("order", order,1,32767);
/// <summary>
///  set the filter mu (from 0 to 2) (default 0.75)
/// </summary>
public AnlmsFilterGen mu(float mu) => this.SetOptionRange("mu", mu,0,2);
/// <summary>
///  set the filter eps (from 0 to 1) (default 1)
/// </summary>
public AnlmsFilterGen eps(float eps) => this.SetOptionRange("eps", eps,0,1);
/// <summary>
///  set the filter leakage (from 0 to 1) (default 0)
/// </summary>
public AnlmsFilterGen leakage(float leakage) => this.SetOptionRange("leakage", leakage,0,1);
/// <summary>
///  set output mode (from 0 to 3) (default o)
/// </summary>
public AnlmsFilterGen out_mode(AnlmsFilterGenOut_mode out_mode) => this.SetOption("out_mode", out_mode.GetAttribute<NameAttribute>().Name);
}
public static class AnlmsFilterGenExtensions
{
/// <summary>
/// Apply Normalized Least-Mean-Squares algorithm to first audio stream.
/// </summary>
public static AnlmsFilterGen AnlmsFilterGen(this AudioMap input0, AudioMap input1) => new AnlmsFilterGen(input0, input1);
}
public enum AnlmsFilterGenOut_mode
{
[Name("i")] i,
[Name("d")] d,
[Name("o")] o,
[Name("n")] n,
}

}
