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
public class FsppFilterGen : ImageToImageFilter,ITimelineSupport
{
internal FsppFilterGen(ImageMap input) : base("fspp",input) { AddMapOut(); }
/// <summary>
///  set quality (from 4 to 5) (default 4)
/// </summary>
public FsppFilterGen quality(int quality) => this.SetOptionRange("quality", quality,4,5);
/// <summary>
///  force a constant quantizer parameter (from 0 to 64) (default 0)
/// </summary>
public FsppFilterGen qp(int qp) => this.SetOptionRange("qp", qp,0,64);
/// <summary>
///  set filter strength (from -15 to 32) (default 0)
/// </summary>
public FsppFilterGen strength(int strength) => this.SetOptionRange("strength", strength,-15,32);
/// <summary>
///  use B-frames' QP (default false)
/// </summary>
public FsppFilterGen use_bframe_qp(bool flag) => this.SetOption("use_bframe_qp",flag.ToFFmpegFlag());
}
public static class FsppFilterGenExtensions
{
/// <summary>
/// Apply Fast Simple Post-processing filter.
/// </summary>
public static FsppFilterGen FsppFilterGen(this ImageMap input) => new FsppFilterGen(input);
}
}
