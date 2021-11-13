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
///  set amplitude (from 0 to 1) (default 1)
/// </summary>
public AnoisesrcFilterGen a(double a) => this.SetOptionRange("a", a,0,1);
/// <summary>
///  set duration (default 0)
/// </summary>
public AnoisesrcFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set duration (default 0)
/// </summary>
public AnoisesrcFilterGen d(TimeSpan d) => this.SetOptionRange("d",d,TimeSpan.Zero,TimeSpan.MaxValue);
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
///  set random seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public AnoisesrcFilterGen s(long s) => this.SetOptionRange("s", s,-1,UINT32_MAX);
/// <summary>
///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
/// </summary>
public AnoisesrcFilterGen nb_samples(int nb_samples) => this.SetOptionRange("nb_samples", nb_samples,1,INT_MAX);
/// <summary>
///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
/// </summary>
public AnoisesrcFilterGen n(int n) => this.SetOptionRange("n", n,1,INT_MAX);
}
public static class AnoisesrcFilterGenExtensions
{
/// <summary>
/// Generate a noise audio signal.
/// </summary>
public static AnoisesrcFilterGen AnoisesrcFilterGen(this FilterGraph input0) => new AnoisesrcFilterGen(input0);
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
