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
public class PermsFilterGen : ImageToImageFilter,ITimelineSupport
{
internal PermsFilterGen(ImageMap input) : base("perms",input) { AddMapOut(); }
/// <summary>
///  select permissions mode (from 0 to 4) (default none)
/// </summary>
public PermsFilterGen mode(PermsFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set the seed for the random mode (from -1 to UINT32_MAX) (default -1)
/// </summary>
public PermsFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
}
public static class PermsFilterGenExtensions
{
/// <summary>
/// Set permissions for the output video frame.
/// </summary>
public static PermsFilterGen PermsFilterGen(this ImageMap input0) => new PermsFilterGen(input0);
/// <summary>
/// Set permissions for the output video frame.
/// </summary>
public static PermsFilterGen PermsFilterGen(this ImageMap input0,PermsFilterGenConfig config)
{
var result = new PermsFilterGen(input0);
if(config?.mode != null) result.mode(config.mode.Value);
if(config?.seed != null) result.seed(config.seed.Value);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class PermsFilterGenConfig
{
/// <summary>
///  select permissions mode (from 0 to 4) (default none)
/// </summary>
public PermsFilterGenMode? mode { get; set; }
/// <summary>
///  set the seed for the random mode (from -1 to UINT32_MAX) (default -1)
/// </summary>
public long? seed { get; set; }
public string TimelineSupport { get; set; }
}
public enum PermsFilterGenMode
{
[Name("none")] none,
[Name("ro")] ro,
[Name("rw")] rw,
[Name("toggle")] toggle,
[Name("random")] random,
}

}
