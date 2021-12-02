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
public class TelecineFilterGen : ImageToImageFilter
{
internal TelecineFilterGen(ImageMap input) : base("telecine",input) { AddMapOut(); }
/// <summary>
///  select first field (from 0 to 1) (default top)
/// </summary>
public TelecineFilterGen first_field(TelecineFilterGenFirst_field first_field) => this.SetOption("first_field", first_field.GetAttribute<NameAttribute>().Name);
/// <summary>
///  pattern that describe for how many fields a frame is to be displayed (default "23")
/// </summary>
public TelecineFilterGen pattern(string pattern) => this.SetOption("pattern",pattern);
}
public static class TelecineFilterGenExtensions
{
/// <summary>
/// Apply a telecine pattern.
/// </summary>
public static TelecineFilterGen TelecineFilterGen(this ImageMap input0) => new TelecineFilterGen(input0);
/// <summary>
/// Apply a telecine pattern.
/// </summary>
public static TelecineFilterGen TelecineFilterGen(this ImageMap input0,TelecineFilterGenConfig config)
{
var result = new TelecineFilterGen(input0);
if(config?.first_field != null) result.first_field(config.first_field.Value);
if(!string.IsNullOrWhiteSpace(config?.pattern)) result.pattern(config.pattern);
return result;
}
}
public class TelecineFilterGenConfig
{
/// <summary>
///  select first field (from 0 to 1) (default top)
/// </summary>
public TelecineFilterGenFirst_field? first_field { get; set; }
/// <summary>
///  pattern that describe for how many fields a frame is to be displayed (default "23")
/// </summary>
public string pattern { get; set; }
}
public enum TelecineFilterGenFirst_field
{
[Name("top")] top,
[Name("t")] t,
[Name("bottom")] bottom,
[Name("b")] b,
}

}
