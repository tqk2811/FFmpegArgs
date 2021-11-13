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
public class FormatFilterGen : ImageToImageFilter
{
internal FormatFilterGen(ImageMap input) : base("format",input) { AddMapOut(); }
/// <summary>
///  A '|'-separated list of pixel formats
/// </summary>
public FormatFilterGen pix_fmts(string pix_fmts) => this.SetOption("pix_fmts",pix_fmts);
}
public static class FormatFilterGenExtensions
{
/// <summary>
/// Convert the input video to one of the specified pixel formats.
/// </summary>
public static FormatFilterGen FormatFilterGen(this ImageMap input) => new FormatFilterGen(input);
}
}
