namespace FFmpegArgs.Filters.Autogens
{
public class AlphamergeFilterGen : ImageToImageFilter,ITimelineSupport
{
internal AlphamergeFilterGen(params ImageMap[] inputs) : base("alphamerge",inputs) { AddMapOut(); }
}
public static class AlphamergeFilterGenExtensions
{
/// <summary>
/// Copy the luma value of the second input into the alpha channel of the first input.
/// </summary>
public static AlphamergeFilterGen AlphamergeFilterGen(this ImageMap input0, ImageMap input1) => new AlphamergeFilterGen(input0, input1);
/// <summary>
/// Copy the luma value of the second input into the alpha channel of the first input.
/// </summary>
public static AlphamergeFilterGen AlphamergeFilterGen(this ImageMap input0, ImageMap input1,AlphamergeFilterGenConfig config)
{
var result = new AlphamergeFilterGen(input0, input1);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class AlphamergeFilterGenConfig
:ITimelineSupportConfig
{
public string TimelineSupport { get; set; }
}
}
