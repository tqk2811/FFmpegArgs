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
public class VolumeFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal VolumeFilterGen(AudioMap input) : base("volume",input) { AddMapOut(); }
/// <summary>
///  set volume adjustment expression (default "1.0")
/// </summary>
public VolumeFilterGen volume(string volume) => this.SetOption("volume",volume);
/// <summary>
///  select mathematical precision (from 0 to 2) (default float)
/// </summary>
public VolumeFilterGen precision(VolumeFilterGenPrecision precision) => this.SetOption("precision", precision.GetAttribute<NameAttribute>().Name);
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default once)
/// </summary>
public VolumeFilterGen eval(VolumeFilterGenEval eval) => this.SetOption("eval", eval.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Apply replaygain side data when present (from 0 to 3) (default drop)
/// </summary>
public VolumeFilterGen replaygain(VolumeFilterGenReplaygain replaygain) => this.SetOption("replaygain", replaygain.GetAttribute<NameAttribute>().Name);
/// <summary>
///  Apply replaygain pre-amplification (from -15 to 15) (default 0)
/// </summary>
public VolumeFilterGen replaygain_preamp(double replaygain_preamp) => this.SetOptionRange("replaygain_preamp", replaygain_preamp,-15,15);
/// <summary>
///  Apply replaygain clipping prevention (default true)
/// </summary>
public VolumeFilterGen replaygain_noclip(bool replaygain_noclip) => this.SetOption("replaygain_noclip",replaygain_noclip.ToFFmpegFlag());
}
public static class VolumeFilterGenExtensions
{
/// <summary>
/// Change input volume.
/// </summary>
public static VolumeFilterGen VolumeFilterGen(this AudioMap input0) => new VolumeFilterGen(input0);
/// <summary>
/// Change input volume.
/// </summary>
public static VolumeFilterGen VolumeFilterGen(this AudioMap input0,VolumeFilterGenConfig config)
{
var result = new VolumeFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.volume)) result.volume(config.volume);
if(config?.precision != null) result.precision(config.precision.Value);
if(config?.eval != null) result.eval(config.eval.Value);
if(config?.replaygain != null) result.replaygain(config.replaygain.Value);
if(config?.replaygain_preamp != null) result.replaygain_preamp(config.replaygain_preamp.Value);
if(config?.replaygain_noclip != null) result.replaygain_noclip(config.replaygain_noclip.Value);
if(config?.TimelineSupport != null) result.Enable(config.TimelineSupport);
return result;
}
}
public class VolumeFilterGenConfig
{
/// <summary>
///  set volume adjustment expression (default "1.0")
/// </summary>
public string volume { get; set; }
/// <summary>
///  select mathematical precision (from 0 to 2) (default float)
/// </summary>
public VolumeFilterGenPrecision? precision { get; set; }
/// <summary>
///  specify when to evaluate expressions (from 0 to 1) (default once)
/// </summary>
public VolumeFilterGenEval? eval { get; set; }
/// <summary>
///  Apply replaygain side data when present (from 0 to 3) (default drop)
/// </summary>
public VolumeFilterGenReplaygain? replaygain { get; set; }
/// <summary>
///  Apply replaygain pre-amplification (from -15 to 15) (default 0)
/// </summary>
public double? replaygain_preamp { get; set; }
/// <summary>
///  Apply replaygain clipping prevention (default true)
/// </summary>
public bool? replaygain_noclip { get; set; }
public string TimelineSupport { get; set; }
}
public enum VolumeFilterGenPrecision
{
[Name("fixed")] _fixed,
[Name("float")] _float,
[Name("double")] _double,
}

public enum VolumeFilterGenEval
{
[Name("once")] once,
[Name("frame")] frame,
}

public enum VolumeFilterGenReplaygain
{
[Name("drop")] drop,
[Name("ignore")] ignore,
[Name("track")] track,
[Name("album")] album,
}

}
