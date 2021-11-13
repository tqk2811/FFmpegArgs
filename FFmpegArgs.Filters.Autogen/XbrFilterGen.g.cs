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
public class XbrFilterGen : ImageToImageFilter,ISliceThreading
{
internal XbrFilterGen(ImageMap input) : base("xbr",input) { AddMapOut(); }
/// <summary>
///  set scale factor (from 2 to 4) (default 3)
/// </summary>
public XbrFilterGen n(int n) => this.SetOptionRange("n", n,2,4);
}
public static class XbrFilterGenExtensions
{
/// <summary>
/// Scale the input using xBR algorithm.
/// </summary>
public static XbrFilterGen XbrFilterGen(this ImageMap input0) => new XbrFilterGen(input0);
}
}
