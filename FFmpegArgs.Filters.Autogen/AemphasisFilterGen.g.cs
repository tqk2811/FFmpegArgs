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
public static AemphasisFilterGen AemphasisFilterGen(this AudioMap input0) => new AemphasisFilterGen(input0);
/// <summary>
/// Audio emphasis.
/// </summary>
public static AemphasisFilterGen AemphasisFilterGen(this AudioMap input0,AemphasisFilterGenConfig config)
{
var result = new AemphasisFilterGen(input0);
if(config?.level_in != null) result.level_in(config.level_in);
if(config?.level_out != null) result.level_out(config.level_out);
if(config?.mode != null) result.mode(config.mode);
if(config?.type != null) result.type(config.type);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class AemphasisFilterGenConfig
{
/// <summary>
///  set input gain (from 0 to 64) (default 1)
/// </summary>
public double level_in { get; set; }
/// <summary>
///  set output gain (from 0 to 64) (default 1)
/// </summary>
public double level_out { get; set; }
/// <summary>
///  set filter mode (from 0 to 1) (default reproduction)
/// </summary>
public AemphasisFilterGenMode mode { get; set; }
/// <summary>
///  set filter type (from 0 to 8) (default cd)
/// </summary>
public AemphasisFilterGenType type { get; set; }
public string TimelineSupport { get; set; }
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
