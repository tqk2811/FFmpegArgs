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
public class Overlay_cudaFilterGen : ImageToImageFilter
{
internal Overlay_cudaFilterGen(params ImageMap[] inputs) : base("overlay_cuda",inputs) { AddMapOut(); }
/// <summary>
///  Overlay x position (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public Overlay_cudaFilterGen x(int x) => this.SetOptionRange("x", x,INT_MIN,INT_MAX);
/// <summary>
///  Overlay y position (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public Overlay_cudaFilterGen y(int y) => this.SetOptionRange("y", y,INT_MIN,INT_MAX);
/// <summary>
///  Action to take when encountering EOF from secondary input  (from 0 to 2) (default repeat)
/// </summary>
public Overlay_cudaFilterGen eof_action(Overlay_cudaFilterGenEof_action eof_action) => this.SetOption("eof_action", eof_action.GetAttribute<NameAttribute>().Name);
/// <summary>
///  force termination when the shortest input terminates (default false)
/// </summary>
public Overlay_cudaFilterGen shortest(bool flag) => this.SetOption("shortest",flag.ToFFmpegFlag());
/// <summary>
///  repeat overlay of the last overlay frame (default true)
/// </summary>
public Overlay_cudaFilterGen repeatlast(bool flag) => this.SetOption("repeatlast",flag.ToFFmpegFlag());
}
public static class Overlay_cudaFilterGenExtensions
{
/// <summary>
/// Overlay one video on top of another using CUDA
/// </summary>
public static Overlay_cudaFilterGen Overlay_cudaFilterGen(this ImageMap input0, ImageMap input1) => new Overlay_cudaFilterGen(input0, input1);
}
public enum Overlay_cudaFilterGenEof_action
{
[Name("repeat")] repeat,
[Name("endall")] endall,
[Name("pass")] pass,
}

}
