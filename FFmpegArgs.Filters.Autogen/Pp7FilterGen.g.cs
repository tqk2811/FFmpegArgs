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
public class Pp7FilterGen : ImageToImageFilter,ITimelineSupport
{
internal Pp7FilterGen(ImageMap input) : base("pp7",input) { AddMapOut(); }
/// <summary>
///  force a constant quantizer parameter (from 0 to 64) (default 0)
/// </summary>
public Pp7FilterGen qp(int qp) => this.SetOptionRange("qp", qp,0,64);
/// <summary>
///  set thresholding mode (from 0 to 2) (default medium)
/// </summary>
public Pp7FilterGen mode(Pp7FilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
}
public static class Pp7FilterGenExtensions
{
/// <summary>
/// Apply Postprocessing 7 filter.
/// </summary>
public static Pp7FilterGen Pp7FilterGen(this ImageMap input0) => new Pp7FilterGen(input0);
/// <summary>
/// Apply Postprocessing 7 filter.
/// </summary>
public static Pp7FilterGen Pp7FilterGen(this ImageMap input0,Pp7FilterGenConfig config)
{
var result = new Pp7FilterGen(input0);
if(config?.qp != null) result.qp(config.qp.Value);
if(config?.mode != null) result.mode(config.mode.Value);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class Pp7FilterGenConfig
{
/// <summary>
///  force a constant quantizer parameter (from 0 to 64) (default 0)
/// </summary>
public int? qp { get; set; }
/// <summary>
///  set thresholding mode (from 0 to 2) (default medium)
/// </summary>
public Pp7FilterGenMode? mode { get; set; }
public string TimelineSupport { get; set; }
}
public enum Pp7FilterGenMode
{
[Name("hard")] hard,
[Name("soft")] soft,
[Name("medium")] medium,
}

}
