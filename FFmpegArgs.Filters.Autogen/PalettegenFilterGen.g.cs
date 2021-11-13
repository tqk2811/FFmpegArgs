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
public class PalettegenFilterGen : ImageToImageFilter
{
internal PalettegenFilterGen(ImageMap input) : base("palettegen",input) { AddMapOut(); }
/// <summary>
///  set the maximum number of colors to use in the palette (from 4 to 256) (default 256)
/// </summary>
public PalettegenFilterGen max_colors(int max_colors) => this.SetOptionRange("max_colors", max_colors,4,256);
/// <summary>
///  reserve a palette entry for transparency (default true)
/// </summary>
public PalettegenFilterGen reserve_transparent(bool flag) => this.SetOption("reserve_transparent",flag.ToFFmpegFlag());
/// <summary>
///  set a background color for transparency (default "lime")
/// </summary>
public PalettegenFilterGen transparency_color(Color transparency_color) => this.SetOption("transparency_color",transparency_color.ToHexStringRGBA());
/// <summary>
///  set statistics mode (from 0 to 2) (default full)
/// </summary>
public PalettegenFilterGen stats_mode(PalettegenFilterGenStats_mode stats_mode) => this.SetOption("stats_mode", stats_mode.GetAttribute<NameAttribute>().Name);
}
public static class PalettegenFilterGenExtensions
{
/// <summary>
/// Find the optimal palette for a given stream.
/// </summary>
public static PalettegenFilterGen PalettegenFilterGen(this ImageMap input0) => new PalettegenFilterGen(input0);
}
public enum PalettegenFilterGenStats_mode
{
[Name("full")] full,
[Name("diff")] diff,
[Name("single")] single,
}

}
