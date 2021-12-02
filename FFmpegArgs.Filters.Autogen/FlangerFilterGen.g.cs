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
public static FlangerFilterGen FlangerFilterGen(this AudioMap input0) => new FlangerFilterGen(input0);
/// <summary>
/// Apply a flanging effect to the audio.
/// </summary>
public static FlangerFilterGen FlangerFilterGen(this AudioMap input0,FlangerFilterGenConfig config)
{
var result = new FlangerFilterGen(input0);
if(config?.delay != null) result.delay(config.delay);
if(config?.depth != null) result.depth(config.depth);
if(config?.regen != null) result.regen(config.regen);
if(config?.width != null) result.width(config.width);
if(config?.speed != null) result.speed(config.speed);
if(config?.shape != null) result.shape(config.shape);
if(config?.phase != null) result.phase(config.phase);
if(config?.interp != null) result.interp(config.interp);
return result;
}
}
public class FlangerFilterGenConfig
{
/// <summary>
///  base delay in milliseconds (from 0 to 30) (default 0)
/// </summary>
public double delay { get; set; }
/// <summary>
///  added swept delay in milliseconds (from 0 to 10) (default 2)
/// </summary>
public double depth { get; set; }
/// <summary>
///  percentage regeneration (delayed signal feedback) (from -95 to 95) (default 0)
/// </summary>
public double regen { get; set; }
/// <summary>
///  percentage of delayed signal mixed with original (from 0 to 100) (default 71)
/// </summary>
public double width { get; set; }
/// <summary>
///  sweeps per second (Hz) (from 0.1 to 10) (default 0.5)
/// </summary>
public double speed { get; set; }
/// <summary>
///  swept wave shape (from 0 to 1) (default sinusoidal)
/// </summary>
public FlangerFilterGenShape shape { get; set; }
/// <summary>
///  swept wave percentage phase-shift for multi-channel (from 0 to 100) (default 25)
/// </summary>
public double phase { get; set; }
/// <summary>
///  delay-line interpolation (from 0 to 1) (default linear)
/// </summary>
public FlangerFilterGenInterp interp { get; set; }
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
