namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC asupercut         A->A       Cut super frequencies.
/// </summary>
public class AsupercutFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AsupercutFilterGen(AudioMap input) : base("asupercut",input) { AddMapOut(); }
/// <summary>
///  set cutoff frequency (from 20000 to 192000) (default 20000)
/// </summary>
public AsupercutFilterGen cutoff(double cutoff) => this.SetOptionRange("cutoff", cutoff,20000,192000);
/// <summary>
///  set filter order (from 3 to 20) (default 10)
/// </summary>
public AsupercutFilterGen order(int order) => this.SetOptionRange("order", order,3,20);
/// <summary>
///  set input level (from 0 to 1) (default 1)
/// </summary>
public AsupercutFilterGen level(double level) => this.SetOptionRange("level", level,0,1);
}
/// <summary>
/// </summary>
public static class AsupercutFilterGenExtensions
{
/// <summary>
/// Cut super frequencies.
/// </summary>
public static AsupercutFilterGen AsupercutFilterGen(this AudioMap input0) => new AsupercutFilterGen(input0);
}
}
