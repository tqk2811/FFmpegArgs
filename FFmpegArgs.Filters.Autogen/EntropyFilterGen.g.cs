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
public class EntropyFilterGen : ImageToImageFilter,ITimelineSupport
{
internal EntropyFilterGen(ImageMap input) : base("entropy",input) { AddMapOut(); }
/// <summary>
///  set kind of histogram entropy measurement (from 0 to 1) (default normal)
/// </summary>
public EntropyFilterGen mode(EntropyFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
}
public static class EntropyFilterGenExtensions
{
/// <summary>
/// Measure video frames entropy.
/// </summary>
public static EntropyFilterGen EntropyFilterGen(this ImageMap input0) => new EntropyFilterGen(input0);
/// <summary>
/// Measure video frames entropy.
/// </summary>
public static EntropyFilterGen EntropyFilterGen(this ImageMap input0,EntropyFilterGenConfig config)
{
var result = new EntropyFilterGen(input0);
if(config?.mode != null) result.mode(config.mode.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class EntropyFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set kind of histogram entropy measurement (from 0 to 1) (default normal)
/// </summary>
public EntropyFilterGenMode? mode { get; set; }
public string TimelineSupport { get; set; }
}
public enum EntropyFilterGenMode
{
[Name("normal")] normal,
[Name("diff")] diff,
}

}
