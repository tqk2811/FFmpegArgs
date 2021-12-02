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
public class VaguedenoiserFilterGen : ImageToImageFilter,ITimelineSupport
{
internal VaguedenoiserFilterGen(ImageMap input) : base("vaguedenoiser",input) { AddMapOut(); }
/// <summary>
///  set filtering strength (from 0 to DBL_MAX) (default 2)
/// </summary>
public VaguedenoiserFilterGen threshold(float threshold) => this.SetOptionRange("threshold", threshold,0,DBL_MAX);
/// <summary>
///  set filtering method (from 0 to 2) (default garrote)
/// </summary>
public VaguedenoiserFilterGen method(VaguedenoiserFilterGenMethod method) => this.SetOption("method", method.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set number of steps (from 1 to 32) (default 6)
/// </summary>
public VaguedenoiserFilterGen nsteps(int nsteps) => this.SetOptionRange("nsteps", nsteps,1,32);
/// <summary>
///  set percent of full denoising (from 0 to 100) (default 85)
/// </summary>
public VaguedenoiserFilterGen percent(float percent) => this.SetOptionRange("percent", percent,0,100);
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public VaguedenoiserFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set threshold type (from 0 to 1) (default universal)
/// </summary>
public VaguedenoiserFilterGen type(VaguedenoiserFilterGenType type) => this.SetOption("type", type.GetAttribute<NameAttribute>().Name);
}
public static class VaguedenoiserFilterGenExtensions
{
/// <summary>
/// Apply a Wavelet based Denoiser.
/// </summary>
public static VaguedenoiserFilterGen VaguedenoiserFilterGen(this ImageMap input0) => new VaguedenoiserFilterGen(input0);
/// <summary>
/// Apply a Wavelet based Denoiser.
/// </summary>
public static VaguedenoiserFilterGen VaguedenoiserFilterGen(this ImageMap input0,VaguedenoiserFilterGenConfig config)
{
var result = new VaguedenoiserFilterGen(input0);
if(config?.threshold != null) result.threshold(config.threshold);
if(config?.method != null) result.method(config.method);
if(config?.nsteps != null) result.nsteps(config.nsteps);
if(config?.percent != null) result.percent(config.percent);
if(config?.planes != null) result.planes(config.planes);
if(config?.type != null) result.type(config.type);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class VaguedenoiserFilterGenConfig
{
/// <summary>
///  set filtering strength (from 0 to DBL_MAX) (default 2)
/// </summary>
public float threshold { get; set; }
/// <summary>
///  set filtering method (from 0 to 2) (default garrote)
/// </summary>
public VaguedenoiserFilterGenMethod method { get; set; }
/// <summary>
///  set number of steps (from 1 to 32) (default 6)
/// </summary>
public int nsteps { get; set; }
/// <summary>
///  set percent of full denoising (from 0 to 100) (default 85)
/// </summary>
public float percent { get; set; }
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public int planes { get; set; }
/// <summary>
///  set threshold type (from 0 to 1) (default universal)
/// </summary>
public VaguedenoiserFilterGenType type { get; set; }
public string TimelineSupport { get; set; }
}
public enum VaguedenoiserFilterGenMethod
{
[Name("hard")] hard,
[Name("soft")] soft,
[Name("garrote")] garrote,
}

public enum VaguedenoiserFilterGenType
{
[Name("universal")] universal,
[Name("bayes")] bayes,
}

}
