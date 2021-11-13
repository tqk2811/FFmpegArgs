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
public class FieldFilterGen : ImageToImageFilter
{
internal FieldFilterGen(ImageMap input) : base("field",input) { AddMapOut(); }
/// <summary>
///  set field type (top or bottom) (from 0 to 1) (default top)
/// </summary>
public FieldFilterGen type(FieldFilterGenType type) => this.SetOption("type", type.GetAttribute<NameAttribute>().Name);
}
public static class FieldFilterGenExtensions
{
/// <summary>
/// Extract a field from the input video.
/// </summary>
public static FieldFilterGen FieldFilterGen(this ImageMap input0) => new FieldFilterGen(input0);
}
public enum FieldFilterGenType
{
[Name("top")] top,
[Name("bottom")] bottom,
}

}
