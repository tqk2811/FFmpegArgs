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
public class TinterlaceFilterGen : ImageToImageFilter
{
internal TinterlaceFilterGen(ImageMap input) : base("tinterlace",input) { AddMapOut(); }
/// <summary>
///  select interlace mode (from 0 to 7) (default merge)
/// </summary>
public TinterlaceFilterGen mode(TinterlaceFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
}
public static class TinterlaceFilterGenExtensions
{
/// <summary>
/// Perform temporal field interlacing.
/// </summary>
public static TinterlaceFilterGen TinterlaceFilterGen(this ImageMap input0) => new TinterlaceFilterGen(input0);
/// <summary>
/// Perform temporal field interlacing.
/// </summary>
public static TinterlaceFilterGen TinterlaceFilterGen(this ImageMap input0,TinterlaceFilterGenConfig config)
{
var result = new TinterlaceFilterGen(input0);
if(config?.mode != null) result.mode(config.mode);
return result;
}
}
public class TinterlaceFilterGenConfig
{
/// <summary>
///  select interlace mode (from 0 to 7) (default merge)
/// </summary>
public TinterlaceFilterGenMode mode { get; set; }
}
public enum TinterlaceFilterGenMode
{
[Name("merge")] merge,
[Name("drop_even")] drop_even,
[Name("drop_odd")] drop_odd,
[Name("pad")] pad,
[Name("interleave_top")] interleave_top,
[Name("interleave_bottom")] interleave_bottom,
[Name("interlacex2")] interlacex2,
[Name("mergex2")] mergex2,
}

}
