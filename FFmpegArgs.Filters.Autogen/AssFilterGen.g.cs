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
public class AssFilterGen : ImageToImageFilter
{
internal AssFilterGen(ImageMap input) : base("ass",input) { AddMapOut(); }
/// <summary>
///  set the filename of file to read
/// </summary>
public AssFilterGen filename(string filename) => this.SetOption("filename",filename);
/// <summary>
///  set the filename of file to read
/// </summary>
public AssFilterGen f(string f) => this.SetOption("f",f);
/// <summary>
///  set the size of the original video (used to scale fonts)
/// </summary>
public AssFilterGen original_size(Size size) => this.SetOption("original_size",$"{size.Width}x{size.Height}");
/// <summary>
///  set the directory containing the fonts to read
/// </summary>
public AssFilterGen fontsdir(string fontsdir) => this.SetOption("fontsdir",fontsdir);
/// <summary>
///  enable processing of alpha channel (default false)
/// </summary>
public AssFilterGen alpha(bool flag) => this.SetOption("alpha",flag.ToFFmpegFlag());
/// <summary>
///  set shaping engine (from -1 to 1) (default auto)
/// </summary>
public AssFilterGen shaping(AssFilterGenShaping shaping) => this.SetOption("shaping", shaping.GetAttribute<NameAttribute>().Name);
}
public static class AssFilterGenExtensions
{
/// <summary>
/// Render ASS subtitles onto input video using the libass library.
/// </summary>
public static AssFilterGen AssFilterGen(this ImageMap input) => new AssFilterGen(input);
}
public enum AssFilterGenShaping
{
[Name("auto")] auto,
[Name("simple")] simple,
[Name("complex")] complex,
}

}
