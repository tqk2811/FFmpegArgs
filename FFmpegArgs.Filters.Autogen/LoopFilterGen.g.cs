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
public class LoopFilterGen : ImageToImageFilter
{
internal LoopFilterGen(ImageMap input) : base("loop",input) { AddMapOut(); }
/// <summary>
///  number of loops (from -1 to INT_MAX) (default 0)
/// </summary>
public LoopFilterGen loop(int loop) => this.SetOptionRange("loop", loop,-1,INT_MAX);
/// <summary>
///  max number of frames to loop (from 0 to 32767) (default 0)
/// </summary>
public LoopFilterGen size(long size) => this.SetOptionRange("size", size,0,32767);
/// <summary>
///  set the loop start frame (from 0 to I64_MAX) (default 0)
/// </summary>
public LoopFilterGen start(long start) => this.SetOptionRange("start", start,0,I64_MAX);
}
public static class LoopFilterGenExtensions
{
/// <summary>
/// Loop video frames.
/// </summary>
public static LoopFilterGen LoopFilterGen(this ImageMap input) => new LoopFilterGen(input);
}
}
