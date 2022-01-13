namespace FFmpegArgs.Filters.Autogens
{
public class VflipFilterGen : ImageToImageFilter,ITimelineSupport
{
internal VflipFilterGen(ImageMap input) : base("vflip",input) { AddMapOut(); }
}
public static class VflipFilterGenExtensions
{
/// <summary>
/// Flip the input video vertically.
/// </summary>
public static VflipFilterGen VflipFilterGen(this ImageMap input0) => new VflipFilterGen(input0);
/// <summary>
/// Flip the input video vertically.
/// </summary>
public static VflipFilterGen VflipFilterGen(this ImageMap input0,VflipFilterGenConfig config)
{
var result = new VflipFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class VflipFilterGenConfig
:ITimelineSupportConfig
{
public string TimelineSupport { get; set; }
}
}
