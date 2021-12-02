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
public class AgateFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal AgateFilterGen(AudioMap input) : base("agate",input) { AddMapOut(); }
/// <summary>
///  set input level (from 0.015625 to 64) (default 1)
/// </summary>
public AgateFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in,0.015625,64);
/// <summary>
///  set mode (from 0 to 1) (default downward)
/// </summary>
public AgateFilterGen mode(AgateFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set max gain reduction (from 0 to 1) (default 0.06125)
/// </summary>
public AgateFilterGen range(double range) => this.SetOptionRange("range", range,0,1);
/// <summary>
///  set threshold (from 0 to 1) (default 0.125)
/// </summary>
public AgateFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,0,1);
/// <summary>
///  set ratio (from 1 to 9000) (default 2)
/// </summary>
public AgateFilterGen ratio(double ratio) => this.SetOptionRange("ratio", ratio,1,9000);
/// <summary>
///  set attack (from 0.01 to 9000) (default 20)
/// </summary>
public AgateFilterGen attack(double attack) => this.SetOptionRange("attack", attack,0.01,9000);
/// <summary>
///  set release (from 0.01 to 9000) (default 250)
/// </summary>
public AgateFilterGen release(double release) => this.SetOptionRange("release", release,0.01,9000);
/// <summary>
///  set makeup gain (from 1 to 64) (default 1)
/// </summary>
public AgateFilterGen makeup(double makeup) => this.SetOptionRange("makeup", makeup,1,64);
/// <summary>
///  set knee (from 1 to 8) (default 2.82843)
/// </summary>
public AgateFilterGen knee(double knee) => this.SetOptionRange("knee", knee,1,8);
/// <summary>
///  set detection (from 0 to 1) (default rms)
/// </summary>
public AgateFilterGen detection(AgateFilterGenDetection detection) => this.SetOption("detection", detection.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set link (from 0 to 1) (default average)
/// </summary>
public AgateFilterGen link(AgateFilterGenLink link) => this.SetOption("link", link.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set sidechain gain (from 0.015625 to 64) (default 1)
/// </summary>
public AgateFilterGen level_sc(double level_sc) => this.SetOptionRange("level_sc", level_sc,0.015625,64);
}
public static class AgateFilterGenExtensions
{
/// <summary>
/// Audio gate.
/// </summary>
public static AgateFilterGen AgateFilterGen(this AudioMap input0) => new AgateFilterGen(input0);
/// <summary>
/// Audio gate.
/// </summary>
public static AgateFilterGen AgateFilterGen(this AudioMap input0,AgateFilterGenConfig config)
{
var result = new AgateFilterGen(input0);
if(config?.level_in != null) result.level_in(config.level_in);
if(config?.mode != null) result.mode(config.mode);
if(config?.range != null) result.range(config.range);
if(config?.threshold != null) result.threshold(config.threshold);
if(config?.ratio != null) result.ratio(config.ratio);
if(config?.attack != null) result.attack(config.attack);
if(config?.release != null) result.release(config.release);
if(config?.makeup != null) result.makeup(config.makeup);
if(config?.knee != null) result.knee(config.knee);
if(config?.detection != null) result.detection(config.detection);
if(config?.link != null) result.link(config.link);
if(config?.level_sc != null) result.level_sc(config.level_sc);
return result;
}
}
public class AgateFilterGenConfig
{
/// <summary>
///  set input level (from 0.015625 to 64) (default 1)
/// </summary>
public double level_in { get; set; }
/// <summary>
///  set mode (from 0 to 1) (default downward)
/// </summary>
public AgateFilterGenMode mode { get; set; }
/// <summary>
///  set max gain reduction (from 0 to 1) (default 0.06125)
/// </summary>
public double range { get; set; }
/// <summary>
///  set threshold (from 0 to 1) (default 0.125)
/// </summary>
public double threshold { get; set; }
/// <summary>
///  set ratio (from 1 to 9000) (default 2)
/// </summary>
public double ratio { get; set; }
/// <summary>
///  set attack (from 0.01 to 9000) (default 20)
/// </summary>
public double attack { get; set; }
/// <summary>
///  set release (from 0.01 to 9000) (default 250)
/// </summary>
public double release { get; set; }
/// <summary>
///  set makeup gain (from 1 to 64) (default 1)
/// </summary>
public double makeup { get; set; }
/// <summary>
///  set knee (from 1 to 8) (default 2.82843)
/// </summary>
public double knee { get; set; }
/// <summary>
///  set detection (from 0 to 1) (default rms)
/// </summary>
public AgateFilterGenDetection detection { get; set; }
/// <summary>
///  set link (from 0 to 1) (default average)
/// </summary>
public AgateFilterGenLink link { get; set; }
/// <summary>
///  set sidechain gain (from 0.015625 to 64) (default 1)
/// </summary>
public double level_sc { get; set; }
}
public enum AgateFilterGenMode
{
[Name("downward")] downward,
[Name("upward")] upward,
}

public enum AgateFilterGenDetection
{
[Name("peak")] peak,
[Name("rms")] rms,
}

public enum AgateFilterGenLink
{
[Name("average")] average,
[Name("maximum")] maximum,
}

}
