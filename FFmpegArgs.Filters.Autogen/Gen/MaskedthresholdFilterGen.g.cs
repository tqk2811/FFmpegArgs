namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC maskedthreshold   VV->V      Pick pixels comparing absolute difference of two streams with threshold.
/// </summary>
public class MaskedthresholdFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal MaskedthresholdFilterGen(params ImageMap[] inputs) : base("maskedthreshold",inputs) { AddMapOut(); }
/// <summary>
///  set threshold (from 0 to 65535) (default 1)
/// </summary>
public MaskedthresholdFilterGen threshold(int threshold) => this.SetOptionRange("threshold", threshold,0,65535);
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public MaskedthresholdFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
/// <summary>
/// </summary>
public static class MaskedthresholdFilterGenExtensions
{
/// <summary>
/// Pick pixels comparing absolute difference of two streams with threshold.
/// </summary>
public static MaskedthresholdFilterGen MaskedthresholdFilterGen(this ImageMap input0, ImageMap input1) => new MaskedthresholdFilterGen(input0, input1);
}
}
