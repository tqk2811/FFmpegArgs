namespace FFmpegArgs.Filters.Autogens
{
public class FramestepFilterGen : ImageToImageFilter,ITimelineSupport
{
internal FramestepFilterGen(ImageMap input) : base("framestep",input) { AddMapOut(); }
/// <summary>
///  set frame step (from 1 to INT_MAX) (default 1)
/// </summary>
public FramestepFilterGen step(int step) => this.SetOptionRange("step", step,1,INT_MAX);
}
public static class FramestepFilterGenExtensions
{
/// <summary>
/// Select one frame every N frames.
/// </summary>
public static FramestepFilterGen FramestepFilterGen(this ImageMap input0) => new FramestepFilterGen(input0);
/// <summary>
/// Select one frame every N frames.
/// </summary>
public static FramestepFilterGen FramestepFilterGen(this ImageMap input0,FramestepFilterGenConfig config)
{
var result = new FramestepFilterGen(input0);
if(config?.step != null) result.step(config.step.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class FramestepFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set frame step (from 1 to INT_MAX) (default 1)
/// </summary>
public int? step { get; set; }
public string TimelineSupport { get; set; }
}
}
