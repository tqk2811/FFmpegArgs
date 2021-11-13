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
public class DrawgraphFilterGen : ImageToImageFilter
{
internal DrawgraphFilterGen(ImageMap input) : base("drawgraph",input) { AddMapOut(); }
/// <summary>
///  set 1st metadata key (default "")
/// </summary>
public DrawgraphFilterGen m1(string m1) => this.SetOption("m1",m1);
/// <summary>
///  set 1st foreground color expression (default "0xffff0000")
/// </summary>
public DrawgraphFilterGen fg1(string fg1) => this.SetOption("fg1",fg1);
/// <summary>
///  set 2nd metadata key (default "")
/// </summary>
public DrawgraphFilterGen m2(string m2) => this.SetOption("m2",m2);
/// <summary>
///  set 2nd foreground color expression (default "0xff00ff00")
/// </summary>
public DrawgraphFilterGen fg2(string fg2) => this.SetOption("fg2",fg2);
/// <summary>
///  set 3rd metadata key (default "")
/// </summary>
public DrawgraphFilterGen m3(string m3) => this.SetOption("m3",m3);
/// <summary>
///  set 3rd foreground color expression (default "0xffff00ff")
/// </summary>
public DrawgraphFilterGen fg3(string fg3) => this.SetOption("fg3",fg3);
/// <summary>
///  set 4th metadata key (default "")
/// </summary>
public DrawgraphFilterGen m4(string m4) => this.SetOption("m4",m4);
/// <summary>
///  set 4th foreground color expression (default "0xffffff00")
/// </summary>
public DrawgraphFilterGen fg4(string fg4) => this.SetOption("fg4",fg4);
/// <summary>
///  set background color (default "white")
/// </summary>
public DrawgraphFilterGen bg(Color bg) => this.SetOption("bg",bg.ToHexStringRGBA());
/// <summary>
///  set minimal value (from INT_MIN to INT_MAX) (default -1)
/// </summary>
public DrawgraphFilterGen min(float min) => this.SetOptionRange("min", min,INT_MIN,INT_MAX);
/// <summary>
///  set maximal value (from INT_MIN to INT_MAX) (default 1)
/// </summary>
public DrawgraphFilterGen max(float max) => this.SetOptionRange("max", max,INT_MIN,INT_MAX);
/// <summary>
///  set graph mode (from 0 to 2) (default line)
/// </summary>
public DrawgraphFilterGen mode(DrawgraphFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set slide mode (from 0 to 4) (default frame)
/// </summary>
public DrawgraphFilterGen slide(DrawgraphFilterGenSlide slide) => this.SetOption("slide", slide.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set graph size (default "900x256")
/// </summary>
public DrawgraphFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set graph size (default "900x256")
/// </summary>
public DrawgraphFilterGen s(Size size) => this.SetOption("s",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public DrawgraphFilterGen Rate(string r) => this.SetOption("rate", r);
/// <summary>
///  set video rate (default "25")
/// </summary>
public DrawgraphFilterGen rate(int r) => this.SetOptionRange("rate", r, 1, int.MaxValue);
/// <summary>
///  set video rate (default "25")
/// </summary>
public DrawgraphFilterGen R(string r) => this.SetOption("r", r);
/// <summary>
///  set video rate (default "25")
/// </summary>
public DrawgraphFilterGen r(int r) => this.SetOptionRange("r", r, 1, int.MaxValue);
}
public static class DrawgraphFilterGenExtensions
{
/// <summary>
/// Draw a graph using input video metadata.
/// </summary>
public static DrawgraphFilterGen DrawgraphFilterGen(this ImageMap input) => new DrawgraphFilterGen(input);
}
public enum DrawgraphFilterGenMode
{
[Name("bar")] bar,
[Name("dot")] dot,
[Name("line")] line,
}

public enum DrawgraphFilterGenSlide
{
[Name("frame")] frame,
[Name("replace")] replace,
[Name("scroll")] scroll,
[Name("rscroll")] rscroll,
[Name("picture")] picture,
}

}
