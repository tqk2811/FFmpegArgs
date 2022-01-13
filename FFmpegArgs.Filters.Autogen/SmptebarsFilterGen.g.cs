namespace FFmpegArgs.Filters.Autogens
{
public class SmptebarsFilterGen : SourceImageFilter
{
internal SmptebarsFilterGen(FilterGraph input) : base("smptebars",input) { AddMapOut(); }
/// <summary>
///  set video size (default "320x240")
/// </summary>
public SmptebarsFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public SmptebarsFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public SmptebarsFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public SmptebarsFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
public static class SmptebarsFilterGenExtensions
{
/// <summary>
/// Generate SMPTE color bars.
/// </summary>
public static SmptebarsFilterGen SmptebarsFilterGen(this FilterGraph input0) => new SmptebarsFilterGen(input0);
/// <summary>
/// Generate SMPTE color bars.
/// </summary>
public static SmptebarsFilterGen SmptebarsFilterGen(this FilterGraph input0,SmptebarsFilterGenConfig config)
{
var result = new SmptebarsFilterGen(input0);
if(config?.size != null) result.size(config.size.Value);
if(config?.rate != null) result.rate(config.rate);
if(config?.duration != null) result.duration(config.duration.Value);
if(config?.sar != null) result.sar(config.sar);
return result;
}
}
public class SmptebarsFilterGenConfig
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
}
}
