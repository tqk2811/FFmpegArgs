namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC maskedmerge       VVV-&gt;V     Merge first stream with second stream using third stream as mask.
/// </summary>
public class MaskedmergeFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal MaskedmergeFilterGen(params ImageMap[] inputs) : base("maskedmerge",inputs) { AddMapOut(); }
/// <summary>
///  set planes (from 0 to 15) (default 15)
/// </summary>
public MaskedmergeFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Merge first stream with second stream using third stream as mask.
/// </summary>
public static MaskedmergeFilterGen MaskedmergeFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2) => new MaskedmergeFilterGen(input0, input1, input2);
}
}
