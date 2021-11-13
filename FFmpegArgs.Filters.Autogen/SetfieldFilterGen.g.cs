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
public class SetfieldFilterGen : ImageToImageFilter
{
internal SetfieldFilterGen(ImageMap input) : base("setfield",input) { AddMapOut(); }
/// <summary>
///  select interlace mode (from -1 to 2) (default auto)
/// </summary>
public SetfieldFilterGen mode(SetfieldFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
}
public static class SetfieldFilterGenExtensions
{
/// <summary>
/// Force field for the output video frame.
/// </summary>
public static SetfieldFilterGen SetfieldFilterGen(this ImageMap input) => new SetfieldFilterGen(input);
}
public enum SetfieldFilterGenMode
{
[Name("auto")] auto,
[Name("bff")] bff,
[Name("tff")] tff,
[Name("prog")] prog,
}

}
