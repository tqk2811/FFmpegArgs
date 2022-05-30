namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC afreqshift        A->A       Apply frequency shifting to input audio.
/// </summary>
public class AfreqshiftFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AfreqshiftFilterGen(AudioMap input) : base("afreqshift",input) { AddMapOut(); }
/// <summary>
///  set frequency shift (from -2.14748e+09 to INT_MAX) (default 0)
/// </summary>
public AfreqshiftFilterGen shift(double shift) => this.SetOptionRange("shift", shift,-2.14748e+09,INT_MAX);
/// <summary>
///  set output level (from 0 to 1) (default 1)
/// </summary>
public AfreqshiftFilterGen level(double level) => this.SetOptionRange("level", level,0,1);
/// <summary>
///  set filter order (from 1 to 16) (default 8)
/// </summary>
public AfreqshiftFilterGen order(int order) => this.SetOptionRange("order", order,1,16);
}
/// <summary>
/// </summary>
public static class AfreqshiftFilterGenExtensions
{
/// <summary>
/// Apply frequency shifting to input audio.
/// </summary>
public static AfreqshiftFilterGen AfreqshiftFilterGen(this AudioMap input0) => new AfreqshiftFilterGen(input0);
}
}
