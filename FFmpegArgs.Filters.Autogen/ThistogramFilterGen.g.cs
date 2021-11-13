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
public class ThistogramFilterGen : ImageToImageFilter
{
internal ThistogramFilterGen(ImageMap input) : base("thistogram",input) { AddMapOut(); }
/// <summary>
///  set width (from 0 to 8192) (default 0)
/// </summary>
public ThistogramFilterGen width(int width) => this.SetOptionRange("width", width,0,8192);
/// <summary>
///  set width (from 0 to 8192) (default 0)
/// </summary>
public ThistogramFilterGen w(int w) => this.SetOptionRange("w", w,0,8192);
/// <summary>
///  set display mode (from 0 to 2) (default stack)
/// </summary>
public ThistogramFilterGen display_mode(ThistogramFilterGenDisplay_mode display_mode) => this.SetOption("display_mode", display_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set display mode (from 0 to 2) (default stack)
/// </summary>
public ThistogramFilterGen d(ThistogramFilterGenD d) => this.SetOption("d", d.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set levels mode (from 0 to 1) (default linear)
/// </summary>
public ThistogramFilterGen levels_mode(ThistogramFilterGenLevels_mode levels_mode) => this.SetOption("levels_mode", levels_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set levels mode (from 0 to 1) (default linear)
/// </summary>
public ThistogramFilterGen m(ThistogramFilterGenM m) => this.SetOption("m", m.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set color components to display (from 1 to 15) (default 7)
/// </summary>
public ThistogramFilterGen components(int components) => this.SetOptionRange("components", components,1,15);
/// <summary>
///  set color components to display (from 1 to 15) (default 7)
/// </summary>
public ThistogramFilterGen c(int c) => this.SetOptionRange("c", c,1,15);
/// <summary>
///  set background opacity (from 0 to 1) (default 0.9)
/// </summary>
public ThistogramFilterGen bgopacity(float bgopacity) => this.SetOptionRange("bgopacity", bgopacity,0,1);
/// <summary>
///  set background opacity (from 0 to 1) (default 0.9)
/// </summary>
public ThistogramFilterGen b(float b) => this.SetOptionRange("b", b,0,1);
/// <summary>
///  display envelope (default false)
/// </summary>
public ThistogramFilterGen envelope(bool flag) => this.SetOption("envelope",flag.ToFFmpegFlag());
/// <summary>
///  display envelope (default false)
/// </summary>
public ThistogramFilterGen e(bool flag) => this.SetOption("e",flag.ToFFmpegFlag());
/// <summary>
///  set envelope color (default "gold")
/// </summary>
public ThistogramFilterGen ecolor(Color ecolor) => this.SetOption("ecolor",ecolor.ToHexStringRGBA());
/// <summary>
///  set envelope color (default "gold")
/// </summary>
public ThistogramFilterGen ec(Color ec) => this.SetOption("ec",ec.ToHexStringRGBA());
/// <summary>
///  set slide mode (from 0 to 4) (default replace)
/// </summary>
public ThistogramFilterGen slide(ThistogramFilterGenSlide slide) => this.SetOption("slide", slide.GetAttribute<NameAttribute>().Name);
}
public static class ThistogramFilterGenExtensions
{
/// <summary>
/// Compute and draw a temporal histogram.
/// </summary>
public static ThistogramFilterGen ThistogramFilterGen(this ImageMap input0) => new ThistogramFilterGen(input0);
}
public enum ThistogramFilterGenDisplay_mode
{
[Name("overlay")] overlay,
[Name("parade")] parade,
[Name("stack")] stack,
}

public enum ThistogramFilterGenD
{
[Name("overlay")] overlay,
[Name("parade")] parade,
[Name("stack")] stack,
}

public enum ThistogramFilterGenLevels_mode
{
[Name("linear")] linear,
[Name("logarithmic")] logarithmic,
}

public enum ThistogramFilterGenM
{
[Name("linear")] linear,
[Name("logarithmic")] logarithmic,
}

public enum ThistogramFilterGenSlide
{
[Name("frame")] frame,
[Name("replace")] replace,
[Name("scroll")] scroll,
[Name("rscroll")] rscroll,
[Name("picture")] picture,
}

}
