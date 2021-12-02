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
public class SetparamsFilterGen : ImageToImageFilter
{
internal SetparamsFilterGen(ImageMap input) : base("setparams",input) { AddMapOut(); }
/// <summary>
///  select interlace mode (from -1 to 2) (default auto)
/// </summary>
public SetparamsFilterGen field_mode(SetparamsFilterGenField_mode field_mode) => this.SetOption("field_mode", field_mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  select color range (from -1 to 2) (default auto)
/// </summary>
public SetparamsFilterGen range(SetparamsFilterGenRange range) => this.SetOption("range", range.GetAttribute<NameAttribute>().Name);
/// <summary>
///  select color primaries (from -1 to 22) (default auto)
/// </summary>
public SetparamsFilterGen color_primaries(SetparamsFilterGenColor_primaries color_primaries) => this.SetOption("color_primaries", color_primaries.GetAttribute<NameAttribute>().Name);
/// <summary>
///  select color transfer (from -1 to 18) (default auto)
/// </summary>
public SetparamsFilterGen color_trc(SetparamsFilterGenColor_trc color_trc) => this.SetOption("color_trc", color_trc.GetAttribute<NameAttribute>().Name);
/// <summary>
///  select colorspace (from -1 to 14) (default auto)
/// </summary>
public SetparamsFilterGen colorspace(SetparamsFilterGenColorspace colorspace) => this.SetOption("colorspace", colorspace.GetAttribute<NameAttribute>().Name);
}
public static class SetparamsFilterGenExtensions
{
/// <summary>
/// Force field, or color property for the output video frame.
/// </summary>
public static SetparamsFilterGen SetparamsFilterGen(this ImageMap input0) => new SetparamsFilterGen(input0);
/// <summary>
/// Force field, or color property for the output video frame.
/// </summary>
public static SetparamsFilterGen SetparamsFilterGen(this ImageMap input0,SetparamsFilterGenConfig config)
{
var result = new SetparamsFilterGen(input0);
if(config?.field_mode != null) result.field_mode(config.field_mode);
if(config?.range != null) result.range(config.range);
if(config?.color_primaries != null) result.color_primaries(config.color_primaries);
if(config?.color_trc != null) result.color_trc(config.color_trc);
if(config?.colorspace != null) result.colorspace(config.colorspace);
return result;
}
}
public class SetparamsFilterGenConfig
{
/// <summary>
///  select interlace mode (from -1 to 2) (default auto)
/// </summary>
public SetparamsFilterGenField_mode field_mode { get; set; }
/// <summary>
///  select color range (from -1 to 2) (default auto)
/// </summary>
public SetparamsFilterGenRange range { get; set; }
/// <summary>
///  select color primaries (from -1 to 22) (default auto)
/// </summary>
public SetparamsFilterGenColor_primaries color_primaries { get; set; }
/// <summary>
///  select color transfer (from -1 to 18) (default auto)
/// </summary>
public SetparamsFilterGenColor_trc color_trc { get; set; }
/// <summary>
///  select colorspace (from -1 to 14) (default auto)
/// </summary>
public SetparamsFilterGenColorspace colorspace { get; set; }
}
public enum SetparamsFilterGenField_mode
{
[Name("auto")] auto,
[Name("bff")] bff,
[Name("tff")] tff,
[Name("prog")] prog,
}

public enum SetparamsFilterGenRange
{
[Name("auto")] auto,
[Name("unspecified")] unspecified,
[Name("unknown")] unknown,
[Name("limited")] limited,
[Name("tv")] tv,
[Name("mpeg")] mpeg,
[Name("full")] full,
[Name("pc")] pc,
[Name("jpeg")] jpeg,
}

public enum SetparamsFilterGenColor_primaries
{
[Name("auto")] auto,
[Name("bt709")] bt709,
[Name("unknown")] unknown,
[Name("bt470m")] bt470m,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("smpte240m")] smpte240m,
[Name("film")] film,
[Name("bt2020")] bt2020,
[Name("smpte428")] smpte428,
[Name("smpte431")] smpte431,
[Name("smpte432")] smpte432,
[Name("jedec-p22")] jedec_p22,
[Name("ebu3213")] ebu3213,
}

public enum SetparamsFilterGenColor_trc
{
[Name("auto")] auto,
[Name("bt709")] bt709,
[Name("unknown")] unknown,
[Name("bt470m")] bt470m,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("smpte240m")] smpte240m,
[Name("linear")] linear,
[Name("log100")] log100,
[Name("log316")] log316,
[Name("iec61966-2-4")] iec61966_2_4,
[Name("bt1361e")] bt1361e,
[Name("iec61966-2-1")] iec61966_2_1,
[Name("bt2020-10")] bt2020_10,
[Name("bt2020-12")] bt2020_12,
[Name("smpte2084")] smpte2084,
[Name("smpte428")] smpte428,
[Name("arib-std-b67")] arib_std_b67,
}

public enum SetparamsFilterGenColorspace
{
[Name("auto")] auto,
[Name("gbr")] gbr,
[Name("bt709")] bt709,
[Name("unknown")] unknown,
[Name("fcc")] fcc,
[Name("bt470bg")] bt470bg,
[Name("smpte170m")] smpte170m,
[Name("smpte240m")] smpte240m,
[Name("ycgco")] ycgco,
[Name("bt2020nc")] bt2020nc,
[Name("bt2020c")] bt2020c,
[Name("smpte2085")] smpte2085,
[Name("chroma-derived-nc")] chroma_derived_nc,
[Name("chroma-derived-c")] chroma_derived_c,
[Name("ictcp")] ictcp,
}

}
