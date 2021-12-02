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
public class CiescopeFilterGen : ImageToImageFilter
{
internal CiescopeFilterGen(ImageMap input) : base("ciescope",input) { AddMapOut(); }
/// <summary>
///  set color system (from 0 to 9) (default hdtv)
/// </summary>
public CiescopeFilterGen system(CiescopeFilterGenSystem system) => this.SetOption("system", system.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set cie system (from 0 to 2) (default xyy)
/// </summary>
public CiescopeFilterGen cie(CiescopeFilterGenCie cie) => this.SetOption("cie", cie.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set what gamuts to draw (default 0)
/// </summary>
public CiescopeFilterGen gamuts(CiescopeFilterGenGamuts gamuts) => this.SetOption("gamuts", gamuts.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set ciescope size (from 256 to 8192) (default 512)
/// </summary>
public CiescopeFilterGen size(int size) => this.SetOptionRange("size", size,256,8192);
/// <summary>
///  set ciescope intensity (from 0 to 1) (default 0.001)
/// </summary>
public CiescopeFilterGen intensity(float intensity) => this.SetOptionRange("intensity", intensity,0,1);
/// <summary>
///  (from 0 to 1) (default 0.75)
/// </summary>
public CiescopeFilterGen contrast(float contrast) => this.SetOptionRange("contrast", contrast,0,1);
/// <summary>
///  (default true)
/// </summary>
public CiescopeFilterGen corrgamma(bool corrgamma) => this.SetOption("corrgamma",corrgamma.ToFFmpegFlag());
/// <summary>
///  (default false)
/// </summary>
public CiescopeFilterGen showwhite(bool showwhite) => this.SetOption("showwhite",showwhite.ToFFmpegFlag());
/// <summary>
///  (from 0.1 to 6) (default 2.6)
/// </summary>
public CiescopeFilterGen gamma(double gamma) => this.SetOptionRange("gamma", gamma,0.1,6);
}
public static class CiescopeFilterGenExtensions
{
/// <summary>
/// Video CIE scope.
/// </summary>
public static CiescopeFilterGen CiescopeFilterGen(this ImageMap input0) => new CiescopeFilterGen(input0);
/// <summary>
/// Video CIE scope.
/// </summary>
public static CiescopeFilterGen CiescopeFilterGen(this ImageMap input0,CiescopeFilterGenConfig config)
{
var result = new CiescopeFilterGen(input0);
if(config?.system != null) result.system(config.system);
if(config?.cie != null) result.cie(config.cie);
if(config?.gamuts != null) result.gamuts(config.gamuts);
if(config?.size != null) result.size(config.size);
if(config?.intensity != null) result.intensity(config.intensity);
if(config?.contrast != null) result.contrast(config.contrast);
if(config?.corrgamma != null) result.corrgamma(config.corrgamma);
if(config?.showwhite != null) result.showwhite(config.showwhite);
if(config?.gamma != null) result.gamma(config.gamma);
return result;
}
}
public class CiescopeFilterGenConfig
{
/// <summary>
///  set color system (from 0 to 9) (default hdtv)
/// </summary>
public CiescopeFilterGenSystem system { get; set; }
/// <summary>
///  set cie system (from 0 to 2) (default xyy)
/// </summary>
public CiescopeFilterGenCie cie { get; set; }
/// <summary>
///  set what gamuts to draw (default 0)
/// </summary>
public CiescopeFilterGenGamuts gamuts { get; set; }
/// <summary>
///  set ciescope size (from 256 to 8192) (default 512)
/// </summary>
public int size { get; set; }
/// <summary>
///  set ciescope intensity (from 0 to 1) (default 0.001)
/// </summary>
public float intensity { get; set; }
/// <summary>
///  (from 0 to 1) (default 0.75)
/// </summary>
public float contrast { get; set; }
/// <summary>
///  (default true)
/// </summary>
public bool corrgamma { get; set; }
/// <summary>
///  (default false)
/// </summary>
public bool showwhite { get; set; }
/// <summary>
///  (from 0.1 to 6) (default 2.6)
/// </summary>
public double gamma { get; set; }
}
public enum CiescopeFilterGenSystem
{
[Name("ntsc")] ntsc,
[Name("470m")] _470m,
[Name("ebu")] ebu,
[Name("470bg")] _470bg,
[Name("smpte")] smpte,
[Name("240m")] _240m,
[Name("apple")] apple,
[Name("widergb")] widergb,
[Name("cie1931")] cie1931,
[Name("hdtv")] hdtv,
[Name("rec709")] rec709,
[Name("uhdtv")] uhdtv,
[Name("rec2020")] rec2020,
[Name("dcip3")] dcip3,
}

public enum CiescopeFilterGenCie
{
[Name("xyy")] xyy,
[Name("ucs")] ucs,
[Name("luv")] luv,
}

public enum CiescopeFilterGenGamuts
{
[Name("ntsc")] ntsc,
[Name("470m")] _470m,
[Name("ebu")] ebu,
[Name("470bg")] _470bg,
[Name("smpte")] smpte,
[Name("240m")] _240m,
[Name("apple")] apple,
[Name("widergb")] widergb,
[Name("cie1931")] cie1931,
[Name("hdtv")] hdtv,
[Name("rec709")] rec709,
[Name("uhdtv")] uhdtv,
[Name("rec2020")] rec2020,
[Name("dcip3")] dcip3,
}

}
