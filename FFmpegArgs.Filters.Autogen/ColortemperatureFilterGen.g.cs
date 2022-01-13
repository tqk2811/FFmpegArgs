namespace FFmpegArgs.Filters.Autogens
{
public class ColortemperatureFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ColortemperatureFilterGen(ImageMap input) : base("colortemperature",input) { AddMapOut(); }
/// <summary>
///  set the temperature in Kelvin (from 1000 to 40000) (default 6500)
/// </summary>
public ColortemperatureFilterGen temperature(float temperature) => this.SetOptionRange("temperature", temperature,1000,40000);
/// <summary>
///  set the mix with filtered output (from 0 to 1) (default 1)
/// </summary>
public ColortemperatureFilterGen mix(float mix) => this.SetOptionRange("mix", mix,0,1);
/// <summary>
///  set the amount of preserving lightness (from 0 to 1) (default 0)
/// </summary>
public ColortemperatureFilterGen pl(float pl) => this.SetOptionRange("pl", pl,0,1);
}
public static class ColortemperatureFilterGenExtensions
{
/// <summary>
/// Adjust color temperature of video.
/// </summary>
public static ColortemperatureFilterGen ColortemperatureFilterGen(this ImageMap input0) => new ColortemperatureFilterGen(input0);
/// <summary>
/// Adjust color temperature of video.
/// </summary>
public static ColortemperatureFilterGen ColortemperatureFilterGen(this ImageMap input0,ColortemperatureFilterGenConfig config)
{
var result = new ColortemperatureFilterGen(input0);
if(config?.temperature != null) result.temperature(config.temperature.Value);
if(config?.mix != null) result.mix(config.mix.Value);
if(config?.pl != null) result.pl(config.pl.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class ColortemperatureFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set the temperature in Kelvin (from 1000 to 40000) (default 6500)
/// </summary>
public float? temperature { get; set; }
/// <summary>
///  set the mix with filtered output (from 0 to 1) (default 1)
/// </summary>
public float? mix { get; set; }
/// <summary>
///  set the amount of preserving lightness (from 0 to 1) (default 0)
/// </summary>
public float? pl { get; set; }
public string TimelineSupport { get; set; }
}
}
