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
public class EpxFilterGen : ImageToImageFilter,ISliceThreading
{
internal EpxFilterGen(ImageMap input) : base("epx",input) { AddMapOut(); }
/// <summary>
///  set scale factor (from 2 to 3) (default 3)
/// </summary>
public EpxFilterGen n(int n) => this.SetOptionRange("n", n,2,3);
}
public static class EpxFilterGenExtensions
{
/// <summary>
/// Scale the input using EPX algorithm.
/// </summary>
public static EpxFilterGen EpxFilterGen(this ImageMap input0) => new EpxFilterGen(input0);
}
}
