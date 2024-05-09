namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC colorhold         V->V       Turns a certain color range into gray. Operates on RGB colors.
/// </summary>
public class ColorholdFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ColorholdFilterGen(ImageMap input) : base("colorhold",input) { AddMapOut(); }
/// <summary>
///  set the colorhold key color (default "black")
/// </summary>
public ColorholdFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
/// <summary>
///  set the colorhold similarity value (from 1e-05 to 1) (default 0.01)
/// </summary>
public ColorholdFilterGen similarity(float similarity) => this.SetOptionRange("similarity", similarity,1e-05,1);
/// <summary>
///  set the colorhold blend value (from 0 to 1) (default 0)
/// </summary>
public ColorholdFilterGen blend(float blend) => this.SetOptionRange("blend", blend,0,1);
}
/// <summary>
/// </summary>
public static class ColorholdFilterGenExtensions
{
/// <summary>
/// Turns a certain color range into gray. Operates on RGB colors.
/// </summary>
public static ColorholdFilterGen ColorholdFilterGen(this ImageMap input0) => new ColorholdFilterGen(input0);
}
}
