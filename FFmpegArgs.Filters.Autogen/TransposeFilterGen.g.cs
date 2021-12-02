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
public class TransposeFilterGen : ImageToImageFilter,ISliceThreading
{
internal TransposeFilterGen(ImageMap input) : base("transpose",input) { AddMapOut(); }
/// <summary>
///  set transpose direction (from 0 to 7) (default cclock_flip)
/// </summary>
public TransposeFilterGen dir(TransposeFilterGenDir dir) => this.SetOption("dir", dir.GetAttribute<NameAttribute>().Name);
/// <summary>
///  do not apply transposition if the input matches the specified geometry (from 0 to INT_MAX) (default none)
/// </summary>
public TransposeFilterGen passthrough(TransposeFilterGenPassthrough passthrough) => this.SetOption("passthrough", passthrough.GetAttribute<NameAttribute>().Name);
}
public static class TransposeFilterGenExtensions
{
/// <summary>
/// Transpose input video.
/// </summary>
public static TransposeFilterGen TransposeFilterGen(this ImageMap input0) => new TransposeFilterGen(input0);
/// <summary>
/// Transpose input video.
/// </summary>
public static TransposeFilterGen TransposeFilterGen(this ImageMap input0,TransposeFilterGenConfig config)
{
var result = new TransposeFilterGen(input0);
if(config?.dir != null) result.dir(config.dir);
if(config?.passthrough != null) result.passthrough(config.passthrough);
return result;
}
}
public class TransposeFilterGenConfig
{
/// <summary>
///  set transpose direction (from 0 to 7) (default cclock_flip)
/// </summary>
public TransposeFilterGenDir dir { get; set; }
/// <summary>
///  do not apply transposition if the input matches the specified geometry (from 0 to INT_MAX) (default none)
/// </summary>
public TransposeFilterGenPassthrough passthrough { get; set; }
}
public enum TransposeFilterGenDir
{
[Name("cclock_flip")] cclock_flip,
[Name("clock")] clock,
[Name("cclock")] cclock,
[Name("clock_flip")] clock_flip,
}

public enum TransposeFilterGenPassthrough
{
[Name("none")] none,
[Name("portrait")] portrait,
[Name("landscape")] landscape,
}

}
