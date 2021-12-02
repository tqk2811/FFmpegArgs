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
public class UsppFilterGen : ImageToImageFilter,ITimelineSupport
{
internal UsppFilterGen(ImageMap input) : base("uspp",input) { AddMapOut(); }
/// <summary>
///  set quality (from 0 to 8) (default 3)
/// </summary>
public UsppFilterGen quality(int quality) => this.SetOptionRange("quality", quality,0,8);
/// <summary>
///  force a constant quantizer parameter (from 0 to 63) (default 0)
/// </summary>
public UsppFilterGen qp(int qp) => this.SetOptionRange("qp", qp,0,63);
/// <summary>
///  use B-frames' QP (default false)
/// </summary>
public UsppFilterGen use_bframe_qp(bool use_bframe_qp) => this.SetOption("use_bframe_qp",use_bframe_qp.ToFFmpegFlag());
}
public static class UsppFilterGenExtensions
{
/// <summary>
/// Apply Ultra Simple / Slow Post-processing filter.
/// </summary>
public static UsppFilterGen UsppFilterGen(this ImageMap input0) => new UsppFilterGen(input0);
/// <summary>
/// Apply Ultra Simple / Slow Post-processing filter.
/// </summary>
public static UsppFilterGen UsppFilterGen(this ImageMap input0,UsppFilterGenConfig config)
{
var result = new UsppFilterGen(input0);
if(config?.quality != null) result.quality(config.quality.Value);
if(config?.qp != null) result.qp(config.qp.Value);
if(config?.use_bframe_qp != null) result.use_bframe_qp(config.use_bframe_qp.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class UsppFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set quality (from 0 to 8) (default 3)
/// </summary>
public int? quality { get; set; }
/// <summary>
///  force a constant quantizer parameter (from 0 to 63) (default 0)
/// </summary>
public int? qp { get; set; }
/// <summary>
///  use B-frames' QP (default false)
/// </summary>
public bool? use_bframe_qp { get; set; }
public string TimelineSupport { get; set; }
}
}
