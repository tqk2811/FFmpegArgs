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
public class ElbgFilterGen : ImageToImageFilter
{
internal ElbgFilterGen(ImageMap input) : base("elbg",input) { AddMapOut(); }
/// <summary>
///  set codebook length (from 1 to INT_MAX) (default 256)
/// </summary>
public ElbgFilterGen codebook_length(int codebook_length) => this.SetOptionRange("codebook_length", codebook_length,1,INT_MAX);
/// <summary>
///  set codebook length (from 1 to INT_MAX) (default 256)
/// </summary>
public ElbgFilterGen l(int l) => this.SetOptionRange("l", l,1,INT_MAX);
/// <summary>
///  set max number of steps used to compute the mapping (from 1 to INT_MAX) (default 1)
/// </summary>
public ElbgFilterGen nb_steps(int nb_steps) => this.SetOptionRange("nb_steps", nb_steps,1,INT_MAX);
/// <summary>
///  set the random seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public ElbgFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
/// <summary>
///  set the pal8 output (default false)
/// </summary>
public ElbgFilterGen pal8(bool pal8) => this.SetOption("pal8",pal8.ToFFmpegFlag());
}
public static class ElbgFilterGenExtensions
{
/// <summary>
/// Apply posterize effect, using the ELBG algorithm.
/// </summary>
public static ElbgFilterGen ElbgFilterGen(this ImageMap input0) => new ElbgFilterGen(input0);
/// <summary>
/// Apply posterize effect, using the ELBG algorithm.
/// </summary>
public static ElbgFilterGen ElbgFilterGen(this ImageMap input0,ElbgFilterGenConfig config)
{
var result = new ElbgFilterGen(input0);
if(config?.codebook_length != null) result.codebook_length(config.codebook_length);
if(config?.l != null) result.l(config.l);
if(config?.nb_steps != null) result.nb_steps(config.nb_steps);
if(config?.seed != null) result.seed(config.seed);
if(config?.pal8 != null) result.pal8(config.pal8);
return result;
}
}
public class ElbgFilterGenConfig
{
/// <summary>
///  set codebook length (from 1 to INT_MAX) (default 256)
/// </summary>
public int codebook_length { get; set; }
/// <summary>
///  set codebook length (from 1 to INT_MAX) (default 256)
/// </summary>
public int l { get; set; }
/// <summary>
///  set max number of steps used to compute the mapping (from 1 to INT_MAX) (default 1)
/// </summary>
public int nb_steps { get; set; }
/// <summary>
///  set the random seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public long seed { get; set; }
/// <summary>
///  set the pal8 output (default false)
/// </summary>
public bool pal8 { get; set; }
}
}
