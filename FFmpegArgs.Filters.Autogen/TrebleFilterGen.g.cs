namespace FFmpegArgs.Filters.Autogens
{
public class TrebleFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal TrebleFilterGen(AudioMap input) : base("treble",input) { AddMapOut(); }
/// <summary>
///  set central frequency (from 0 to 999999) (default 3000)
/// </summary>
public TrebleFilterGen frequency(double frequency) => this.SetOptionRange("frequency", frequency,0,999999);
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public TrebleFilterGen width_type(TrebleFilterGenWidth_type width_type) => this.SetOption("width_type", width_type.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public TrebleFilterGen t(TrebleFilterGenT t) => this.SetOption("t", t.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set shelf transition steep (from 0 to 99999) (default 0.5)
/// </summary>
public TrebleFilterGen width(double width) => this.SetOptionRange("width", width,0,99999);
/// <summary>
///  set gain (from -900 to 900) (default 0)
/// </summary>
public TrebleFilterGen gain(double gain) => this.SetOptionRange("gain", gain,-900,900);
/// <summary>
///  set number of poles (from 1 to 2) (default 2)
/// </summary>
public TrebleFilterGen poles(int poles) => this.SetOptionRange("poles", poles,1,2);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public TrebleFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public TrebleFilterGen channels(ChannelLayout channels) => this.SetOption("channels",channels.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public TrebleFilterGen normalize(bool normalize) => this.SetOption("normalize",normalize.ToFFmpegFlag());
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public TrebleFilterGen transform(TrebleFilterGenTransform transform) => this.SetOption("transform", transform.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public TrebleFilterGen a(TrebleFilterGenA a) => this.SetOption("a", a.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public TrebleFilterGen precision(TrebleFilterGenPrecision precision) => this.SetOption("precision", precision.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public TrebleFilterGen r(TrebleFilterGenR r) => this.SetOption("r", r.GetEnumAttribute<NameAttribute>().Name);
}
public static class TrebleFilterGenExtensions
{
/// <summary>
/// Boost or cut upper frequencies.
/// </summary>
public static TrebleFilterGen TrebleFilterGen(this AudioMap input0) => new TrebleFilterGen(input0);
/// <summary>
/// Boost or cut upper frequencies.
/// </summary>
public static TrebleFilterGen TrebleFilterGen(this AudioMap input0,TrebleFilterGenConfig config)
{
var result = new TrebleFilterGen(input0);
if(config?.frequency != null) result.frequency(config.frequency.Value);
if(config?.width_type != null) result.width_type(config.width_type.Value);
if(config?.t != null) result.t(config.t.Value);
if(config?.width != null) result.width(config.width.Value);
if(config?.gain != null) result.gain(config.gain.Value);
if(config?.poles != null) result.poles(config.poles.Value);
if(config?.mix != null) result.mix(config.mix.Value);
if(config?.channels != null) result.channels(config.channels.Value);
if(config?.normalize != null) result.normalize(config.normalize.Value);
if(config?.transform != null) result.transform(config.transform.Value);
if(config?.a != null) result.a(config.a.Value);
if(config?.precision != null) result.precision(config.precision.Value);
if(config?.r != null) result.r(config.r.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class TrebleFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set central frequency (from 0 to 999999) (default 3000)
/// </summary>
public double? frequency { get; set; }
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public TrebleFilterGenWidth_type? width_type { get; set; }
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public TrebleFilterGenT? t { get; set; }
/// <summary>
///  set shelf transition steep (from 0 to 99999) (default 0.5)
/// </summary>
public double? width { get; set; }
/// <summary>
///  set gain (from -900 to 900) (default 0)
/// </summary>
public double? gain { get; set; }
/// <summary>
///  set number of poles (from 1 to 2) (default 2)
/// </summary>
public int? poles { get; set; }
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public double? mix { get; set; }
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public ChannelLayout? channels { get; set; }
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public bool? normalize { get; set; }
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public TrebleFilterGenTransform? transform { get; set; }
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public TrebleFilterGenA? a { get; set; }
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public TrebleFilterGenPrecision? precision { get; set; }
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public TrebleFilterGenR? r { get; set; }
public string TimelineSupport { get; set; }
}
public enum TrebleFilterGenWidth_type
{
[Name("h")] h,
[Name("q")] q,
[Name("o")] o,
[Name("s")] s,
[Name("k")] k,
}

public enum TrebleFilterGenT
{
[Name("h")] h,
[Name("q")] q,
[Name("o")] o,
[Name("s")] s,
[Name("k")] k,
}

public enum TrebleFilterGenTransform
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum TrebleFilterGenA
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum TrebleFilterGenPrecision
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

public enum TrebleFilterGenR
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

}
