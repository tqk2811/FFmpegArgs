namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// .S. framerate         V->V       Upsamples or downsamples progressive source between specified frame rates.
/// </summary>
public class FramerateFilterGen : ImageToImageFilter,ISliceThreading
{
internal FramerateFilterGen(ImageMap input) : base("framerate",input) { AddMapOut(); }
/// <summary>
///  required output frames per second rate (default "50")
/// </summary>
public FramerateFilterGen fps(Rational fps) => this.SetOption("fps",fps);
/// <summary>
///  point to start linear interpolation (from 0 to 255) (default 15)
/// </summary>
public FramerateFilterGen interp_start(int interp_start) => this.SetOptionRange("interp_start", interp_start,0,255);
/// <summary>
///  point to end linear interpolation (from 0 to 255) (default 240)
/// </summary>
public FramerateFilterGen interp_end(int interp_end) => this.SetOptionRange("interp_end", interp_end,0,255);
/// <summary>
///  scene change level (from 0 to 100) (default 8.2)
/// </summary>
public FramerateFilterGen scene(double scene) => this.SetOptionRange("scene", scene,0,100);
/// <summary>
///  set flags (default scene_change_detect+scd)
/// </summary>
public FramerateFilterGen flags(FramerateFilterGenFlags flags) => this.SetOption("flags", flags.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Upsamples or downsamples progressive source between specified frame rates.
/// </summary>
public static FramerateFilterGen FramerateFilterGen(this ImageMap input0) => new FramerateFilterGen(input0);
}
/// <summary>
///  set flags (default scene_change_detect+scd)
/// </summary>
public enum FramerateFilterGenFlags
{
/// <summary>
/// scene_change_detect              ..FV....... enable scene change detection
/// </summary>
[Name("scene_change_detect")] scene_change_detect,
/// <summary>
/// scd                          ..FV....... enable scene change detection
/// </summary>
[Name("scd")] scd,
}

}
