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
public static FieldorderFilterGen FieldorderFilterGen(this ImageMap input0) => new FieldorderFilterGen(input0);
/// <summary>
/// Set the field order.
/// </summary>
public static FieldorderFilterGen FieldorderFilterGen(this ImageMap input0,FieldorderFilterGenConfig config)
{
var result = new FieldorderFilterGen(input0);
if(config?.order != null) result.order(config.order);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class FieldorderFilterGenConfig
{
/// <summary>
///  output field order (from 0 to 1) (default tff)
/// </summary>
public FieldorderFilterGenOrder order { get; set; }
public string TimelineSupport { get; set; }
}
public enum FieldorderFilterGenOrder
{
[Name("bff")] bff,
[Name("tff")] tff,
}

}
