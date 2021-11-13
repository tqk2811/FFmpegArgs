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
public class AcompressorFilterGen : AudioToAudioFilter,ICommandSupport
{
internal AcompressorFilterGen(AudioMap input) : base("acompressor",input) { AddMapOut(); }
/// <summary>
///  set input gain (from 0.015625 to 64) (default 1)
/// </summary>
public AcompressorFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in,0.015625,64);
/// <summary>
///  set mode (from 0 to 1) (default downward)
/// </summary>
public AcompressorFilterGen mode(AcompressorFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set threshold (from 0.000976563 to 1) (default 0.125)
/// </summary>
public AcompressorFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,0.000976563,1);
/// <summary>
///  set ratio (from 1 to 20) (default 2)
/// </summary>
public AcompressorFilterGen ratio(double ratio) => this.SetOptionRange("ratio", ratio,1,20);
/// <summary>
///  set attack (from 0.01 to 2000) (default 20)
/// </summary>
public AcompressorFilterGen attack(double attack) => this.SetOptionRange("attack", attack,0.01,2000);
/// <summary>
///  set release (from 0.01 to 9000) (default 250)
/// </summary>
public AcompressorFilterGen release(double release) => this.SetOptionRange("release", release,0.01,9000);
/// <summary>
///  set make up gain (from 1 to 64) (default 1)
/// </summary>
public AcompressorFilterGen makeup(double makeup) => this.SetOptionRange("makeup", makeup,1,64);
/// <summary>
///  set knee (from 1 to 8) (default 2.82843)
/// </summary>
public AcompressorFilterGen knee(double knee) => this.SetOptionRange("knee", knee,1,8);
/// <summary>
///  set link type (from 0 to 1) (default average)
/// </summary>
public AcompressorFilterGen link(AcompressorFilterGenLink link) => this.SetOption("link", link.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set detection (from 0 to 1) (default rms)
/// </summary>
public AcompressorFilterGen detection(AcompressorFilterGenDetection detection) => this.SetOption("detection", detection.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set sidechain gain (from 0.015625 to 64) (default 1)
/// </summary>
public AcompressorFilterGen level_sc(double level_sc) => this.SetOptionRange("level_sc", level_sc,0.015625,64);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public AcompressorFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
}
public static class AcompressorFilterGenExtensions
{
/// <summary>
/// Audio compressor.
/// </summary>
public static AcompressorFilterGen AcompressorFilterGen(this AudioMap input0) => new AcompressorFilterGen(input0);
}
public enum AcompressorFilterGenMode
{
[Name("downward")] downward,
[Name("upward")] upward,
}

public enum AcompressorFilterGenLink
{
[Name("average")] average,
[Name("maximum")] maximum,
}

public enum AcompressorFilterGenDetection
{
[Name("peak")] peak,
[Name("rms")] rms,
}

}
