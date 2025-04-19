namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC afir              N-&gt;A       Apply Finite Impulse Response filter with supplied coefficients in additional stream(s).
/// </summary>
public class AfirFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AfirFilterGen(params AudioMap[] inputs) : base("afir",inputs) { AddMapOut(); }
/// <summary>
///  set dry gain (from 0 to 10) (default 1)
/// </summary>
public AfirFilterGen dry(float dry) => this.SetOptionRange("dry", dry,0,10);
/// <summary>
///  set wet gain (from 0 to 10) (default 1)
/// </summary>
public AfirFilterGen wet(float wet) => this.SetOptionRange("wet", wet,0,10);
/// <summary>
///  set IR length (from 0 to 1) (default 1)
/// </summary>
public AfirFilterGen length(float length) => this.SetOptionRange("length", length,0,1);
/// <summary>
///  set IR auto gain type (from -1 to 4) (default peak)
/// </summary>
[Obsolete]
public AfirFilterGen gtype(AfirFilterGenGtype gtype) => this.SetOption("gtype", gtype.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set IR norm (from -1 to 2) (default 1)
/// </summary>
public AfirFilterGen irnorm(float irnorm) => this.SetOptionRange("irnorm", irnorm,-1,2);
/// <summary>
///  set IR link (default true)
/// </summary>
public AfirFilterGen irlink(bool irlink) => this.SetOption("irlink",irlink.ToFFmpegFlag());
/// <summary>
///  set IR gain (from 0 to 1) (default 1)
/// </summary>
public AfirFilterGen irgain(float irgain) => this.SetOptionRange("irgain", irgain,0,1);
/// <summary>
///  set IR format (from 0 to 1) (default input)
/// </summary>
public AfirFilterGen irfmt(AfirFilterGenIrfmt irfmt) => this.SetOption("irfmt", irfmt.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set max IR length (from 0.1 to 60) (default 30)
/// </summary>
public AfirFilterGen maxir(float maxir) => this.SetOptionRange("maxir", maxir,0.1,60);
/// <summary>
///  show IR frequency response (default false)
/// </summary>
[Obsolete]
public AfirFilterGen response(bool response) => this.SetOption("response",response.ToFFmpegFlag());
/// <summary>
///  set IR channel to display frequency response (from 0 to 1024) (default 0)
/// </summary>
[Obsolete]
public AfirFilterGen channel(int channel) => this.SetOptionRange("channel", channel,0,1024);
/// <summary>
///  set video size (default &quot;hd720&quot;)
/// </summary>
[Obsolete]
public AfirFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default &quot;25&quot;)
/// </summary>
[Obsolete]
public AfirFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set min partition size (from 1 to 65536) (default 8192)
/// </summary>
public AfirFilterGen minp(int minp) => this.SetOptionRange("minp", minp,1,65536);
/// <summary>
///  set max partition size (from 8 to 65536) (default 8192)
/// </summary>
public AfirFilterGen maxp(int maxp) => this.SetOptionRange("maxp", maxp,8,65536);
/// <summary>
///  set number of input IRs (from 1 to 32) (default 1)
/// </summary>
public AfirFilterGen nbirs(int nbirs) => this.SetOptionRange("nbirs", nbirs,1,32);
/// <summary>
///  select IR (from 0 to 31) (default 0)
/// </summary>
public AfirFilterGen ir(int ir) => this.SetOptionRange("ir", ir,0,31);
/// <summary>
///  set processing precision (from 0 to 2) (default auto)
/// </summary>
public AfirFilterGen precision(AfirFilterGenPrecision precision) => this.SetOption("precision", precision.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set IR loading type (from 0 to 1) (default init)
/// </summary>
public AfirFilterGen irload(AfirFilterGenIrload irload) => this.SetOption("irload", irload.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply Finite Impulse Response filter with supplied coefficients in additional stream(s).
/// </summary>
public static AfirFilterGen AfirFilterGen(this IEnumerable<AudioMap> inputs) => new AfirFilterGen(inputs.ToArray());
}
/// <summary>
///  set IR auto gain type (from -1 to 4) (default peak)
/// </summary>
public enum AfirFilterGenGtype
{
/// <summary>
/// none            -1           ..F.A.....P without auto gain
/// </summary>
[Name("none")] none,
/// <summary>
/// peak            0            ..F.A.....P peak gain
/// </summary>
[Name("peak")] peak,
/// <summary>
/// dc              1            ..F.A.....P DC gain
/// </summary>
[Name("dc")] dc,
/// <summary>
/// gn              2            ..F.A.....P gain to noise
/// </summary>
[Name("gn")] gn,
/// <summary>
/// ac              3            ..F.A.....P AC gain
/// </summary>
[Name("ac")] ac,
/// <summary>
/// rms             4            ..F.A.....P RMS gain
/// </summary>
[Name("rms")] rms,
}

/// <summary>
///  set IR format (from 0 to 1) (default input)
/// </summary>
public enum AfirFilterGenIrfmt
{
/// <summary>
/// mono            0            ..F.A...... single channel
/// </summary>
[Name("mono")] mono,
/// <summary>
/// input           1            ..F.A...... same as input
/// </summary>
[Name("input")] input,
}

/// <summary>
///  set processing precision (from 0 to 2) (default auto)
/// </summary>
public enum AfirFilterGenPrecision
{
/// <summary>
/// auto            0            ..F.A...... set auto processing precision
/// </summary>
[Name("auto")] auto,
/// <summary>
/// float           1            ..F.A...... set single-floating point processing precision
/// </summary>
[Name("float")] _float,
/// <summary>
/// double          2            ..F.A...... set double-floating point processing precision
/// </summary>
[Name("double")] _double,
}

/// <summary>
///  set IR loading type (from 0 to 1) (default init)
/// </summary>
public enum AfirFilterGenIrload
{
/// <summary>
/// init            0            ..F.A...... load all IRs on init
/// </summary>
[Name("init")] init,
/// <summary>
/// access          1            ..F.A...... load IR on access
/// </summary>
[Name("access")] access,
}

}
