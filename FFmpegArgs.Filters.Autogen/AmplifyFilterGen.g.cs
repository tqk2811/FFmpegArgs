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
public class AmplifyFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AmplifyFilterGen(ImageMap input) : base("amplify",input) { AddMapOut(); }
/// <summary>
///  set radius (from 1 to 63) (default 2)
/// </summary>
public AmplifyFilterGen radius(int radius) => this.SetOptionRange("radius", radius,1,63);
/// <summary>
///  set factor (from 0 to 65535) (default 2)
/// </summary>
public AmplifyFilterGen factor(float factor) => this.SetOptionRange("factor", factor,0,65535);
/// <summary>
///  set threshold (from 0 to 65535) (default 10)
/// </summary>
public AmplifyFilterGen threshold(float threshold) => this.SetOptionRange("threshold", threshold,0,65535);
/// <summary>
///  set tolerance (from 0 to 65535) (default 0)
/// </summary>
public AmplifyFilterGen tolerance(float tolerance) => this.SetOptionRange("tolerance", tolerance,0,65535);
/// <summary>
///  set low limit for amplification (from 0 to 65535) (default 65535)
/// </summary>
public AmplifyFilterGen low(int low) => this.SetOptionRange("low", low,0,65535);
/// <summary>
///  set high limit for amplification (from 0 to 65535) (default 65535)
/// </summary>
public AmplifyFilterGen high(int high) => this.SetOptionRange("high", high,0,65535);
/// <summary>
///  set what planes to filter (default 7)
/// </summary>
public AmplifyFilterGen planes(AmplifyFilterGenPlanes planes) => this.SetOption("planes", planes.GetAttribute<NameAttribute>().Name);
}
public static class AmplifyFilterGenExtensions
{
/// <summary>
/// Amplify changes between successive video frames.
/// </summary>
public static AmplifyFilterGen AmplifyFilterGen(this ImageMap input0) => new AmplifyFilterGen(input0);
/// <summary>
/// Amplify changes between successive video frames.
/// </summary>
public static AmplifyFilterGen AmplifyFilterGen(this ImageMap input0,AmplifyFilterGenConfig config)
{
var result = new AmplifyFilterGen(input0);
if(config?.radius != null) result.radius(config.radius.Value);
if(config?.factor != null) result.factor(config.factor.Value);
if(config?.threshold != null) result.threshold(config.threshold.Value);
if(config?.tolerance != null) result.tolerance(config.tolerance.Value);
if(config?.low != null) result.low(config.low.Value);
if(config?.high != null) result.high(config.high.Value);
if(config?.planes != null) result.planes(config.planes.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class AmplifyFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set radius (from 1 to 63) (default 2)
/// </summary>
public int? radius { get; set; }
/// <summary>
///  set factor (from 0 to 65535) (default 2)
/// </summary>
public float? factor { get; set; }
/// <summary>
///  set threshold (from 0 to 65535) (default 10)
/// </summary>
public float? threshold { get; set; }
/// <summary>
///  set tolerance (from 0 to 65535) (default 0)
/// </summary>
public float? tolerance { get; set; }
/// <summary>
///  set low limit for amplification (from 0 to 65535) (default 65535)
/// </summary>
public int? low { get; set; }
/// <summary>
///  set high limit for amplification (from 0 to 65535) (default 65535)
/// </summary>
public int? high { get; set; }
/// <summary>
///  set what planes to filter (default 7)
/// </summary>
public AmplifyFilterGenPlanes? planes { get; set; }
public string TimelineSupport { get; set; }
}
public enum AmplifyFilterGenPlanes
{
}

}
