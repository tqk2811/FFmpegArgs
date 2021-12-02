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
public class PullupFilterGen : ImageToImageFilter
{
internal PullupFilterGen(ImageMap input) : base("pullup",input) { AddMapOut(); }
/// <summary>
///  set left junk size (from 0 to INT_MAX) (default 1)
/// </summary>
public PullupFilterGen jl(int jl) => this.SetOptionRange("jl", jl,0,INT_MAX);
/// <summary>
///  set right junk size (from 0 to INT_MAX) (default 1)
/// </summary>
public PullupFilterGen jr(int jr) => this.SetOptionRange("jr", jr,0,INT_MAX);
/// <summary>
///  set top junk size (from 1 to INT_MAX) (default 4)
/// </summary>
public PullupFilterGen jt(int jt) => this.SetOptionRange("jt", jt,1,INT_MAX);
/// <summary>
///  set bottom junk size (from 1 to INT_MAX) (default 4)
/// </summary>
public PullupFilterGen jb(int jb) => this.SetOptionRange("jb", jb,1,INT_MAX);
/// <summary>
///  set strict breaks (default false)
/// </summary>
public PullupFilterGen sb(bool sb) => this.SetOption("sb",sb.ToFFmpegFlag());
/// <summary>
///  set metric plane (from 0 to 2) (default y)
/// </summary>
public PullupFilterGen mp(PullupFilterGenMp mp) => this.SetOption("mp", mp.GetAttribute<NameAttribute>().Name);
}
public static class PullupFilterGenExtensions
{
/// <summary>
/// Pullup from field sequence to frames.
/// </summary>
public static PullupFilterGen PullupFilterGen(this ImageMap input0) => new PullupFilterGen(input0);
/// <summary>
/// Pullup from field sequence to frames.
/// </summary>
public static PullupFilterGen PullupFilterGen(this ImageMap input0,PullupFilterGenConfig config)
{
var result = new PullupFilterGen(input0);
if(config?.jl != null) result.jl(config.jl.Value);
if(config?.jr != null) result.jr(config.jr.Value);
if(config?.jt != null) result.jt(config.jt.Value);
if(config?.jb != null) result.jb(config.jb.Value);
if(config?.sb != null) result.sb(config.sb.Value);
if(config?.mp != null) result.mp(config.mp.Value);
return result;
}
}
public class PullupFilterGenConfig
{
/// <summary>
///  set left junk size (from 0 to INT_MAX) (default 1)
/// </summary>
public int? jl { get; set; }
/// <summary>
///  set right junk size (from 0 to INT_MAX) (default 1)
/// </summary>
public int? jr { get; set; }
/// <summary>
///  set top junk size (from 1 to INT_MAX) (default 4)
/// </summary>
public int? jt { get; set; }
/// <summary>
///  set bottom junk size (from 1 to INT_MAX) (default 4)
/// </summary>
public int? jb { get; set; }
/// <summary>
///  set strict breaks (default false)
/// </summary>
public bool? sb { get; set; }
/// <summary>
///  set metric plane (from 0 to 2) (default y)
/// </summary>
public PullupFilterGenMp? mp { get; set; }
}
public enum PullupFilterGenMp
{
[Name("y")] y,
[Name("u")] u,
[Name("v")] v,
}

}
