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
public class BwdifFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal BwdifFilterGen(ImageMap input) : base("bwdif",input) { AddMapOut(); }
/// <summary>
///  specify the interlacing mode (from 0 to 1) (default send_field)
/// </summary>
public BwdifFilterGen mode(BwdifFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  specify the assumed picture field parity (from -1 to 1) (default auto)
/// </summary>
public BwdifFilterGen parity(BwdifFilterGenParity parity) => this.SetOption("parity", parity.GetAttribute<NameAttribute>().Name);
/// <summary>
///  specify which frames to deinterlace (from 0 to 1) (default all)
/// </summary>
public BwdifFilterGen deint(BwdifFilterGenDeint deint) => this.SetOption("deint", deint.GetAttribute<NameAttribute>().Name);
}
public static class BwdifFilterGenExtensions
{
/// <summary>
/// Deinterlace the input image.
/// </summary>
public static BwdifFilterGen BwdifFilterGen(this ImageMap input0) => new BwdifFilterGen(input0);
/// <summary>
/// Deinterlace the input image.
/// </summary>
public static BwdifFilterGen BwdifFilterGen(this ImageMap input0,BwdifFilterGenConfig config)
{
var result = new BwdifFilterGen(input0);
if(config?.mode != null) result.mode(config.mode);
if(config?.parity != null) result.parity(config.parity);
if(config?.deint != null) result.deint(config.deint);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class BwdifFilterGenConfig
{
/// <summary>
///  specify the interlacing mode (from 0 to 1) (default send_field)
/// </summary>
public BwdifFilterGenMode mode { get; set; }
/// <summary>
///  specify the assumed picture field parity (from -1 to 1) (default auto)
/// </summary>
public BwdifFilterGenParity parity { get; set; }
/// <summary>
///  specify which frames to deinterlace (from 0 to 1) (default all)
/// </summary>
public BwdifFilterGenDeint deint { get; set; }
public string TimelineSupport { get; set; }
}
public enum BwdifFilterGenMode
{
[Name("send_frame")] send_frame,
[Name("send_field")] send_field,
}

public enum BwdifFilterGenParity
{
[Name("tff")] tff,
[Name("bff")] bff,
[Name("auto")] auto,
}

public enum BwdifFilterGenDeint
{
[Name("all")] all,
[Name("interlaced")] interlaced,
}

}
