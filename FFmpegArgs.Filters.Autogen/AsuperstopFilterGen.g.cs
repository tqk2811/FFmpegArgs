namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC asuperstop        A->A       Apply high order Butterworth band-stop filter.
/// </summary>
public class AsuperstopFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AsuperstopFilterGen(AudioMap input) : base("asuperstop",input) { AddMapOut(); }
/// <summary>
///  set center frequency (from 2 to 999999) (default 1000)
/// </summary>
public AsuperstopFilterGen centerf(double centerf) => this.SetOptionRange("centerf", centerf,2,999999);
/// <summary>
///  set filter order (from 4 to 20) (default 4)
/// </summary>
public AsuperstopFilterGen order(int order) => this.SetOptionRange("order", order,4,20);
/// <summary>
///  set Q-factor (from 0.01 to 100) (default 1)
/// </summary>
public AsuperstopFilterGen qfactor(double qfactor) => this.SetOptionRange("qfactor", qfactor,0.01,100);
/// <summary>
///  set input level (from 0 to 2) (default 1)
/// </summary>
public AsuperstopFilterGen level(double level) => this.SetOptionRange("level", level,0,2);
}
/// <summary>
/// </summary>
public static class AsuperstopFilterGenExtensions
{
/// <summary>
/// Apply high order Butterworth band-stop filter.
/// </summary>
public static AsuperstopFilterGen AsuperstopFilterGen(this AudioMap input0) => new AsuperstopFilterGen(input0);
}
}
