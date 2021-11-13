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
public class Thumbnail_cudaFilterGen : ImageToImageFilter
{
internal Thumbnail_cudaFilterGen(ImageMap input) : base("thumbnail_cuda",input) { AddMapOut(); }
/// <summary>
///  set the frames batch size (from 2 to INT_MAX) (default 100)
/// </summary>
public Thumbnail_cudaFilterGen n(int n) => this.SetOptionRange("n", n,2,INT_MAX);
}
public static class Thumbnail_cudaFilterGenExtensions
{
/// <summary>
/// Select the most representative frame in a given sequence of consecutive frames.
/// </summary>
public static Thumbnail_cudaFilterGen Thumbnail_cudaFilterGen(this ImageMap input0) => new Thumbnail_cudaFilterGen(input0);
}
}
