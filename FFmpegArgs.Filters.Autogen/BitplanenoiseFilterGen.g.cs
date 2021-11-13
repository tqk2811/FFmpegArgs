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
public class BitplanenoiseFilterGen : ImageToImageFilter,ITimelineSupport
{
internal BitplanenoiseFilterGen(ImageMap input) : base("bitplanenoise",input) { AddMapOut(); }
/// <summary>
///  set bit plane to use for measuring noise (from 1 to 16) (default 1)
/// </summary>
public BitplanenoiseFilterGen bitplane(int bitplane) => this.SetOptionRange("bitplane", bitplane,1,16);
/// <summary>
///  show noisy pixels (default false)
/// </summary>
public BitplanenoiseFilterGen filter(bool flag) => this.SetOption("filter",flag.ToFFmpegFlag());
}
public static class BitplanenoiseFilterGenExtensions
{
/// <summary>
/// Measure bit plane noise.
/// </summary>
public static BitplanenoiseFilterGen BitplanenoiseFilterGen(this ImageMap input) => new BitplanenoiseFilterGen(input);
}
}
