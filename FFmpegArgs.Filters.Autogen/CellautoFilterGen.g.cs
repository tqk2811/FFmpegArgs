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
public class CellautoFilterGen : SourceImageFilter
{
internal CellautoFilterGen(FilterGraph input) : base("cellauto",input) { AddMapOut(); }
/// <summary>
///  read initial pattern from file
/// </summary>
public CellautoFilterGen filename(string filename) => this.SetOption("filename",filename);
/// <summary>
///  set initial pattern
/// </summary>
public CellautoFilterGen pattern(string pattern) => this.SetOption("pattern",pattern);
/// <summary>
///  set video rate (default "25")
/// </summary>
public CellautoFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video size
/// </summary>
public CellautoFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set rule (from 0 to 255) (default 110)
/// </summary>
public CellautoFilterGen rule(int rule) => this.SetOptionRange("rule", rule,0,255);
/// <summary>
///  set fill ratio for filling initial grid randomly (from 0 to 1) (default 0.618034)
/// </summary>
public CellautoFilterGen random_fill_ratio(double random_fill_ratio) => this.SetOptionRange("random_fill_ratio", random_fill_ratio,0,1);
/// <summary>
///  set fill ratio for filling initial grid randomly (from 0 to 1) (default 0.618034)
/// </summary>
public CellautoFilterGen ratio(double ratio) => this.SetOptionRange("ratio", ratio,0,1);
/// <summary>
///  set the seed for filling the initial grid randomly (from -1 to UINT32_MAX) (default -1)
/// </summary>
public CellautoFilterGen random_seed(long random_seed) => this.SetOptionRange("random_seed", random_seed,-1,UINT32_MAX);
/// <summary>
///  set the seed for filling the initial grid randomly (from -1 to UINT32_MAX) (default -1)
/// </summary>
public CellautoFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
/// <summary>
///  scroll pattern downward (default true)
/// </summary>
public CellautoFilterGen scroll(bool scroll) => this.SetOption("scroll",scroll.ToFFmpegFlag());
/// <summary>
///  start filling the whole video (default false)
/// </summary>
public CellautoFilterGen start_full(bool start_full) => this.SetOption("start_full",start_full.ToFFmpegFlag());
/// <summary>
///  start filling the whole video (default true)
/// </summary>
public CellautoFilterGen full(bool full) => this.SetOption("full",full.ToFFmpegFlag());
/// <summary>
///  stitch boundaries (default true)
/// </summary>
public CellautoFilterGen stitch(bool stitch) => this.SetOption("stitch",stitch.ToFFmpegFlag());
}
public static class CellautoFilterGenExtensions
{
/// <summary>
/// Create pattern generated by an elementary cellular automaton.
/// </summary>
public static CellautoFilterGen CellautoFilterGen(this FilterGraph input0) => new CellautoFilterGen(input0);
/// <summary>
/// Create pattern generated by an elementary cellular automaton.
/// </summary>
public static CellautoFilterGen CellautoFilterGen(this FilterGraph input0,CellautoFilterGenConfig config)
{
var result = new CellautoFilterGen(input0);
if(config?.filename != null) result.filename(config.filename);
if(config?.pattern != null) result.pattern(config.pattern);
if(config?.rate != null) result.rate(config.rate);
if(config?.size != null) result.size(config.size);
if(config?.rule != null) result.rule(config.rule);
if(config?.random_fill_ratio != null) result.random_fill_ratio(config.random_fill_ratio);
if(config?.ratio != null) result.ratio(config.ratio);
if(config?.random_seed != null) result.random_seed(config.random_seed);
if(config?.seed != null) result.seed(config.seed);
if(config?.scroll != null) result.scroll(config.scroll);
if(config?.start_full != null) result.start_full(config.start_full);
if(config?.full != null) result.full(config.full);
if(config?.stitch != null) result.stitch(config.stitch);
return result;
}
}
public class CellautoFilterGenConfig
{
/// <summary>
///  read initial pattern from file
/// </summary>
public string filename { get; set; }
/// <summary>
///  set initial pattern
/// </summary>
public string pattern { get; set; }
/// <summary>
///  set video rate (default "25")
/// </summary>
public Rational rate { get; set; }
/// <summary>
///  set video size
/// </summary>
public Size size { get; set; }
/// <summary>
///  set rule (from 0 to 255) (default 110)
/// </summary>
public int rule { get; set; }
/// <summary>
///  set fill ratio for filling initial grid randomly (from 0 to 1) (default 0.618034)
/// </summary>
public double random_fill_ratio { get; set; }
/// <summary>
///  set fill ratio for filling initial grid randomly (from 0 to 1) (default 0.618034)
/// </summary>
public double ratio { get; set; }
/// <summary>
///  set the seed for filling the initial grid randomly (from -1 to UINT32_MAX) (default -1)
/// </summary>
public long random_seed { get; set; }
/// <summary>
///  set the seed for filling the initial grid randomly (from -1 to UINT32_MAX) (default -1)
/// </summary>
public long seed { get; set; }
/// <summary>
///  scroll pattern downward (default true)
/// </summary>
public bool scroll { get; set; }
/// <summary>
///  start filling the whole video (default false)
/// </summary>
public bool start_full { get; set; }
/// <summary>
///  start filling the whole video (default true)
/// </summary>
public bool full { get; set; }
/// <summary>
///  stitch boundaries (default true)
/// </summary>
public bool stitch { get; set; }
}
}
