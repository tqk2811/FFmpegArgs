namespace FFmpegArgs.Filters.Autogens
{
public class BandrejectFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal BandrejectFilterGen(AudioMap input) : base("bandreject",input) { AddMapOut(); }
/// <summary>
///  set central frequency (from 0 to 999999) (default 3000)
/// </summary>
public BandrejectFilterGen frequency(double frequency) => this.SetOptionRange("frequency", frequency,0,999999);
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public BandrejectFilterGen width_type(BandrejectFilterGenWidth_type width_type) => this.SetOption("width_type", width_type.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public BandrejectFilterGen t(BandrejectFilterGenT t) => this.SetOption("t", t.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set band-width (from 0 to 99999) (default 0.5)
/// </summary>
public BandrejectFilterGen width(double width) => this.SetOptionRange("width", width,0,99999);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public BandrejectFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set channels to filter (default 0xffffffffffffffff)
/// </summary>
public BandrejectFilterGen channels(ChannelLayout channels) => this.SetOption("channels",channels.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public BandrejectFilterGen normalize(bool normalize) => this.SetOption("normalize",normalize.ToFFmpegFlag());
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public BandrejectFilterGen transform(BandrejectFilterGenTransform transform) => this.SetOption("transform", transform.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public BandrejectFilterGen a(BandrejectFilterGenA a) => this.SetOption("a", a.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public BandrejectFilterGen precision(BandrejectFilterGenPrecision precision) => this.SetOption("precision", precision.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public BandrejectFilterGen r(BandrejectFilterGenR r) => this.SetOption("r", r.GetEnumAttribute<NameAttribute>().Name);
}
public static class BandrejectFilterGenExtensions
{
/// <summary>
/// Apply a two-pole Butterworth band-reject filter.
/// </summary>
public static BandrejectFilterGen BandrejectFilterGen(this AudioMap input0) => new BandrejectFilterGen(input0);
/// <summary>
/// Apply a two-pole Butterworth band-reject filter.
/// </summary>
public static BandrejectFilterGen BandrejectFilterGen(this AudioMap input0,BandrejectFilterGenConfig config)
{
var result = new BandrejectFilterGen(input0);
if(config?.frequency != null) result.frequency(config.frequency.Value);
if(config?.width_type != null) result.width_type(config.width_type.Value);
if(config?.t != null) result.t(config.t.Value);
if(config?.width != null) result.width(config.width.Value);
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
public class BandrejectFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set central frequency (from 0 to 999999) (default 3000)
/// </summary>
public double? frequency { get; set; }
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public BandrejectFilterGenWidth_type? width_type { get; set; }
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public BandrejectFilterGenT? t { get; set; }
/// <summary>
///  set band-width (from 0 to 99999) (default 0.5)
/// </summary>
public double? width { get; set; }
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
public BandrejectFilterGenTransform? transform { get; set; }
/// <summary>
///  set transform type (from 0 to 3) (default di)
/// </summary>
public BandrejectFilterGenA? a { get; set; }
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public BandrejectFilterGenPrecision? precision { get; set; }
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public BandrejectFilterGenR? r { get; set; }
public string TimelineSupport { get; set; }
}
public enum BandrejectFilterGenWidth_type
{
[Name("h")] h,
[Name("q")] q,
[Name("o")] o,
[Name("s")] s,
[Name("k")] k,
}

public enum BandrejectFilterGenT
{
[Name("h")] h,
[Name("q")] q,
[Name("o")] o,
[Name("s")] s,
[Name("k")] k,
}

public enum BandrejectFilterGenTransform
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum BandrejectFilterGenA
{
[Name("di")] di,
[Name("dii")] dii,
[Name("tdii")] tdii,
[Name("latt")] latt,
}

public enum BandrejectFilterGenPrecision
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

public enum BandrejectFilterGenR
{
[Name("auto")] auto,
[Name("s16")] s16,
[Name("s32")] s32,
[Name("f32")] f32,
[Name("f64")] f64,
}

}
