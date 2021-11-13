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
public class IlFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal IlFilterGen(ImageMap input) : base("il",input) { AddMapOut(); }
/// <summary>
///  select luma mode (from 0 to 2) (default none)
/// </summary>
public IlFilterGen luma_mode(IlFilterGenLuma_mode luma_mode) => this.SetOption("luma_mode", luma_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  select luma mode (from 0 to 2) (default none)
/// </summary>
public IlFilterGen l(IlFilterGenL l) => this.SetOption("l", l.GetAttribute<NameAttribute>().Name);
/// <summary>
///  select chroma mode (from 0 to 2) (default none)
/// </summary>
public IlFilterGen chroma_mode(IlFilterGenChroma_mode chroma_mode) => this.SetOption("chroma_mode", chroma_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  select chroma mode (from 0 to 2) (default none)
/// </summary>
public IlFilterGen c(IlFilterGenC c) => this.SetOption("c", c.GetAttribute<NameAttribute>().Name);
/// <summary>
///  select alpha mode (from 0 to 2) (default none)
/// </summary>
public IlFilterGen alpha_mode(IlFilterGenAlpha_mode alpha_mode) => this.SetOption("alpha_mode", alpha_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  select alpha mode (from 0 to 2) (default none)
/// </summary>
public IlFilterGen a(IlFilterGenA a) => this.SetOption("a", a.GetAttribute<NameAttribute>().Name);
/// <summary>
///  swap luma fields (default false)
/// </summary>
public IlFilterGen luma_swap(bool flag) => this.SetOption("luma_swap",flag.ToFFmpegFlag());
/// <summary>
///  swap luma fields (default false)
/// </summary>
public IlFilterGen ls(bool flag) => this.SetOption("ls",flag.ToFFmpegFlag());
/// <summary>
///  swap chroma fields (default false)
/// </summary>
public IlFilterGen chroma_swap(bool flag) => this.SetOption("chroma_swap",flag.ToFFmpegFlag());
/// <summary>
///  swap chroma fields (default false)
/// </summary>
public IlFilterGen cs(bool flag) => this.SetOption("cs",flag.ToFFmpegFlag());
/// <summary>
///  swap alpha fields (default false)
/// </summary>
public IlFilterGen alpha_swap(bool flag) => this.SetOption("alpha_swap",flag.ToFFmpegFlag());
/// <summary>
///  swap alpha fields (default false)
/// </summary>
public IlFilterGen _as(bool flag) => this.SetOption("as",flag.ToFFmpegFlag());
}
public static class IlFilterGenExtensions
{
/// <summary>
/// Deinterleave or interleave fields.
/// </summary>
public static IlFilterGen IlFilterGen(this ImageMap input) => new IlFilterGen(input);
}
public enum IlFilterGenLuma_mode
{
[Name("none")] none,
[Name("interleave")] interleave,
[Name("i")] i,
[Name("deinterleave")] deinterleave,
[Name("d")] d,
}

public enum IlFilterGenL
{
[Name("none")] none,
[Name("interleave")] interleave,
[Name("i")] i,
[Name("deinterleave")] deinterleave,
[Name("d")] d,
}

public enum IlFilterGenChroma_mode
{
[Name("none")] none,
[Name("interleave")] interleave,
[Name("i")] i,
[Name("deinterleave")] deinterleave,
[Name("d")] d,
}

public enum IlFilterGenC
{
[Name("none")] none,
[Name("interleave")] interleave,
[Name("i")] i,
[Name("deinterleave")] deinterleave,
[Name("d")] d,
}

public enum IlFilterGenAlpha_mode
{
[Name("none")] none,
[Name("interleave")] interleave,
[Name("i")] i,
[Name("deinterleave")] deinterleave,
[Name("d")] d,
}

public enum IlFilterGenA
{
[Name("none")] none,
[Name("interleave")] interleave,
[Name("i")] i,
[Name("deinterleave")] deinterleave,
[Name("d")] d,
}

}
