namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC biquad            A->A       Apply a biquad IIR filter with the given coefficients.
/// </summary>
public class BiquadFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal BiquadFilterGen(AudioMap input) : base("biquad",input) { AddMapOut(); }
/// <summary>
///  (from INT_MIN to INT_MAX) (default 1)
/// </summary>
public BiquadFilterGen a0(double a0) => this.SetOptionRange("a0", a0,INT_MIN,INT_MAX);
/// <summary>
///  (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public BiquadFilterGen a1(double a1) => this.SetOptionRange("a1", a1,INT_MIN,INT_MAX);
/// <summary>
///  (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public BiquadFilterGen a2(double a2) => this.SetOptionRange("a2", a2,INT_MIN,INT_MAX);
/// <summary>
///  (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public BiquadFilterGen b0(double b0) => this.SetOptionRange("b0", b0,INT_MIN,INT_MAX);
/// <summary>
///  (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public BiquadFilterGen b1(double b1) => this.SetOptionRange("b1", b1,INT_MIN,INT_MAX);
/// <summary>
///  (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public BiquadFilterGen b2(double b2) => this.SetOptionRange("b2", b2,INT_MIN,INT_MAX);
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public BiquadFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set channels to filter (default "all")
/// </summary>
public BiquadFilterGen channels(string channels) => this.SetOption("channels",channels);
/// <summary>
///  normalize coefficients (default false)
/// </summary>
public BiquadFilterGen normalize(bool normalize) => this.SetOption("normalize",normalize.ToFFmpegFlag());
/// <summary>
///  set transform type (from 0 to 6) (default di)
/// </summary>
public BiquadFilterGen transform(BiquadFilterGenTransform transform) => this.SetOption("transform", transform.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set transform type (from 0 to 6) (default di)
/// </summary>
public BiquadFilterGen a(BiquadFilterGenA a) => this.SetOption("a", a.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public BiquadFilterGen precision(BiquadFilterGenPrecision precision) => this.SetOption("precision", precision.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from -1 to 3) (default auto)
/// </summary>
public BiquadFilterGen r(BiquadFilterGenR r) => this.SetOption("r", r.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set the block size (from 0 to 32768) (default 0)
/// </summary>
public BiquadFilterGen blocksize(int blocksize) => this.SetOptionRange("blocksize", blocksize,0,32768);
}
/// <summary>
/// </summary>
public static class BiquadFilterGenExtensions
{
/// <summary>
/// Apply a biquad IIR filter with the given coefficients.
/// </summary>
public static BiquadFilterGen BiquadFilterGen(this AudioMap input0) => new BiquadFilterGen(input0);
}
/// <summary>
///  set transform type (from 0 to 6) (default di)
/// </summary>
public enum BiquadFilterGenTransform
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
public enum BiquadFilterGenA
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
public enum BiquadFilterGenPrecision
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
public enum BiquadFilterGenR
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
