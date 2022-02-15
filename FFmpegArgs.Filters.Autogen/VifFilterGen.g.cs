namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TS. vif               VV->V      Calculate the VIF between two video streams.
/// </summary>
public class VifFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal VifFilterGen(params ImageMap[] inputs) : base("vif",inputs) { AddMapOut(); }
}
/// <summary>
/// </summary>
public static class VifFilterGenExtensions
{
/// <summary>
/// Calculate the VIF between two video streams.
/// </summary>
public static VifFilterGen VifFilterGen(this ImageMap input0, ImageMap input1) => new VifFilterGen(input0, input1);
}
}
