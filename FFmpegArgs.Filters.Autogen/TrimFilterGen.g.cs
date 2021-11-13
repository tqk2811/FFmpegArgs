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
public class TrimFilterGen : ImageToImageFilter
{
internal TrimFilterGen(ImageMap input) : base("trim",input) { AddMapOut(); }
/// <summary>
///  Timestamp of the first frame that should be passed (default INT64_MAX)
/// </summary>
public TrimFilterGen start(TimeSpan start) => this.SetOptionRange("start",start,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  Timestamp of the first frame that should be passed (default INT64_MAX)
/// </summary>
public TrimFilterGen starti(TimeSpan starti) => this.SetOptionRange("starti",starti,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  Timestamp of the first frame that should be dropped again (default INT64_MAX)
/// </summary>
public TrimFilterGen end(TimeSpan end) => this.SetOptionRange("end",end,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  Timestamp of the first frame that should be dropped again (default INT64_MAX)
/// </summary>
public TrimFilterGen endi(TimeSpan endi) => this.SetOptionRange("endi",endi,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  Timestamp of the first frame that should be  passed (from I64_MIN to I64_MAX) (default I64_MIN)
/// </summary>
public TrimFilterGen start_pts(long start_pts) => this.SetOptionRange("start_pts", start_pts,I64_MIN,I64_MAX);
/// <summary>
///  Timestamp of the first frame that should be dropped again (from I64_MIN to I64_MAX) (default I64_MIN)
/// </summary>
public TrimFilterGen end_pts(long end_pts) => this.SetOptionRange("end_pts", end_pts,I64_MIN,I64_MAX);
/// <summary>
///  Maximum duration of the output (default 0)
/// </summary>
public TrimFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  Maximum duration of the output (default 0)
/// </summary>
public TrimFilterGen durationi(TimeSpan durationi) => this.SetOptionRange("durationi",durationi,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  Number of the first frame that should be passed to the output (from -1 to I64_MAX) (default -1)
/// </summary>
public TrimFilterGen start_frame(long start_frame) => this.SetOptionRange("start_frame", start_frame,-1,I64_MAX);
/// <summary>
///  Number of the first frame that should be dropped again (from 0 to I64_MAX) (default I64_MAX)
/// </summary>
public TrimFilterGen end_frame(long end_frame) => this.SetOptionRange("end_frame", end_frame,0,I64_MAX);
}
public static class TrimFilterGenExtensions
{
/// <summary>
/// Pick one continuous section from the input, drop the rest.
/// </summary>
public static TrimFilterGen TrimFilterGen(this ImageMap input) => new TrimFilterGen(input);
}
}
