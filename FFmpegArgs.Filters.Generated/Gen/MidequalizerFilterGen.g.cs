namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.. midequalizer      VV->V      Apply Midway Equalization.
/// </summary>
public class MidequalizerFilterGen : ImageToImageFilter,ITimelineSupport
{
internal MidequalizerFilterGen(params ImageMap[] inputs) : base("midequalizer",inputs) { AddMapOut(); }
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public MidequalizerFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
/// <summary>
/// </summary>
public static class MidequalizerFilterGenExtensions
{
/// <summary>
/// Apply Midway Equalization.
/// </summary>
public static MidequalizerFilterGen MidequalizerFilterGen(this ImageMap input0, ImageMap input1) => new MidequalizerFilterGen(input0, input1);
}
}
