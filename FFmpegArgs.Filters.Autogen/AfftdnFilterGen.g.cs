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
public class AfftdnFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AfftdnFilterGen(AudioMap input) : base("afftdn",input) { AddMapOut(); }
/// <summary>
///  set the noise reduction (from 0.01 to 97) (default 12)
/// </summary>
public AfftdnFilterGen nr(float nr) => this.SetOptionRange("nr", nr,0.01,97);
/// <summary>
///  set the noise floor (from -80 to -20) (default -50)
/// </summary>
public AfftdnFilterGen nf(float nf) => this.SetOptionRange("nf", nf,-80,-20);
/// <summary>
///  set the noise type (from 0 to 3) (default w)
/// </summary>
public AfftdnFilterGen nt(AfftdnFilterGenNt nt) => this.SetOption("nt", nt.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set the custom bands noise
/// </summary>
public AfftdnFilterGen bn(string bn) => this.SetOption("bn",bn);
/// <summary>
///  set the residual floor (from -80 to -20) (default -38)
/// </summary>
public AfftdnFilterGen rf(float rf) => this.SetOptionRange("rf", rf,-80,-20);
/// <summary>
///  track noise (default false)
/// </summary>
public AfftdnFilterGen tn(bool tn) => this.SetOption("tn",tn.ToFFmpegFlag());
/// <summary>
///  track residual (default false)
/// </summary>
public AfftdnFilterGen tr(bool tr) => this.SetOption("tr",tr.ToFFmpegFlag());
/// <summary>
///  set output mode (from 0 to 2) (default o)
/// </summary>
public AfftdnFilterGen om(AfftdnFilterGenOm om) => this.SetOption("om", om.GetAttribute<NameAttribute>().Name);
}
public static class AfftdnFilterGenExtensions
{
/// <summary>
/// Denoise audio samples using FFT.
/// </summary>
public static AfftdnFilterGen AfftdnFilterGen(this AudioMap input0) => new AfftdnFilterGen(input0);
/// <summary>
/// Denoise audio samples using FFT.
/// </summary>
public static AfftdnFilterGen AfftdnFilterGen(this AudioMap input0,AfftdnFilterGenConfig config)
{
var result = new AfftdnFilterGen(input0);
if(config?.nr != null) result.nr(config.nr.Value);
if(config?.nf != null) result.nf(config.nf.Value);
if(config?.nt != null) result.nt(config.nt.Value);
if(!string.IsNullOrWhiteSpace(config?.bn)) result.bn(config.bn);
if(config?.rf != null) result.rf(config.rf.Value);
if(config?.tn != null) result.tn(config.tn.Value);
if(config?.tr != null) result.tr(config.tr.Value);
if(config?.om != null) result.om(config.om.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class AfftdnFilterGenConfig
{
/// <summary>
///  set the noise reduction (from 0.01 to 97) (default 12)
/// </summary>
public float? nr { get; set; }
/// <summary>
///  set the noise floor (from -80 to -20) (default -50)
/// </summary>
public float? nf { get; set; }
/// <summary>
///  set the noise type (from 0 to 3) (default w)
/// </summary>
public AfftdnFilterGenNt? nt { get; set; }
/// <summary>
///  set the custom bands noise
/// </summary>
public string bn { get; set; }
/// <summary>
///  set the residual floor (from -80 to -20) (default -38)
/// </summary>
public float? rf { get; set; }
/// <summary>
///  track noise (default false)
/// </summary>
public bool? tn { get; set; }
/// <summary>
///  track residual (default false)
/// </summary>
public bool? tr { get; set; }
/// <summary>
///  set output mode (from 0 to 2) (default o)
/// </summary>
public AfftdnFilterGenOm? om { get; set; }
public string TimelineSupport { get; set; }
}
public enum AfftdnFilterGenNt
{
[Name("w")] w,
[Name("v")] v,
[Name("s")] s,
[Name("c")] c,
}

public enum AfftdnFilterGenOm
{
[Name("i")] i,
[Name("o")] o,
[Name("n")] n,
}

}
