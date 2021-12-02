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
public class IdentityFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal IdentityFilterGen(params ImageMap[] inputs) : base("identity",inputs) { AddMapOut(); }
}
public static class IdentityFilterGenExtensions
{
/// <summary>
/// Calculate the Identity between two video streams.
/// </summary>
public static IdentityFilterGen IdentityFilterGen(this ImageMap input0, ImageMap input1) => new IdentityFilterGen(input0, input1);
/// <summary>
/// Calculate the Identity between two video streams.
/// </summary>
public static IdentityFilterGen IdentityFilterGen(this ImageMap input0, ImageMap input1,IdentityFilterGenConfig config)
{
var result = new IdentityFilterGen(input0, input1);
return result;
}
}
public class IdentityFilterGenConfig
{
}
}
