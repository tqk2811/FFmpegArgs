namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC hsvhold           V->V       Turns a certain HSV range into gray.
/// </summary>
public class HsvholdFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal HsvholdFilterGen(ImageMap input) : base("hsvhold",input) { AddMapOut(); }
/// <summary>
///  set the hue value (from -360 to 360) (default 0)
/// </summary>
public HsvholdFilterGen hue(float hue) => this.SetOptionRange("hue", hue,-360,360);
/// <summary>
///  set the saturation value (from -1 to 1) (default 0)
/// </summary>
public HsvholdFilterGen sat(float sat) => this.SetOptionRange("sat", sat,-1,1);
/// <summary>
///  set the value value (from -1 to 1) (default 0)
/// </summary>
public HsvholdFilterGen val(float val) => this.SetOptionRange("val", val,-1,1);
/// <summary>
///  set the hsvhold similarity value (from 1e-05 to 1) (default 0.01)
/// </summary>
public HsvholdFilterGen similarity(float similarity) => this.SetOptionRange("similarity", similarity,1e-05,1);
/// <summary>
///  set the hsvhold blend value (from 0 to 1) (default 0)
/// </summary>
public HsvholdFilterGen blend(float blend) => this.SetOptionRange("blend", blend,0,1);
}
/// <summary>
/// </summary>
public static class HsvholdFilterGenExtensions
{
/// <summary>
/// Turns a certain HSV range into gray.
/// </summary>
public static HsvholdFilterGen HsvholdFilterGen(this ImageMap input0) => new HsvholdFilterGen(input0);
}
}
