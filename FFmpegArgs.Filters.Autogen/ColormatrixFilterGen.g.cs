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
public class ColormatrixFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal ColormatrixFilterGen(ImageMap input) : base("colormatrix",input) { AddMapOut(); }
/// <summary>
///  set source color matrix (from -1 to 4) (default -1)
/// </summary>
public ColormatrixFilterGen src(ColormatrixFilterGenSrc src) => this.SetOption("src", src.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set destination color matrix (from -1 to 4) (default -1)
/// </summary>
public ColormatrixFilterGen dst(ColormatrixFilterGenDst dst) => this.SetOption("dst", dst.GetAttribute<NameAttribute>().Name);
}
public static class ColormatrixFilterGenExtensions
{
/// <summary>
/// Convert color matrix.
/// </summary>
public static ColormatrixFilterGen ColormatrixFilterGen(this ImageMap input0) => new ColormatrixFilterGen(input0);
}
public enum ColormatrixFilterGenSrc
{
[Name("bt709")] bt709,
[Name("fcc")] fcc,
[Name("bt601")] bt601,
[Name("bt470")] bt470,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("smpte240m")] smpte240m,
[Name("bt2020")] bt2020,
}

public enum ColormatrixFilterGenDst
{
[Name("bt709")] bt709,
[Name("fcc")] fcc,
[Name("bt601")] bt601,
[Name("bt470")] bt470,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("smpte240m")] smpte240m,
[Name("bt2020")] bt2020,
}

}
