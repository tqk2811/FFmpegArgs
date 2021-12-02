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
public CrystalizerFilterGen c(bool c) => this.SetOption("c",c.ToFFmpegFlag());
}
public static class CrystalizerFilterGenExtensions
{
/// <summary>
/// Simple audio noise sharpening filter.
/// </summary>
public static CrystalizerFilterGen CrystalizerFilterGen(this AudioMap input0) => new CrystalizerFilterGen(input0);
/// <summary>
/// Simple audio noise sharpening filter.
/// </summary>
public static CrystalizerFilterGen CrystalizerFilterGen(this AudioMap input0,CrystalizerFilterGenConfig config)
{
var result = new CrystalizerFilterGen(input0);
if(config?.i != null) result.i(config.i);
if(config?.c != null) result.c(config.c);
return result;
}
}
public class CrystalizerFilterGenConfig
{
/// <summary>
///  set intensity (from -10 to 10) (default 2)
/// </summary>
public float i { get; set; }
/// <summary>
///  enable clipping (default true)
/// </summary>
public bool c { get; set; }
}
}
