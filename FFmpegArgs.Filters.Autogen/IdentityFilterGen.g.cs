namespace FFmpegArgs.Filters.Autogens
{
public class IdentityFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal IdentityFilterGen(params ImageMap[] inputs) : base("identity",inputs) { AddMapOut(); }
}
public static class IdentityFilterGenExtensions
{
/// <summary>
/// Calculate the Identity between two video streams.
/// </summary>
public static IdentityFilterGen IdentityFilterGen(this ImageMap input0, ImageMap input1) => new IdentityFilterGen(input0, input1);
/// <summary>
/// Calculate the Identity between two video streams.
/// </summary>
public static IdentityFilterGen IdentityFilterGen(this ImageMap input0, ImageMap input1,IdentityFilterGenConfig config)
{
var result = new IdentityFilterGen(input0, input1);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class IdentityFilterGenConfig
:ITimelineSupportConfig
{
public string TimelineSupport { get; set; }
}
}
