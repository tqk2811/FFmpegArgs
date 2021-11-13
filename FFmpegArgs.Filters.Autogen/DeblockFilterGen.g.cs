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
public class DeblockFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal DeblockFilterGen(ImageMap input) : base("deblock",input) { AddMapOut(); }
/// <summary>
///  set type of filter (from 0 to 1) (default strong)
/// </summary>
public DeblockFilterGen filter(DeblockFilterGenFilter filter) => this.SetOption("filter", filter.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set size of block (from 4 to 512) (default 8)
/// </summary>
public DeblockFilterGen block(int block) => this.SetOptionRange("block", block,4,512);
/// <summary>
///  set 1st detection threshold (from 0 to 1) (default 0.098)
/// </summary>
public DeblockFilterGen alpha(float alpha) => this.SetOptionRange("alpha", alpha,0,1);
/// <summary>
///  set 2nd detection threshold (from 0 to 1) (default 0.05)
/// </summary>
public DeblockFilterGen beta(float beta) => this.SetOptionRange("beta", beta,0,1);
/// <summary>
///  set 3rd detection threshold (from 0 to 1) (default 0.05)
/// </summary>
public DeblockFilterGen gamma(float gamma) => this.SetOptionRange("gamma", gamma,0,1);
/// <summary>
///  set 4th detection threshold (from 0 to 1) (default 0.05)
/// </summary>
public DeblockFilterGen delta(float delta) => this.SetOptionRange("delta", delta,0,1);
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public DeblockFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
public static class DeblockFilterGenExtensions
{
/// <summary>
/// Deblock video.
/// </summary>
public static DeblockFilterGen DeblockFilterGen(this ImageMap input0) => new DeblockFilterGen(input0);
}
public enum DeblockFilterGenFilter
{
[Name("weak")] weak,
[Name("strong")] strong,
}

}
