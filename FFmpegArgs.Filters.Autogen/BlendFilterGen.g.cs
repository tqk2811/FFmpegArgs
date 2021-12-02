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
public class BlendFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal BlendFilterGen(params ImageMap[] inputs) : base("blend",inputs) { AddMapOut(); }
/// <summary>
///  set component #0 blend mode (from 0 to 32) (default normal)
/// </summary>
public BlendFilterGen c0_mode(BlendFilterGenC0_mode c0_mode) => this.SetOption("c0_mode", c0_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set component #1 blend mode (from 0 to 32) (default normal)
/// </summary>
public BlendFilterGen c1_mode(BlendFilterGenC1_mode c1_mode) => this.SetOption("c1_mode", c1_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set component #2 blend mode (from 0 to 32) (default normal)
/// </summary>
public BlendFilterGen c2_mode(BlendFilterGenC2_mode c2_mode) => this.SetOption("c2_mode", c2_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set component #3 blend mode (from 0 to 32) (default normal)
/// </summary>
public BlendFilterGen c3_mode(BlendFilterGenC3_mode c3_mode) => this.SetOption("c3_mode", c3_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set blend mode for all components (from -1 to 32) (default -1)
/// </summary>
public BlendFilterGen all_mode(BlendFilterGenAll_mode all_mode) => this.SetOption("all_mode", all_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set color component #0 expression
/// </summary>
public BlendFilterGen c0_expr(string c0_expr) => this.SetOption("c0_expr",c0_expr);
/// <summary>
///  set color component #1 expression
/// </summary>
public BlendFilterGen c1_expr(string c1_expr) => this.SetOption("c1_expr",c1_expr);
/// <summary>
///  set color component #2 expression
/// </summary>
public BlendFilterGen c2_expr(string c2_expr) => this.SetOption("c2_expr",c2_expr);
/// <summary>
///  set color component #3 expression
/// </summary>
public BlendFilterGen c3_expr(string c3_expr) => this.SetOption("c3_expr",c3_expr);
/// <summary>
///  set expression for all color components
/// </summary>
public BlendFilterGen all_expr(string all_expr) => this.SetOption("all_expr",all_expr);
/// <summary>
///  set color component #0 opacity (from 0 to 1) (default 1)
/// </summary>
public BlendFilterGen c0_opacity(double c0_opacity) => this.SetOptionRange("c0_opacity", c0_opacity,0,1);
/// <summary>
///  set color component #1 opacity (from 0 to 1) (default 1)
/// </summary>
public BlendFilterGen c1_opacity(double c1_opacity) => this.SetOptionRange("c1_opacity", c1_opacity,0,1);
/// <summary>
///  set color component #2 opacity (from 0 to 1) (default 1)
/// </summary>
public BlendFilterGen c2_opacity(double c2_opacity) => this.SetOptionRange("c2_opacity", c2_opacity,0,1);
/// <summary>
///  set color component #3 opacity (from 0 to 1) (default 1)
/// </summary>
public BlendFilterGen c3_opacity(double c3_opacity) => this.SetOptionRange("c3_opacity", c3_opacity,0,1);
/// <summary>
///  set opacity for all color components (from 0 to 1) (default 1)
/// </summary>
public BlendFilterGen all_opacity(double all_opacity) => this.SetOptionRange("all_opacity", all_opacity,0,1);
}
public static class BlendFilterGenExtensions
{
/// <summary>
/// Blend two video frames into each other.
/// </summary>
public static BlendFilterGen BlendFilterGen(this ImageMap input0, ImageMap input1) => new BlendFilterGen(input0, input1);
/// <summary>
/// Blend two video frames into each other.
/// </summary>
public static BlendFilterGen BlendFilterGen(this ImageMap input0, ImageMap input1,BlendFilterGenConfig config)
{
var result = new BlendFilterGen(input0, input1);
if(config?.c0_mode != null) result.c0_mode(config.c0_mode.Value);
if(config?.c1_mode != null) result.c1_mode(config.c1_mode.Value);
if(config?.c2_mode != null) result.c2_mode(config.c2_mode.Value);
if(config?.c3_mode != null) result.c3_mode(config.c3_mode.Value);
if(config?.all_mode != null) result.all_mode(config.all_mode.Value);
if(!string.IsNullOrWhiteSpace(config?.c0_expr)) result.c0_expr(config.c0_expr);
if(!string.IsNullOrWhiteSpace(config?.c1_expr)) result.c1_expr(config.c1_expr);
if(!string.IsNullOrWhiteSpace(config?.c2_expr)) result.c2_expr(config.c2_expr);
if(!string.IsNullOrWhiteSpace(config?.c3_expr)) result.c3_expr(config.c3_expr);
if(!string.IsNullOrWhiteSpace(config?.all_expr)) result.all_expr(config.all_expr);
if(config?.c0_opacity != null) result.c0_opacity(config.c0_opacity.Value);
if(config?.c1_opacity != null) result.c1_opacity(config.c1_opacity.Value);
if(config?.c2_opacity != null) result.c2_opacity(config.c2_opacity.Value);
if(config?.c3_opacity != null) result.c3_opacity(config.c3_opacity.Value);
if(config?.all_opacity != null) result.all_opacity(config.all_opacity.Value);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class BlendFilterGenConfig
{
/// <summary>
///  set component #0 blend mode (from 0 to 32) (default normal)
/// </summary>
public BlendFilterGenC0_mode? c0_mode { get; set; }
/// <summary>
///  set component #1 blend mode (from 0 to 32) (default normal)
/// </summary>
public BlendFilterGenC1_mode? c1_mode { get; set; }
/// <summary>
///  set component #2 blend mode (from 0 to 32) (default normal)
/// </summary>
public BlendFilterGenC2_mode? c2_mode { get; set; }
/// <summary>
///  set component #3 blend mode (from 0 to 32) (default normal)
/// </summary>
public BlendFilterGenC3_mode? c3_mode { get; set; }
/// <summary>
///  set blend mode for all components (from -1 to 32) (default -1)
/// </summary>
public BlendFilterGenAll_mode? all_mode { get; set; }
/// <summary>
///  set color component #0 expression
/// </summary>
public string c0_expr { get; set; }
/// <summary>
///  set color component #1 expression
/// </summary>
public string c1_expr { get; set; }
/// <summary>
///  set color component #2 expression
/// </summary>
public string c2_expr { get; set; }
/// <summary>
///  set color component #3 expression
/// </summary>
public string c3_expr { get; set; }
/// <summary>
///  set expression for all color components
/// </summary>
public string all_expr { get; set; }
/// <summary>
///  set color component #0 opacity (from 0 to 1) (default 1)
/// </summary>
public double? c0_opacity { get; set; }
/// <summary>
///  set color component #1 opacity (from 0 to 1) (default 1)
/// </summary>
public double? c1_opacity { get; set; }
/// <summary>
///  set color component #2 opacity (from 0 to 1) (default 1)
/// </summary>
public double? c2_opacity { get; set; }
/// <summary>
///  set color component #3 opacity (from 0 to 1) (default 1)
/// </summary>
public double? c3_opacity { get; set; }
/// <summary>
///  set opacity for all color components (from 0 to 1) (default 1)
/// </summary>
public double? all_opacity { get; set; }
public string TimelineSupport { get; set; }
}
public enum BlendFilterGenC0_mode
{
[Name("addition")] addition,
[Name("addition128")] addition128,
[Name("grainmerge")] grainmerge,
[Name("and")] and,
[Name("average")] average,
[Name("burn")] burn,
[Name("darken")] darken,
[Name("difference")] difference,
[Name("difference128")] difference128,
[Name("grainextract")] grainextract,
[Name("divide")] divide,
[Name("dodge")] dodge,
[Name("exclusion")] exclusion,
[Name("extremity")] extremity,
[Name("freeze")] freeze,
[Name("glow")] glow,
[Name("hardlight")] hardlight,
[Name("hardmix")] hardmix,
[Name("heat")] heat,
[Name("lighten")] lighten,
[Name("linearlight")] linearlight,
[Name("multiply")] multiply,
[Name("multiply128")] multiply128,
[Name("negation")] negation,
[Name("normal")] normal,
[Name("or")] or,
[Name("overlay")] overlay,
[Name("phoenix")] phoenix,
[Name("pinlight")] pinlight,
[Name("reflect")] reflect,
[Name("screen")] screen,
[Name("softlight")] softlight,
[Name("subtract")] subtract,
[Name("vividlight")] vividlight,
[Name("xor")] xor,
}

public enum BlendFilterGenC1_mode
{
[Name("addition")] addition,
[Name("addition128")] addition128,
[Name("grainmerge")] grainmerge,
[Name("and")] and,
[Name("average")] average,
[Name("burn")] burn,
[Name("darken")] darken,
[Name("difference")] difference,
[Name("difference128")] difference128,
[Name("grainextract")] grainextract,
[Name("divide")] divide,
[Name("dodge")] dodge,
[Name("exclusion")] exclusion,
[Name("extremity")] extremity,
[Name("freeze")] freeze,
[Name("glow")] glow,
[Name("hardlight")] hardlight,
[Name("hardmix")] hardmix,
[Name("heat")] heat,
[Name("lighten")] lighten,
[Name("linearlight")] linearlight,
[Name("multiply")] multiply,
[Name("multiply128")] multiply128,
[Name("negation")] negation,
[Name("normal")] normal,
[Name("or")] or,
[Name("overlay")] overlay,
[Name("phoenix")] phoenix,
[Name("pinlight")] pinlight,
[Name("reflect")] reflect,
[Name("screen")] screen,
[Name("softlight")] softlight,
[Name("subtract")] subtract,
[Name("vividlight")] vividlight,
[Name("xor")] xor,
}

public enum BlendFilterGenC2_mode
{
[Name("addition")] addition,
[Name("addition128")] addition128,
[Name("grainmerge")] grainmerge,
[Name("and")] and,
[Name("average")] average,
[Name("burn")] burn,
[Name("darken")] darken,
[Name("difference")] difference,
[Name("difference128")] difference128,
[Name("grainextract")] grainextract,
[Name("divide")] divide,
[Name("dodge")] dodge,
[Name("exclusion")] exclusion,
[Name("extremity")] extremity,
[Name("freeze")] freeze,
[Name("glow")] glow,
[Name("hardlight")] hardlight,
[Name("hardmix")] hardmix,
[Name("heat")] heat,
[Name("lighten")] lighten,
[Name("linearlight")] linearlight,
[Name("multiply")] multiply,
[Name("multiply128")] multiply128,
[Name("negation")] negation,
[Name("normal")] normal,
[Name("or")] or,
[Name("overlay")] overlay,
[Name("phoenix")] phoenix,
[Name("pinlight")] pinlight,
[Name("reflect")] reflect,
[Name("screen")] screen,
[Name("softlight")] softlight,
[Name("subtract")] subtract,
[Name("vividlight")] vividlight,
[Name("xor")] xor,
}

public enum BlendFilterGenC3_mode
{
[Name("addition")] addition,
[Name("addition128")] addition128,
[Name("grainmerge")] grainmerge,
[Name("and")] and,
[Name("average")] average,
[Name("burn")] burn,
[Name("darken")] darken,
[Name("difference")] difference,
[Name("difference128")] difference128,
[Name("grainextract")] grainextract,
[Name("divide")] divide,
[Name("dodge")] dodge,
[Name("exclusion")] exclusion,
[Name("extremity")] extremity,
[Name("freeze")] freeze,
[Name("glow")] glow,
[Name("hardlight")] hardlight,
[Name("hardmix")] hardmix,
[Name("heat")] heat,
[Name("lighten")] lighten,
[Name("linearlight")] linearlight,
[Name("multiply")] multiply,
[Name("multiply128")] multiply128,
[Name("negation")] negation,
[Name("normal")] normal,
[Name("or")] or,
[Name("overlay")] overlay,
[Name("phoenix")] phoenix,
[Name("pinlight")] pinlight,
[Name("reflect")] reflect,
[Name("screen")] screen,
[Name("softlight")] softlight,
[Name("subtract")] subtract,
[Name("vividlight")] vividlight,
[Name("xor")] xor,
}

public enum BlendFilterGenAll_mode
{
[Name("addition")] addition,
[Name("addition128")] addition128,
[Name("grainmerge")] grainmerge,
[Name("and")] and,
[Name("average")] average,
[Name("burn")] burn,
[Name("darken")] darken,
[Name("difference")] difference,
[Name("difference128")] difference128,
[Name("grainextract")] grainextract,
[Name("divide")] divide,
[Name("dodge")] dodge,
[Name("exclusion")] exclusion,
[Name("extremity")] extremity,
[Name("freeze")] freeze,
[Name("glow")] glow,
[Name("hardlight")] hardlight,
[Name("hardmix")] hardmix,
[Name("heat")] heat,
[Name("lighten")] lighten,
[Name("linearlight")] linearlight,
[Name("multiply")] multiply,
[Name("multiply128")] multiply128,
[Name("negation")] negation,
[Name("normal")] normal,
[Name("or")] or,
[Name("overlay")] overlay,
[Name("phoenix")] phoenix,
[Name("pinlight")] pinlight,
[Name("reflect")] reflect,
[Name("screen")] screen,
[Name("softlight")] softlight,
[Name("subtract")] subtract,
[Name("vividlight")] vividlight,
[Name("xor")] xor,
}

}
