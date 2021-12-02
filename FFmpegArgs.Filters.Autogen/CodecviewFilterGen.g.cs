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
public class CodecviewFilterGen : ImageToImageFilter,ITimelineSupport
{
internal CodecviewFilterGen(ImageMap input) : base("codecview",input) { AddMapOut(); }
/// <summary>
///  set motion vectors to visualize (default 0)
/// </summary>
public CodecviewFilterGen mv(CodecviewFilterGenMv mv) => this.SetOption("mv", mv.GetAttribute<NameAttribute>().Name);
/// <summary>
///  (default false)
/// </summary>
public CodecviewFilterGen qp(bool qp) => this.SetOption("qp",qp.ToFFmpegFlag());
/// <summary>
///  set motion vectors type (default 0)
/// </summary>
public CodecviewFilterGen mv_type(CodecviewFilterGenMv_type mv_type) => this.SetOption("mv_type", mv_type.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set motion vectors type (default 0)
/// </summary>
public CodecviewFilterGen mvt(CodecviewFilterGenMvt mvt) => this.SetOption("mvt", mvt.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set frame types to visualize motion vectors of (default 0)
/// </summary>
public CodecviewFilterGen frame_type(CodecviewFilterGenFrame_type frame_type) => this.SetOption("frame_type", frame_type.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set frame types to visualize motion vectors of (default 0)
/// </summary>
public CodecviewFilterGen ft(CodecviewFilterGenFt ft) => this.SetOption("ft", ft.GetAttribute<NameAttribute>().Name);
}
public static class CodecviewFilterGenExtensions
{
/// <summary>
/// Visualize information about some codecs.
/// </summary>
public static CodecviewFilterGen CodecviewFilterGen(this ImageMap input0) => new CodecviewFilterGen(input0);
/// <summary>
/// Visualize information about some codecs.
/// </summary>
public static CodecviewFilterGen CodecviewFilterGen(this ImageMap input0,CodecviewFilterGenConfig config)
{
var result = new CodecviewFilterGen(input0);
if(config?.mv != null) result.mv(config.mv.Value);
if(config?.qp != null) result.qp(config.qp.Value);
if(config?.mv_type != null) result.mv_type(config.mv_type.Value);
if(config?.mvt != null) result.mvt(config.mvt.Value);
if(config?.frame_type != null) result.frame_type(config.frame_type.Value);
if(config?.ft != null) result.ft(config.ft.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class CodecviewFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set motion vectors to visualize (default 0)
/// </summary>
public CodecviewFilterGenMv? mv { get; set; }
/// <summary>
///  (default false)
/// </summary>
public bool? qp { get; set; }
/// <summary>
///  set motion vectors type (default 0)
/// </summary>
public CodecviewFilterGenMv_type? mv_type { get; set; }
/// <summary>
///  set motion vectors type (default 0)
/// </summary>
public CodecviewFilterGenMvt? mvt { get; set; }
/// <summary>
///  set frame types to visualize motion vectors of (default 0)
/// </summary>
public CodecviewFilterGenFrame_type? frame_type { get; set; }
/// <summary>
///  set frame types to visualize motion vectors of (default 0)
/// </summary>
public CodecviewFilterGenFt? ft { get; set; }
public string TimelineSupport { get; set; }
}
public enum CodecviewFilterGenMv
{
[Name("pf")] pf,
[Name("bf")] bf,
[Name("bb")] bb,
}

public enum CodecviewFilterGenMv_type
{
[Name("fp")] fp,
[Name("bp")] bp,
}

public enum CodecviewFilterGenMvt
{
[Name("fp")] fp,
[Name("bp")] bp,
}

public enum CodecviewFilterGenFrame_type
{
[Name("if")] _if,
[Name("pf")] pf,
[Name("bf")] bf,
}

public enum CodecviewFilterGenFt
{
[Name("if")] _if,
[Name("pf")] pf,
[Name("bf")] bf,
}

}
