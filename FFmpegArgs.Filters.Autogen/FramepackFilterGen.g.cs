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
public class FramepackFilterGen : ImageToImageFilter
{
internal FramepackFilterGen(params ImageMap[] inputs) : base("framepack",inputs) { AddMapOut(); }
/// <summary>
///  Frame pack output format (from 0 to INT_MAX) (default sbs)
/// </summary>
public FramepackFilterGen format(FramepackFilterGenFormat format) => this.SetOption("format", format.GetAttribute<NameAttribute>().Name);
}
public static class FramepackFilterGenExtensions
{
/// <summary>
/// Generate a frame packed stereoscopic video.
/// </summary>
public static FramepackFilterGen FramepackFilterGen(this ImageMap input0, ImageMap input1) => new FramepackFilterGen(input0, input1);
/// <summary>
/// Generate a frame packed stereoscopic video.
/// </summary>
public static FramepackFilterGen FramepackFilterGen(this ImageMap input0, ImageMap input1,FramepackFilterGenConfig config)
{
var result = new FramepackFilterGen(input0, input1);
if(config?.format != null) result.format(config.format);
return result;
}
}
public class FramepackFilterGenConfig
{
/// <summary>
///  Frame pack output format (from 0 to INT_MAX) (default sbs)
/// </summary>
public FramepackFilterGenFormat format { get; set; }
}
public enum FramepackFilterGenFormat
{
[Name("sbs")] sbs,
[Name("tab")] tab,
[Name("frameseq")] frameseq,
[Name("lines")] lines,
[Name("columns")] columns,
}

}
