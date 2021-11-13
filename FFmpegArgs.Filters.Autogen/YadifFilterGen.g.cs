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
public class YadifFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal YadifFilterGen(ImageMap input) : base("yadif",input) { AddMapOut(); }
/// <summary>
///  specify the interlacing mode (from 0 to 3) (default send_frame)
/// </summary>
public YadifFilterGen mode(YadifFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  specify the assumed picture field parity (from -1 to 1) (default auto)
/// </summary>
public YadifFilterGen parity(YadifFilterGenParity parity) => this.SetOption("parity", parity.GetAttribute<NameAttribute>().Name);
/// <summary>
///  specify which frames to deinterlace (from 0 to 1) (default all)
/// </summary>
public YadifFilterGen deint(YadifFilterGenDeint deint) => this.SetOption("deint", deint.GetAttribute<NameAttribute>().Name);
}
public static class YadifFilterGenExtensions
{
/// <summary>
/// Deinterlace the input image.
/// </summary>
public static YadifFilterGen YadifFilterGen(this ImageMap input) => new YadifFilterGen(input);
}
public enum YadifFilterGenMode
{
[Name("send_frame")] send_frame,
[Name("send_field")] send_field,
[Name("send_frame_nospatial")] send_frame_nospatial,
[Name("send_field_nospatial")] send_field_nospatial,
}

public enum YadifFilterGenParity
{
[Name("tff")] tff,
[Name("bff")] bff,
[Name("auto")] auto,
}

public enum YadifFilterGenDeint
{
[Name("all")] all,
[Name("interlaced")] interlaced,
}

}
