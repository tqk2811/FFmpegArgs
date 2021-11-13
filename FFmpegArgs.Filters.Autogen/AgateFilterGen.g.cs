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
