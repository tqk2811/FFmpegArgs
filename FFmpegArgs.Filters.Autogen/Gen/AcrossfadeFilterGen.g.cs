namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... acrossfade        AA->A      Cross fade two input audio streams.
/// </summary>
public class AcrossfadeFilterGen : AudioToAudioFilter
{
internal AcrossfadeFilterGen(params AudioMap[] inputs) : base("acrossfade",inputs) { AddMapOut(); }
/// <summary>
///  set number of samples for cross fade duration (from 1 to 2.14748e+08) (default 44100)
/// </summary>
public AcrossfadeFilterGen nb_samples(int nb_samples) => this.SetOptionRange("nb_samples", nb_samples,1,2.14748e+08);
/// <summary>
///  set number of samples for cross fade duration (from 1 to 2.14748e+08) (default 44100)
/// </summary>
public AcrossfadeFilterGen ns(int ns) => this.SetOptionRange("ns", ns,1,2.14748e+08);
/// <summary>
///  set cross fade duration (default 0)
/// </summary>
public AcrossfadeFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  overlap 1st stream end with 2nd stream start (default true)
/// </summary>
public AcrossfadeFilterGen overlap(bool overlap) => this.SetOption("overlap",overlap.ToFFmpegFlag());
/// <summary>
///  set fade curve type for 1st stream (from -1 to 22) (default tri)
/// </summary>
public AcrossfadeFilterGen curve1(AcrossfadeFilterGenCurve1 curve1) => this.SetOption("curve1", curve1.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set fade curve type for 1st stream (from -1 to 22) (default tri)
/// </summary>
public AcrossfadeFilterGen c1(AcrossfadeFilterGenC1 c1) => this.SetOption("c1", c1.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set fade curve type for 2nd stream (from -1 to 22) (default tri)
/// </summary>
public AcrossfadeFilterGen curve2(AcrossfadeFilterGenCurve2 curve2) => this.SetOption("curve2", curve2.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set fade curve type for 2nd stream (from -1 to 22) (default tri)
/// </summary>
public AcrossfadeFilterGen c2(AcrossfadeFilterGenC2 c2) => this.SetOption("c2", c2.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class AcrossfadeFilterGenExtensions
{
/// <summary>
/// Cross fade two input audio streams.
/// </summary>
public static AcrossfadeFilterGen AcrossfadeFilterGen(this AudioMap input0, AudioMap input1) => new AcrossfadeFilterGen(input0, input1);
}
/// <summary>
///  set fade curve type for 1st stream (from -1 to 22) (default tri)
/// </summary>
public enum AcrossfadeFilterGenCurve1
{
/// <summary>
/// nofade          -1           ..F.A...... no fade; keep audio as-is
/// </summary>
[Name("nofade")] nofade,
/// <summary>
/// tri             0            ..F.A...... linear slope
/// </summary>
[Name("tri")] tri,
/// <summary>
/// qsin            1            ..F.A...... quarter of sine wave
/// </summary>
[Name("qsin")] qsin,
/// <summary>
/// esin            2            ..F.A...... exponential sine wave
/// </summary>
[Name("esin")] esin,
/// <summary>
/// hsin            3            ..F.A...... half of sine wave
/// </summary>
[Name("hsin")] hsin,
/// <summary>
/// log             4            ..F.A...... logarithmic
/// </summary>
[Name("log")] log,
/// <summary>
/// ipar            5            ..F.A...... inverted parabola
/// </summary>
[Name("ipar")] ipar,
/// <summary>
/// qua             6            ..F.A...... quadratic
/// </summary>
[Name("qua")] qua,
/// <summary>
/// cub             7            ..F.A...... cubic
/// </summary>
[Name("cub")] cub,
/// <summary>
/// squ             8            ..F.A...... square root
/// </summary>
[Name("squ")] squ,
/// <summary>
/// cbr             9            ..F.A...... cubic root
/// </summary>
[Name("cbr")] cbr,
/// <summary>
/// par             10           ..F.A...... parabola
/// </summary>
[Name("par")] par,
/// <summary>
/// exp             11           ..F.A...... exponential
/// </summary>
[Name("exp")] exp,
/// <summary>
/// iqsin           12           ..F.A...... inverted quarter of sine wave
/// </summary>
[Name("iqsin")] iqsin,
/// <summary>
/// ihsin           13           ..F.A...... inverted half of sine wave
/// </summary>
[Name("ihsin")] ihsin,
/// <summary>
/// dese            14           ..F.A...... double-exponential seat
/// </summary>
[Name("dese")] dese,
/// <summary>
/// desi            15           ..F.A...... double-exponential sigmoid
/// </summary>
[Name("desi")] desi,
/// <summary>
/// losi            16           ..F.A...... logistic sigmoid
/// </summary>
[Name("losi")] losi,
/// <summary>
/// sinc            17           ..F.A...... sine cardinal function
/// </summary>
[Name("sinc")] sinc,
/// <summary>
/// isinc           18           ..F.A...... inverted sine cardinal function
/// </summary>
[Name("isinc")] isinc,
/// <summary>
/// quat            19           ..F.A...... quartic
/// </summary>
[Name("quat")] quat,
/// <summary>
/// quatr           20           ..F.A...... quartic root
/// </summary>
[Name("quatr")] quatr,
/// <summary>
/// qsin2           21           ..F.A...... squared quarter of sine wave
/// </summary>
[Name("qsin2")] qsin2,
/// <summary>
/// hsin2           22           ..F.A...... squared half of sine wave
/// </summary>
[Name("hsin2")] hsin2,
}

/// <summary>
///  set fade curve type for 1st stream (from -1 to 22) (default tri)
/// </summary>
public enum AcrossfadeFilterGenC1
{
/// <summary>
/// nofade          -1           ..F.A...... no fade; keep audio as-is
/// </summary>
[Name("nofade")] nofade,
/// <summary>
/// tri             0            ..F.A...... linear slope
/// </summary>
[Name("tri")] tri,
/// <summary>
/// qsin            1            ..F.A...... quarter of sine wave
/// </summary>
[Name("qsin")] qsin,
/// <summary>
/// esin            2            ..F.A...... exponential sine wave
/// </summary>
[Name("esin")] esin,
/// <summary>
/// hsin            3            ..F.A...... half of sine wave
/// </summary>
[Name("hsin")] hsin,
/// <summary>
/// log             4            ..F.A...... logarithmic
/// </summary>
[Name("log")] log,
/// <summary>
/// ipar            5            ..F.A...... inverted parabola
/// </summary>
[Name("ipar")] ipar,
/// <summary>
/// qua             6            ..F.A...... quadratic
/// </summary>
[Name("qua")] qua,
/// <summary>
/// cub             7            ..F.A...... cubic
/// </summary>
[Name("cub")] cub,
/// <summary>
/// squ             8            ..F.A...... square root
/// </summary>
[Name("squ")] squ,
/// <summary>
/// cbr             9            ..F.A...... cubic root
/// </summary>
[Name("cbr")] cbr,
/// <summary>
/// par             10           ..F.A...... parabola
/// </summary>
[Name("par")] par,
/// <summary>
/// exp             11           ..F.A...... exponential
/// </summary>
[Name("exp")] exp,
/// <summary>
/// iqsin           12           ..F.A...... inverted quarter of sine wave
/// </summary>
[Name("iqsin")] iqsin,
/// <summary>
/// ihsin           13           ..F.A...... inverted half of sine wave
/// </summary>
[Name("ihsin")] ihsin,
/// <summary>
/// dese            14           ..F.A...... double-exponential seat
/// </summary>
[Name("dese")] dese,
/// <summary>
/// desi            15           ..F.A...... double-exponential sigmoid
/// </summary>
[Name("desi")] desi,
/// <summary>
/// losi            16           ..F.A...... logistic sigmoid
/// </summary>
[Name("losi")] losi,
/// <summary>
/// sinc            17           ..F.A...... sine cardinal function
/// </summary>
[Name("sinc")] sinc,
/// <summary>
/// isinc           18           ..F.A...... inverted sine cardinal function
/// </summary>
[Name("isinc")] isinc,
/// <summary>
/// quat            19           ..F.A...... quartic
/// </summary>
[Name("quat")] quat,
/// <summary>
/// quatr           20           ..F.A...... quartic root
/// </summary>
[Name("quatr")] quatr,
/// <summary>
/// qsin2           21           ..F.A...... squared quarter of sine wave
/// </summary>
[Name("qsin2")] qsin2,
/// <summary>
/// hsin2           22           ..F.A...... squared half of sine wave
/// </summary>
[Name("hsin2")] hsin2,
}

/// <summary>
///  set fade curve type for 2nd stream (from -1 to 22) (default tri)
/// </summary>
public enum AcrossfadeFilterGenCurve2
{
/// <summary>
/// nofade          -1           ..F.A...... no fade; keep audio as-is
/// </summary>
[Name("nofade")] nofade,
/// <summary>
/// tri             0            ..F.A...... linear slope
/// </summary>
[Name("tri")] tri,
/// <summary>
/// qsin            1            ..F.A...... quarter of sine wave
/// </summary>
[Name("qsin")] qsin,
/// <summary>
/// esin            2            ..F.A...... exponential sine wave
/// </summary>
[Name("esin")] esin,
/// <summary>
/// hsin            3            ..F.A...... half of sine wave
/// </summary>
[Name("hsin")] hsin,
/// <summary>
/// log             4            ..F.A...... logarithmic
/// </summary>
[Name("log")] log,
/// <summary>
/// ipar            5            ..F.A...... inverted parabola
/// </summary>
[Name("ipar")] ipar,
/// <summary>
/// qua             6            ..F.A...... quadratic
/// </summary>
[Name("qua")] qua,
/// <summary>
/// cub             7            ..F.A...... cubic
/// </summary>
[Name("cub")] cub,
/// <summary>
/// squ             8            ..F.A...... square root
/// </summary>
[Name("squ")] squ,
/// <summary>
/// cbr             9            ..F.A...... cubic root
/// </summary>
[Name("cbr")] cbr,
/// <summary>
/// par             10           ..F.A...... parabola
/// </summary>
[Name("par")] par,
/// <summary>
/// exp             11           ..F.A...... exponential
/// </summary>
[Name("exp")] exp,
/// <summary>
/// iqsin           12           ..F.A...... inverted quarter of sine wave
/// </summary>
[Name("iqsin")] iqsin,
/// <summary>
/// ihsin           13           ..F.A...... inverted half of sine wave
/// </summary>
[Name("ihsin")] ihsin,
/// <summary>
/// dese            14           ..F.A...... double-exponential seat
/// </summary>
[Name("dese")] dese,
/// <summary>
/// desi            15           ..F.A...... double-exponential sigmoid
/// </summary>
[Name("desi")] desi,
/// <summary>
/// losi            16           ..F.A...... logistic sigmoid
/// </summary>
[Name("losi")] losi,
/// <summary>
/// sinc            17           ..F.A...... sine cardinal function
/// </summary>
[Name("sinc")] sinc,
/// <summary>
/// isinc           18           ..F.A...... inverted sine cardinal function
/// </summary>
[Name("isinc")] isinc,
/// <summary>
/// quat            19           ..F.A...... quartic
/// </summary>
[Name("quat")] quat,
/// <summary>
/// quatr           20           ..F.A...... quartic root
/// </summary>
[Name("quatr")] quatr,
/// <summary>
/// qsin2           21           ..F.A...... squared quarter of sine wave
/// </summary>
[Name("qsin2")] qsin2,
/// <summary>
/// hsin2           22           ..F.A...... squared half of sine wave
/// </summary>
[Name("hsin2")] hsin2,
}

/// <summary>
///  set fade curve type for 2nd stream (from -1 to 22) (default tri)
/// </summary>
public enum AcrossfadeFilterGenC2
{
/// <summary>
/// nofade          -1           ..F.A...... no fade; keep audio as-is
/// </summary>
[Name("nofade")] nofade,
/// <summary>
/// tri             0            ..F.A...... linear slope
/// </summary>
[Name("tri")] tri,
/// <summary>
/// qsin            1            ..F.A...... quarter of sine wave
/// </summary>
[Name("qsin")] qsin,
/// <summary>
/// esin            2            ..F.A...... exponential sine wave
/// </summary>
[Name("esin")] esin,
/// <summary>
/// hsin            3            ..F.A...... half of sine wave
/// </summary>
[Name("hsin")] hsin,
/// <summary>
/// log             4            ..F.A...... logarithmic
/// </summary>
[Name("log")] log,
/// <summary>
/// ipar            5            ..F.A...... inverted parabola
/// </summary>
[Name("ipar")] ipar,
/// <summary>
/// qua             6            ..F.A...... quadratic
/// </summary>
[Name("qua")] qua,
/// <summary>
/// cub             7            ..F.A...... cubic
/// </summary>
[Name("cub")] cub,
/// <summary>
/// squ             8            ..F.A...... square root
/// </summary>
[Name("squ")] squ,
/// <summary>
/// cbr             9            ..F.A...... cubic root
/// </summary>
[Name("cbr")] cbr,
/// <summary>
/// par             10           ..F.A...... parabola
/// </summary>
[Name("par")] par,
/// <summary>
/// exp             11           ..F.A...... exponential
/// </summary>
[Name("exp")] exp,
/// <summary>
/// iqsin           12           ..F.A...... inverted quarter of sine wave
/// </summary>
[Name("iqsin")] iqsin,
/// <summary>
/// ihsin           13           ..F.A...... inverted half of sine wave
/// </summary>
[Name("ihsin")] ihsin,
/// <summary>
/// dese            14           ..F.A...... double-exponential seat
/// </summary>
[Name("dese")] dese,
/// <summary>
/// desi            15           ..F.A...... double-exponential sigmoid
/// </summary>
[Name("desi")] desi,
/// <summary>
/// losi            16           ..F.A...... logistic sigmoid
/// </summary>
[Name("losi")] losi,
/// <summary>
/// sinc            17           ..F.A...... sine cardinal function
/// </summary>
[Name("sinc")] sinc,
/// <summary>
/// isinc           18           ..F.A...... inverted sine cardinal function
/// </summary>
[Name("isinc")] isinc,
/// <summary>
/// quat            19           ..F.A...... quartic
/// </summary>
[Name("quat")] quat,
/// <summary>
/// quatr           20           ..F.A...... quartic root
/// </summary>
[Name("quatr")] quatr,
/// <summary>
/// qsin2           21           ..F.A...... squared quarter of sine wave
/// </summary>
[Name("qsin2")] qsin2,
/// <summary>
/// hsin2           22           ..F.A...... squared half of sine wave
/// </summary>
[Name("hsin2")] hsin2,
}

}
