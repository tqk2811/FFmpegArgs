namespace FFmpegArgs.Filters.Autogens
{
public class RgbtestsrcFilterGen : SourceImageFilter
{
internal RgbtestsrcFilterGen(FilterGraph input) : base("rgbtestsrc",input) { AddMapOut(); }
/// <summary>
///  set video size (default "320x240")
/// </summary>
public RgbtestsrcFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public RgbtestsrcFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public RgbtestsrcFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public RgbtestsrcFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
/// <summary>
///  set complement colors (default false)
/// </summary>
public RgbtestsrcFilterGen complement(bool complement) => this.SetOption("complement",complement.ToFFmpegFlag());
}
public static class RgbtestsrcFilterGenExtensions
{
/// <summary>
/// Generate RGB test pattern.
/// </summary>
public static RgbtestsrcFilterGen RgbtestsrcFilterGen(this FilterGraph input0) => new RgbtestsrcFilterGen(input0);
/// <summary>
/// Generate RGB test pattern.
/// </summary>
public static RgbtestsrcFilterGen RgbtestsrcFilterGen(this FilterGraph input0,RgbtestsrcFilterGenConfig config)
{
var result = new RgbtestsrcFilterGen(input0);
if(config?.size != null) result.size(config.size.Value);
if(config?.rate != null) result.rate(config.rate);
if(config?.duration != null) result.duration(config.duration.Value);
if(config?.sar != null) result.sar(config.sar);
if(config?.complement != null) result.complement(config.complement.Value);
return result;
}
}
public class RgbtestsrcFilterGenConfig
{
/// <summary>
///  set video size (default "320x240")
/// </summary>
public Size? size { get; set; }
/// <summary>
///  set video rate (default "25")
/// </summary>
public Rational rate { get; set; }
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public TimeSpan? duration { get; set; }
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public Rational sar { get; set; }
/// <summary>
///  set complement colors (default false)
/// </summary>
public bool? complement { get; set; }
}
}
