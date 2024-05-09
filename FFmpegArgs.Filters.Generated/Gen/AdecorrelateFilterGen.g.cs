namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TS. adecorrelate      A->A       Apply decorrelation to input audio.
/// </summary>
public class AdecorrelateFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading
{
internal AdecorrelateFilterGen(AudioMap input) : base("adecorrelate",input) { AddMapOut(); }
/// <summary>
///  set filtering stages (from 1 to 16) (default 6)
/// </summary>
public AdecorrelateFilterGen stages(int stages) => this.SetOptionRange("stages", stages,1,16);
/// <summary>
///  set random seed (from -1 to UINT32_MAX) (default -1)
/// </summary>
public AdecorrelateFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
}
/// <summary>
/// </summary>
public static class AdecorrelateFilterGenExtensions
{
/// <summary>
/// Apply decorrelation to input audio.
/// </summary>
public static AdecorrelateFilterGen AdecorrelateFilterGen(this AudioMap input0) => new AdecorrelateFilterGen(input0);
}
}
