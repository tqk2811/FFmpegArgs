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
public class LenscorrectionFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal LenscorrectionFilterGen(ImageMap input) : base("lenscorrection",input) { AddMapOut(); }
/// <summary>
///  set relative center x (from 0 to 1) (default 0.5)
/// </summary>
public LenscorrectionFilterGen cx(double cx) => this.SetOptionRange("cx", cx,0,1);
/// <summary>
///  set relative center y (from 0 to 1) (default 0.5)
/// </summary>
public LenscorrectionFilterGen cy(double cy) => this.SetOptionRange("cy", cy,0,1);
/// <summary>
///  set quadratic distortion factor (from -1 to 1) (default 0)
/// </summary>
public LenscorrectionFilterGen k1(double k1) => this.SetOptionRange("k1", k1,-1,1);
/// <summary>
///  set double quadratic distortion factor (from -1 to 1) (default 0)
/// </summary>
public LenscorrectionFilterGen k2(double k2) => this.SetOptionRange("k2", k2,-1,1);
/// <summary>
///  set interpolation type (from 0 to 64) (default nearest)
/// </summary>
public LenscorrectionFilterGen i(LenscorrectionFilterGenI i) => this.SetOption("i", i.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set the color of the unmapped pixels (default "black@0")
/// </summary>
public LenscorrectionFilterGen fc(Color fc) => this.SetOption("fc",fc.ToHexStringRGBA());
}
public static class LenscorrectionFilterGenExtensions
{
/// <summary>
/// Rectify the image by correcting for lens distortion.
/// </summary>
public static LenscorrectionFilterGen LenscorrectionFilterGen(this ImageMap input0) => new LenscorrectionFilterGen(input0);
}
public enum LenscorrectionFilterGenI
{
[Name("nearest")] nearest,
[Name("bilinear")] bilinear,
}

}
