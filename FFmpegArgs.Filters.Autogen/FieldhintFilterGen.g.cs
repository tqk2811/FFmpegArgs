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
public class FieldhintFilterGen : ImageToImageFilter
{
internal FieldhintFilterGen(ImageMap input) : base("fieldhint",input) { AddMapOut(); }
/// <summary>
///  set hint file
/// </summary>
public FieldhintFilterGen hint(string hint) => this.SetOption("hint",hint);
/// <summary>
///  set hint mode (from 0 to 1) (default absolute)
/// </summary>
public FieldhintFilterGen mode(FieldhintFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
}
public static class FieldhintFilterGenExtensions
{
/// <summary>
/// Field matching using hints.
/// </summary>
public static FieldhintFilterGen FieldhintFilterGen(this ImageMap input) => new FieldhintFilterGen(input);
}
public enum FieldhintFilterGenMode
{
[Name("absolute")] absolute,
[Name("relative")] relative,
}

}
