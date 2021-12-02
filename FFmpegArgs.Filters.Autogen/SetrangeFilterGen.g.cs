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
public class SetrangeFilterGen : ImageToImageFilter
{
internal SetrangeFilterGen(ImageMap input) : base("setrange",input) { AddMapOut(); }
/// <summary>
///  select color range (from -1 to 2) (default auto)
/// </summary>
public SetrangeFilterGen range(SetrangeFilterGenRange range) => this.SetOption("range", range.GetAttribute<NameAttribute>().Name);
}
public static class SetrangeFilterGenExtensions
{
/// <summary>
/// Force color range for the output video frame.
/// </summary>
public static SetrangeFilterGen SetrangeFilterGen(this ImageMap input0) => new SetrangeFilterGen(input0);
/// <summary>
/// Force color range for the output video frame.
/// </summary>
public static SetrangeFilterGen SetrangeFilterGen(this ImageMap input0,SetrangeFilterGenConfig config)
{
var result = new SetrangeFilterGen(input0);
if(config?.range != null) result.range(config.range);
return result;
}
}
public class SetrangeFilterGenConfig
{
/// <summary>
///  select color range (from -1 to 2) (default auto)
/// </summary>
public SetrangeFilterGenRange range { get; set; }
}
public enum SetrangeFilterGenRange
{
[Name("auto")] auto,
[Name("unspecified")] unspecified,
[Name("unknown")] unknown,
[Name("limited")] limited,
[Name("tv")] tv,
[Name("mpeg")] mpeg,
[Name("full")] full,
[Name("pc")] pc,
[Name("jpeg")] jpeg,
}

}
