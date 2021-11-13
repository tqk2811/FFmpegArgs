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
public class DespillFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal DespillFilterGen(ImageMap input) : base("despill",input) { AddMapOut(); }
/// <summary>
///  set the screen type (from 0 to 1) (default green)
/// </summary>
public DespillFilterGen type(DespillFilterGenType type) => this.SetOption("type", type.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set the spillmap mix (from 0 to 1) (default 0.5)
/// </summary>
public DespillFilterGen mix(float mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set the spillmap expand (from 0 to 1) (default 0)
/// </summary>
public DespillFilterGen expand(float expand) => this.SetOptionRange("expand", expand,0,1);
/// <summary>
///  set red scale (from -100 to 100) (default 0)
/// </summary>
public DespillFilterGen red(float red) => this.SetOptionRange("red", red,-100,100);
/// <summary>
///  set green scale (from -100 to 100) (default -1)
/// </summary>
public DespillFilterGen green(float green) => this.SetOptionRange("green", green,-100,100);
/// <summary>
///  set blue scale (from -100 to 100) (default 0)
/// </summary>
public DespillFilterGen blue(float blue) => this.SetOptionRange("blue", blue,-100,100);
/// <summary>
///  set brightness (from -10 to 10) (default 0)
/// </summary>
public DespillFilterGen brightness(float brightness) => this.SetOptionRange("brightness", brightness,-10,10);
/// <summary>
///  change alpha component (default false)
/// </summary>
public DespillFilterGen alpha(bool flag) => this.SetOption("alpha",flag.ToFFmpegFlag());
}
public static class DespillFilterGenExtensions
{
/// <summary>
/// Despill video.
/// </summary>
public static DespillFilterGen DespillFilterGen(this ImageMap input) => new DespillFilterGen(input);
}
public enum DespillFilterGenType
{
[Name("green")] green,
[Name("blue")] blue,
}

}
