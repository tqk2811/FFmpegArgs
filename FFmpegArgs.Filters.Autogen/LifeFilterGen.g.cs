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
public class LifeFilterGen : SourceImageFilter
{
internal LifeFilterGen(FilterGraph input) : base("life",input) { AddMapOut(); }
/// <summary>
///  set source file
/// </summary>
public LifeFilterGen filename(string filename) => this.SetOption("filename",filename);
/// <summary>
///  set video size
/// </summary>
public LifeFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public LifeFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set rule (default "B3/S23")
/// </summary>
public LifeFilterGen rule(string rule) => this.SetOption("rule",rule);
/// <summary>
///  set fill ratio for filling initial grid randomly (from 0 to 1) (default 0.618034)
/// </summary>
public LifeFilterGen random_fill_ratio(double random_fill_ratio) => this.SetOptionRange("random_fill_ratio", random_fill_ratio,0,1);
/// <summary>
///  set fill ratio for filling initial grid randomly (from 0 to 1) (default 0.618034)
/// </summary>
public LifeFilterGen ratio(double ratio) => this.SetOptionRange("ratio", ratio,0,1);
/// <summary>
///  set the seed for filling the initial grid randomly (from -1 to UINT32_MAX) (default -1)
/// </summary>
public LifeFilterGen random_seed(long random_seed) => this.SetOptionRange("random_seed", random_seed,-1,UINT32_MAX);
/// <summary>
///  set the seed for filling the initial grid randomly (from -1 to UINT32_MAX) (default -1)
/// </summary>
public LifeFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
/// <summary>
///  stitch boundaries (default true)
/// </summary>
public LifeFilterGen stitch(bool stitch) => this.SetOption("stitch",stitch.ToFFmpegFlag());
/// <summary>
///  set mold speed for dead cells (from 0 to 255) (default 0)
/// </summary>
public LifeFilterGen mold(int mold) => this.SetOptionRange("mold", mold,0,255);
/// <summary>
///  set life color (default "white")
/// </summary>
public LifeFilterGen life_color(Color life_color) => this.SetOption("life_color",life_color.ToHexStringRGBA());
/// <summary>
///  set death color (default "black")
/// </summary>
public LifeFilterGen death_color(Color death_color) => this.SetOption("death_color",death_color.ToHexStringRGBA());
/// <summary>
///  set mold color (default "black")
/// </summary>
public LifeFilterGen mold_color(Color mold_color) => this.SetOption("mold_color",mold_color.ToHexStringRGBA());
}
public static class LifeFilterGenExtensions
{
/// <summary>
/// Create life.
/// </summary>
public static LifeFilterGen LifeFilterGen(this FilterGraph input0) => new LifeFilterGen(input0);
/// <summary>
/// Create life.
/// </summary>
public static LifeFilterGen LifeFilterGen(this FilterGraph input0,LifeFilterGenConfig config)
{
var result = new LifeFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.filename)) result.filename(config.filename);
if(config?.size != null) result.size(config.size.Value);
if(config?.rate != null) result.rate(config.rate);
if(!string.IsNullOrWhiteSpace(config?.rule)) result.rule(config.rule);
if(config?.random_fill_ratio != null) result.random_fill_ratio(config.random_fill_ratio.Value);
if(config?.ratio != null) result.ratio(config.ratio.Value);
if(config?.random_seed != null) result.random_seed(config.random_seed.Value);
if(config?.seed != null) result.seed(config.seed.Value);
if(config?.stitch != null) result.stitch(config.stitch.Value);
if(config?.mold != null) result.mold(config.mold.Value);
if(config?.life_color != null) result.life_color(config.life_color.Value);
if(config?.death_color != null) result.death_color(config.death_color.Value);
if(config?.mold_color != null) result.mold_color(config.mold_color.Value);
return result;
}
}
public class LifeFilterGenConfig
{
/// <summary>
///  set source file
/// </summary>
public string filename { get; set; }
/// <summary>
///  set video size
/// </summary>
public Size? size { get; set; }
/// <summary>
///  set video rate (default "25")
/// </summary>
public Rational rate { get; set; }
/// <summary>
///  set rule (default "B3/S23")
/// </summary>
public string rule { get; set; }
/// <summary>
///  set fill ratio for filling initial grid randomly (from 0 to 1) (default 0.618034)
/// </summary>
public double? random_fill_ratio { get; set; }
/// <summary>
///  set fill ratio for filling initial grid randomly (from 0 to 1) (default 0.618034)
/// </summary>
public double? ratio { get; set; }
/// <summary>
///  set the seed for filling the initial grid randomly (from -1 to UINT32_MAX) (default -1)
/// </summary>
public long? random_seed { get; set; }
/// <summary>
///  set the seed for filling the initial grid randomly (from -1 to UINT32_MAX) (default -1)
/// </summary>
public long? seed { get; set; }
/// <summary>
///  stitch boundaries (default true)
/// </summary>
public bool? stitch { get; set; }
/// <summary>
///  set mold speed for dead cells (from 0 to 255) (default 0)
/// </summary>
public int? mold { get; set; }
/// <summary>
///  set life color (default "white")
/// </summary>
public Color? life_color { get; set; }
/// <summary>
///  set death color (default "black")
/// </summary>
public Color? death_color { get; set; }
/// <summary>
///  set mold color (default "black")
/// </summary>
public Color? mold_color { get; set; }
}
}
