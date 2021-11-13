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
public class AloopFilterGen : AudioToAudioFilter
{
internal AloopFilterGen(AudioMap input) : base("aloop",input) { AddMapOut(); }
/// <summary>
///  number of loops (from -1 to INT_MAX) (default 0)
/// </summary>
public AloopFilterGen loop(int loop) => this.SetOptionRange("loop", loop,-1,INT_MAX);
/// <summary>
///  max number of samples to loop (from 0 to INT_MAX) (default 0)
/// </summary>
public AloopFilterGen size(long size) => this.SetOptionRange("size", size,0,INT_MAX);
/// <summary>
///  set the loop start sample (from 0 to I64_MAX) (default 0)
/// </summary>
public AloopFilterGen start(long start) => this.SetOptionRange("start", start,0,I64_MAX);
}
public static class AloopFilterGenExtensions
{
/// <summary>
/// Loop audio samples.
/// </summary>
public static AloopFilterGen AloopFilterGen(this AudioMap input0) => new AloopFilterGen(input0);
}
}
