namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TS. identity          VV->V      Calculate the Identity between two video streams.
/// </summary>
public class IdentityFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal IdentityFilterGen(params ImageMap[] inputs) : base("identity",inputs) { AddMapOut(); }
}
/// <summary>
/// </summary>
public static class IdentityFilterGenExtensions
{
/// <summary>
/// Calculate the Identity between two video streams.
/// </summary>
public static IdentityFilterGen IdentityFilterGen(this ImageMap input0, ImageMap input1) => new IdentityFilterGen(input0, input1);
}
}
