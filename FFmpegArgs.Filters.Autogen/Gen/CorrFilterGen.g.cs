namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.. corr              VV->V      Calculate the correlation between two video streams.
/// </summary>
public class CorrFilterGen : ImageToImageFilter,ITimelineSupport
{
internal CorrFilterGen(params ImageMap[] inputs) : base("corr",inputs) { AddMapOut(); }
}
/// <summary>
/// </summary>
public static class CorrFilterGenExtensions
{
/// <summary>
/// Calculate the correlation between two video streams.
/// </summary>
public static CorrFilterGen CorrFilterGen(this ImageMap input0, ImageMap input1) => new CorrFilterGen(input0, input1);
}
}
