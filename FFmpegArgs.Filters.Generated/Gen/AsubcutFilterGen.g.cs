namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC asubcut           A-&gt;A       Cut subwoofer frequencies.
/// </summary>
public class AsubcutFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AsubcutFilterGen(AudioMap input) : base("asubcut",input) { AddMapOut(); }
/// <summary>
///  set cutoff frequency (from 2 to 200) (default 20)
/// </summary>
public AsubcutFilterGen cutoff(double cutoff) => this.SetOptionRange("cutoff", cutoff,2,200);
/// <summary>
///  set filter order (from 3 to 20) (default 10)
/// </summary>
public AsubcutFilterGen order(int order) => this.SetOptionRange("order", order,3,20);
/// <summary>
///  set input level (from 0 to 1) (default 1)
/// </summary>
public AsubcutFilterGen level(double level) => this.SetOptionRange("level", level,0,1);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Cut subwoofer frequencies.
/// </summary>
public static AsubcutFilterGen AsubcutFilterGen(this AudioMap input0) => new AsubcutFilterGen(input0);
}
}
