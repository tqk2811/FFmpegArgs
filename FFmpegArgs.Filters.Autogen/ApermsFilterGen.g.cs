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
public class ApermsFilterGen : AudioToAudioFilter,ITimelineSupport
{
internal ApermsFilterGen(AudioMap input) : base("aperms",input) { AddMapOut(); }
/// <summary>
///  select permissions mode (from 0 to 4) (default none)
/// </summary>
public ApermsFilterGen mode(ApermsFilterGenMode mode) => this.SetOption("mode", mode.GetAttribute<NameAttribute>().Name);
/// <summary>
///  set the seed for the random mode (from -1 to UINT32_MAX) (default -1)
/// </summary>
public ApermsFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
}
public static class ApermsFilterGenExtensions
{
/// <summary>
/// Set permissions for the output audio frame.
/// </summary>
public static ApermsFilterGen ApermsFilterGen(this AudioMap input0) => new ApermsFilterGen(input0);
/// <summary>
/// Set permissions for the output audio frame.
/// </summary>
public static ApermsFilterGen ApermsFilterGen(this AudioMap input0,ApermsFilterGenConfig config)
{
var result = new ApermsFilterGen(input0);
if(config?.mode != null) result.mode(config.mode);
if(config?.seed != null) result.seed(config.seed);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class ApermsFilterGenConfig
{
/// <summary>
///  select permissions mode (from 0 to 4) (default none)
/// </summary>
public ApermsFilterGenMode mode { get; set; }
/// <summary>
///  set the seed for the random mode (from -1 to UINT32_MAX) (default -1)
/// </summary>
public long seed { get; set; }
public string TimelineSupport { get; set; }
}
public enum ApermsFilterGenMode
{
[Name("none")] none,
[Name("ro")] ro,
[Name("rw")] rw,
[Name("toggle")] toggle,
[Name("random")] random,
}

}
