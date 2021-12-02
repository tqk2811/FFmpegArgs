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
public class PhaseFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal PhaseFilterGen(ImageMap input) : base("phase",input) { AddMapOut(); }
/// <summary>
///  set phase mode (from 0 to 8) (default A)
/// </summary>
public PhaseFilterGen mode(PhaseFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
}
public static class PhaseFilterGenExtensions
{
/// <summary>
/// Phase shift fields.
/// </summary>
public static PhaseFilterGen PhaseFilterGen(this ImageMap input0) => new PhaseFilterGen(input0);
/// <summary>
/// Phase shift fields.
/// </summary>
public static PhaseFilterGen PhaseFilterGen(this ImageMap input0,PhaseFilterGenConfig config)
{
var result = new PhaseFilterGen(input0);
if(config?.mode != null) result.mode(config.mode.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class PhaseFilterGenConfig
{
/// <summary>
///  set phase mode (from 0 to 8) (default A)
/// </summary>
public PhaseFilterGenMode? mode { get; set; }
public string TimelineSupport { get; set; }
}
public enum PhaseFilterGenMode
{
[Name("p")] p,
[Name("t")] t,
[Name("b")] b,
[Name("T")] T,
[Name("B")] B,
[Name("u")] u,
[Name("U")] U,
[Name("a")] a,
[Name("A")] A,
}

}
