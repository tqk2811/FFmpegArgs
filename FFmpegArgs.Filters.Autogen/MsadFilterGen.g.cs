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
public class MsadFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal MsadFilterGen(params ImageMap[] inputs) : base("msad",inputs) { AddMapOut(); }
}
public static class MsadFilterGenExtensions
{
/// <summary>
/// Calculate the MSAD between two video streams.
/// </summary>
public static MsadFilterGen MsadFilterGen(this ImageMap input0, ImageMap input1) => new MsadFilterGen(input0, input1);
}
}
