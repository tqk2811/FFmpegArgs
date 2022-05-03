namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.C afade             A->A       Fade in/out input audio.
/// </summary>
public class AfadeFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal AfadeFilterGen(AudioMap input) : base("afade",input) { AddMapOut(); }
/// <summary>
///  set the fade direction (from 0 to 1) (default in)
/// </summary>
public AfadeFilterGen type(AfadeFilterGenType type) => this.SetOption("type", type.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set number of first sample to start fading (from 0 to I64_MAX) (default 0)
/// </summary>
public AfadeFilterGen start_sample(long start_sample) => this.SetOptionRange("start_sample", start_sample,0,I64_MAX);
/// <summary>
///  set number of first sample to start fading (from 0 to I64_MAX) (default 0)
/// </summary>
public AfadeFilterGen ss(long ss) => this.SetOptionRange("ss", ss,0,I64_MAX);
/// <summary>
///  set number of samples for fade duration (from 1 to I64_MAX) (default 44100)
/// </summary>
public AfadeFilterGen nb_samples(long nb_samples) => this.SetOptionRange("nb_samples", nb_samples,1,I64_MAX);
/// <summary>
///  set number of samples for fade duration (from 1 to I64_MAX) (default 44100)
/// </summary>
public AfadeFilterGen ns(long ns) => this.SetOptionRange("ns", ns,1,I64_MAX);
/// <summary>
///  set time to start fading (default 0)
/// </summary>
public AfadeFilterGen start_time(TimeSpan start_time) => this.SetOptionRange("start_time",start_time,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set fade duration (default 0)
/// </summary>
public AfadeFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set fade curve type (from -1 to 18) (default tri)
/// </summary>
public AfadeFilterGen curve(AfadeFilterGenCurve curve) => this.SetOption("curve", curve.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class AfadeFilterGenExtensions
{
/// <summary>
/// Fade in/out input audio.
/// </summary>
public static AfadeFilterGen AfadeFilterGen(this AudioMap input0) => new AfadeFilterGen(input0);
}
/// <summary>
///  set the fade direction (from 0 to 1) (default in)
/// </summary>
public enum AfadeFilterGenType
{
/// <summary>
/// in              0            ..F.A....T. fade-in
/// </summary>
[Name("in")] _in,
/// <summary>
/// out             1            ..F.A....T. fade-out
/// </summary>
[Name("out")] _out,
}

/// <summary>
///  set fade curve type (from -1 to 18) (default tri)
/// </summary>
public enum AfadeFilterGenCurve
{
/// <summary>
/// nofade          -1           ..F.A....T. no fade; keep audio as-is
/// </summary>
[Name("nofade")] nofade,
/// <summary>
/// tri             0            ..F.A....T. linear slope
/// </summary>
[Name("tri")] tri,
/// <summary>
/// qsin            1            ..F.A....T. quarter of sine wave
/// </summary>
[Name("qsin")] qsin,
/// <summary>
/// esin            2            ..F.A....T. exponential sine wave
/// </summary>
[Name("esin")] esin,
/// <summary>
/// hsin            3            ..F.A....T. half of sine wave
/// </summary>
[Name("hsin")] hsin,
/// <summary>
/// log             4            ..F.A....T. logarithmic
/// </summary>
[Name("log")] log,
/// <summary>
/// ipar            5            ..F.A....T. inverted parabola
/// </summary>
[Name("ipar")] ipar,
/// <summary>
/// qua             6            ..F.A....T. quadratic
/// </summary>
[Name("qua")] qua,
/// <summary>
/// cub             7            ..F.A....T. cubic
/// </summary>
[Name("cub")] cub,
/// <summary>
/// squ             8            ..F.A....T. square root
/// </summary>
[Name("squ")] squ,
/// <summary>
/// cbr             9            ..F.A....T. cubic root
/// </summary>
[Name("cbr")] cbr,
/// <summary>
/// par             10           ..F.A....T. parabola
/// </summary>
[Name("par")] par,
/// <summary>
/// exp             11           ..F.A....T. exponential
/// </summary>
[Name("exp")] exp,
/// <summary>
/// iqsin           12           ..F.A....T. inverted quarter of sine wave
/// </summary>
[Name("iqsin")] iqsin,
/// <summary>
/// ihsin           13           ..F.A....T. inverted half of sine wave
/// </summary>
[Name("ihsin")] ihsin,
/// <summary>
/// dese            14           ..F.A....T. double-exponential seat
/// </summary>
[Name("dese")] dese,
/// <summary>
/// desi            15           ..F.A....T. double-exponential sigmoid
/// </summary>
[Name("desi")] desi,
/// <summary>
/// losi            16           ..F.A....T. logistic sigmoid
/// </summary>
[Name("losi")] losi,
/// <summary>
/// sinc            17           ..F.A....T. sine cardinal function
/// </summary>
[Name("sinc")] sinc,
/// <summary>
/// isinc           18           ..F.A....T. inverted sine cardinal function
/// </summary>
[Name("isinc")] isinc,
}

}
