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
public MinterpolateFilterGen fps(Rational fps) => this.SetOption("fps",fps);
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
/// <summary>
/// Frame rate conversion using Motion Interpolation.
/// </summary>
public static MinterpolateFilterGen MinterpolateFilterGen(this ImageMap input0,MinterpolateFilterGenConfig config)
{
var result = new MinterpolateFilterGen(input0);
if(config?.fps != null) result.fps(config.fps);
if(config?.mi_mode != null) result.mi_mode(config.mi_mode);
if(config?.mc_mode != null) result.mc_mode(config.mc_mode);
if(config?.me_mode != null) result.me_mode(config.me_mode);
if(config?.me != null) result.me(config.me);
if(config?.mb_size != null) result.mb_size(config.mb_size);
if(config?.search_param != null) result.search_param(config.search_param);
if(config?.vsbmc != null) result.vsbmc(config.vsbmc);
if(config?.scd != null) result.scd(config.scd);
if(config?.scd_threshold != null) result.scd_threshold(config.scd_threshold);
return result;
}
}
public class MinterpolateFilterGenConfig
{
/// <summary>
///  output's frame rate (default "60")
/// </summary>
public Rational fps { get; set; }
/// <summary>
///  motion interpolation mode (from 0 to 2) (default mci)
/// </summary>
public MinterpolateFilterGenMi_mode mi_mode { get; set; }
/// <summary>
///  motion compensation mode (from 0 to 1) (default obmc)
/// </summary>
public MinterpolateFilterGenMc_mode mc_mode { get; set; }
/// <summary>
///  motion estimation mode (from 0 to 1) (default bilat)
/// </summary>
public MinterpolateFilterGenMe_mode me_mode { get; set; }
/// <summary>
///  motion estimation method (from 1 to 9) (default epzs)
/// </summary>
public MinterpolateFilterGenMe me { get; set; }
/// <summary>
///  macroblock size (from 4 to 16) (default 16)
/// </summary>
public int mb_size { get; set; }
/// <summary>
///  search parameter (from 4 to INT_MAX) (default 32)
/// </summary>
public int search_param { get; set; }
/// <summary>
///  variable-size block motion compensation (from 0 to 1) (default 0)
/// </summary>
public int vsbmc { get; set; }
/// <summary>
///  scene change detection method (from 0 to 1) (default fdiff)
/// </summary>
public MinterpolateFilterGenScd scd { get; set; }
/// <summary>
///  scene change threshold (from 0 to 100) (default 10)
/// </summary>
public double scd_threshold { get; set; }
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
