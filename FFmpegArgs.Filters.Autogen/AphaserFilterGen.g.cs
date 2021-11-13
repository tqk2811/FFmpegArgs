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
public class AphaserFilterGen : AudioToAudioFilter
{
internal AphaserFilterGen(AudioMap input) : base("aphaser",input) { AddMapOut(); }
/// <summary>
///  set input gain (from 0 to 1) (default 0.4)
/// </summary>
public AphaserFilterGen in_gain(double in_gain) => this.SetOptionRange("in_gain", in_gain,0,1);
/// <summary>
///  set output gain (from 0 to 1e+09) (default 0.74)
/// </summary>
public AphaserFilterGen out_gain(double out_gain) => this.SetOptionRange("out_gain", out_gain,0,1e+09);
/// <summary>
///  set delay in milliseconds (from 0 to 5) (default 3)
/// </summary>
public AphaserFilterGen delay(double delay) => this.SetOptionRange("delay", delay,0,5);
/// <summary>
///  set decay (from 0 to 0.99) (default 0.4)
/// </summary>
public AphaserFilterGen decay(double decay) => this.SetOptionRange("decay", decay,0,0.99);
/// <summary>
///  set modulation speed (from 0.1 to 2) (default 0.5)
/// </summary>
public AphaserFilterGen speed(double speed) => this.SetOptionRange("speed", speed,0.1,2);
/// <summary>
///  set modulation type (from 0 to 1) (default triangular)
/// </summary>
public AphaserFilterGen type(AphaserFilterGenType type) => this.SetOption("type", type.GetAttribute<NameAttribute>().Name);
}
public static class AphaserFilterGenExtensions
{
/// <summary>
/// Add a phasing effect to the audio.
/// </summary>
public static AphaserFilterGen AphaserFilterGen(this AudioMap input) => new AphaserFilterGen(input);
}
public enum AphaserFilterGenType
{
[Name("triangular")] triangular,
[Name("t")] t,
[Name("sinusoidal")] sinusoidal,
[Name("s")] s,
}

}
