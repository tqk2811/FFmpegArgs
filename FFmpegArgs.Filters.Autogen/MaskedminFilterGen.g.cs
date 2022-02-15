namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC maskedmin         VVV->V     Apply filtering with minimum difference of two streams.
/// </summary>
public class MaskedminFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal MaskedminFilterGen(params ImageMap[] inputs) : base("maskedmin",inputs) { AddMapOut(); }
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public MaskedminFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
/// <summary>
/// </summary>
public static class MaskedminFilterGenExtensions
{
/// <summary>
/// Apply filtering with minimum difference of two streams.
/// </summary>
public static MaskedminFilterGen MaskedminFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2) => new MaskedminFilterGen(input0, input1, input2);
}
}
