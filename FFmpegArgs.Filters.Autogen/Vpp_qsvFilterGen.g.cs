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
public class Vpp_qsvFilterGen : ImageToImageFilter
{
internal Vpp_qsvFilterGen(ImageMap input) : base("vpp_qsv",input) { AddMapOut(); }
/// <summary>
///  deinterlace mode: 0=off, 1=bob, 2=advanced (from 0 to 2) (default 0)
/// </summary>
public Vpp_qsvFilterGen deinterlace(Vpp_qsvFilterGenDeinterlace deinterlace) => this.SetOption("deinterlace", deinterlace.GetAttribute<NameAttribute>().Name);
/// <summary>
///  denoise level [0, 100] (from 0 to 100) (default 0)
/// </summary>
public Vpp_qsvFilterGen denoise(int denoise) => this.SetOptionRange("denoise", denoise,0,100);
/// <summary>
///  enhancement level [0, 100] (from 0 to 100) (default 0)
/// </summary>
public Vpp_qsvFilterGen detail(int detail) => this.SetOptionRange("detail", detail,0,100);
/// <summary>
///  output framerate (from 0 to DBL_MAX) (default 0/1)
/// </summary>
public Vpp_qsvFilterGen framerate(string framerate) => this.SetOption("framerate",framerate);
/// <summary>
///  Enable ProcAmp (from 0 to 1) (default 0)
/// </summary>
public Vpp_qsvFilterGen procamp(int procamp) => this.SetOptionRange("procamp", procamp,0,1);
/// <summary>
///  ProcAmp hue (from -180 to 180) (default 0)
/// </summary>
public Vpp_qsvFilterGen hue(float hue) => this.SetOptionRange("hue", hue,-180,180);
/// <summary>
///  ProcAmp saturation (from 0 to 10) (default 1)
/// </summary>
public Vpp_qsvFilterGen saturation(float saturation) => this.SetOptionRange("saturation", saturation,0,10);
/// <summary>
///  ProcAmp contrast (from 0 to 10) (default 1)
/// </summary>
public Vpp_qsvFilterGen contrast(float contrast) => this.SetOptionRange("contrast", contrast,0,10);
/// <summary>
///  ProcAmp brightness (from -100 to 100) (default 0)
/// </summary>
public Vpp_qsvFilterGen brightness(float brightness) => this.SetOptionRange("brightness", brightness,-100,100);
/// <summary>
///  set transpose direction (from -1 to 6) (default -1)
/// </summary>
public Vpp_qsvFilterGen transpose(Vpp_qsvFilterGenTranspose transpose) => this.SetOption("transpose", transpose.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set the width crop area expression (default "iw")
/// </summary>
public Vpp_qsvFilterGen cw(string cw) => this.SetOption("cw",cw);
/// <summary>
///  set the height crop area expression (default "ih")
/// </summary>
public Vpp_qsvFilterGen ch(string ch) => this.SetOption("ch",ch);
/// <summary>
///  set the x crop area expression (default "(in_w-out_w)/2")
/// </summary>
public Vpp_qsvFilterGen cx(string cx) => this.SetOption("cx",cx);
/// <summary>
///  set the y crop area expression (default "(in_h-out_h)/2")
/// </summary>
public Vpp_qsvFilterGen cy(string cy) => this.SetOption("cy",cy);
/// <summary>
///  Output video width (default "cw")
/// </summary>
public Vpp_qsvFilterGen w(string w) => this.SetOption("w",w);
/// <summary>
///  Output video width (default "cw")
/// </summary>
public Vpp_qsvFilterGen width(string width) => this.SetOption("width",width);
/// <summary>
///  Output video height (default "w*ch/cw")
/// </summary>
public Vpp_qsvFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  Output video height (default "w*ch/cw")
/// </summary>
public Vpp_qsvFilterGen height(string height) => this.SetOption("height",height);
/// <summary>
///  Output pixel format (default "same")
/// </summary>
public Vpp_qsvFilterGen format(string format) => this.SetOption("format",format);
}
public static class Vpp_qsvFilterGenExtensions
{
/// <summary>
/// Quick Sync Video VPP.
/// </summary>
public static Vpp_qsvFilterGen Vpp_qsvFilterGen(this ImageMap input0) => new Vpp_qsvFilterGen(input0);
}
public enum Vpp_qsvFilterGenDeinterlace
{
[Name("bob")] bob,
[Name("advanced")] advanced,
}

public enum Vpp_qsvFilterGenTranspose
{
[Name("cclock_hflip")] cclock_hflip,
[Name("clock")] clock,
[Name("cclock")] cclock,
[Name("clock_hflip")] clock_hflip,
[Name("reversal")] reversal,
[Name("hflip")] hflip,
[Name("vflip")] vflip,
}

}
