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
public class MaskedclampFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal MaskedclampFilterGen(params ImageMap[] inputs) : base("maskedclamp",inputs) { AddMapOut(); }
/// <summary>
///  set undershoot (from 0 to 65535) (default 0)
/// </summary>
public MaskedclampFilterGen undershoot(int undershoot) => this.SetOptionRange("undershoot", undershoot,0,65535);
/// <summary>
///  set overshoot (from 0 to 65535) (default 0)
/// </summary>
public MaskedclampFilterGen overshoot(int overshoot) => this.SetOptionRange("overshoot", overshoot,0,65535);
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public MaskedclampFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
public static class MaskedclampFilterGenExtensions
{
/// <summary>
/// Clamp first stream with second stream and third stream.
/// </summary>
public static MaskedclampFilterGen MaskedclampFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2) => new MaskedclampFilterGen(input0, input1, input2);
/// <summary>
/// Clamp first stream with second stream and third stream.
/// </summary>
public static MaskedclampFilterGen MaskedclampFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2,MaskedclampFilterGenConfig config)
{
var result = new MaskedclampFilterGen(input0, input1, input2);
if(config?.undershoot != null) result.undershoot(config.undershoot.Value);
if(config?.overshoot != null) result.overshoot(config.overshoot.Value);
if(config?.planes != null) result.planes(config.planes.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class MaskedclampFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set undershoot (from 0 to 65535) (default 0)
/// </summary>
public int? undershoot { get; set; }
/// <summary>
///  set overshoot (from 0 to 65535) (default 0)
/// </summary>
public int? overshoot { get; set; }
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public int? planes { get; set; }
public string TimelineSupport { get; set; }
}
}
