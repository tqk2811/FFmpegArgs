namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC exposure          V->V       Adjust exposure of the video stream.
/// </summary>
public class ExposureFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ExposureFilterGen(ImageMap input) : base("exposure",input) { AddMapOut(); }
/// <summary>
///  set the exposure correction (from -3 to 3) (default 0)
/// </summary>
public ExposureFilterGen exposure(float exposure) => this.SetOptionRange("exposure", exposure,-3,3);
/// <summary>
///  set the black level correction (from -1 to 1) (default 0)
/// </summary>
public ExposureFilterGen black(float black) => this.SetOptionRange("black", black,-1,1);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Adjust exposure of the video stream.
/// </summary>
public static ExposureFilterGen ExposureFilterGen(this ImageMap input0) => new ExposureFilterGen(input0);
}
}
