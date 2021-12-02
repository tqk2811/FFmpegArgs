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
public class TmixFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal TmixFilterGen(ImageMap input) : base("tmix",input) { AddMapOut(); }
/// <summary>
///  set number of successive frames to mix (from 1 to 128) (default 3)
/// </summary>
public TmixFilterGen frames(int frames) => this.SetOptionRange("frames", frames,1,128);
/// <summary>
///  set weight for each frame (default "1 1 1")
/// </summary>
public TmixFilterGen weights(string weights) => this.SetOption("weights",weights);
/// <summary>
///  set scale (from 0 to 32767) (default 0)
/// </summary>
public TmixFilterGen scale(float scale) => this.SetOptionRange("scale", scale,0,32767);
}
public static class TmixFilterGenExtensions
{
/// <summary>
/// Mix successive video frames.
/// </summary>
public static TmixFilterGen TmixFilterGen(this ImageMap input0) => new TmixFilterGen(input0);
/// <summary>
/// Mix successive video frames.
/// </summary>
public static TmixFilterGen TmixFilterGen(this ImageMap input0,TmixFilterGenConfig config)
{
var result = new TmixFilterGen(input0);
if(config?.frames != null) result.frames(config.frames.Value);
if(!string.IsNullOrWhiteSpace(config?.weights)) result.weights(config.weights);
if(config?.scale != null) result.scale(config.scale.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class TmixFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set number of successive frames to mix (from 1 to 128) (default 3)
/// </summary>
public int? frames { get; set; }
/// <summary>
///  set weight for each frame (default "1 1 1")
/// </summary>
public string weights { get; set; }
/// <summary>
///  set scale (from 0 to 32767) (default 0)
/// </summary>
public float? scale { get; set; }
public string TimelineSupport { get; set; }
}
}
