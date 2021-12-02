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
///  set preset (from -1 to 9) (default none)
/// </summary>
public PseudocolorFilterGen preset(PseudocolorFilterGenPreset preset) => this.SetOption("preset", preset.GetAttribute<NameAttribute>().Name);
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
public static PseudocolorFilterGen PseudocolorFilterGen(this ImageMap input0) => new PseudocolorFilterGen(input0);
/// <summary>
/// Make pseudocolored video frames.
/// </summary>
public static PseudocolorFilterGen PseudocolorFilterGen(this ImageMap input0,PseudocolorFilterGenConfig config)
{
var result = new PseudocolorFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.c0)) result.c0(config.c0);
if(!string.IsNullOrWhiteSpace(config?.c1)) result.c1(config.c1);
if(!string.IsNullOrWhiteSpace(config?.c2)) result.c2(config.c2);
if(!string.IsNullOrWhiteSpace(config?.c3)) result.c3(config.c3);
if(config?.index != null) result.index(config.index.Value);
if(config?.preset != null) result.preset(config.preset.Value);
if(config?.opacity != null) result.opacity(config.opacity.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class PseudocolorFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set component #0 expression (default "val")
/// </summary>
public string c0 { get; set; }
/// <summary>
///  set component #1 expression (default "val")
/// </summary>
public string c1 { get; set; }
/// <summary>
///  set component #2 expression (default "val")
/// </summary>
public string c2 { get; set; }
/// <summary>
///  set component #3 expression (default "val")
/// </summary>
public string c3 { get; set; }
/// <summary>
///  set component as base (from 0 to 3) (default 0)
/// </summary>
public int? index { get; set; }
/// <summary>
///  set preset (from -1 to 9) (default none)
/// </summary>
public PseudocolorFilterGenPreset? preset { get; set; }
/// <summary>
///  set pseudocolor opacity (from 0 to 1) (default 1)
/// </summary>
public float? opacity { get; set; }
public string TimelineSupport { get; set; }
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

}
