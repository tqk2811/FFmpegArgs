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
public class Stereo3dFilterGen : ImageToImageFilter,ISliceThreading
{
internal Stereo3dFilterGen(ImageMap input) : base("stereo3d",input) { AddMapOut(); }
/// <summary>
///  set input format (from 16 to 32) (default sbsl)
/// </summary>
public Stereo3dFilterGen _in(Stereo3dFilterGenIn _in) => this.SetOption("in", _in.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set output format (from 0 to 32) (default arcd)
/// </summary>
public Stereo3dFilterGen _out(Stereo3dFilterGenOut _out) => this.SetOption("out", _out.GetAttribute<NameAttribute>().Name);
}
public static class Stereo3dFilterGenExtensions
{
/// <summary>
/// Convert video stereoscopic 3D view.
/// </summary>
public static Stereo3dFilterGen Stereo3dFilterGen(this ImageMap input0) => new Stereo3dFilterGen(input0);
/// <summary>
/// Convert video stereoscopic 3D view.
/// </summary>
public static Stereo3dFilterGen Stereo3dFilterGen(this ImageMap input0,Stereo3dFilterGenConfig config)
{
var result = new Stereo3dFilterGen(input0);
if(config?._in != null) result._in(config._in);
if(config?._out != null) result._out(config._out);
return result;
}
}
public class Stereo3dFilterGenConfig
{
/// <summary>
///  set input format (from 16 to 32) (default sbsl)
/// </summary>
public Stereo3dFilterGenIn _in { get; set; }
/// <summary>
///  set output format (from 0 to 32) (default arcd)
/// </summary>
public Stereo3dFilterGenOut _out { get; set; }
}
public enum Stereo3dFilterGenIn
{
[Name("ab2l")] ab2l,
[Name("tb2l")] tb2l,
[Name("ab2r")] ab2r,
[Name("tb2r")] tb2r,
[Name("abl")] abl,
[Name("tbl")] tbl,
[Name("abr")] abr,
[Name("tbr")] tbr,
[Name("al")] al,
[Name("ar")] ar,
[Name("sbs2l")] sbs2l,
[Name("sbs2r")] sbs2r,
[Name("sbsl")] sbsl,
[Name("sbsr")] sbsr,
[Name("irl")] irl,
[Name("irr")] irr,
[Name("icl")] icl,
[Name("icr")] icr,
}

public enum Stereo3dFilterGenOut
{
[Name("ab2l")] ab2l,
[Name("tb2l")] tb2l,
[Name("ab2r")] ab2r,
[Name("tb2r")] tb2r,
[Name("abl")] abl,
[Name("tbl")] tbl,
[Name("abr")] abr,
[Name("tbr")] tbr,
[Name("agmc")] agmc,
[Name("agmd")] agmd,
[Name("agmg")] agmg,
[Name("agmh")] agmh,
[Name("al")] al,
[Name("ar")] ar,
[Name("arbg")] arbg,
[Name("arcc")] arcc,
[Name("arcd")] arcd,
[Name("arcg")] arcg,
[Name("arch")] arch,
[Name("argg")] argg,
[Name("aybc")] aybc,
[Name("aybd")] aybd,
[Name("aybg")] aybg,
[Name("aybh")] aybh,
[Name("irl")] irl,
[Name("irr")] irr,
[Name("ml")] ml,
[Name("mr")] mr,
[Name("sbs2l")] sbs2l,
[Name("sbs2r")] sbs2r,
[Name("sbsl")] sbsl,
[Name("sbsr")] sbsr,
[Name("chl")] chl,
[Name("chr")] chr,
[Name("icl")] icl,
[Name("icr")] icr,
[Name("hdmi")] hdmi,
}

}
