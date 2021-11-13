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
public class AphaseshiftFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AphaseshiftFilterGen(AudioMap input) : base("aphaseshift",input) { AddMapOut(); }
/// <summary>
///  set phase shift (from -1 to 1) (default 0)
/// </summary>
public AphaseshiftFilterGen shift(double shift) => this.SetOptionRange("shift", shift,-1,1);
/// <summary>
///  set output level (from 0 to 1) (default 1)
/// </summary>
public AphaseshiftFilterGen level(double level) => this.SetOptionRange("level", level,0,1);
}
public static class AphaseshiftFilterGenExtensions
{
/// <summary>
/// Apply phase shifting to input audio.
/// </summary>
public static AphaseshiftFilterGen AphaseshiftFilterGen(this AudioMap input) => new AphaseshiftFilterGen(input);
}
}
