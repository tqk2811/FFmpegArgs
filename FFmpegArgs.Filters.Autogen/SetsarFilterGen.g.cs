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
public class SetsarFilterGen : ImageToImageFilter
{
internal SetsarFilterGen(ImageMap input) : base("setsar",input) { AddMapOut(); }
/// <summary>
///  set sample (pixel) aspect ratio (default "0")
/// </summary>
public SetsarFilterGen sar(string sar) => this.SetOption("sar",sar);
/// <summary>
///  set sample (pixel) aspect ratio (default "0")
/// </summary>
public SetsarFilterGen ratio(string ratio) => this.SetOption("ratio",ratio);
/// <summary>
///  set sample (pixel) aspect ratio (default "0")
/// </summary>
public SetsarFilterGen r(string r) => this.SetOption("r",r);
/// <summary>
///  set max value for nominator or denominator in the ratio (from 1 to INT_MAX) (default 100)
/// </summary>
public SetsarFilterGen max(int max) => this.SetOptionRange("max", max,1,INT_MAX);
}
public static class SetsarFilterGenExtensions
{
/// <summary>
/// Set the pixel sample aspect ratio.
/// </summary>
public static SetsarFilterGen SetsarFilterGen(this ImageMap input0) => new SetsarFilterGen(input0);
}
}
