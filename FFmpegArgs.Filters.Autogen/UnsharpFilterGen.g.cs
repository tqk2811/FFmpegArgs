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
public class UnsharpFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal UnsharpFilterGen(ImageMap input) : base("unsharp",input) { AddMapOut(); }
/// <summary>
///  set luma matrix horizontal size (from 3 to 23) (default 5)
/// </summary>
public UnsharpFilterGen luma_msize_x(int luma_msize_x) => this.SetOptionRange("luma_msize_x", luma_msize_x,3,23);
/// <summary>
///  set luma matrix horizontal size (from 3 to 23) (default 5)
/// </summary>
public UnsharpFilterGen lx(int lx) => this.SetOptionRange("lx", lx,3,23);
/// <summary>
///  set luma matrix vertical size (from 3 to 23) (default 5)
/// </summary>
public UnsharpFilterGen luma_msize_y(int luma_msize_y) => this.SetOptionRange("luma_msize_y", luma_msize_y,3,23);
/// <summary>
///  set luma matrix vertical size (from 3 to 23) (default 5)
/// </summary>
public UnsharpFilterGen ly(int ly) => this.SetOptionRange("ly", ly,3,23);
/// <summary>
///  set luma effect strength (from -2 to 5) (default 1)
/// </summary>
public UnsharpFilterGen luma_amount(float luma_amount) => this.SetOptionRange("luma_amount", luma_amount,-2,5);
/// <summary>
///  set luma effect strength (from -2 to 5) (default 1)
/// </summary>
public UnsharpFilterGen la(float la) => this.SetOptionRange("la", la,-2,5);
/// <summary>
///  set chroma matrix horizontal size (from 3 to 23) (default 5)
/// </summary>
public UnsharpFilterGen chroma_msize_x(int chroma_msize_x) => this.SetOptionRange("chroma_msize_x", chroma_msize_x,3,23);
/// <summary>
///  set chroma matrix horizontal size (from 3 to 23) (default 5)
/// </summary>
public UnsharpFilterGen cx(int cx) => this.SetOptionRange("cx", cx,3,23);
/// <summary>
///  set chroma matrix vertical size (from 3 to 23) (default 5)
/// </summary>
public UnsharpFilterGen chroma_msize_y(int chroma_msize_y) => this.SetOptionRange("chroma_msize_y", chroma_msize_y,3,23);
/// <summary>
///  set chroma matrix vertical size (from 3 to 23) (default 5)
/// </summary>
public UnsharpFilterGen cy(int cy) => this.SetOptionRange("cy", cy,3,23);
/// <summary>
///  set chroma effect strength (from -2 to 5) (default 0)
/// </summary>
public UnsharpFilterGen chroma_amount(float chroma_amount) => this.SetOptionRange("chroma_amount", chroma_amount,-2,5);
/// <summary>
///  set chroma effect strength (from -2 to 5) (default 0)
/// </summary>
public UnsharpFilterGen ca(float ca) => this.SetOptionRange("ca", ca,-2,5);
/// <summary>
///  ignored (default false)
/// </summary>
public UnsharpFilterGen opencl(bool opencl) => this.SetOption("opencl",opencl.ToFFmpegFlag());
}
public static class UnsharpFilterGenExtensions
{
/// <summary>
/// Sharpen or blur the input video.
/// </summary>
public static UnsharpFilterGen UnsharpFilterGen(this ImageMap input0) => new UnsharpFilterGen(input0);
/// <summary>
/// Sharpen or blur the input video.
/// </summary>
public static UnsharpFilterGen UnsharpFilterGen(this ImageMap input0,UnsharpFilterGenConfig config)
{
var result = new UnsharpFilterGen(input0);
if(config?.luma_msize_x != null) result.luma_msize_x(config.luma_msize_x.Value);
if(config?.lx != null) result.lx(config.lx.Value);
if(config?.luma_msize_y != null) result.luma_msize_y(config.luma_msize_y.Value);
if(config?.ly != null) result.ly(config.ly.Value);
if(config?.luma_amount != null) result.luma_amount(config.luma_amount.Value);
if(config?.la != null) result.la(config.la.Value);
if(config?.chroma_msize_x != null) result.chroma_msize_x(config.chroma_msize_x.Value);
if(config?.cx != null) result.cx(config.cx.Value);
if(config?.chroma_msize_y != null) result.chroma_msize_y(config.chroma_msize_y.Value);
if(config?.cy != null) result.cy(config.cy.Value);
if(config?.chroma_amount != null) result.chroma_amount(config.chroma_amount.Value);
if(config?.ca != null) result.ca(config.ca.Value);
if(config?.opencl != null) result.opencl(config.opencl.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class UnsharpFilterGenConfig
{
/// <summary>
///  set luma matrix horizontal size (from 3 to 23) (default 5)
/// </summary>
public int? luma_msize_x { get; set; }
/// <summary>
///  set luma matrix horizontal size (from 3 to 23) (default 5)
/// </summary>
public int? lx { get; set; }
/// <summary>
///  set luma matrix vertical size (from 3 to 23) (default 5)
/// </summary>
public int? luma_msize_y { get; set; }
/// <summary>
///  set luma matrix vertical size (from 3 to 23) (default 5)
/// </summary>
public int? ly { get; set; }
/// <summary>
///  set luma effect strength (from -2 to 5) (default 1)
/// </summary>
public float? luma_amount { get; set; }
/// <summary>
///  set luma effect strength (from -2 to 5) (default 1)
/// </summary>
public float? la { get; set; }
/// <summary>
///  set chroma matrix horizontal size (from 3 to 23) (default 5)
/// </summary>
public int? chroma_msize_x { get; set; }
/// <summary>
///  set chroma matrix horizontal size (from 3 to 23) (default 5)
/// </summary>
public int? cx { get; set; }
/// <summary>
///  set chroma matrix vertical size (from 3 to 23) (default 5)
/// </summary>
public int? chroma_msize_y { get; set; }
/// <summary>
///  set chroma matrix vertical size (from 3 to 23) (default 5)
/// </summary>
public int? cy { get; set; }
/// <summary>
///  set chroma effect strength (from -2 to 5) (default 0)
/// </summary>
public float? chroma_amount { get; set; }
/// <summary>
///  set chroma effect strength (from -2 to 5) (default 0)
/// </summary>
public float? ca { get; set; }
/// <summary>
///  ignored (default false)
/// </summary>
public bool? opencl { get; set; }
public string TimelineSupport { get; set; }
}
}
