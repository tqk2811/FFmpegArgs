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
public class MetadataFilterGen : ImageToImageFilter,ITimelineSupport
{
internal MetadataFilterGen(ImageMap input) : base("metadata",input) { AddMapOut(); }
/// <summary>
///  set a mode of operation (from 0 to 4) (default select)
/// </summary>
public MetadataFilterGen mode(MetadataFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set metadata key
/// </summary>
public MetadataFilterGen key(string key) => this.SetOption("key",key);
/// <summary>
///  set metadata value
/// </summary>
public MetadataFilterGen value(string value) => this.SetOption("value",value);
/// <summary>
///  function for comparing values (from 0 to 6) (default same_str)
/// </summary>
public MetadataFilterGen function(MetadataFilterGenFunction function) => this.SetOption("function", function.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set expression for expr function
/// </summary>
public MetadataFilterGen expr(string expr) => this.SetOption("expr",expr);
/// <summary>
///  set file where to print metadata information
/// </summary>
public MetadataFilterGen file(string file) => this.SetOption("file",file);
/// <summary>
///  reduce buffering when printing to user-set file or pipe (default false)
/// </summary>
public MetadataFilterGen direct(bool flag) => this.SetOption("direct",flag.ToFFmpegFlag());
}
public static class MetadataFilterGenExtensions
{
/// <summary>
/// Manipulate video frame metadata.
/// </summary>
public static MetadataFilterGen MetadataFilterGen(this ImageMap input0) => new MetadataFilterGen(input0);
}
public enum MetadataFilterGenMode
{
[Name("select")] select,
[Name("add")] add,
[Name("modify")] modify,
[Name("delete")] delete,
[Name("print")] print,
}

public enum MetadataFilterGenFunction
{
[Name("same_str")] same_str,
[Name("starts_with")] starts_with,
[Name("less")] less,
[Name("equal")] equal,
[Name("greater")] greater,
[Name("expr")] expr,
[Name("ends_with")] ends_with,
}

}
