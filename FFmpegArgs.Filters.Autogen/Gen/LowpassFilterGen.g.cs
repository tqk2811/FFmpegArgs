namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC lowpass           A->A       Apply a low-pass filter with 3dB point frequency.
/// </summary>
public class LowpassFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal LowpassFilterGen(AudioMap input) : base("lowpass",input) { AddMapOut(); }
/// <summary>
///  set frequency (from 0 to 999999) (default 500)
/// </summary>
public LowpassFilterGen frequency(double frequency) => this.SetOptionRange("frequency", frequency,0,999999);
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public LowpassFilterGen width_type(LowpassFilterGenWidth_type width_type) => this.SetOption("width_type", width_type.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public LowpassFilterGen t(LowpassFilterGenT t) => this.SetOption("t", t.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set width (from 0 to 99999) (default 0.707)
/// </summary>
public LowpassFilterGen width(double width) => this.SetOptionRange("width", width,0,99999);
/// <summary>
///  set number of poles (from 1 to 2) (default 2)
/// </summary>
public LowpassFilterGen poles(int poles) => this.SetOptionRange("poles", poles,1,2);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public LowpassFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set channels to filter (default "all")
/// </summary>
public LowpassFilterGen channels(string channels) => this.SetOption("channels",channels);
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public LowpassFilterGen normalize(bool normalize) => this.SetOption("normalize",normalize.ToFFmpegFlag());
/// <summary>
///  set transform type (from 0 to 6) (default di)
/// </summary>
public LowpassFilterGen transform(LowpassFilterGenTransform transform) => this.SetOption("transform", transform.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set transform type (from 0 to 6) (default di)
/// </summary>
public LowpassFilterGen a(LowpassFilterGenA a) => this.SetOption("a", a.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public LowpassFilterGen precision(LowpassFilterGenPrecision precision) => this.SetOption("precision", precision.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public LowpassFilterGen r(LowpassFilterGenR r) => this.SetOption("r", r.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set the block size (from 0 to 32768) (default 0)
/// </summary>
public LowpassFilterGen blocksize(int blocksize) => this.SetOptionRange("blocksize", blocksize,0,32768);
}
/// <summary>
/// </summary>
public static class LowpassFilterGenExtensions
{
/// <summary>
/// Apply a low-pass filter with 3dB point frequency.
/// </summary>
public static LowpassFilterGen LowpassFilterGen(this AudioMap input0) => new LowpassFilterGen(input0);
}
/// <summary>
///  set filter-width type (from 1 to 5) (default q)
/// </summary>
public enum LowpassFilterGenWidth_type
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
public enum LowpassFilterGenT
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
///  set transform type (from 0 to 6) (default di)
/// </summary>
public enum LowpassFilterGenTransform
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
/// tdi             2            ..F.A...... transposed direct form I
/// </summary>
[Name("tdi")] tdi,
/// <summary>
/// tdii            3            ..F.A...... transposed direct form II
/// </summary>
[Name("tdii")] tdii,
/// <summary>
/// latt            4            ..F.A...... lattice-ladder form
/// </summary>
[Name("latt")] latt,
/// <summary>
/// svf             5            ..F.A...... state variable filter form
/// </summary>
[Name("svf")] svf,
/// <summary>
/// zdf             6            ..F.A...... zero-delay filter form
/// </summary>
[Name("zdf")] zdf,
}

/// <summary>
///  set transform type (from 0 to 6) (default di)
/// </summary>
public enum LowpassFilterGenA
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
/// tdi             2            ..F.A...... transposed direct form I
/// </summary>
[Name("tdi")] tdi,
/// <summary>
/// tdii            3            ..F.A...... transposed direct form II
/// </summary>
[Name("tdii")] tdii,
/// <summary>
/// latt            4            ..F.A...... lattice-ladder form
/// </summary>
[Name("latt")] latt,
/// <summary>
/// svf             5            ..F.A...... state variable filter form
/// </summary>
[Name("svf")] svf,
/// <summary>
/// zdf             6            ..F.A...... zero-delay filter form
/// </summary>
[Name("zdf")] zdf,
}

/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public enum LowpassFilterGenPrecision
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
public enum LowpassFilterGenR
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
