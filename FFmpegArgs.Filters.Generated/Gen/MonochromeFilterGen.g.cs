namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC monochrome        V->V       Convert video to gray using custom color filter.
/// </summary>
public class MonochromeFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal MonochromeFilterGen(ImageMap input) : base("monochrome",input) { AddMapOut(); }
/// <summary>
///  set the chroma blue spot (from -1 to 1) (default 0)
/// </summary>
public MonochromeFilterGen cb(float cb) => this.SetOptionRange("cb", cb,-1,1);
/// <summary>
///  set the chroma red spot (from -1 to 1) (default 0)
/// </summary>
public MonochromeFilterGen cr(float cr) => this.SetOptionRange("cr", cr,-1,1);
/// <summary>
///  set the color filter size (from 0.1 to 10) (default 1)
/// </summary>
public MonochromeFilterGen size(float size) => this.SetOptionRange("size", size,0.1,10);
/// <summary>
///  set the highlights strength (from 0 to 1) (default 0)
/// </summary>
public MonochromeFilterGen high(float high) => this.SetOptionRange("high", high,0,1);
}
/// <summary>
/// </summary>
public static class MonochromeFilterGenExtensions
{
/// <summary>
/// Convert video to gray using custom color filter.
/// </summary>
public static MonochromeFilterGen MonochromeFilterGen(this ImageMap input0) => new MonochromeFilterGen(input0);
}
}
