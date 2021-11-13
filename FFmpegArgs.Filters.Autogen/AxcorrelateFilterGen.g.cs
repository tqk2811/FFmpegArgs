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
public class AxcorrelateFilterGen : AudioToAudioFilter
{
internal AxcorrelateFilterGen(params AudioMap[] inputs) : base("axcorrelate",inputs) { AddMapOut(); }
/// <summary>
///  set segment size (from 2 to 131072) (default 256)
/// </summary>
public AxcorrelateFilterGen size(int size) => this.SetOptionRange("size", size,2,131072);
/// <summary>
///  set alghorithm (from 0 to 1) (default slow)
/// </summary>
public AxcorrelateFilterGen algo(AxcorrelateFilterGenAlgo algo) => this.SetOption("algo", algo.GetAttribute<NameAttribute>().Name);
}
public static class AxcorrelateFilterGenExtensions
{
/// <summary>
/// Cross-correlate two audio streams.
/// </summary>
public static AxcorrelateFilterGen AxcorrelateFilterGen(this AudioMap input0, AudioMap input1) => new AxcorrelateFilterGen(input0, input1);
}
public enum AxcorrelateFilterGenAlgo
{
[Name("slow")] slow,
[Name("fast")] fast,
}

}
