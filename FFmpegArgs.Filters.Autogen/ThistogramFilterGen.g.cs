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
///  set display mode (from 0 to 2) (default stack)
/// </summary>
public ThistogramFilterGen display_mode(ThistogramFilterGenDisplay_mode display_mode) => this.SetOption("display_mode", display_mode.GetAttribute<NameAttribute>().Name);
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
///  set background opacity (from 0 to 1) (default 0.9)
/// </summary>
public ThistogramFilterGen bgopacity(float bgopacity) => this.SetOptionRange("bgopacity", bgopacity,0,1);
/// <summary>
///  display envelope (default false)
/// </summary>
public ThistogramFilterGen envelope(bool envelope) => this.SetOption("envelope",envelope.ToFFmpegFlag());
/// <summary>
///  set envelope color (default "gold")
/// </summary>
public ThistogramFilterGen ecolor(Color ecolor) => this.SetOption("ecolor",ecolor.ToHexStringRGBA());
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
/// <summary>
/// Compute and draw a temporal histogram.
/// </summary>
public static ThistogramFilterGen ThistogramFilterGen(this ImageMap input0,ThistogramFilterGenConfig config)
{
var result = new ThistogramFilterGen(input0);
if(config?.width != null) result.width(config.width.Value);
if(config?.display_mode != null) result.display_mode(config.display_mode.Value);
if(config?.levels_mode != null) result.levels_mode(config.levels_mode.Value);
if(config?.m != null) result.m(config.m.Value);
if(config?.components != null) result.components(config.components.Value);
if(config?.bgopacity != null) result.bgopacity(config.bgopacity.Value);
if(config?.envelope != null) result.envelope(config.envelope.Value);
if(config?.ecolor != null) result.ecolor(config.ecolor.Value);
if(config?.slide != null) result.slide(config.slide.Value);
return result;
}
}
public class ThistogramFilterGenConfig
{
/// <summary>
///  set width (from 0 to 8192) (default 0)
/// </summary>
public int? width { get; set; }
/// <summary>
///  set display mode (from 0 to 2) (default stack)
/// </summary>
public ThistogramFilterGenDisplay_mode? display_mode { get; set; }
/// <summary>
///  set levels mode (from 0 to 1) (default linear)
/// </summary>
public ThistogramFilterGenLevels_mode? levels_mode { get; set; }
/// <summary>
///  set levels mode (from 0 to 1) (default linear)
/// </summary>
public ThistogramFilterGenM? m { get; set; }
/// <summary>
///  set color components to display (from 1 to 15) (default 7)
/// </summary>
public int? components { get; set; }
/// <summary>
///  set background opacity (from 0 to 1) (default 0.9)
/// </summary>
public float? bgopacity { get; set; }
/// <summary>
///  display envelope (default false)
/// </summary>
public bool? envelope { get; set; }
/// <summary>
///  set envelope color (default "gold")
/// </summary>
public Color? ecolor { get; set; }
/// <summary>
///  set slide mode (from 0 to 4) (default replace)
/// </summary>
public ThistogramFilterGenSlide? slide { get; set; }
}
public enum ThistogramFilterGenDisplay_mode
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
