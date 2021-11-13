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
public class DeflickerFilterGen : ImageToImageFilter
{
internal DeflickerFilterGen(ImageMap input) : base("deflicker",input) { AddMapOut(); }
/// <summary>
///  set how many frames to use (from 2 to 129) (default 5)
/// </summary>
public DeflickerFilterGen size(int size) => this.SetOptionRange("size", size,2,129);
/// <summary>
///  set how many frames to use (from 2 to 129) (default 5)
/// </summary>
public DeflickerFilterGen s(int s) => this.SetOptionRange("s", s,2,129);
/// <summary>
///  set how to smooth luminance (from 0 to 6) (default am)
/// </summary>
public DeflickerFilterGen mode(DeflickerFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set how to smooth luminance (from 0 to 6) (default am)
/// </summary>
public DeflickerFilterGen m(DeflickerFilterGenM m) => this.SetOption("m", m.GetAttribute<NameAttribute>().Name);
/// <summary>
///  leave frames unchanged (default false)
/// </summary>
public DeflickerFilterGen bypass(bool flag) => this.SetOption("bypass",flag.ToFFmpegFlag());
}
public static class DeflickerFilterGenExtensions
{
/// <summary>
/// Remove temporal frame luminance variations.
/// </summary>
public static DeflickerFilterGen DeflickerFilterGen(this ImageMap input0) => new DeflickerFilterGen(input0);
}
public enum DeflickerFilterGenMode
{
[Name("am")] am,
[Name("gm")] gm,
[Name("hm")] hm,
[Name("qm")] qm,
[Name("cm")] cm,
[Name("pm")] pm,
[Name("median")] median,
}

public enum DeflickerFilterGenM
{
[Name("am")] am,
[Name("gm")] gm,
[Name("hm")] hm,
[Name("qm")] qm,
[Name("cm")] cm,
[Name("pm")] pm,
[Name("median")] median,
}

}
