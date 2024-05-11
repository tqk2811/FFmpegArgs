namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// .S. aiir              A-&gt;N       Apply Infinite Impulse Response filter with supplied coefficients.
/// </summary>
public class AiirFilterGen : AudioToAudioFilter,ISliceThreading
{
internal AiirFilterGen(int outputCount, AudioMap input) : base("aiir",input) { AddMultiMapOut(outputCount); }
/// <summary>
///  set B/numerator/zeros/reflection coefficients (default &quot;1+0i 1-0i&quot;)
/// </summary>
public AiirFilterGen zeros(string zeros) => this.SetOption("zeros",zeros);
/// <summary>
///  set A/denominator/poles/ladder coefficients (default &quot;1+0i 1-0i&quot;)
/// </summary>
public AiirFilterGen poles(string poles) => this.SetOption("poles",poles);
/// <summary>
///  set channels gains (default &quot;1|1&quot;)
/// </summary>
public AiirFilterGen gains(string gains) => this.SetOption("gains",gains);
/// <summary>
///  set channels gains (default &quot;1|1&quot;)
/// </summary>
public AiirFilterGen k(string k) => this.SetOption("k",k);
/// <summary>
///  set dry gain (from 0 to 1) (default 1)
/// </summary>
public AiirFilterGen dry(double dry) => this.SetOptionRange("dry", dry,0,1);
/// <summary>
///  set wet gain (from 0 to 1) (default 1)
/// </summary>
public AiirFilterGen wet(double wet) => this.SetOptionRange("wet", wet,0,1);
/// <summary>
///  set coefficients format (from -2 to 4) (default zp)
/// </summary>
public AiirFilterGen format(AiirFilterGenFormat format) => this.SetOption("format", format.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set kind of processing (from 0 to 2) (default s)
/// </summary>
public AiirFilterGen process(AiirFilterGenProcess process) => this.SetOption("process", process.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set kind of processing (from 0 to 2) (default s)
/// </summary>
public AiirFilterGen r(AiirFilterGenR r) => this.SetOption("r", r.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set filtering precision (from 0 to 3) (default dbl)
/// </summary>
public AiirFilterGen precision(AiirFilterGenPrecision precision) => this.SetOption("precision", precision.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set precision (from 0 to 3) (default dbl)
/// </summary>
public AiirFilterGen e(AiirFilterGenE e) => this.SetOption("e", e.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  normalize coefficients (default true)
/// </summary>
public AiirFilterGen normalize(bool normalize) => this.SetOption("normalize",normalize.ToFFmpegFlag());
/// <summary>
///  set mix (from 0 to 1) (default 1)
/// </summary>
public AiirFilterGen mix(double mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  show IR frequency response (default false)
/// </summary>
public AiirFilterGen response(bool response) => this.SetOption("response",response.ToFFmpegFlag());
/// <summary>
///  set IR channel to display frequency response (from 0 to 1024) (default 0)
/// </summary>
public AiirFilterGen channel(int channel) => this.SetOptionRange("channel", channel,0,1024);
/// <summary>
///  set video size (default &quot;hd720&quot;)
/// </summary>
public AiirFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default &quot;25&quot;)
/// </summary>
public AiirFilterGen rate(Rational rate) => this.SetOption("rate",rate);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply Infinite Impulse Response filter with supplied coefficients.
/// </summary>
public static AiirFilterGen AiirFilterGen(this AudioMap input0, int outputCount) => new AiirFilterGen(outputCount, input0);
}
/// <summary>
///  set coefficients format (from -2 to 4) (default zp)
/// </summary>
public enum AiirFilterGenFormat
{
/// <summary>
/// ll              -2           ..F.A...... lattice-ladder function
/// </summary>
[Name("ll")] ll,
/// <summary>
/// sf              -1           ..F.A...... analog transfer function
/// </summary>
[Name("sf")] sf,
/// <summary>
/// tf              0            ..F.A...... digital transfer function
/// </summary>
[Name("tf")] tf,
/// <summary>
/// zp              1            ..F.A...... Z-plane zeros/poles
/// </summary>
[Name("zp")] zp,
/// <summary>
/// pr              2            ..F.A...... Z-plane zeros/poles (polar radians)
/// </summary>
[Name("pr")] pr,
/// <summary>
/// pd              3            ..F.A...... Z-plane zeros/poles (polar degrees)
/// </summary>
[Name("pd")] pd,
/// <summary>
/// sp              4            ..F.A...... S-plane zeros/poles
/// </summary>
[Name("sp")] sp,
}

/// <summary>
///  set kind of processing (from 0 to 2) (default s)
/// </summary>
public enum AiirFilterGenProcess
{
/// <summary>
/// d               0            ..F.A...... direct
/// </summary>
[Name("d")] d,
/// <summary>
/// s               1            ..F.A...... serial
/// </summary>
[Name("s")] s,
/// <summary>
/// p               2            ..F.A...... parallel
/// </summary>
[Name("p")] p,
}

/// <summary>
///  set kind of processing (from 0 to 2) (default s)
/// </summary>
public enum AiirFilterGenR
{
/// <summary>
/// d               0            ..F.A...... direct
/// </summary>
[Name("d")] d,
/// <summary>
/// s               1            ..F.A...... serial
/// </summary>
[Name("s")] s,
/// <summary>
/// p               2            ..F.A...... parallel
/// </summary>
[Name("p")] p,
}

/// <summary>
///  set filtering precision (from 0 to 3) (default dbl)
/// </summary>
public enum AiirFilterGenPrecision
{
/// <summary>
/// dbl             0            ..F.A...... double-precision floating-point
/// </summary>
[Name("dbl")] dbl,
/// <summary>
/// flt             1            ..F.A...... single-precision floating-point
/// </summary>
[Name("flt")] flt,
/// <summary>
/// i32             2            ..F.A...... 32-bit integers
/// </summary>
[Name("i32")] i32,
/// <summary>
/// i16             3            ..F.A...... 16-bit integers
/// </summary>
[Name("i16")] i16,
}

/// <summary>
///  set precision (from 0 to 3) (default dbl)
/// </summary>
public enum AiirFilterGenE
{
/// <summary>
/// dbl             0            ..F.A...... double-precision floating-point
/// </summary>
[Name("dbl")] dbl,
/// <summary>
/// flt             1            ..F.A...... single-precision floating-point
/// </summary>
[Name("flt")] flt,
/// <summary>
/// i32             2            ..F.A...... 32-bit integers
/// </summary>
[Name("i32")] i32,
/// <summary>
/// i16             3            ..F.A...... 16-bit integers
/// </summary>
[Name("i16")] i16,
}

}
