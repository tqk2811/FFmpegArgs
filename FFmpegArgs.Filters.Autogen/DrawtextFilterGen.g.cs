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
public class DrawtextFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal DrawtextFilterGen(ImageMap input) : base("drawtext",input) { AddMapOut(); }
/// <summary>
///  set font file
/// </summary>
public DrawtextFilterGen fontfile(string fontfile) => this.SetOption("fontfile",fontfile);
/// <summary>
///  set text
/// </summary>
public DrawtextFilterGen text(string text) => this.SetOption("text",text);
/// <summary>
///  set text file
/// </summary>
public DrawtextFilterGen textfile(string textfile) => this.SetOption("textfile",textfile);
/// <summary>
///  set foreground color (default "black")
/// </summary>
public DrawtextFilterGen fontcolor(Color fontcolor) => this.SetOption("fontcolor",fontcolor.ToHexStringRGBA());
/// <summary>
///  set foreground color expression (default "")
/// </summary>
public DrawtextFilterGen fontcolor_expr(string fontcolor_expr) => this.SetOption("fontcolor_expr",fontcolor_expr);
/// <summary>
///  set box color (default "white")
/// </summary>
public DrawtextFilterGen boxcolor(Color boxcolor) => this.SetOption("boxcolor",boxcolor.ToHexStringRGBA());
/// <summary>
///  set border color (default "black")
/// </summary>
public DrawtextFilterGen bordercolor(Color bordercolor) => this.SetOption("bordercolor",bordercolor.ToHexStringRGBA());
/// <summary>
///  set shadow color (default "black")
/// </summary>
public DrawtextFilterGen shadowcolor(Color shadowcolor) => this.SetOption("shadowcolor",shadowcolor.ToHexStringRGBA());
/// <summary>
///  set box (default false)
/// </summary>
public DrawtextFilterGen box(bool flag) => this.SetOption("box",flag.ToFFmpegFlag());
/// <summary>
///  set box border width (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public DrawtextFilterGen boxborderw(int boxborderw) => this.SetOptionRange("boxborderw", boxborderw,INT_MIN,INT_MAX);
/// <summary>
///  set line spacing in pixels (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public DrawtextFilterGen line_spacing(int line_spacing) => this.SetOptionRange("line_spacing", line_spacing,INT_MIN,INT_MAX);
/// <summary>
///  set font size
/// </summary>
public DrawtextFilterGen fontsize(string fontsize) => this.SetOption("fontsize",fontsize);
/// <summary>
///  set x expression (default "0")
/// </summary>
public DrawtextFilterGen x(string x) => this.SetOption("x",x);
/// <summary>
///  set y expression (default "0")
/// </summary>
public DrawtextFilterGen y(string y) => this.SetOption("y",y);
/// <summary>
///  set shadow x offset (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public DrawtextFilterGen shadowx(int shadowx) => this.SetOptionRange("shadowx", shadowx,INT_MIN,INT_MAX);
/// <summary>
///  set shadow y offset (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public DrawtextFilterGen shadowy(int shadowy) => this.SetOptionRange("shadowy", shadowy,INT_MIN,INT_MAX);
/// <summary>
///  set border width (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public DrawtextFilterGen borderw(int borderw) => this.SetOptionRange("borderw", borderw,INT_MIN,INT_MAX);
/// <summary>
///  set tab size (from 0 to INT_MAX) (default 4)
/// </summary>
public DrawtextFilterGen tabsize(int tabsize) => this.SetOptionRange("tabsize", tabsize,0,INT_MAX);
/// <summary>
///  set base time (from I64_MIN to I64_MAX) (default I64_MIN)
/// </summary>
public DrawtextFilterGen basetime(long basetime) => this.SetOptionRange("basetime", basetime,I64_MIN,I64_MAX);
/// <summary>
///  Font name (default "Sans")
/// </summary>
public DrawtextFilterGen font(string font) => this.SetOption("font",font);
/// <summary>
///  set the expansion mode (from 0 to 2) (default normal)
/// </summary>
public DrawtextFilterGen expansion(DrawtextFilterGenExpansion expansion) => this.SetOption("expansion", expansion.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set initial timecode
/// </summary>
public DrawtextFilterGen timecode(string timecode) => this.SetOption("timecode",timecode);
/// <summary>
///  set 24 hours max (timecode only) (default false)
/// </summary>
public DrawtextFilterGen tc24hmax(bool flag) => this.SetOption("tc24hmax",flag.ToFFmpegFlag());
/// <summary>
///  set rate (timecode only) (from 0 to INT_MAX) (default 0/1)
/// </summary>
public DrawtextFilterGen timecode_rate(Rational timecode_rate) => this.SetOption("timecode_rate",timecode_rate.Check(0,INT_MAX));
/// <summary>
///  set rate (timecode only) (from 0 to INT_MAX) (default 0/1)
/// </summary>
public DrawtextFilterGen r(Rational r) => this.SetOption("r",r.Check(0,INT_MAX));
/// <summary>
///  set rate (timecode only) (from 0 to INT_MAX) (default 0/1)
/// </summary>
public DrawtextFilterGen rate(Rational rate) => this.SetOption("rate",rate.Check(0,INT_MAX));
/// <summary>
///  reload text file for each frame (default false)
/// </summary>
public DrawtextFilterGen reload(bool flag) => this.SetOption("reload",flag.ToFFmpegFlag());
/// <summary>
///  apply alpha while rendering (default "1")
/// </summary>
public DrawtextFilterGen alpha(string alpha) => this.SetOption("alpha",alpha);
/// <summary>
///  check and fix text coords to avoid clipping (default false)
/// </summary>
public DrawtextFilterGen fix_bounds(bool flag) => this.SetOption("fix_bounds",flag.ToFFmpegFlag());
/// <summary>
///  start frame number for n/frame_num variable (from 0 to INT_MAX) (default 0)
/// </summary>
public DrawtextFilterGen start_number(int start_number) => this.SetOptionRange("start_number", start_number,0,INT_MAX);
/// <summary>
///  attempt to shape text before drawing (default true)
/// </summary>
public DrawtextFilterGen text_shaping(bool flag) => this.SetOption("text_shaping",flag.ToFFmpegFlag());
/// <summary>
///  set font loading flags for libfreetype (default 0)
/// </summary>
public DrawtextFilterGen ft_load_flags(DrawtextFilterGenFt_load_flags ft_load_flags) => this.SetOption("ft_load_flags", ft_load_flags.GetAttribute<NameAttribute>().Name);
}
public static class DrawtextFilterGenExtensions
{
/// <summary>
/// Draw text on top of video frames using libfreetype library.
/// </summary>
public static DrawtextFilterGen DrawtextFilterGen(this ImageMap input0) => new DrawtextFilterGen(input0);
}
public enum DrawtextFilterGenExpansion
{
[Name("none")] none,
[Name("normal")] normal,
[Name("strftime")] strftime,
}

public enum DrawtextFilterGenFt_load_flags
{
[Name("default")] _default,
[Name("no_scale")] no_scale,
[Name("no_hinting")] no_hinting,
[Name("render")] render,
[Name("no_bitmap")] no_bitmap,
[Name("vertical_layout")] vertical_layout,
[Name("force_autohint")] force_autohint,
[Name("crop_bitmap")] crop_bitmap,
[Name("pedantic")] pedantic,
[Name("ignore_global_advance_width")] ignore_global_advance_width,
[Name("no_recurse")] no_recurse,
[Name("ignore_transform")] ignore_transform,
[Name("monochrome")] monochrome,
[Name("linear_design")] linear_design,
[Name("no_autohint")] no_autohint,
}

}
