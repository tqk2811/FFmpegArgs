namespace FFmpegArgs.Filters.Autogens
{
public class HaldclutsrcFilterGen : SourceImageFilter
{
internal HaldclutsrcFilterGen(FilterGraph input) : base("haldclutsrc",input) { AddMapOut(); }
/// <summary>
///  set level (from 2 to 16) (default 6)
/// </summary>
public HaldclutsrcFilterGen level(int level) => this.SetOptionRange("level", level,2,16);
/// <summary>
///  set video rate (default "25")
/// </summary>
public HaldclutsrcFilterGen rate(Rational rate) => this.SetOption("rate",rate);
/// <summary>
///  set video duration (default -0.000001)
/// </summary>
public HaldclutsrcFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set video sample aspect ratio (from 0 to INT_MAX) (default 1/1)
/// </summary>
public HaldclutsrcFilterGen sar(Rational sar) => this.SetOption("sar",sar.Check(0,INT_MAX));
}
public static class HaldclutsrcFilterGenExtensions
{
/// <summary>
/// Provide an identity Hald CLUT.
/// </summary>
public static HaldclutsrcFilterGen HaldclutsrcFilterGen(this FilterGraph input0) => new HaldclutsrcFilterGen(input0);
/// <summary>
/// Provide an identity Hald CLUT.
/// </summary>
public static HaldclutsrcFilterGen HaldclutsrcFilterGen(this FilterGraph input0,HaldclutsrcFilterGenConfig config)
{
var result = new HaldclutsrcFilterGen(input0);
if(config?.level != null) result.level(config.level.Value);
if(config?.rate != null) result.rate(config.rate);
if(config?.duration != null) result.duration(config.duration.Value);
if(config?.sar != null) result.sar(config.sar);
return result;
}
}
public class HaldclutsrcFilterGenConfig
{
/// <summary>
///  set level (from 2 to 16) (default 6)
/// </summary>
public int? level { get; set; }
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
