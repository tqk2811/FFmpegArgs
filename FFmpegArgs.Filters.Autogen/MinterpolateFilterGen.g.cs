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
public class MinterpolateFilterGen : ImageToImageFilter
{
internal MinterpolateFilterGen(ImageMap input) : base("minterpolate",input) { AddMapOut(); }
/// <summary>
///  output's frame rate (default "60")
/// </summary>
public MinterpolateFilterGen Fps(string r) => this.SetOption("fps", r);
/// <summary>
///  output's frame rate (default "60")
/// </summary>
public MinterpolateFilterGen fps(int r) => this.SetOptionRange("fps", r, 1, int.MaxValue);
/// <summary>
///  motion interpolation mode (from 0 to 2) (default mci)
/// </summary>
public MinterpolateFilterGen mi_mode(MinterpolateFilterGenMi_mode mi_mode) => this.SetOption("mi_mode", mi_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  motion compensation mode (from 0 to 1) (default obmc)
/// </summary>
public MinterpolateFilterGen mc_mode(MinterpolateFilterGenMc_mode mc_mode) => this.SetOption("mc_mode", mc_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  motion estimation mode (from 0 to 1) (default bilat)
/// </summary>
public MinterpolateFilterGen me_mode(MinterpolateFilterGenMe_mode me_mode) => this.SetOption("me_mode", me_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  motion estimation method (from 1 to 9) (default epzs)
/// </summary>
public MinterpolateFilterGen me(MinterpolateFilterGenMe me) => this.SetOption("me", me.GetAttribute<NameAttribute>().Name);
/// <summary>
///  macroblock size (from 4 to 16) (default 16)
/// </summary>
public MinterpolateFilterGen mb_size(int mb_size) => this.SetOptionRange("mb_size", mb_size,4,16);
/// <summary>
///  search parameter (from 4 to INT_MAX) (default 32)
/// </summary>
public MinterpolateFilterGen search_param(int search_param) => this.SetOptionRange("search_param", search_param,4,INT_MAX);
/// <summary>
///  variable-size block motion compensation (from 0 to 1) (default 0)
/// </summary>
public MinterpolateFilterGen vsbmc(int vsbmc) => this.SetOptionRange("vsbmc", vsbmc,0,1);
/// <summary>
///  scene change detection method (from 0 to 1) (default fdiff)
/// </summary>
public MinterpolateFilterGen scd(MinterpolateFilterGenScd scd) => this.SetOption("scd", scd.GetAttribute<NameAttribute>().Name);
/// <summary>
///  scene change threshold (from 0 to 100) (default 10)
/// </summary>
public MinterpolateFilterGen scd_threshold(double scd_threshold) => this.SetOptionRange("scd_threshold", scd_threshold,0,100);
}
public static class MinterpolateFilterGenExtensions
{
/// <summary>
/// Frame rate conversion using Motion Interpolation.
/// </summary>
public static MinterpolateFilterGen MinterpolateFilterGen(this ImageMap input0) => new MinterpolateFilterGen(input0);
}
public enum MinterpolateFilterGenMi_mode
{
[Name("dup")] dup,
[Name("blend")] blend,
[Name("mci")] mci,
}

public enum MinterpolateFilterGenMc_mode
{
[Name("obmc")] obmc,
[Name("aobmc")] aobmc,
}

public enum MinterpolateFilterGenMe_mode
{
[Name("bidir")] bidir,
[Name("bilat")] bilat,
}

public enum MinterpolateFilterGenMe
{
[Name("esa")] esa,
[Name("tss")] tss,
[Name("tdls")] tdls,
[Name("ntss")] ntss,
[Name("fss")] fss,
[Name("ds")] ds,
[Name("hexbs")] hexbs,
[Name("epzs")] epzs,
[Name("umh")] umh,
}

public enum MinterpolateFilterGenScd
{
[Name("none")] none,
[Name("fdiff")] fdiff,
}

}
