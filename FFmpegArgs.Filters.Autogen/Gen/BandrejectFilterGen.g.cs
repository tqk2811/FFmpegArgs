namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC bandreject        A->A       Apply a two-pole Butterworth band-reject filter.
/// </summary>
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
///  set transform type (from 0 to 4) (default di)
/// </summary>
public BandrejectFilterGen transform(BandrejectFilterGenTransform transform) => this.SetOption("transform", transform.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set transform type (from 0 to 4) (default di)
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
/// <summary>
/// </summary>
public static class BandrejectFilterGenExtensions
{
/// <summary>
/// Apply a two-pole Butterworth band-reject filter.
/// </summary>
public static BandrejectFilterGen BandrejectFilterGen(this AudioMap input0) => new BandrejectFilterGen(input0);
}
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public enum BandrejectFilterGenWidth_type
{
/// <summary>
/// h               1            ..F.A....T. Hz
/// </summary>
[Name("h")] h,
/// <summary>
/// q               3            ..F.A....T. Q-Factor
/// </summary>
[Name("q")] q,
/// <summary>
/// o               2            ..F.A....T. octave
/// </summary>
[Name("o")] o,
/// <summary>
/// s               4            ..F.A....T. slope
/// </summary>
[Name("s")] s,
/// <summary>
/// k               5            ..F.A....T. kHz
/// </summary>
[Name("k")] k,
}

/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public enum BandrejectFilterGenT
{
/// <summary>
/// h               1            ..F.A....T. Hz
/// </summary>
[Name("h")] h,
/// <summary>
/// q               3            ..F.A....T. Q-Factor
/// </summary>
[Name("q")] q,
/// <summary>
/// o               2            ..F.A....T. octave
/// </summary>
[Name("o")] o,
/// <summary>
/// s               4            ..F.A....T. slope
/// </summary>
[Name("s")] s,
/// <summary>
/// k               5            ..F.A....T. kHz
/// </summary>
[Name("k")] k,
}

/// <summary>
///  set transform type (from 0 to 4) (default di)
/// </summary>
public enum BandrejectFilterGenTransform
{
/// <summary>
/// di              0            ..F.A...... direct form I
/// </summary>
[Name("di")] di,
/// <summary>
/// dii             1            ..F.A...... direct form II
/// </summary>
[Name("dii")] dii,
/// <summary>
/// tdii            2            ..F.A...... transposed direct form II
/// </summary>
[Name("tdii")] tdii,
/// <summary>
/// latt            3            ..F.A...... lattice-ladder form
/// </summary>
[Name("latt")] latt,
/// <summary>
/// svf             4            ..F.A...... state variable filter form
/// </summary>
[Name("svf")] svf,
}

/// <summary>
///  set transform type (from 0 to 4) (default di)
/// </summary>
public enum BandrejectFilterGenA
{
/// <summary>
/// di              0            ..F.A...... direct form I
/// </summary>
[Name("di")] di,
/// <summary>
/// dii             1            ..F.A...... direct form II
/// </summary>
[Name("dii")] dii,
/// <summary>
/// tdii            2            ..F.A...... transposed direct form II
/// </summary>
[Name("tdii")] tdii,
/// <summary>
/// latt            3            ..F.A...... lattice-ladder form
/// </summary>
[Name("latt")] latt,
/// <summary>
/// svf             4            ..F.A...... state variable filter form
/// </summary>
[Name("svf")] svf,
}

/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public enum BandrejectFilterGenPrecision
{
/// <summary>
/// auto            -1           ..F.A...... automatic
/// </summary>
[Name("auto")] auto,
/// <summary>
/// s16             0            ..F.A...... signed 16-bit
/// </summary>
[Name("s16")] s16,
/// <summary>
/// s32             1            ..F.A...... signed 32-bit
/// </summary>
[Name("s32")] s32,
/// <summary>
/// f32             2            ..F.A...... floating-point single
/// </summary>
[Name("f32")] f32,
/// <summary>
/// f64             3            ..F.A...... floating-point double
/// </summary>
[Name("f64")] f64,
}

/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public enum BandrejectFilterGenR
{
/// <summary>
/// auto            -1           ..F.A...... automatic
/// </summary>
[Name("auto")] auto,
/// <summary>
/// s16             0            ..F.A...... signed 16-bit
/// </summary>
[Name("s16")] s16,
/// <summary>
/// s32             1            ..F.A...... signed 32-bit
/// </summary>
[Name("s32")] s32,
/// <summary>
/// f32             2            ..F.A...... floating-point single
/// </summary>
[Name("f32")] f32,
/// <summary>
/// f64             3            ..F.A...... floating-point double
/// </summary>
[Name("f64")] f64,
}

}
