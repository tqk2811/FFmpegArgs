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
public class FlangerFilterGen : AudioToAudioFilter
{
internal FlangerFilterGen(AudioMap input) : base("flanger",input) { AddMapOut(); }
/// <summary>
///  base delay in milliseconds (from 0 to 30) (default 0)
/// </summary>
public FlangerFilterGen delay(double delay) => this.SetOptionRange("delay", delay,0,30);
/// <summary>
///  added swept delay in milliseconds (from 0 to 10) (default 2)
/// </summary>
public FlangerFilterGen depth(double depth) => this.SetOptionRange("depth", depth,0,10);
/// <summary>
///  percentage regeneration (delayed signal feedback) (from -95 to 95) (default 0)
/// </summary>
public FlangerFilterGen regen(double regen) => this.SetOptionRange("regen", regen,-95,95);
/// <summary>
///  percentage of delayed signal mixed with original (from 0 to 100) (default 71)
/// </summary>
public FlangerFilterGen width(double width) => this.SetOptionRange("width", width,0,100);
/// <summary>
///  sweeps per second (Hz) (from 0.1 to 10) (default 0.5)
/// </summary>
public FlangerFilterGen speed(double speed) => this.SetOptionRange("speed", speed,0.1,10);
/// <summary>
///  swept wave shape (from 0 to 1) (default sinusoidal)
/// </summary>
public FlangerFilterGen shape(FlangerFilterGenShape shape) => this.SetOption("shape", shape.GetAttribute<NameAttribute>().Name);
/// <summary>
///  swept wave percentage phase-shift for multi-channel (from 0 to 100) (default 25)
/// </summary>
public FlangerFilterGen phase(double phase) => this.SetOptionRange("phase", phase,0,100);
/// <summary>
///  delay-line interpolation (from 0 to 1) (default linear)
/// </summary>
public FlangerFilterGen interp(FlangerFilterGenInterp interp) => this.SetOption("interp", interp.GetAttribute<NameAttribute>().Name);
}
public static class FlangerFilterGenExtensions
{
/// <summary>
/// Apply a flanging effect to the audio.
/// </summary>
public static FlangerFilterGen FlangerFilterGen(this AudioMap input) => new FlangerFilterGen(input);
}
public enum FlangerFilterGenShape
{
[Name("triangular")] triangular,
[Name("t")] t,
[Name("sinusoidal")] sinusoidal,
[Name("s")] s,
}

public enum FlangerFilterGenInterp
{
[Name("linear")] linear,
[Name("quadratic")] quadratic,
}

}
