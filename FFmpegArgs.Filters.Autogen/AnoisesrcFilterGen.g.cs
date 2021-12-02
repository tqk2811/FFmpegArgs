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
public class AnoisesrcFilterGen : SourceAudioFilter
{
internal AnoisesrcFilterGen(FilterGraph input) : base("anoisesrc",input) { AddMapOut(); }
/// <summary>
///  set sample rate (from 15 to INT_MAX) (default 48000)
/// </summary>
public AnoisesrcFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate,15,INT_MAX);
/// <summary>
///  set sample rate (from 15 to INT_MAX) (default 48000)
/// </summary>
public AnoisesrcFilterGen r(int r) => this.SetOptionRange("r", r,15,INT_MAX);
/// <summary>
///  set amplitude (from 0 to 1) (default 1)
/// </summary>
public AnoisesrcFilterGen amplitude(double amplitude) => this.SetOptionRange("amplitude", amplitude,0,1);
/// <summary>
///  set duration (default 0)
/// </summary>
public AnoisesrcFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set noise color (from 0 to 5) (default white)
/// </summary>
public AnoisesrcFilterGen color(AnoisesrcFilterGenColor color) => this.SetOption("color", color.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set noise color (from 0 to 5) (default white)
/// </summary>
public AnoisesrcFilterGen colour(AnoisesrcFilterGenColour colour) => this.SetOption("colour", colour.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set noise color (from 0 to 5) (default white)
/// </summary>
public AnoisesrcFilterGen c(AnoisesrcFilterGenC c) => this.SetOption("c", c.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set random seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public AnoisesrcFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
/// <summary>
///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
/// </summary>
public AnoisesrcFilterGen nb_samples(int nb_samples) => this.SetOptionRange("nb_samples", nb_samples,1,INT_MAX);
}
public static class AnoisesrcFilterGenExtensions
{
/// <summary>
/// Generate a noise audio signal.
/// </summary>
public static AnoisesrcFilterGen AnoisesrcFilterGen(this FilterGraph input0) => new AnoisesrcFilterGen(input0);
/// <summary>
/// Generate a noise audio signal.
/// </summary>
public static AnoisesrcFilterGen AnoisesrcFilterGen(this FilterGraph input0,AnoisesrcFilterGenConfig config)
{
var result = new AnoisesrcFilterGen(input0);
if(config?.sample_rate != null) result.sample_rate(config.sample_rate.Value);
if(config?.r != null) result.r(config.r.Value);
if(config?.amplitude != null) result.amplitude(config.amplitude.Value);
if(config?.duration != null) result.duration(config.duration.Value);
if(config?.color != null) result.color(config.color.Value);
if(config?.colour != null) result.colour(config.colour.Value);
if(config?.c != null) result.c(config.c.Value);
if(config?.seed != null) result.seed(config.seed.Value);
if(config?.nb_samples != null) result.nb_samples(config.nb_samples.Value);
return result;
}
}
public class AnoisesrcFilterGenConfig
{
/// <summary>
///  set sample rate (from 15 to INT_MAX) (default 48000)
/// </summary>
public int? sample_rate { get; set; }
/// <summary>
///  set sample rate (from 15 to INT_MAX) (default 48000)
/// </summary>
public int? r { get; set; }
/// <summary>
///  set amplitude (from 0 to 1) (default 1)
/// </summary>
public double? amplitude { get; set; }
/// <summary>
///  set duration (default 0)
/// </summary>
public TimeSpan? duration { get; set; }
/// <summary>
///  set noise color (from 0 to 5) (default white)
/// </summary>
public AnoisesrcFilterGenColor? color { get; set; }
/// <summary>
///  set noise color (from 0 to 5) (default white)
/// </summary>
public AnoisesrcFilterGenColour? colour { get; set; }
/// <summary>
///  set noise color (from 0 to 5) (default white)
/// </summary>
public AnoisesrcFilterGenC? c { get; set; }
/// <summary>
///  set random seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public long? seed { get; set; }
/// <summary>
///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
/// </summary>
public int? nb_samples { get; set; }
}
public enum AnoisesrcFilterGenColor
{
[Name("white")] white,
[Name("pink")] pink,
[Name("brown")] brown,
[Name("blue")] blue,
[Name("violet")] violet,
[Name("velvet")] velvet,
}

public enum AnoisesrcFilterGenColour
{
[Name("white")] white,
[Name("pink")] pink,
[Name("brown")] brown,
[Name("blue")] blue,
[Name("violet")] violet,
[Name("velvet")] velvet,
}

public enum AnoisesrcFilterGenC
{
[Name("white")] white,
[Name("pink")] pink,
[Name("brown")] brown,
[Name("blue")] blue,
[Name("violet")] violet,
[Name("velvet")] velvet,
}

}
