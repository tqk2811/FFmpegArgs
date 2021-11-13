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
public class CropdetectFilterGen : ImageToImageFilter,ITimelineSupport
{
internal CropdetectFilterGen(ImageMap input) : base("cropdetect",input) { AddMapOut(); }
/// <summary>
///  Threshold below which the pixel is considered black (from 0 to 65535) (default 0.0941176)
/// </summary>
public CropdetectFilterGen limit(float limit) => this.SetOptionRange("limit", limit,0,65535);
/// <summary>
///  Value by which the width/height should be divisible (from 0 to INT_MAX) (default 16)
/// </summary>
public CropdetectFilterGen round(int round) => this.SetOptionRange("round", round,0,INT_MAX);
/// <summary>
///  Recalculate the crop area after this many frames (from 0 to INT_MAX) (default 0)
/// </summary>
public CropdetectFilterGen reset(int reset) => this.SetOptionRange("reset", reset,0,INT_MAX);
/// <summary>
///  Number of initial frames to skip (from 0 to INT_MAX) (default 2)
/// </summary>
public CropdetectFilterGen skip(int skip) => this.SetOptionRange("skip", skip,0,INT_MAX);
/// <summary>
///  Recalculate the crop area after this many frames (from 0 to INT_MAX) (default 0)
/// </summary>
public CropdetectFilterGen reset_count(int reset_count) => this.SetOptionRange("reset_count", reset_count,0,INT_MAX);
/// <summary>
///  Threshold count of outliers (from 0 to INT_MAX) (default 0)
/// </summary>
public CropdetectFilterGen max_outliers(int max_outliers) => this.SetOptionRange("max_outliers", max_outliers,0,INT_MAX);
}
public static class CropdetectFilterGenExtensions
{
/// <summary>
/// Auto-detect crop size.
/// </summary>
public static CropdetectFilterGen CropdetectFilterGen(this ImageMap input) => new CropdetectFilterGen(input);
}
}
