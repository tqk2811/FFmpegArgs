namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC maskedmax         VVV->V     Apply filtering with maximum difference of two streams.
/// </summary>
public class MaskedmaxFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal MaskedmaxFilterGen(params ImageMap[] inputs) : base("maskedmax",inputs) { AddMapOut(); }
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public MaskedmaxFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
/// <summary>
/// </summary>
public static class MaskedmaxFilterGenExtensions
{
/// <summary>
/// Apply filtering with maximum difference of two streams.
/// </summary>
public static MaskedmaxFilterGen MaskedmaxFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2) => new MaskedmaxFilterGen(input0, input1, input2);
}
}
