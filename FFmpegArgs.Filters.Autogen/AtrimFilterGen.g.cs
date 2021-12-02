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
public class AtrimFilterGen : AudioToAudioFilter
{
internal AtrimFilterGen(AudioMap input) : base("atrim",input) { AddMapOut(); }
/// <summary>
///  Timestamp of the first frame that should be passed (default INT64_MAX)
/// </summary>
public AtrimFilterGen starti(TimeSpan starti) => this.SetOptionRange("starti",starti,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  Timestamp of the first frame that should be dropped again (default INT64_MAX)
/// </summary>
public AtrimFilterGen endi(TimeSpan endi) => this.SetOptionRange("endi",endi,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  Timestamp of the first frame that should be  passed (from I64_MIN to I64_MAX) (default I64_MIN)
/// </summary>
public AtrimFilterGen start_pts(long start_pts) => this.SetOptionRange("start_pts", start_pts,I64_MIN,I64_MAX);
/// <summary>
///  Timestamp of the first frame that should be dropped again (from I64_MIN to I64_MAX) (default I64_MIN)
/// </summary>
public AtrimFilterGen end_pts(long end_pts) => this.SetOptionRange("end_pts", end_pts,I64_MIN,I64_MAX);
/// <summary>
///  Maximum duration of the output (default 0)
/// </summary>
public AtrimFilterGen durationi(TimeSpan durationi) => this.SetOptionRange("durationi",durationi,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  Number of the first audio sample that should be passed to the output (from -1 to I64_MAX) (default -1)
/// </summary>
public AtrimFilterGen start_sample(long start_sample) => this.SetOptionRange("start_sample", start_sample,-1,I64_MAX);
/// <summary>
///  Number of the first audio sample that should be dropped again (from 0 to I64_MAX) (default I64_MAX)
/// </summary>
public AtrimFilterGen end_sample(long end_sample) => this.SetOptionRange("end_sample", end_sample,0,I64_MAX);
}
public static class AtrimFilterGenExtensions
{
/// <summary>
/// Pick one continuous section from the input, drop the rest.
/// </summary>
public static AtrimFilterGen AtrimFilterGen(this AudioMap input0) => new AtrimFilterGen(input0);
/// <summary>
/// Pick one continuous section from the input, drop the rest.
/// </summary>
public static AtrimFilterGen AtrimFilterGen(this AudioMap input0,AtrimFilterGenConfig config)
{
var result = new AtrimFilterGen(input0);
if(config?.starti != null) result.starti(config.starti.Value);
if(config?.endi != null) result.endi(config.endi.Value);
if(config?.start_pts != null) result.start_pts(config.start_pts.Value);
if(config?.end_pts != null) result.end_pts(config.end_pts.Value);
if(config?.durationi != null) result.durationi(config.durationi.Value);
if(config?.start_sample != null) result.start_sample(config.start_sample.Value);
if(config?.end_sample != null) result.end_sample(config.end_sample.Value);
return result;
}
}
public class AtrimFilterGenConfig
{
/// <summary>
///  Timestamp of the first frame that should be passed (default INT64_MAX)
/// </summary>
public TimeSpan? starti { get; set; }
/// <summary>
///  Timestamp of the first frame that should be dropped again (default INT64_MAX)
/// </summary>
public TimeSpan? endi { get; set; }
/// <summary>
///  Timestamp of the first frame that should be  passed (from I64_MIN to I64_MAX) (default I64_MIN)
/// </summary>
public long? start_pts { get; set; }
/// <summary>
///  Timestamp of the first frame that should be dropped again (from I64_MIN to I64_MAX) (default I64_MIN)
/// </summary>
public long? end_pts { get; set; }
/// <summary>
///  Maximum duration of the output (default 0)
/// </summary>
public TimeSpan? durationi { get; set; }
/// <summary>
///  Number of the first audio sample that should be passed to the output (from -1 to I64_MAX) (default -1)
/// </summary>
public long? start_sample { get; set; }
/// <summary>
///  Number of the first audio sample that should be dropped again (from 0 to I64_MAX) (default I64_MAX)
/// </summary>
public long? end_sample { get; set; }
}
}
