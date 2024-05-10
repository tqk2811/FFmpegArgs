namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TS. msad              VV->V      Calculate the MSAD between two video streams.
/// </summary>
public class MsadFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal MsadFilterGen(params ImageMap[] inputs) : base("msad",inputs) { AddMapOut(); }
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Calculate the MSAD between two video streams.
/// </summary>
public static MsadFilterGen MsadFilterGen(this ImageMap input0, ImageMap input1) => new MsadFilterGen(input0, input1);
}
}
