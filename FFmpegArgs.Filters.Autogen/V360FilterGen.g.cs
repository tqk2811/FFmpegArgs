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
public class V360FilterGen : ImageToImageFilter,ISliceThreading,ICommandSupport
{
internal V360FilterGen(ImageMap input) : base("v360",input) { AddMapOut(); }
/// <summary>
///  set input projection (from 0 to 23) (default e)
/// </summary>
public V360FilterGen input(V360FilterGenInput input) => this.SetOption("input", input.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set output projection (from 0 to 23) (default c3x2)
/// </summary>
public V360FilterGen output(V360FilterGenOutput output) => this.SetOption("output", output.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set interpolation method (from 0 to 7) (default line)
/// </summary>
public V360FilterGen interp(V360FilterGenInterp interp) => this.SetOption("interp", interp.GetAttribute<NameAttribute>().Name);
/// <summary>
///  output width (from 0 to 32767) (default 0)
/// </summary>
public V360FilterGen w(int w) => this.SetOptionRange("w", w,0,32767);
/// <summary>
///  output height (from 0 to 32767) (default 0)
/// </summary>
public V360FilterGen h(int h) => this.SetOptionRange("h", h,0,32767);
/// <summary>
///  input stereo format (from 0 to 2) (default 2d)
/// </summary>
public V360FilterGen in_stereo(V360FilterGenIn_stereo in_stereo) => this.SetOption("in_stereo", in_stereo.GetAttribute<NameAttribute>().Name);
/// <summary>
///  output stereo format (from 0 to 2) (default 2d)
/// </summary>
public V360FilterGen out_stereo(V360FilterGenOut_stereo out_stereo) => this.SetOption("out_stereo", out_stereo.GetAttribute<NameAttribute>().Name);
/// <summary>
///  input cubemap face order (default "rludfb")
/// </summary>
public V360FilterGen in_forder(string in_forder) => this.SetOption("in_forder",in_forder);
/// <summary>
///  output cubemap face order (default "rludfb")
/// </summary>
public V360FilterGen out_forder(string out_forder) => this.SetOption("out_forder",out_forder);
/// <summary>
///  input cubemap face rotation (default "000000")
/// </summary>
public V360FilterGen in_frot(string in_frot) => this.SetOption("in_frot",in_frot);
/// <summary>
///  output cubemap face rotation (default "000000")
/// </summary>
public V360FilterGen out_frot(string out_frot) => this.SetOption("out_frot",out_frot);
/// <summary>
///  percent input cubemap pads (from 0 to 0.1) (default 0)
/// </summary>
public V360FilterGen in_pad(float in_pad) => this.SetOptionRange("in_pad", in_pad,0,0.1);
/// <summary>
///  percent output cubemap pads (from 0 to 0.1) (default 0)
/// </summary>
public V360FilterGen out_pad(float out_pad) => this.SetOptionRange("out_pad", out_pad,0,0.1);
/// <summary>
///  fixed input cubemap pads (from 0 to 100) (default 0)
/// </summary>
public V360FilterGen fin_pad(int fin_pad) => this.SetOptionRange("fin_pad", fin_pad,0,100);
/// <summary>
///  fixed output cubemap pads (from 0 to 100) (default 0)
/// </summary>
public V360FilterGen fout_pad(int fout_pad) => this.SetOptionRange("fout_pad", fout_pad,0,100);
/// <summary>
///  yaw rotation (from -180 to 180) (default 0)
/// </summary>
public V360FilterGen yaw(float yaw) => this.SetOptionRange("yaw", yaw,-180,180);
/// <summary>
///  pitch rotation (from -180 to 180) (default 0)
/// </summary>
public V360FilterGen pitch(float pitch) => this.SetOptionRange("pitch", pitch,-180,180);
/// <summary>
///  roll rotation (from -180 to 180) (default 0)
/// </summary>
public V360FilterGen roll(float roll) => this.SetOptionRange("roll", roll,-180,180);
/// <summary>
///  rotation order (default "ypr")
/// </summary>
public V360FilterGen rorder(string rorder) => this.SetOption("rorder",rorder);
/// <summary>
///  output horizontal field of view (from 1e-05 to 360) (default 90)
/// </summary>
public V360FilterGen h_fov(float h_fov) => this.SetOptionRange("h_fov", h_fov,1e-05,360);
/// <summary>
///  output vertical field of view (from 1e-05 to 360) (default 45)
/// </summary>
public V360FilterGen v_fov(float v_fov) => this.SetOptionRange("v_fov", v_fov,1e-05,360);
/// <summary>
///  output diagonal field of view (from 0 to 360) (default 0)
/// </summary>
public V360FilterGen d_fov(float d_fov) => this.SetOptionRange("d_fov", d_fov,0,360);
/// <summary>
///  flip out video horizontally (default false)
/// </summary>
public V360FilterGen h_flip(bool flag) => this.SetOption("h_flip",flag.ToFFmpegFlag());
/// <summary>
///  flip out video vertically (default false)
/// </summary>
public V360FilterGen v_flip(bool flag) => this.SetOption("v_flip",flag.ToFFmpegFlag());
/// <summary>
///  flip out video indepth (default false)
/// </summary>
public V360FilterGen d_flip(bool flag) => this.SetOption("d_flip",flag.ToFFmpegFlag());
/// <summary>
///  flip in video horizontally (default false)
/// </summary>
public V360FilterGen ih_flip(bool flag) => this.SetOption("ih_flip",flag.ToFFmpegFlag());
/// <summary>
///  flip in video vertically (default false)
/// </summary>
public V360FilterGen iv_flip(bool flag) => this.SetOption("iv_flip",flag.ToFFmpegFlag());
/// <summary>
///  transpose video input (default false)
/// </summary>
public V360FilterGen in_trans(bool flag) => this.SetOption("in_trans",flag.ToFFmpegFlag());
/// <summary>
///  transpose video output (default false)
/// </summary>
public V360FilterGen out_trans(bool flag) => this.SetOption("out_trans",flag.ToFFmpegFlag());
/// <summary>
///  input horizontal field of view (from 1e-05 to 360) (default 90)
/// </summary>
public V360FilterGen ih_fov(float ih_fov) => this.SetOptionRange("ih_fov", ih_fov,1e-05,360);
/// <summary>
///  input vertical field of view (from 1e-05 to 360) (default 45)
/// </summary>
public V360FilterGen iv_fov(float iv_fov) => this.SetOptionRange("iv_fov", iv_fov,1e-05,360);
/// <summary>
///  input diagonal field of view (from 0 to 360) (default 0)
/// </summary>
public V360FilterGen id_fov(float id_fov) => this.SetOptionRange("id_fov", id_fov,0,360);
/// <summary>
///  build mask in alpha plane (default false)
/// </summary>
public V360FilterGen alpha_mask(bool flag) => this.SetOption("alpha_mask",flag.ToFFmpegFlag());
}
public static class V360FilterGenExtensions
{
/// <summary>
/// Convert 360 projection of video.
/// </summary>
public static V360FilterGen V360FilterGen(this ImageMap input0) => new V360FilterGen(input0);
}
public enum V360FilterGenInput
{
[Name("e")] e,
[Name("equirect")] equirect,
[Name("c3x2")] c3x2,
[Name("c6x1")] c6x1,
[Name("eac")] eac,
[Name("dfisheye")] dfisheye,
[Name("flat")] flat,
[Name("rectilinear")] rectilinear,
[Name("gnomonic")] gnomonic,
[Name("barrel")] barrel,
[Name("fb")] fb,
[Name("c1x6")] c1x6,
[Name("sg")] sg,
[Name("mercator")] mercator,
[Name("ball")] ball,
[Name("hammer")] hammer,
[Name("sinusoidal")] sinusoidal,
[Name("fisheye")] fisheye,
[Name("pannini")] pannini,
[Name("cylindrical")] cylindrical,
[Name("tetrahedron")] tetrahedron,
[Name("barrelsplit")] barrelsplit,
[Name("tsp")] tsp,
[Name("hequirect")] hequirect,
[Name("he")] he,
[Name("equisolid")] equisolid,
[Name("og")] og,
[Name("octahedron")] octahedron,
}

public enum V360FilterGenOutput
{
[Name("e")] e,
[Name("equirect")] equirect,
[Name("c3x2")] c3x2,
[Name("c6x1")] c6x1,
[Name("eac")] eac,
[Name("dfisheye")] dfisheye,
[Name("flat")] flat,
[Name("rectilinear")] rectilinear,
[Name("gnomonic")] gnomonic,
[Name("barrel")] barrel,
[Name("fb")] fb,
[Name("c1x6")] c1x6,
[Name("sg")] sg,
[Name("mercator")] mercator,
[Name("ball")] ball,
[Name("hammer")] hammer,
[Name("sinusoidal")] sinusoidal,
[Name("fisheye")] fisheye,
[Name("pannini")] pannini,
[Name("cylindrical")] cylindrical,
[Name("perspective")] perspective,
[Name("tetrahedron")] tetrahedron,
[Name("barrelsplit")] barrelsplit,
[Name("tsp")] tsp,
[Name("hequirect")] hequirect,
[Name("he")] he,
[Name("equisolid")] equisolid,
[Name("og")] og,
[Name("octahedron")] octahedron,
}

public enum V360FilterGenInterp
{
[Name("near")] near,
[Name("nearest")] nearest,
[Name("line")] line,
[Name("linear")] linear,
[Name("lagrange9")] lagrange9,
[Name("cube")] cube,
[Name("cubic")] cubic,
[Name("lanc")] lanc,
[Name("lanczos")] lanczos,
[Name("sp16")] sp16,
[Name("spline16")] spline16,
[Name("gauss")] gauss,
[Name("gaussian")] gaussian,
[Name("mitchell")] mitchell,
}

public enum V360FilterGenIn_stereo
{
[Name("2d")] _2d,
[Name("sbs")] sbs,
[Name("tb")] tb,
}

public enum V360FilterGenOut_stereo
{
[Name("2d")] _2d,
[Name("sbs")] sbs,
[Name("tb")] tb,
}

}
