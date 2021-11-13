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
public class SmartblurFilterGen : ImageToImageFilter,ITimelineSupport
{
internal SmartblurFilterGen(ImageMap input) : base("smartblur",input) { AddMapOut(); }
/// <summary>
///  set luma radius (from 0.1 to 5) (default 1)
/// </summary>
public SmartblurFilterGen luma_radius(float luma_radius) => this.SetOptionRange("luma_radius", luma_radius,0.1,5);
/// <summary>
///  set luma radius (from 0.1 to 5) (default 1)
/// </summary>
public SmartblurFilterGen lr(float lr) => this.SetOptionRange("lr", lr,0.1,5);
/// <summary>
///  set luma strength (from -1 to 1) (default 1)
/// </summary>
public SmartblurFilterGen luma_strength(float luma_strength) => this.SetOptionRange("luma_strength", luma_strength,-1,1);
/// <summary>
///  set luma strength (from -1 to 1) (default 1)
/// </summary>
public SmartblurFilterGen ls(float ls) => this.SetOptionRange("ls", ls,-1,1);
/// <summary>
///  set luma threshold (from -30 to 30) (default 0)
/// </summary>
public SmartblurFilterGen luma_threshold(int luma_threshold) => this.SetOptionRange("luma_threshold", luma_threshold,-30,30);
/// <summary>
///  set luma threshold (from -30 to 30) (default 0)
/// </summary>
public SmartblurFilterGen lt(int lt) => this.SetOptionRange("lt", lt,-30,30);
/// <summary>
///  set chroma radius (from -0.9 to 5) (default -0.9)
/// </summary>
public SmartblurFilterGen chroma_radius(float chroma_radius) => this.SetOptionRange("chroma_radius", chroma_radius,-0.9,5);
/// <summary>
///  set chroma radius (from -0.9 to 5) (default -0.9)
/// </summary>
public SmartblurFilterGen cr(float cr) => this.SetOptionRange("cr", cr,-0.9,5);
/// <summary>
///  set chroma strength (from -2 to 1) (default -2)
/// </summary>
public SmartblurFilterGen chroma_strength(float chroma_strength) => this.SetOptionRange("chroma_strength", chroma_strength,-2,1);
/// <summary>
///  set chroma strength (from -2 to 1) (default -2)
/// </summary>
public SmartblurFilterGen cs(float cs) => this.SetOptionRange("cs", cs,-2,1);
/// <summary>
///  set chroma threshold (from -31 to 30) (default -31)
/// </summary>
public SmartblurFilterGen chroma_threshold(int chroma_threshold) => this.SetOptionRange("chroma_threshold", chroma_threshold,-31,30);
/// <summary>
///  set chroma threshold (from -31 to 30) (default -31)
/// </summary>
public SmartblurFilterGen ct(int ct) => this.SetOptionRange("ct", ct,-31,30);
}
public static class SmartblurFilterGenExtensions
{
/// <summary>
/// Blur the input video without impacting the outlines.
/// </summary>
public static SmartblurFilterGen SmartblurFilterGen(this ImageMap input0) => new SmartblurFilterGen(input0);
}
}
