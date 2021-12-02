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
public class Scale_qsvFilterGen : ImageToImageFilter
{
internal Scale_qsvFilterGen(ImageMap input) : base("scale_qsv",input) { AddMapOut(); }
/// <summary>
///  Output video width (default "iw")
/// </summary>
public Scale_qsvFilterGen w(string w) => this.SetOption("w",w);
/// <summary>
///  Output video height (default "ih")
/// </summary>
public Scale_qsvFilterGen h(string h) => this.SetOption("h",h);
/// <summary>
///  Output pixel format (default "same")
/// </summary>
public Scale_qsvFilterGen format(string format) => this.SetOption("format",format);
/// <summary>
///  set scaling mode (from 0 to 2) (default 0)
/// </summary>
public Scale_qsvFilterGen mode(Scale_qsvFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
}
public static class Scale_qsvFilterGenExtensions
{
/// <summary>
/// QuickSync video scaling and format conversion
/// </summary>
public static Scale_qsvFilterGen Scale_qsvFilterGen(this ImageMap input0) => new Scale_qsvFilterGen(input0);
/// <summary>
/// QuickSync video scaling and format conversion
/// </summary>
public static Scale_qsvFilterGen Scale_qsvFilterGen(this ImageMap input0,Scale_qsvFilterGenConfig config)
{
var result = new Scale_qsvFilterGen(input0);
if(config?.w != null) result.w(config.w);
if(config?.h != null) result.h(config.h);
if(config?.format != null) result.format(config.format);
if(config?.mode != null) result.mode(config.mode);
return result;
}
}
public class Scale_qsvFilterGenConfig
{
/// <summary>
///  Output video width (default "iw")
/// </summary>
public string w { get; set; }
/// <summary>
///  Output video height (default "ih")
/// </summary>
public string h { get; set; }
/// <summary>
///  Output pixel format (default "same")
/// </summary>
public string format { get; set; }
/// <summary>
///  set scaling mode (from 0 to 2) (default 0)
/// </summary>
public Scale_qsvFilterGenMode mode { get; set; }
}
public enum Scale_qsvFilterGenMode
{
[Name("low_power")] low_power,
[Name("hq")] hq,
}

}
