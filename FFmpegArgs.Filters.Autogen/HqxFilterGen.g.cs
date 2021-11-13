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
public class HqxFilterGen : ImageToImageFilter,ISliceThreading
{
internal HqxFilterGen(ImageMap input) : base("hqx",input) { AddMapOut(); }
/// <summary>
///  set scale factor (from 2 to 4) (default 3)
/// </summary>
public HqxFilterGen n(int n) => this.SetOptionRange("n", n,2,4);
}
public static class HqxFilterGenExtensions
{
/// <summary>
/// Scale the input by 2, 3 or 4 using the hq*x magnification algorithm.
/// </summary>
public static HqxFilterGen HqxFilterGen(this ImageMap input) => new HqxFilterGen(input);
}
}
