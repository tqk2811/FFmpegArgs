namespace FFmpegArgs.Filters.Autogens
{
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
public static class ColorizeFilterGenExtensions
{
/// <summary>
/// Overlay a solid color on the video stream.
/// </summary>
public static ColorizeFilterGen ColorizeFilterGen(this ImageMap input0) => new ColorizeFilterGen(input0);
/// <summary>
/// Overlay a solid color on the video stream.
/// </summary>
public static ColorizeFilterGen ColorizeFilterGen(this ImageMap input0,ColorizeFilterGenConfig config)
{
var result = new ColorizeFilterGen(input0);
if(config?.hue != null) result.hue(config.hue.Value);
if(config?.saturation != null) result.saturation(config.saturation.Value);
if(config?.lightness != null) result.lightness(config.lightness.Value);
if(config?.mix != null) result.mix(config.mix.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class ColorizeFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set the hue (from 0 to 360) (default 0)
/// </summary>
public float? hue { get; set; }
/// <summary>
///  set the saturation (from 0 to 1) (default 0.5)
/// </summary>
public float? saturation { get; set; }
/// <summary>
///  set the lightness (from 0 to 1) (default 0.5)
/// </summary>
public float? lightness { get; set; }
/// <summary>
///  set the mix of source lightness (from 0 to 1) (default 1)
/// </summary>
public float? mix { get; set; }
public string TimelineSupport { get; set; }
}
}
