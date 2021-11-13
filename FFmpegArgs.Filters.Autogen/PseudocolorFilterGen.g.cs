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
public class PseudocolorFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal PseudocolorFilterGen(ImageMap input) : base("pseudocolor",input) { AddMapOut(); }
/// <summary>
///  set component #0 expression (default "val")
/// </summary>
public PseudocolorFilterGen c0(string c0) => this.SetOption("c0",c0);
/// <summary>
///  set component #1 expression (default "val")
/// </summary>
public PseudocolorFilterGen c1(string c1) => this.SetOption("c1",c1);
/// <summary>
///  set component #2 expression (default "val")
/// </summary>
public PseudocolorFilterGen c2(string c2) => this.SetOption("c2",c2);
/// <summary>
///  set component #3 expression (default "val")
/// </summary>
public PseudocolorFilterGen c3(string c3) => this.SetOption("c3",c3);
/// <summary>
///  set component as base (from 0 to 3) (default 0)
/// </summary>
public PseudocolorFilterGen index(int index) => this.SetOptionRange("index", index,0,3);
/// <summary>
///  set component as base (from 0 to 3) (default 0)
/// </summary>
public PseudocolorFilterGen i(int i) => this.SetOptionRange("i", i,0,3);
/// <summary>
///  set preset (from -1 to 9) (default none)
/// </summary>
public PseudocolorFilterGen preset(PseudocolorFilterGenPreset preset) => this.SetOption("preset", preset.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set preset (from -1 to 9) (default none)
/// </summary>
public PseudocolorFilterGen p(PseudocolorFilterGenP p) => this.SetOption("p", p.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set pseudocolor opacity (from 0 to 1) (default 1)
/// </summary>
public PseudocolorFilterGen opacity(float opacity) => this.SetOptionRange("opacity", opacity,0,1);
}
public static class PseudocolorFilterGenExtensions
{
/// <summary>
/// Make pseudocolored video frames.
/// </summary>
public static PseudocolorFilterGen PseudocolorFilterGen(this ImageMap input) => new PseudocolorFilterGen(input);
}
public enum PseudocolorFilterGenPreset
{
[Name("none")] none,
[Name("magma")] magma,
[Name("inferno")] inferno,
[Name("plasma")] plasma,
[Name("viridis")] viridis,
[Name("turbo")] turbo,
[Name("cividis")] cividis,
[Name("range1")] range1,
[Name("range2")] range2,
[Name("shadows")] shadows,
[Name("highlights")] highlights,
}

public enum PseudocolorFilterGenP
{
[Name("none")] none,
[Name("magma")] magma,
[Name("inferno")] inferno,
[Name("plasma")] plasma,
[Name("viridis")] viridis,
[Name("turbo")] turbo,
[Name("cividis")] cividis,
[Name("range1")] range1,
[Name("range2")] range2,
[Name("shadows")] shadows,
[Name("highlights")] highlights,
}

}
