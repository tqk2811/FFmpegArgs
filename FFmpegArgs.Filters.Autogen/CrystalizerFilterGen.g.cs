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
public class CrystalizerFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal CrystalizerFilterGen(AudioMap input) : base("crystalizer",input) { AddMapOut(); }
/// <summary>
///  set intensity (from -10 to 10) (default 2)
/// </summary>
public CrystalizerFilterGen i(float i) => this.SetOptionRange("i", i,-10,10);
/// <summary>
///  enable clipping (default true)
/// </summary>
public CrystalizerFilterGen c(bool flag) => this.SetOption("c",flag.ToFFmpegFlag());
}
public static class CrystalizerFilterGenExtensions
{
/// <summary>
/// Simple audio noise sharpening filter.
/// </summary>
public static CrystalizerFilterGen CrystalizerFilterGen(this AudioMap input) => new CrystalizerFilterGen(input);
}
}
