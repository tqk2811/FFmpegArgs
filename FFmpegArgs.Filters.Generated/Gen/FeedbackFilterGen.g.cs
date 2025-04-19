namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.C feedback          VV-&gt;VV     Apply feedback video filter.
/// </summary>
public class FeedbackFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal FeedbackFilterGen(params ImageMap[] inputs) : base("feedback",inputs) { AddMultiMapOut(2); }
/// <summary>
///  set top left crop position (from 0 to INT_MAX) (default 0)
/// </summary>
public FeedbackFilterGen x(int x) => this.SetOptionRange("x", x,0,INT_MAX);
/// <summary>
///  set top left crop position (from 0 to INT_MAX) (default 0)
/// </summary>
public FeedbackFilterGen y(int y) => this.SetOptionRange("y", y,0,INT_MAX);
/// <summary>
///  set crop size (from 0 to INT_MAX) (default 0)
/// </summary>
public FeedbackFilterGen w(int w) => this.SetOptionRange("w", w,0,INT_MAX);
/// <summary>
///  set crop size (from 0 to INT_MAX) (default 0)
/// </summary>
public FeedbackFilterGen h(int h) => this.SetOptionRange("h", h,0,INT_MAX);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply feedback video filter.
/// </summary>
public static FeedbackFilterGen FeedbackFilterGen(this ImageMap input0, ImageMap input1) => new FeedbackFilterGen(input0, input1);
}
}
