namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC asuperpass        A->A       Apply high order Butterworth band-pass filter.
/// </summary>
public class AsuperpassFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AsuperpassFilterGen(AudioMap input) : base("asuperpass",input) { AddMapOut(); }
/// <summary>
///  set center frequency (from 2 to 999999) (default 1000)
/// </summary>
public AsuperpassFilterGen centerf(double centerf) => this.SetOptionRange("centerf", centerf,2,999999);
/// <summary>
///  set filter order (from 4 to 20) (default 4)
/// </summary>
public AsuperpassFilterGen order(int order) => this.SetOptionRange("order", order,4,20);
/// <summary>
///  set Q-factor (from 0.01 to 100) (default 1)
/// </summary>
public AsuperpassFilterGen qfactor(double qfactor) => this.SetOptionRange("qfactor", qfactor,0.01,100);
/// <summary>
///  set input level (from 0 to 2) (default 1)
/// </summary>
public AsuperpassFilterGen level(double level) => this.SetOptionRange("level", level,0,2);
}
/// <summary>
/// </summary>
public static class AsuperpassFilterGenExtensions
{
/// <summary>
/// Apply high order Butterworth band-pass filter.
/// </summary>
public static AsuperpassFilterGen AsuperpassFilterGen(this AudioMap input0) => new AsuperpassFilterGen(input0);
}
}
