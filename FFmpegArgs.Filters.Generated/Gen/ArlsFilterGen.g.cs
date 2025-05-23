namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC arls              AA-&gt;A      Apply Recursive Least Squares algorithm to first audio stream.
/// </summary>
public class ArlsFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ArlsFilterGen(params AudioMap[] inputs) : base("arls",inputs) { AddMapOut(); }
/// <summary>
///  set the filter order (from 1 to 32767) (default 16)
/// </summary>
public ArlsFilterGen order(int order) => this.SetOptionRange("order", order,1,32767);
/// <summary>
///  set the filter lambda (from 0 to 1) (default 1)
/// </summary>
public ArlsFilterGen lambda(float lambda) => this.SetOptionRange("lambda", lambda,0,1);
/// <summary>
///  set the filter delta (from 0 to 32767) (default 2)
/// </summary>
public ArlsFilterGen delta(float delta) => this.SetOptionRange("delta", delta,0,32767);
/// <summary>
///  set output mode (from 0 to 4) (default o)
/// </summary>
public ArlsFilterGen out_mode(ArlsFilterGenOut_mode out_mode) => this.SetOption("out_mode", out_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set processing precision (from 0 to 2) (default auto)
/// </summary>
public ArlsFilterGen precision(ArlsFilterGenPrecision precision) => this.SetOption("precision", precision.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply Recursive Least Squares algorithm to first audio stream.
/// </summary>
public static ArlsFilterGen ArlsFilterGen(this AudioMap input0, AudioMap input1) => new ArlsFilterGen(input0, input1);
}
/// <summary>
///  set output mode (from 0 to 4) (default o)
/// </summary>
public enum ArlsFilterGenOut_mode
{
/// <summary>
/// i               0            ..F.A....T. input
/// </summary>
[Name("i")] i,
/// <summary>
/// d               1            ..F.A....T. desired
/// </summary>
[Name("d")] d,
/// <summary>
/// o               2            ..F.A....T. output
/// </summary>
[Name("o")] o,
/// <summary>
/// n               3            ..F.A....T. noise
/// </summary>
[Name("n")] n,
/// <summary>
/// e               4            ..F.A....T. error
/// </summary>
[Name("e")] e,
}

/// <summary>
///  set processing precision (from 0 to 2) (default auto)
/// </summary>
public enum ArlsFilterGenPrecision
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

}
