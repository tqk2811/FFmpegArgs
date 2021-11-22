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
public class BlackframeFilterGen : ImageToImageFilter
{
internal BlackframeFilterGen(ImageMap input) : base("blackframe",input) { AddMapOut(); }
/// <summary>
///  percentage of the pixels that have to be below the threshold for the frame to be considered black (from 0 to 100) (default 98)
/// </summary>
public BlackframeFilterGen amount(int amount) => this.SetOptionRange("amount", amount,0,100);
/// <summary>
///  threshold below which a pixel value is considered black (from 0 to 255) (default 32)
/// </summary>
public BlackframeFilterGen threshold(int threshold) => this.SetOptionRange("threshold", threshold,0,255);
/// <summary>
///  threshold below which a pixel value is considered black (from 0 to 255) (default 32)
/// </summary>
public BlackframeFilterGen thresh(int thresh) => this.SetOptionRange("thresh", thresh,0,255);
}
public static class BlackframeFilterGenExtensions
{
/// <summary>
/// Detect frames that are (almost) black.
/// </summary>
public static BlackframeFilterGen BlackframeFilterGen(this ImageMap input0) => new BlackframeFilterGen(input0);
}
}