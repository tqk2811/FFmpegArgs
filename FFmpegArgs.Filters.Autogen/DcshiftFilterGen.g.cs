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
public class DcshiftFilterGen : AudioToAudioFilter,ITimelineSupport
{
internal DcshiftFilterGen(AudioMap input) : base("dcshift",input) { AddMapOut(); }
/// <summary>
///  set DC shift (from -1 to 1) (default 0)
/// </summary>
public DcshiftFilterGen shift(double shift) => this.SetOptionRange("shift", shift,-1,1);
/// <summary>
///  set limiter gain (from 0 to 1) (default 0)
/// </summary>
public DcshiftFilterGen limitergain(double limitergain) => this.SetOptionRange("limitergain", limitergain,0,1);
}
public static class DcshiftFilterGenExtensions
{
/// <summary>
/// Apply a DC shift to the audio.
/// </summary>
public static DcshiftFilterGen DcshiftFilterGen(this AudioMap input0) => new DcshiftFilterGen(input0);
/// <summary>
/// Apply a DC shift to the audio.
/// </summary>
public static DcshiftFilterGen DcshiftFilterGen(this AudioMap input0,DcshiftFilterGenConfig config)
{
var result = new DcshiftFilterGen(input0);
if(config?.shift != null) result.shift(config.shift);
if(config?.limitergain != null) result.limitergain(config.limitergain);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class DcshiftFilterGenConfig
{
/// <summary>
///  set DC shift (from -1 to 1) (default 0)
/// </summary>
public double shift { get; set; }
/// <summary>
///  set limiter gain (from 0 to 1) (default 0)
/// </summary>
public double limitergain { get; set; }
public string TimelineSupport { get; set; }
}
}
