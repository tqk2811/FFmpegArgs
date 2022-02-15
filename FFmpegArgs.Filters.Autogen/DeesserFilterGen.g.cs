namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.. deesser           A->A       Apply de-essing to the audio.
/// </summary>
public class DeesserFilterGen : AudioToAudioFilter,ITimelineSupport
{
internal DeesserFilterGen(AudioMap input) : base("deesser",input) { AddMapOut(); }
/// <summary>
///  set intensity (from 0 to 1) (default 0)
/// </summary>
public DeesserFilterGen i(double i) => this.SetOptionRange("i", i,0,1);
/// <summary>
///  set max deessing (from 0 to 1) (default 0.5)
/// </summary>
public DeesserFilterGen m(double m) => this.SetOptionRange("m", m,0,1);
/// <summary>
///  set frequency (from 0 to 1) (default 0.5)
/// </summary>
public DeesserFilterGen f(double f) => this.SetOptionRange("f", f,0,1);
/// <summary>
///  set output mode (from 0 to 2) (default o)
/// </summary>
public DeesserFilterGen s(DeesserFilterGenS s) => this.SetOption("s", s.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class DeesserFilterGenExtensions
{
/// <summary>
/// Apply de-essing to the audio.
/// </summary>
public static DeesserFilterGen DeesserFilterGen(this AudioMap input0) => new DeesserFilterGen(input0);
}
/// <summary>
///  set output mode (from 0 to 2) (default o)
/// </summary>
public enum DeesserFilterGenS
{
/// <summary>
/// i               0            ..F.A...... input
/// </summary>
[Name("i")] i,
/// <summary>
/// o               1            ..F.A...... output
/// </summary>
[Name("o")] o,
/// <summary>
/// e               2            ..F.A...... ess
/// </summary>
[Name("e")] e,
}

}
