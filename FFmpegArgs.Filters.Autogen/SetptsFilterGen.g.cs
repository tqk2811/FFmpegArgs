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
public class SetptsFilterGen : ImageToImageFilter
{
internal SetptsFilterGen(ImageMap input) : base("setpts",input) { AddMapOut(); }
/// <summary>
///  Expression determining the frame timestamp (default "PTS")
/// </summary>
public SetptsFilterGen expr(string expr) => this.SetOption("expr",expr);
}
public static class SetptsFilterGenExtensions
{
/// <summary>
/// Set PTS for the output video frame.
/// </summary>
public static SetptsFilterGen SetptsFilterGen(this ImageMap input0) => new SetptsFilterGen(input0);
}
}
