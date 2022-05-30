namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC colorize          V->V       Overlay a solid color on the video stream.
/// </summary>
public class ColorizeFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ColorizeFilterGen(ImageMap input) : base("colorize",input) { AddMapOut(); }
/// <summary>
///  set the hue (from 0 to 360) (default 0)
/// </summary>
public ColorizeFilterGen hue(float hue) => this.SetOptionRange("hue", hue,0,360);
/// <summary>
///  set the saturation (from 0 to 1) (default 0.5)
/// </summary>
public ColorizeFilterGen saturation(float saturation) => this.SetOptionRange("saturation", saturation,0,1);
/// <summary>
///  set the lightness (from 0 to 1) (default 0.5)
/// </summary>
public ColorizeFilterGen lightness(float lightness) => this.SetOptionRange("lightness", lightness,0,1);
/// <summary>
///  set the mix of source lightness (from 0 to 1) (default 1)
/// </summary>
public ColorizeFilterGen mix(float mix) => this.SetOptionRange("mix", mix,0,1);
}
/// <summary>
/// </summary>
public static class ColorizeFilterGenExtensions
{
/// <summary>
/// Overlay a solid color on the video stream.
/// </summary>
public static ColorizeFilterGen ColorizeFilterGen(this ImageMap input0) => new ColorizeFilterGen(input0);
}
}
