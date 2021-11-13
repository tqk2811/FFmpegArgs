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
public class DetelecineFilterGen : ImageToImageFilter
{
internal DetelecineFilterGen(ImageMap input) : base("detelecine",input) { AddMapOut(); }
/// <summary>
///  select first field (from 0 to 1) (default top)
/// </summary>
public DetelecineFilterGen first_field(DetelecineFilterGenFirst_field first_field) => this.SetOption("first_field", first_field.GetAttribute<NameAttribute>().Name);
/// <summary>
///  pattern that describe for how many fields a frame is to be displayed (default "23")
/// </summary>
public DetelecineFilterGen pattern(string pattern) => this.SetOption("pattern",pattern);
/// <summary>
///  position of first frame with respect to the pattern if stream is cut (from 0 to 13) (default 0)
/// </summary>
public DetelecineFilterGen start_frame(int start_frame) => this.SetOptionRange("start_frame", start_frame,0,13);
}
public static class DetelecineFilterGenExtensions
{
/// <summary>
/// Apply an inverse telecine pattern.
/// </summary>
public static DetelecineFilterGen DetelecineFilterGen(this ImageMap input) => new DetelecineFilterGen(input);
}
public enum DetelecineFilterGenFirst_field
{
[Name("top")] top,
[Name("t")] t,
[Name("bottom")] bottom,
[Name("b")] b,
}

}
