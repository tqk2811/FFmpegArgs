namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... xfade_vulkan      VV->V      Cross fade one video with another video.
/// </summary>
public class Xfade_vulkanFilterGen : ImageToImageFilter
{
internal Xfade_vulkanFilterGen(params ImageMap[] inputs) : base("xfade_vulkan",inputs) { AddMapOut(); }
/// <summary>
///  set cross fade transition (from 0 to 16) (default fade)
/// </summary>
public Xfade_vulkanFilterGen transition(Xfade_vulkanFilterGenTransition transition) => this.SetOption("transition", transition.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set cross fade duration (default 1)
/// </summary>
public Xfade_vulkanFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set cross fade start relative to first input stream (default 0)
/// </summary>
public Xfade_vulkanFilterGen offset(TimeSpan offset) => this.SetOptionRange("offset",offset,TimeSpan.Zero,TimeSpan.MaxValue);
}
/// <summary>
/// </summary>
public static class Xfade_vulkanFilterGenExtensions
{
/// <summary>
/// Cross fade one video with another video.
/// </summary>
public static Xfade_vulkanFilterGen Xfade_vulkanFilterGen(this ImageMap input0, ImageMap input1) => new Xfade_vulkanFilterGen(input0, input1);
}
/// <summary>
///  set cross fade transition (from 0 to 16) (default fade)
/// </summary>
public enum Xfade_vulkanFilterGenTransition
{
/// <summary>
/// fade            0            ..FV....... fade transition
/// </summary>
[Name("fade")] fade,
/// <summary>
/// wipeleft        1            ..FV....... wipe left transition
/// </summary>
[Name("wipeleft")] wipeleft,
/// <summary>
/// wiperight       2            ..FV....... wipe right transition
/// </summary>
[Name("wiperight")] wiperight,
/// <summary>
/// wipeup          3            ..FV....... wipe up transition
/// </summary>
[Name("wipeup")] wipeup,
/// <summary>
/// wipedown        4            ..FV....... wipe down transition
/// </summary>
[Name("wipedown")] wipedown,
/// <summary>
/// slidedown       5            ..FV....... slide down transition
/// </summary>
[Name("slidedown")] slidedown,
/// <summary>
/// slideup         6            ..FV....... slide up transition
/// </summary>
[Name("slideup")] slideup,
/// <summary>
/// slideleft       7            ..FV....... slide left transition
/// </summary>
[Name("slideleft")] slideleft,
/// <summary>
/// slideright      8            ..FV....... slide right transition
/// </summary>
[Name("slideright")] slideright,
/// <summary>
/// circleopen      9            ..FV....... circleopen transition
/// </summary>
[Name("circleopen")] circleopen,
/// <summary>
/// circleclose     10           ..FV....... circleclose transition
/// </summary>
[Name("circleclose")] circleclose,
/// <summary>
/// dissolve        11           ..FV....... dissolve transition
/// </summary>
[Name("dissolve")] dissolve,
/// <summary>
/// pixelize        12           ..FV....... pixelize transition
/// </summary>
[Name("pixelize")] pixelize,
/// <summary>
/// wipetl          13           ..FV....... wipe top left transition
/// </summary>
[Name("wipetl")] wipetl,
/// <summary>
/// wipetr          14           ..FV....... wipe top right transition
/// </summary>
[Name("wipetr")] wipetr,
/// <summary>
/// wipebl          15           ..FV....... wipe bottom left transition
/// </summary>
[Name("wipebl")] wipebl,
/// <summary>
/// wipebr          16           ..FV....... wipe bottom right transition
/// </summary>
[Name("wipebr")] wipebr,
}

}
