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
public class HistogramFilterGen : ImageToImageFilter
{
internal HistogramFilterGen(ImageMap input) : base("histogram",input) { AddMapOut(); }
/// <summary>
///  set level height (from 50 to 2048) (default 200)
/// </summary>
public HistogramFilterGen level_height(int level_height) => this.SetOptionRange("level_height", level_height,50,2048);
/// <summary>
///  set scale height (from 0 to 40) (default 12)
/// </summary>
public HistogramFilterGen scale_height(int scale_height) => this.SetOptionRange("scale_height", scale_height,0,40);
/// <summary>
///  set display mode (from 0 to 2) (default stack)
/// </summary>
public HistogramFilterGen display_mode(HistogramFilterGenDisplay_mode display_mode) => this.SetOption("display_mode", display_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set display mode (from 0 to 2) (default stack)
/// </summary>
public HistogramFilterGen d(HistogramFilterGenD d) => this.SetOption("d", d.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set levels mode (from 0 to 1) (default linear)
/// </summary>
public HistogramFilterGen levels_mode(HistogramFilterGenLevels_mode levels_mode) => this.SetOption("levels_mode", levels_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set levels mode (from 0 to 1) (default linear)
/// </summary>
public HistogramFilterGen m(HistogramFilterGenM m) => this.SetOption("m", m.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set color components to display (from 1 to 15) (default 7)
/// </summary>
public HistogramFilterGen components(int components) => this.SetOptionRange("components", components,1,15);
/// <summary>
///  set color components to display (from 1 to 15) (default 7)
/// </summary>
public HistogramFilterGen c(int c) => this.SetOptionRange("c", c,1,15);
/// <summary>
///  set foreground opacity (from 0 to 1) (default 0.7)
/// </summary>
public HistogramFilterGen fgopacity(float fgopacity) => this.SetOptionRange("fgopacity", fgopacity,0,1);
/// <summary>
///  set foreground opacity (from 0 to 1) (default 0.7)
/// </summary>
public HistogramFilterGen f(float f) => this.SetOptionRange("f", f,0,1);
/// <summary>
///  set background opacity (from 0 to 1) (default 0.5)
/// </summary>
public HistogramFilterGen bgopacity(float bgopacity) => this.SetOptionRange("bgopacity", bgopacity,0,1);
/// <summary>
///  set background opacity (from 0 to 1) (default 0.5)
/// </summary>
public HistogramFilterGen b(float b) => this.SetOptionRange("b", b,0,1);
}
public static class HistogramFilterGenExtensions
{
/// <summary>
/// Compute and draw a histogram.
/// </summary>
public static HistogramFilterGen HistogramFilterGen(this ImageMap input0) => new HistogramFilterGen(input0);
}
public enum HistogramFilterGenDisplay_mode
{
[Name("overlay")] overlay,
[Name("parade")] parade,
[Name("stack")] stack,
}

public enum HistogramFilterGenD
{
[Name("overlay")] overlay,
[Name("parade")] parade,
[Name("stack")] stack,
}

public enum HistogramFilterGenLevels_mode
{
[Name("linear")] linear,
[Name("logarithmic")] logarithmic,
}

public enum HistogramFilterGenM
{
[Name("linear")] linear,
[Name("logarithmic")] logarithmic,
}

}
