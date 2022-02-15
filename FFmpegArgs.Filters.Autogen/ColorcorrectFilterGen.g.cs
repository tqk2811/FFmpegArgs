namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC colorcorrect      V->V       Adjust color white balance selectively for blacks and whites.
/// </summary>
public class ColorcorrectFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ColorcorrectFilterGen(ImageMap input) : base("colorcorrect",input) { AddMapOut(); }
/// <summary>
///  set the red shadow spot (from -1 to 1) (default 0)
/// </summary>
public ColorcorrectFilterGen rl(float rl) => this.SetOptionRange("rl", rl,-1,1);
/// <summary>
///  set the blue shadow spot (from -1 to 1) (default 0)
/// </summary>
public ColorcorrectFilterGen bl(float bl) => this.SetOptionRange("bl", bl,-1,1);
/// <summary>
///  set the red highlight spot (from -1 to 1) (default 0)
/// </summary>
public ColorcorrectFilterGen rh(float rh) => this.SetOptionRange("rh", rh,-1,1);
/// <summary>
///  set the blue highlight spot (from -1 to 1) (default 0)
/// </summary>
public ColorcorrectFilterGen bh(float bh) => this.SetOptionRange("bh", bh,-1,1);
/// <summary>
///  set the amount of saturation (from -3 to 3) (default 1)
/// </summary>
public ColorcorrectFilterGen saturation(float saturation) => this.SetOptionRange("saturation", saturation,-3,3);
}
/// <summary>
/// </summary>
public static class ColorcorrectFilterGenExtensions
{
/// <summary>
/// Adjust color white balance selectively for blacks and whites.
/// </summary>
public static ColorcorrectFilterGen ColorcorrectFilterGen(this ImageMap input0) => new ColorcorrectFilterGen(input0);
}
}
