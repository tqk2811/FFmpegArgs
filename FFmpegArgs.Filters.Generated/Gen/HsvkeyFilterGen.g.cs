namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC hsvkey            V->V       Turns a certain HSV range into transparency. Operates on YUV colors.
/// </summary>
public class HsvkeyFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal HsvkeyFilterGen(ImageMap input) : base("hsvkey",input) { AddMapOut(); }
/// <summary>
///  set the hue value (from -360 to 360) (default 0)
/// </summary>
public HsvkeyFilterGen hue(float hue) => this.SetOptionRange("hue", hue,-360,360);
/// <summary>
///  set the saturation value (from -1 to 1) (default 0)
/// </summary>
public HsvkeyFilterGen sat(float sat) => this.SetOptionRange("sat", sat,-1,1);
/// <summary>
///  set the value value (from -1 to 1) (default 0)
/// </summary>
public HsvkeyFilterGen val(float val) => this.SetOptionRange("val", val,-1,1);
/// <summary>
///  set the hsvkey similarity value (from 1e-05 to 1) (default 0.01)
/// </summary>
public HsvkeyFilterGen similarity(float similarity) => this.SetOptionRange("similarity", similarity,1e-05,1);
/// <summary>
///  set the hsvkey blend value (from 0 to 1) (default 0)
/// </summary>
public HsvkeyFilterGen blend(float blend) => this.SetOptionRange("blend", blend,0,1);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Turns a certain HSV range into transparency. Operates on YUV colors.
/// </summary>
public static HsvkeyFilterGen HsvkeyFilterGen(this ImageMap input0) => new HsvkeyFilterGen(input0);
}
}
