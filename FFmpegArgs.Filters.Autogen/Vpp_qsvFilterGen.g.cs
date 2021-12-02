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
public Vpp_qsvFilterGen framerate(Rational framerate) => this.SetOption("framerate",framerate.Check(0,DBL_MAX));
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
public Vpp_qsvFilterGen width(string width) => this.SetOption("width",width);
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
/// <summary>
/// Quick Sync Video VPP.
/// </summary>
public static Vpp_qsvFilterGen Vpp_qsvFilterGen(this ImageMap input0,Vpp_qsvFilterGenConfig config)
{
var result = new Vpp_qsvFilterGen(input0);
if(config?.deinterlace != null) result.deinterlace(config.deinterlace);
if(config?.denoise != null) result.denoise(config.denoise);
if(config?.detail != null) result.detail(config.detail);
if(config?.framerate != null) result.framerate(config.framerate);
if(config?.procamp != null) result.procamp(config.procamp);
if(config?.hue != null) result.hue(config.hue);
if(config?.saturation != null) result.saturation(config.saturation);
if(config?.contrast != null) result.contrast(config.contrast);
if(config?.brightness != null) result.brightness(config.brightness);
if(config?.transpose != null) result.transpose(config.transpose);
if(config?.cw != null) result.cw(config.cw);
if(config?.ch != null) result.ch(config.ch);
if(config?.cx != null) result.cx(config.cx);
if(config?.cy != null) result.cy(config.cy);
if(config?.width != null) result.width(config.width);
if(config?.height != null) result.height(config.height);
if(config?.format != null) result.format(config.format);
return result;
}
}
public class Vpp_qsvFilterGenConfig
{
/// <summary>
///  deinterlace mode: 0=off, 1=bob, 2=advanced (from 0 to 2) (default 0)
/// </summary>
public Vpp_qsvFilterGenDeinterlace deinterlace { get; set; }
/// <summary>
///  denoise level [0, 100] (from 0 to 100) (default 0)
/// </summary>
public int denoise { get; set; }
/// <summary>
///  enhancement level [0, 100] (from 0 to 100) (default 0)
/// </summary>
public int detail { get; set; }
/// <summary>
///  output framerate (from 0 to DBL_MAX) (default 0/1)
/// </summary>
public Rational framerate { get; set; }
/// <summary>
///  Enable ProcAmp (from 0 to 1) (default 0)
/// </summary>
public int procamp { get; set; }
/// <summary>
///  ProcAmp hue (from -180 to 180) (default 0)
/// </summary>
public float hue { get; set; }
/// <summary>
///  ProcAmp saturation (from 0 to 10) (default 1)
/// </summary>
public float saturation { get; set; }
/// <summary>
///  ProcAmp contrast (from 0 to 10) (default 1)
/// </summary>
public float contrast { get; set; }
/// <summary>
///  ProcAmp brightness (from -100 to 100) (default 0)
/// </summary>
public float brightness { get; set; }
/// <summary>
///  set transpose direction (from -1 to 6) (default -1)
/// </summary>
public Vpp_qsvFilterGenTranspose transpose { get; set; }
/// <summary>
///  set the width crop area expression (default "iw")
/// </summary>
public string cw { get; set; }
/// <summary>
///  set the height crop area expression (default "ih")
/// </summary>
public string ch { get; set; }
/// <summary>
///  set the x crop area expression (default "(in_w-out_w)/2")
/// </summary>
public string cx { get; set; }
/// <summary>
///  set the y crop area expression (default "(in_h-out_h)/2")
/// </summary>
public string cy { get; set; }
/// <summary>
///  Output video width (default "cw")
/// </summary>
public string width { get; set; }
/// <summary>
///  Output video height (default "w*ch/cw")
/// </summary>
public string height { get; set; }
/// <summary>
///  Output pixel format (default "same")
/// </summary>
public string format { get; set; }
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
