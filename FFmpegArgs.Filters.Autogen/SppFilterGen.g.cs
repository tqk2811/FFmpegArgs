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
public class SppFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal SppFilterGen(ImageMap input) : base("spp",input) { AddMapOut(); }
/// <summary>
///  set quality (from 0 to 6) (default 3)
/// </summary>
public SppFilterGen quality(int quality) => this.SetOptionRange("quality", quality,0,6);
/// <summary>
///  force a constant quantizer parameter (from 0 to 63) (default 0)
/// </summary>
public SppFilterGen qp(int qp) => this.SetOptionRange("qp", qp,0,63);
/// <summary>
///  set thresholding mode (from 0 to 1) (default hard)
/// </summary>
public SppFilterGen mode(SppFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  use B-frames' QP (default false)
/// </summary>
public SppFilterGen use_bframe_qp(bool flag) => this.SetOption("use_bframe_qp",flag.ToFFmpegFlag());
}
public static class SppFilterGenExtensions
{
/// <summary>
/// Apply a simple post processing filter.
/// </summary>
public static SppFilterGen SppFilterGen(this ImageMap input) => new SppFilterGen(input);
}
public enum SppFilterGenMode
{
[Name("hard")] hard,
[Name("soft")] soft,
}

}
