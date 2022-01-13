namespace FFmpegArgs.Filters.Autogens
{
public class ShuffleframesFilterGen : ImageToImageFilter,ITimelineSupport
{
internal ShuffleframesFilterGen(ImageMap input) : base("shuffleframes",input) { AddMapOut(); }
/// <summary>
///  set destination indexes of input frames (default "0")
/// </summary>
public ShuffleframesFilterGen mapping(string mapping) => this.SetOption("mapping",mapping);
}
public static class ShuffleframesFilterGenExtensions
{
/// <summary>
/// Shuffle video frames.
/// </summary>
public static ShuffleframesFilterGen ShuffleframesFilterGen(this ImageMap input0) => new ShuffleframesFilterGen(input0);
/// <summary>
/// Shuffle video frames.
/// </summary>
public static ShuffleframesFilterGen ShuffleframesFilterGen(this ImageMap input0,ShuffleframesFilterGenConfig config)
{
var result = new ShuffleframesFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.mapping)) result.mapping(config.mapping);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class ShuffleframesFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set destination indexes of input frames (default "0")
/// </summary>
public string mapping { get; set; }
public string TimelineSupport { get; set; }
}
}
