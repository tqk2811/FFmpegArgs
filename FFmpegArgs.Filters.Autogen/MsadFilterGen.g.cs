namespace FFmpegArgs.Filters.Autogens
{
public class MsadFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal MsadFilterGen(params ImageMap[] inputs) : base("msad",inputs) { AddMapOut(); }
}
public static class MsadFilterGenExtensions
{
/// <summary>
/// Calculate the MSAD between two video streams.
/// </summary>
public static MsadFilterGen MsadFilterGen(this ImageMap input0, ImageMap input1) => new MsadFilterGen(input0, input1);
/// <summary>
/// Calculate the MSAD between two video streams.
/// </summary>
public static MsadFilterGen MsadFilterGen(this ImageMap input0, ImageMap input1,MsadFilterGenConfig config)
{
var result = new MsadFilterGen(input0, input1);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class MsadFilterGenConfig
:ITimelineSupportConfig
{
public string TimelineSupport { get; set; }
}
}
