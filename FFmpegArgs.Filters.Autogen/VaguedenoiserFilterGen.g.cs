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
public static VaguedenoiserFilterGen VaguedenoiserFilterGen(this ImageMap input) => new VaguedenoiserFilterGen(input);
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
