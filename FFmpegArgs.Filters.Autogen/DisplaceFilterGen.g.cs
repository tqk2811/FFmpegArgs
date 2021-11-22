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
public class DisplaceFilterGen : ImageToImageFilter,ITimelineSupport
{
internal DisplaceFilterGen(params ImageMap[] inputs) : base("displace",inputs) { AddMapOut(); }
/// <summary>
///  set edge mode (from 0 to 3) (default smear)
/// </summary>
public DisplaceFilterGen edge(DisplaceFilterGenEdge edge) => this.SetOption("edge", edge.GetAttribute<NameAttribute>().Name);
}
public static class DisplaceFilterGenExtensions
{
/// <summary>
/// Displace pixels.
/// </summary>
public static DisplaceFilterGen DisplaceFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2) => new DisplaceFilterGen(input0, input1, input2);
}
public enum DisplaceFilterGenEdge
{
[Name("blank")] blank,
[Name("smear")] smear,
[Name("wrap")] wrap,
[Name("mirror")] mirror,
}

}