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
public class AsoftclipFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AsoftclipFilterGen(AudioMap input) : base("asoftclip",input) { AddMapOut(); }
/// <summary>
///  set softclip type (from -1 to 7) (default tanh)
/// </summary>
public AsoftclipFilterGen type(AsoftclipFilterGenType type) => this.SetOption("type", type.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set softclip threshold (from 1e-06 to 1) (default 1)
/// </summary>
public AsoftclipFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,1e-06,1);
/// <summary>
///  set softclip output gain (from 1e-06 to 16) (default 1)
/// </summary>
public AsoftclipFilterGen output(double output) => this.SetOptionRange("output", output,1e-06,16);
/// <summary>
///  set softclip parameter (from 0.01 to 3) (default 1)
/// </summary>
public AsoftclipFilterGen param(double param) => this.SetOptionRange("param", param,0.01,3);
/// <summary>
///  set oversample factor (from 1 to 32) (default 1)
/// </summary>
public AsoftclipFilterGen oversample(int oversample) => this.SetOptionRange("oversample", oversample,1,32);
}
public static class AsoftclipFilterGenExtensions
{
/// <summary>
/// Audio Soft Clipper.
/// </summary>
public static AsoftclipFilterGen AsoftclipFilterGen(this AudioMap input0) => new AsoftclipFilterGen(input0);
}
public enum AsoftclipFilterGenType
{
[Name("hard")] hard,
[Name("tanh")] tanh,
[Name("atan")] atan,
[Name("cubic")] cubic,
[Name("exp")] exp,
[Name("alg")] alg,
[Name("quintic")] quintic,
[Name("sin")] sin,
[Name("erf")] erf,
}

}
