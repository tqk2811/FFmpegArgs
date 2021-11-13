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
public class Cover_rectFilterGen : ImageToImageFilter
{
internal Cover_rectFilterGen(ImageMap input) : base("cover_rect",input) { AddMapOut(); }
/// <summary>
///  cover bitmap filename
/// </summary>
public Cover_rectFilterGen cover(string cover) => this.SetOption("cover",cover);
/// <summary>
///  set removal mode (from 0 to 1) (default blur)
/// </summary>
public Cover_rectFilterGen mode(Cover_rectFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
}
public static class Cover_rectFilterGenExtensions
{
/// <summary>
/// Find and cover a user specified object.
/// </summary>
public static Cover_rectFilterGen Cover_rectFilterGen(this ImageMap input0) => new Cover_rectFilterGen(input0);
}
public enum Cover_rectFilterGenMode
{
[Name("cover")] cover,
[Name("blur")] blur,
}

}
