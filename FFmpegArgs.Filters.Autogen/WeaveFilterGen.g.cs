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
public class WeaveFilterGen : ImageToImageFilter,ISliceThreading
{
internal WeaveFilterGen(ImageMap input) : base("weave",input) { AddMapOut(); }
/// <summary>
///  set first field (from 0 to 1) (default top)
/// </summary>
public WeaveFilterGen first_field(WeaveFilterGenFirst_field first_field) => this.SetOption("first_field", first_field.GetAttribute<NameAttribute>().Name);
}
public static class WeaveFilterGenExtensions
{
/// <summary>
/// Weave input video fields into frames.
/// </summary>
public static WeaveFilterGen WeaveFilterGen(this ImageMap input) => new WeaveFilterGen(input);
}
public enum WeaveFilterGenFirst_field
{
[Name("top")] top,
[Name("t")] t,
[Name("bottom")] bottom,
[Name("b")] b,
}

}
