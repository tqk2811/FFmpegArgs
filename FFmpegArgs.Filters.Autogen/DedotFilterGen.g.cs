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
public class DedotFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal DedotFilterGen(ImageMap input) : base("dedot",input) { AddMapOut(); }
/// <summary>
///  set filtering mode (default dotcrawl+rainbows)
/// </summary>
public DedotFilterGen m(DedotFilterGenM m) => this.SetOption("m", m.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set spatial luma threshold (from 0 to 1) (default 0.079)
/// </summary>
public DedotFilterGen lt(float lt) => this.SetOptionRange("lt", lt,0,1);
/// <summary>
///  set tolerance for temporal luma (from 0 to 1) (default 0.079)
/// </summary>
public DedotFilterGen tl(float tl) => this.SetOptionRange("tl", tl,0,1);
/// <summary>
///  set tolerance for chroma temporal variation (from 0 to 1) (default 0.058)
/// </summary>
public DedotFilterGen tc(float tc) => this.SetOptionRange("tc", tc,0,1);
/// <summary>
///  set temporal chroma threshold (from 0 to 1) (default 0.019)
/// </summary>
public DedotFilterGen ct(float ct) => this.SetOptionRange("ct", ct,0,1);
}
public static class DedotFilterGenExtensions
{
/// <summary>
/// Reduce cross-luminance and cross-color.
/// </summary>
public static DedotFilterGen DedotFilterGen(this ImageMap input0) => new DedotFilterGen(input0);
}
public enum DedotFilterGenM
{
[Name("dotcrawl")] dotcrawl,
[Name("rainbows")] rainbows,
}

}
