namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC lumakey           V-&gt;V       Turns a certain luma into transparency.
/// </summary>
public class LumakeyFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal LumakeyFilterGen(ImageMap input) : base("lumakey",input) { AddMapOut(); }
/// <summary>
///  set the threshold value (from 0 to 1) (default 0)
/// </summary>
public LumakeyFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,0,1);
/// <summary>
///  set the tolerance value (from 0 to 1) (default 0.01)
/// </summary>
public LumakeyFilterGen tolerance(double tolerance) => this.SetOptionRange("tolerance", tolerance,0,1);
/// <summary>
///  set the softness value (from 0 to 1) (default 0)
/// </summary>
public LumakeyFilterGen softness(double softness) => this.SetOptionRange("softness", softness,0,1);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Turns a certain luma into transparency.
/// </summary>
public static LumakeyFilterGen LumakeyFilterGen(this ImageMap input0) => new LumakeyFilterGen(input0);
}
}
