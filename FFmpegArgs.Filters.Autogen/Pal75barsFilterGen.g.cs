namespace FFmpegArgs.Filters.Autogens
{
public class Pal75barsFilterGen : SourceImageFilter
{
internal Pal75barsFilterGen(FilterGraph input) : base("pal75bars",input) { AddMapOut(); }
/// <summary>
///  set video size (default "320x240")
/// </summary>
public Pal75barsFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video rate (default "25")
/// </summary>
public Pal75barsFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public Pal75barsFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public Pal75barsFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
public static class Pal75barsFilterGenExtensions
{
/// <summary>
/// Generate PAL 75% color bars.
/// </summary>
public static Pal75barsFilterGen Pal75barsFilterGen(this FilterGraph input0) => new Pal75barsFilterGen(input0);
/// <summary>
/// Generate PAL 75% color bars.
/// </summary>
public static Pal75barsFilterGen Pal75barsFilterGen(this FilterGraph input0,Pal75barsFilterGenConfig config)
{
var result = new Pal75barsFilterGen(input0);
if(config?.size != null) result.size(config.size.Value);
if(config?.rate != null) result.rate(config.rate);
if(config?.duration != null) result.duration(config.duration.Value);
if(config?.sar != null) result.sar(config.sar);
return result;
}
}
public class Pal75barsFilterGenConfig
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
