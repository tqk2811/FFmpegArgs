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
public class ColorchannelmixerFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ColorchannelmixerFilterGen(ImageMap input) : base("colorchannelmixer",input) { AddMapOut(); }
/// <summary>
///  set the red gain for the red channel (from -2 to 2) (default 1)
/// </summary>
public ColorchannelmixerFilterGen rr(double rr) => this.SetOptionRange("rr", rr,-2,2);
/// <summary>
///  set the green gain for the red channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen rg(double rg) => this.SetOptionRange("rg", rg,-2,2);
/// <summary>
///  set the blue gain for the red channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen rb(double rb) => this.SetOptionRange("rb", rb,-2,2);
/// <summary>
///  set the alpha gain for the red channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen ra(double ra) => this.SetOptionRange("ra", ra,-2,2);
/// <summary>
///  set the red gain for the green channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen gr(double gr) => this.SetOptionRange("gr", gr,-2,2);
/// <summary>
///  set the green gain for the green channel (from -2 to 2) (default 1)
/// </summary>
public ColorchannelmixerFilterGen gg(double gg) => this.SetOptionRange("gg", gg,-2,2);
/// <summary>
///  set the blue gain for the green channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen gb(double gb) => this.SetOptionRange("gb", gb,-2,2);
/// <summary>
///  set the alpha gain for the green channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen ga(double ga) => this.SetOptionRange("ga", ga,-2,2);
/// <summary>
///  set the red gain for the blue channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen br(double br) => this.SetOptionRange("br", br,-2,2);
/// <summary>
///  set the green gain for the blue channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen bg(double bg) => this.SetOptionRange("bg", bg,-2,2);
/// <summary>
///  set the blue gain for the blue channel (from -2 to 2) (default 1)
/// </summary>
public ColorchannelmixerFilterGen bb(double bb) => this.SetOptionRange("bb", bb,-2,2);
/// <summary>
///  set the alpha gain for the blue channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen ba(double ba) => this.SetOptionRange("ba", ba,-2,2);
/// <summary>
///  set the red gain for the alpha channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen ar(double ar) => this.SetOptionRange("ar", ar,-2,2);
/// <summary>
///  set the green gain for the alpha channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen ag(double ag) => this.SetOptionRange("ag", ag,-2,2);
/// <summary>
///  set the blue gain for the alpha channel (from -2 to 2) (default 0)
/// </summary>
public ColorchannelmixerFilterGen ab(double ab) => this.SetOptionRange("ab", ab,-2,2);
/// <summary>
///  set the alpha gain for the alpha channel (from -2 to 2) (default 1)
/// </summary>
public ColorchannelmixerFilterGen aa(double aa) => this.SetOptionRange("aa", aa,-2,2);
/// <summary>
///  preserve lightness (from 0 to 1) (default 0)
/// </summary>
public ColorchannelmixerFilterGen pl(double pl) => this.SetOptionRange("pl", pl,0,1);
}
public static class ColorchannelmixerFilterGenExtensions
{
/// <summary>
/// Adjust colors by mixing color channels.
/// </summary>
public static ColorchannelmixerFilterGen ColorchannelmixerFilterGen(this ImageMap input0) => new ColorchannelmixerFilterGen(input0);
/// <summary>
/// Adjust colors by mixing color channels.
/// </summary>
public static ColorchannelmixerFilterGen ColorchannelmixerFilterGen(this ImageMap input0,ColorchannelmixerFilterGenConfig config)
{
var result = new ColorchannelmixerFilterGen(input0);
if(config?.rr != null) result.rr(config.rr);
if(config?.rg != null) result.rg(config.rg);
if(config?.rb != null) result.rb(config.rb);
if(config?.ra != null) result.ra(config.ra);
if(config?.gr != null) result.gr(config.gr);
if(config?.gg != null) result.gg(config.gg);
if(config?.gb != null) result.gb(config.gb);
if(config?.ga != null) result.ga(config.ga);
if(config?.br != null) result.br(config.br);
if(config?.bg != null) result.bg(config.bg);
if(config?.bb != null) result.bb(config.bb);
if(config?.ba != null) result.ba(config.ba);
if(config?.ar != null) result.ar(config.ar);
if(config?.ag != null) result.ag(config.ag);
if(config?.ab != null) result.ab(config.ab);
if(config?.aa != null) result.aa(config.aa);
if(config?.pl != null) result.pl(config.pl);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class ColorchannelmixerFilterGenConfig
{
/// <summary>
///  set the red gain for the red channel (from -2 to 2) (default 1)
/// </summary>
public double rr { get; set; }
/// <summary>
///  set the green gain for the red channel (from -2 to 2) (default 0)
/// </summary>
public double rg { get; set; }
/// <summary>
///  set the blue gain for the red channel (from -2 to 2) (default 0)
/// </summary>
public double rb { get; set; }
/// <summary>
///  set the alpha gain for the red channel (from -2 to 2) (default 0)
/// </summary>
public double ra { get; set; }
/// <summary>
///  set the red gain for the green channel (from -2 to 2) (default 0)
/// </summary>
public double gr { get; set; }
/// <summary>
///  set the green gain for the green channel (from -2 to 2) (default 1)
/// </summary>
public double gg { get; set; }
/// <summary>
///  set the blue gain for the green channel (from -2 to 2) (default 0)
/// </summary>
public double gb { get; set; }
/// <summary>
///  set the alpha gain for the green channel (from -2 to 2) (default 0)
/// </summary>
public double ga { get; set; }
/// <summary>
///  set the red gain for the blue channel (from -2 to 2) (default 0)
/// </summary>
public double br { get; set; }
/// <summary>
///  set the green gain for the blue channel (from -2 to 2) (default 0)
/// </summary>
public double bg { get; set; }
/// <summary>
///  set the blue gain for the blue channel (from -2 to 2) (default 1)
/// </summary>
public double bb { get; set; }
/// <summary>
///  set the alpha gain for the blue channel (from -2 to 2) (default 0)
/// </summary>
public double ba { get; set; }
/// <summary>
///  set the red gain for the alpha channel (from -2 to 2) (default 0)
/// </summary>
public double ar { get; set; }
/// <summary>
///  set the green gain for the alpha channel (from -2 to 2) (default 0)
/// </summary>
public double ag { get; set; }
/// <summary>
///  set the blue gain for the alpha channel (from -2 to 2) (default 0)
/// </summary>
public double ab { get; set; }
/// <summary>
///  set the alpha gain for the alpha channel (from -2 to 2) (default 1)
/// </summary>
public double aa { get; set; }
/// <summary>
///  preserve lightness (from 0 to 1) (default 0)
/// </summary>
public double pl { get; set; }
public string TimelineSupport { get; set; }
}
}
