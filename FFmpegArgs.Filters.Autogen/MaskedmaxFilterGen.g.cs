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
public class MaskedmaxFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal MaskedmaxFilterGen(params ImageMap[] inputs) : base("maskedmax",inputs) { AddMapOut(); }
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public MaskedmaxFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
public static class MaskedmaxFilterGenExtensions
{
/// <summary>
/// Apply filtering with maximum difference of two streams.
/// </summary>
public static MaskedmaxFilterGen MaskedmaxFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2) => new MaskedmaxFilterGen(input0, input1, input2);
}
}
