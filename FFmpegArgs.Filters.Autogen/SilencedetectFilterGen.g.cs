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
public class SilencedetectFilterGen : AudioToAudioFilter
{
internal SilencedetectFilterGen(AudioMap input) : base("silencedetect",input) { AddMapOut(); }
/// <summary>
///  set noise tolerance (from 0 to DBL_MAX) (default 0.001)
/// </summary>
public SilencedetectFilterGen n(double n) => this.SetOptionRange("n", n,0,DBL_MAX);
/// <summary>
///  set noise tolerance (from 0 to DBL_MAX) (default 0.001)
/// </summary>
public SilencedetectFilterGen noise(double noise) => this.SetOptionRange("noise", noise,0,DBL_MAX);
/// <summary>
///  set minimum duration in seconds (default 2)
/// </summary>
public SilencedetectFilterGen d(TimeSpan d) => this.SetOptionRange("d",d,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set minimum duration in seconds (default 2)
/// </summary>
public SilencedetectFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  check each channel separately (default false)
/// </summary>
public SilencedetectFilterGen mono(bool flag) => this.SetOption("mono",flag.ToFFmpegFlag());
/// <summary>
///  check each channel separately (default false)
/// </summary>
public SilencedetectFilterGen m(bool flag) => this.SetOption("m",flag.ToFFmpegFlag());
}
public static class SilencedetectFilterGenExtensions
{
/// <summary>
/// Detect silence.
/// </summary>
public static SilencedetectFilterGen SilencedetectFilterGen(this AudioMap input) => new SilencedetectFilterGen(input);
}
}
