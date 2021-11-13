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
public class AemphasisFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AemphasisFilterGen(AudioMap input) : base("aemphasis",input) { AddMapOut(); }
/// <summary>
///  set input gain (from 0 to 64) (default 1)
/// </summary>
public AemphasisFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in,0,64);
/// <summary>
///  set output gain (from 0 to 64) (default 1)
/// </summary>
public AemphasisFilterGen level_out(double level_out) => this.SetOptionRange("level_out", level_out,0,64);
/// <summary>
///  set filter mode (from 0 to 1) (default reproduction)
/// </summary>
public AemphasisFilterGen mode(AemphasisFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set filter type (from 0 to 8) (default cd)
/// </summary>
public AemphasisFilterGen type(AemphasisFilterGenType type) => this.SetOption("type", type.GetAttribute<NameAttribute>().Name);
}
public static class AemphasisFilterGenExtensions
{
/// <summary>
/// Audio emphasis.
/// </summary>
public static AemphasisFilterGen AemphasisFilterGen(this AudioMap input) => new AemphasisFilterGen(input);
}
public enum AemphasisFilterGenMode
{
[Name("reproduction")] reproduction,
[Name("production")] production,
}

public enum AemphasisFilterGenType
{
[Name("col")] col,
[Name("emi")] emi,
[Name("bsi")] bsi,
[Name("riaa")] riaa,
[Name("cd")] cd,
[Name("50fm")] _50fm,
[Name("75fm")] _75fm,
[Name("50kf")] _50kf,
[Name("75kf")] _75kf,
}

}
