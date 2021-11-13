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
public class UntileFilterGen : ImageToImageFilter
{
internal UntileFilterGen(ImageMap input) : base("untile",input) { AddMapOut(); }
/// <summary>
///  set grid size (default "6x5")
/// </summary>
public UntileFilterGen layout(Size size) => this.SetOption("layout",$"{size.Width}x{size.Height}");
}
public static class UntileFilterGenExtensions
{
/// <summary>
/// Untile a frame into a sequence of frames.
/// </summary>
public static UntileFilterGen UntileFilterGen(this ImageMap input) => new UntileFilterGen(input);
}
}
