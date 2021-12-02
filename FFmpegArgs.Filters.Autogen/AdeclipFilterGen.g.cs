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
public class AdeclipFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading
{
internal AdeclipFilterGen(AudioMap input) : base("adeclip",input) { AddMapOut(); }
/// <summary>
///  set window size (from 10 to 100) (default 55)
/// </summary>
public AdeclipFilterGen window(double window) => this.SetOptionRange("window", window,10,100);
/// <summary>
///  set window overlap (from 50 to 95) (default 75)
/// </summary>
public AdeclipFilterGen overlap(double overlap) => this.SetOptionRange("overlap", overlap,50,95);
/// <summary>
///  set autoregression order (from 0 to 25) (default 8)
/// </summary>
public AdeclipFilterGen arorder(double arorder) => this.SetOptionRange("arorder", arorder,0,25);
/// <summary>
///  set threshold (from 1 to 100) (default 10)
/// </summary>
public AdeclipFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,1,100);
/// <summary>
///  set histogram size (from 100 to 9999) (default 1000)
/// </summary>
public AdeclipFilterGen hsize(int hsize) => this.SetOptionRange("hsize", hsize,100,9999);
/// <summary>
///  set histogram size (from 100 to 9999) (default 1000)
/// </summary>
public AdeclipFilterGen n(int n) => this.SetOptionRange("n", n,100,9999);
/// <summary>
///  set overlap method (from 0 to 1) (default add)
/// </summary>
public AdeclipFilterGen method(AdeclipFilterGenMethod method) => this.SetOption("method", method.GetAttribute<NameAttribute>().Name);
}
public static class AdeclipFilterGenExtensions
{
/// <summary>
/// Remove clipping from input audio.
/// </summary>
public static AdeclipFilterGen AdeclipFilterGen(this AudioMap input0) => new AdeclipFilterGen(input0);
/// <summary>
/// Remove clipping from input audio.
/// </summary>
public static AdeclipFilterGen AdeclipFilterGen(this AudioMap input0,AdeclipFilterGenConfig config)
{
var result = new AdeclipFilterGen(input0);
if(config?.window != null) result.window(config.window.Value);
if(config?.overlap != null) result.overlap(config.overlap.Value);
if(config?.arorder != null) result.arorder(config.arorder.Value);
if(config?.threshold != null) result.threshold(config.threshold.Value);
if(config?.hsize != null) result.hsize(config.hsize.Value);
if(config?.n != null) result.n(config.n.Value);
if(config?.method != null) result.method(config.method.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class AdeclipFilterGenConfig
{
/// <summary>
///  set window size (from 10 to 100) (default 55)
/// </summary>
public double? window { get; set; }
/// <summary>
///  set window overlap (from 50 to 95) (default 75)
/// </summary>
public double? overlap { get; set; }
/// <summary>
///  set autoregression order (from 0 to 25) (default 8)
/// </summary>
public double? arorder { get; set; }
/// <summary>
///  set threshold (from 1 to 100) (default 10)
/// </summary>
public double? threshold { get; set; }
/// <summary>
///  set histogram size (from 100 to 9999) (default 1000)
/// </summary>
public int? hsize { get; set; }
/// <summary>
///  set histogram size (from 100 to 9999) (default 1000)
/// </summary>
public int? n { get; set; }
/// <summary>
///  set overlap method (from 0 to 1) (default add)
/// </summary>
public AdeclipFilterGenMethod? method { get; set; }
public string TimelineSupport { get; set; }
}
public enum AdeclipFilterGenMethod
{
[Name("add")] add,
[Name("a")] a,
[Name("save")] save,
[Name("s")] s,
}

}
