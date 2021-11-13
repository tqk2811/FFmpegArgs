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
public CodecviewFilterGen qp(bool flag) => this.SetOption("qp",flag.ToFFmpegFlag());
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
