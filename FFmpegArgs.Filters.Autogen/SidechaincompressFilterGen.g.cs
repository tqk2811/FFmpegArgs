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
public class SidechaincompressFilterGen : AudioToAudioFilter,ICommandSupport
{
internal SidechaincompressFilterGen(params AudioMap[] inputs) : base("sidechaincompress",inputs) { AddMapOut(); }
/// <summary>
///  set input gain (from 0.015625 to 64) (default 1)
/// </summary>
public SidechaincompressFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in,0.015625,64);
/// <summary>
///  set mode (from 0 to 1) (default downward)
/// </summary>
public SidechaincompressFilterGen mode(SidechaincompressFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set threshold (from 0.000976563 to 1) (default 0.125)
/// </summary>
public SidechaincompressFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,0.000976563,1);
/// <summary>
///  set ratio (from 1 to 20) (default 2)
/// </summary>
public SidechaincompressFilterGen ratio(double ratio) => this.SetOptionRange("ratio", ratio,1,20);
/// <summary>
///  set attack (from 0.01 to 2000) (default 20)
/// </summary>
public SidechaincompressFilterGen attack(double attack) => this.SetOptionRange("attack", attack,0.01,2000);
/// <summary>
///  set release (from 0.01 to 9000) (default 250)
/// </summary>
public SidechaincompressFilterGen release(double release) => this.SetOptionRange("release", release,0.01,9000);
/// <summary>
///  set make up gain (from 1 to 64) (default 1)
/// </summary>
public SidechaincompressFilterGen makeup(double makeup) => this.SetOptionRange("makeup", makeup,1,64);
/// <summary>
///  set knee (from 1 to 8) (default 2.82843)
/// </summary>
public SidechaincompressFilterGen knee(double knee) => this.SetOptionRange("knee", knee,1,8);
/// <summary>
///  set link type (from 0 to 1) (default average)
/// </summary>
public SidechaincompressFilterGen link(SidechaincompressFilterGenLink link) => this.SetOption("link", link.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set detection (from 0 to 1) (default rms)
/// </summary>
public SidechaincompressFilterGen detection(SidechaincompressFilterGenDetection detection) => this.SetOption("detection", detection.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set sidechain gain (from 0.015625 to 64) (default 1)
/// </summary>
public SidechaincompressFilterGen level_sc(double level_sc) => this.SetOptionRange("level_sc", level_sc,0.015625,64);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public SidechaincompressFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
}
public static class SidechaincompressFilterGenExtensions
{
/// <summary>
/// Sidechain compressor.
/// </summary>
public static SidechaincompressFilterGen SidechaincompressFilterGen(this AudioMap input0, AudioMap input1) => new SidechaincompressFilterGen(input0, input1);
/// <summary>
/// Sidechain compressor.
/// </summary>
public static SidechaincompressFilterGen SidechaincompressFilterGen(this AudioMap input0, AudioMap input1,SidechaincompressFilterGenConfig config)
{
var result = new SidechaincompressFilterGen(input0, input1);
if(config?.level_in != null) result.level_in(config.level_in);
if(config?.mode != null) result.mode(config.mode);
if(config?.threshold != null) result.threshold(config.threshold);
if(config?.ratio != null) result.ratio(config.ratio);
if(config?.attack != null) result.attack(config.attack);
if(config?.release != null) result.release(config.release);
if(config?.makeup != null) result.makeup(config.makeup);
if(config?.knee != null) result.knee(config.knee);
if(config?.link != null) result.link(config.link);
if(config?.detection != null) result.detection(config.detection);
if(config?.level_sc != null) result.level_sc(config.level_sc);
if(config?.mix != null) result.mix(config.mix);
return result;
}
}
public class SidechaincompressFilterGenConfig
{
/// <summary>
///  set input gain (from 0.015625 to 64) (default 1)
/// </summary>
public double level_in { get; set; }
/// <summary>
///  set mode (from 0 to 1) (default downward)
/// </summary>
public SidechaincompressFilterGenMode mode { get; set; }
/// <summary>
///  set threshold (from 0.000976563 to 1) (default 0.125)
/// </summary>
public double threshold { get; set; }
/// <summary>
///  set ratio (from 1 to 20) (default 2)
/// </summary>
public double ratio { get; set; }
/// <summary>
///  set attack (from 0.01 to 2000) (default 20)
/// </summary>
public double attack { get; set; }
/// <summary>
///  set release (from 0.01 to 9000) (default 250)
/// </summary>
public double release { get; set; }
/// <summary>
///  set make up gain (from 1 to 64) (default 1)
/// </summary>
public double makeup { get; set; }
/// <summary>
///  set knee (from 1 to 8) (default 2.82843)
/// </summary>
public double knee { get; set; }
/// <summary>
///  set link type (from 0 to 1) (default average)
/// </summary>
public SidechaincompressFilterGenLink link { get; set; }
/// <summary>
///  set detection (from 0 to 1) (default rms)
/// </summary>
public SidechaincompressFilterGenDetection detection { get; set; }
/// <summary>
///  set sidechain gain (from 0.015625 to 64) (default 1)
/// </summary>
public double level_sc { get; set; }
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public double mix { get; set; }
}
public enum SidechaincompressFilterGenMode
{
[Name("downward")] downward,
[Name("upward")] upward,
}

public enum SidechaincompressFilterGenLink
{
[Name("average")] average,
[Name("maximum")] maximum,
}

public enum SidechaincompressFilterGenDetection
{
[Name("peak")] peak,
[Name("rms")] rms,
}

}
