namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.. framestep         V-&gt;V       Select one frame every N frames.
/// </summary>
public class FramestepFilterGen : ImageToImageFilter,ITimelineSupport
{
internal FramestepFilterGen(ImageMap input) : base("framestep",input) { AddMapOut(); }
/// <summary>
///  set frame step (from 1 to INT_MAX) (default 1)
/// </summary>
public FramestepFilterGen step(int step) => this.SetOptionRange("step", step,1,INT_MAX);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Select one frame every N frames.
/// </summary>
public static FramestepFilterGen FramestepFilterGen(this ImageMap input0) => new FramestepFilterGen(input0);
}
}
