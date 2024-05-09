namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC crystalizer       A->A       Simple audio noise sharpening filter.
/// </summary>
public class CrystalizerFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal CrystalizerFilterGen(AudioMap input) : base("crystalizer",input) { AddMapOut(); }
/// <summary>
///  set intensity (from -10 to 10) (default 2)
/// </summary>
public CrystalizerFilterGen i(float i) => this.SetOptionRange("i", i,-10,10);
/// <summary>
///  enable clipping (default true)
/// </summary>
public CrystalizerFilterGen c(bool c) => this.SetOption("c",c.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static class CrystalizerFilterGenExtensions
{
/// <summary>
/// Simple audio noise sharpening filter.
/// </summary>
public static CrystalizerFilterGen CrystalizerFilterGen(this AudioMap input0) => new CrystalizerFilterGen(input0);
}
}
