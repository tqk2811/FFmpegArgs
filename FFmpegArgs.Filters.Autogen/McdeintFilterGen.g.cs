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
public class McdeintFilterGen : ImageToImageFilter
{
internal McdeintFilterGen(ImageMap input) : base("mcdeint",input) { AddMapOut(); }
/// <summary>
///  set mode (from 0 to 3) (default fast)
/// </summary>
public McdeintFilterGen mode(McdeintFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set the assumed picture field parity (from -1 to 1) (default bff)
/// </summary>
public McdeintFilterGen parity(McdeintFilterGenParity parity) => this.SetOption("parity", parity.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set qp (from INT_MIN to INT_MAX) (default 1)
/// </summary>
public McdeintFilterGen qp(int qp) => this.SetOptionRange("qp", qp,INT_MIN,INT_MAX);
}
public static class McdeintFilterGenExtensions
{
/// <summary>
/// Apply motion compensating deinterlacing.
/// </summary>
public static McdeintFilterGen McdeintFilterGen(this ImageMap input) => new McdeintFilterGen(input);
}
public enum McdeintFilterGenMode
{
[Name("fast")] fast,
[Name("medium")] medium,
[Name("slow")] slow,
[Name("extra_slow")] extra_slow,
}

public enum McdeintFilterGenParity
{
[Name("tff")] tff,
[Name("bff")] bff,
}

}
