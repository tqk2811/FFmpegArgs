namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.C bbox              V->V       Compute bounding box for each frame.
/// </summary>
public class BboxFilterGen : ImageToImageFilter,ITimelineSupport,ICommandSupport
{
internal BboxFilterGen(ImageMap input) : base("bbox",input) { AddMapOut(); }
/// <summary>
///  set minimum luminance value for bounding box (from 0 to 65535) (default 16)
/// </summary>
public BboxFilterGen min_val(int min_val) => this.SetOptionRange("min_val", min_val,0,65535);
}
/// <summary>
/// </summary>
public static class BboxFilterGenExtensions
{
/// <summary>
/// Compute bounding box for each frame.
/// </summary>
public static BboxFilterGen BboxFilterGen(this ImageMap input0) => new BboxFilterGen(input0);
}
}
