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
public class CrossfeedFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal CrossfeedFilterGen(AudioMap input) : base("crossfeed",input) { AddMapOut(); }
/// <summary>
///  set crossfeed strength (from 0 to 1) (default 0.2)
/// </summary>
public CrossfeedFilterGen strength(double strength) => this.SetOptionRange("strength", strength,0,1);
/// <summary>
///  set soundstage wideness (from 0 to 1) (default 0.5)
/// </summary>
public CrossfeedFilterGen range(double range) => this.SetOptionRange("range", range,0,1);
/// <summary>
///  set curve slope (from 0.01 to 1) (default 0.5)
/// </summary>
public CrossfeedFilterGen slope(double slope) => this.SetOptionRange("slope", slope,0.01,1);
/// <summary>
///  set level in (from 0 to 1) (default 0.9)
/// </summary>
public CrossfeedFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in,0,1);
/// <summary>
///  set level out (from 0 to 1) (default 1)
/// </summary>
public CrossfeedFilterGen level_out(double level_out) => this.SetOptionRange("level_out", level_out,0,1);
}
public static class CrossfeedFilterGenExtensions
{
/// <summary>
/// Apply headphone crossfeed filter.
/// </summary>
public static CrossfeedFilterGen CrossfeedFilterGen(this AudioMap input0) => new CrossfeedFilterGen(input0);
/// <summary>
/// Apply headphone crossfeed filter.
/// </summary>
public static CrossfeedFilterGen CrossfeedFilterGen(this AudioMap input0,CrossfeedFilterGenConfig config)
{
var result = new CrossfeedFilterGen(input0);
if(config?.strength != null) result.strength(config.strength.Value);
if(config?.range != null) result.range(config.range.Value);
if(config?.slope != null) result.slope(config.slope.Value);
if(config?.level_in != null) result.level_in(config.level_in.Value);
if(config?.level_out != null) result.level_out(config.level_out.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class CrossfeedFilterGenConfig
{
/// <summary>
///  set crossfeed strength (from 0 to 1) (default 0.2)
/// </summary>
public double? strength { get; set; }
/// <summary>
///  set soundstage wideness (from 0 to 1) (default 0.5)
/// </summary>
public double? range { get; set; }
/// <summary>
///  set curve slope (from 0.01 to 1) (default 0.5)
/// </summary>
public double? slope { get; set; }
/// <summary>
///  set level in (from 0 to 1) (default 0.9)
/// </summary>
public double? level_in { get; set; }
/// <summary>
///  set level out (from 0 to 1) (default 1)
/// </summary>
public double? level_out { get; set; }
public string TimelineSupport { get; set; }
}
}
