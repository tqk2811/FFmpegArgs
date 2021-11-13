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
public class FieldorderFilterGen : ImageToImageFilter,ITimelineSupport
{
internal FieldorderFilterGen(ImageMap input) : base("fieldorder",input) { AddMapOut(); }
/// <summary>
///  output field order (from 0 to 1) (default tff)
/// </summary>
public FieldorderFilterGen order(FieldorderFilterGenOrder order) => this.SetOption("order", order.GetAttribute<NameAttribute>().Name);
}
public static class FieldorderFilterGenExtensions
{
/// <summary>
/// Set the field order.
/// </summary>
public static FieldorderFilterGen FieldorderFilterGen(this ImageMap input) => new FieldorderFilterGen(input);
}
public enum FieldorderFilterGenOrder
{
[Name("bff")] bff,
[Name("tff")] tff,
}

}
