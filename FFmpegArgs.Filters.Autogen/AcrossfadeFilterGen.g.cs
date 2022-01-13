namespace FFmpegArgs.Filters.Autogens
{
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
///  set fade curve type for 1st stream (from -1 to 18) (default tri)
/// </summary>
public AcrossfadeFilterGen curve1(AcrossfadeFilterGenCurve1 curve1) => this.SetOption("curve1", curve1.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set fade curve type for 1st stream (from -1 to 18) (default tri)
/// </summary>
public AcrossfadeFilterGen c1(AcrossfadeFilterGenC1 c1) => this.SetOption("c1", c1.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set fade curve type for 2nd stream (from -1 to 18) (default tri)
/// </summary>
public AcrossfadeFilterGen curve2(AcrossfadeFilterGenCurve2 curve2) => this.SetOption("curve2", curve2.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set fade curve type for 2nd stream (from -1 to 18) (default tri)
/// </summary>
public AcrossfadeFilterGen c2(AcrossfadeFilterGenC2 c2) => this.SetOption("c2", c2.GetEnumAttribute<NameAttribute>().Name);
}
public static class AcrossfadeFilterGenExtensions
{
/// <summary>
/// Cross fade two input audio streams.
/// </summary>
public static AcrossfadeFilterGen AcrossfadeFilterGen(this AudioMap input0, AudioMap input1) => new AcrossfadeFilterGen(input0, input1);
/// <summary>
/// Cross fade two input audio streams.
/// </summary>
public static AcrossfadeFilterGen AcrossfadeFilterGen(this AudioMap input0, AudioMap input1,AcrossfadeFilterGenConfig config)
{
var result = new AcrossfadeFilterGen(input0, input1);
if(config?.nb_samples != null) result.nb_samples(config.nb_samples.Value);
if(config?.ns != null) result.ns(config.ns.Value);
if(config?.duration != null) result.duration(config.duration.Value);
if(config?.overlap != null) result.overlap(config.overlap.Value);
if(config?.curve1 != null) result.curve1(config.curve1.Value);
if(config?.c1 != null) result.c1(config.c1.Value);
if(config?.curve2 != null) result.curve2(config.curve2.Value);
if(config?.c2 != null) result.c2(config.c2.Value);
return result;
}
}
public class AcrossfadeFilterGenConfig
{
/// <summary>
///  set number of samples for cross fade duration (from 1 to 2.14748e+08) (default 44100)
/// </summary>
public int? nb_samples { get; set; }
/// <summary>
///  set number of samples for cross fade duration (from 1 to 2.14748e+08) (default 44100)
/// </summary>
public int? ns { get; set; }
/// <summary>
///  set cross fade duration (default 0)
/// </summary>
public TimeSpan? duration { get; set; }
/// <summary>
///  overlap 1st stream end with 2nd stream start (default true)
/// </summary>
public bool? overlap { get; set; }
/// <summary>
///  set fade curve type for 1st stream (from -1 to 18) (default tri)
/// </summary>
public AcrossfadeFilterGenCurve1? curve1 { get; set; }
/// <summary>
///  set fade curve type for 1st stream (from -1 to 18) (default tri)
/// </summary>
public AcrossfadeFilterGenC1? c1 { get; set; }
/// <summary>
///  set fade curve type for 2nd stream (from -1 to 18) (default tri)
/// </summary>
public AcrossfadeFilterGenCurve2? curve2 { get; set; }
/// <summary>
///  set fade curve type for 2nd stream (from -1 to 18) (default tri)
/// </summary>
public AcrossfadeFilterGenC2? c2 { get; set; }
}
public enum AcrossfadeFilterGenCurve1
{
[Name("nofade")] nofade,
[Name("tri")] tri,
[Name("qsin")] qsin,
[Name("esin")] esin,
[Name("hsin")] hsin,
[Name("log")] log,
[Name("ipar")] ipar,
[Name("qua")] qua,
[Name("cub")] cub,
[Name("squ")] squ,
[Name("cbr")] cbr,
[Name("par")] par,
[Name("exp")] exp,
[Name("iqsin")] iqsin,
[Name("ihsin")] ihsin,
[Name("dese")] dese,
[Name("desi")] desi,
[Name("losi")] losi,
[Name("sinc")] sinc,
[Name("isinc")] isinc,
}

public enum AcrossfadeFilterGenC1
{
[Name("nofade")] nofade,
[Name("tri")] tri,
[Name("qsin")] qsin,
[Name("esin")] esin,
[Name("hsin")] hsin,
[Name("log")] log,
[Name("ipar")] ipar,
[Name("qua")] qua,
[Name("cub")] cub,
[Name("squ")] squ,
[Name("cbr")] cbr,
[Name("par")] par,
[Name("exp")] exp,
[Name("iqsin")] iqsin,
[Name("ihsin")] ihsin,
[Name("dese")] dese,
[Name("desi")] desi,
[Name("losi")] losi,
[Name("sinc")] sinc,
[Name("isinc")] isinc,
}

public enum AcrossfadeFilterGenCurve2
{
[Name("nofade")] nofade,
[Name("tri")] tri,
[Name("qsin")] qsin,
[Name("esin")] esin,
[Name("hsin")] hsin,
[Name("log")] log,
[Name("ipar")] ipar,
[Name("qua")] qua,
[Name("cub")] cub,
[Name("squ")] squ,
[Name("cbr")] cbr,
[Name("par")] par,
[Name("exp")] exp,
[Name("iqsin")] iqsin,
[Name("ihsin")] ihsin,
[Name("dese")] dese,
[Name("desi")] desi,
[Name("losi")] losi,
[Name("sinc")] sinc,
[Name("isinc")] isinc,
}

public enum AcrossfadeFilterGenC2
{
[Name("nofade")] nofade,
[Name("tri")] tri,
[Name("qsin")] qsin,
[Name("esin")] esin,
[Name("hsin")] hsin,
[Name("log")] log,
[Name("ipar")] ipar,
[Name("qua")] qua,
[Name("cub")] cub,
[Name("squ")] squ,
[Name("cbr")] cbr,
[Name("par")] par,
[Name("exp")] exp,
[Name("iqsin")] iqsin,
[Name("ihsin")] ihsin,
[Name("dese")] dese,
[Name("desi")] desi,
[Name("losi")] losi,
[Name("sinc")] sinc,
[Name("isinc")] isinc,
}

}
