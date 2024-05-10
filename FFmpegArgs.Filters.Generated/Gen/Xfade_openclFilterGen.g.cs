namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... xfade_opencl      VV->V      Cross fade one video with another video.
/// </summary>
public class Xfade_openclFilterGen : ImageToImageFilter
{
internal Xfade_openclFilterGen(params ImageMap[] inputs) : base("xfade_opencl",inputs) { AddMapOut(); }
/// <summary>
///  set cross fade transition (from 0 to 9) (default fade)
/// </summary>
public Xfade_openclFilterGen transition(Xfade_openclFilterGenTransition transition) => this.SetOption("transition", transition.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set OpenCL program source file for custom transition
/// </summary>
public Xfade_openclFilterGen source(string source) => this.SetOption("source",source);
/// <summary>
///  set kernel name in program file for custom transition
/// </summary>
public Xfade_openclFilterGen kernel(string kernel) => this.SetOption("kernel",kernel);
/// <summary>
///  set cross fade duration (default 1)
/// </summary>
public Xfade_openclFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set cross fade start relative to first input stream (default 0)
/// </summary>
public Xfade_openclFilterGen offset(TimeSpan offset) => this.SetOptionRange("offset",offset,TimeSpan.Zero,TimeSpan.MaxValue);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Cross fade one video with another video.
/// </summary>
public static Xfade_openclFilterGen Xfade_openclFilterGen(this ImageMap input0, ImageMap input1) => new Xfade_openclFilterGen(input0, input1);
}
/// <summary>
///  set cross fade transition (from 0 to 9) (default fade)
/// </summary>
public enum Xfade_openclFilterGenTransition
{
/// <summary>
/// custom          0            ..FV....... custom transition
/// </summary>
[Name("custom")] custom,
/// <summary>
/// fade            1            ..FV....... fade transition
/// </summary>
[Name("fade")] fade,
/// <summary>
/// wipeleft        2            ..FV....... wipe left transition
/// </summary>
[Name("wipeleft")] wipeleft,
/// <summary>
/// wiperight       3            ..FV....... wipe right transition
/// </summary>
[Name("wiperight")] wiperight,
/// <summary>
/// wipeup          4            ..FV....... wipe up transition
/// </summary>
[Name("wipeup")] wipeup,
/// <summary>
/// wipedown        5            ..FV....... wipe down transition
/// </summary>
[Name("wipedown")] wipedown,
/// <summary>
/// slideleft       6            ..FV....... slide left transition
/// </summary>
[Name("slideleft")] slideleft,
/// <summary>
/// slideright      7            ..FV....... slide right transition
/// </summary>
[Name("slideright")] slideright,
/// <summary>
/// slideup         8            ..FV....... slide up transition
/// </summary>
[Name("slideup")] slideup,
/// <summary>
/// slidedown       9            ..FV....... slide down transition
/// </summary>
[Name("slidedown")] slidedown,
}

}
