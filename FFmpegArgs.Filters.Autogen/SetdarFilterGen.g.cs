namespace FFmpegArgs.Filters.Autogens
{
public class SetdarFilterGen : ImageToImageFilter
{
internal SetdarFilterGen(ImageMap input) : base("setdar",input) { AddMapOut(); }
/// <summary>
///  set display aspect ratio (default "0")
/// </summary>
public SetdarFilterGen dar(string dar) => this.SetOption("dar",dar);
/// <summary>
///  set display aspect ratio (default "0")
/// </summary>
public SetdarFilterGen ratio(string ratio) => this.SetOption("ratio",ratio);
/// <summary>
///  set display aspect ratio (default "0")
/// </summary>
public SetdarFilterGen r(string r) => this.SetOption("r",r);
/// <summary>
///  set max value for nominator or denominator in the ratio (from 1 to INT_MAX) (default 100)
/// </summary>
public SetdarFilterGen max(int max) => this.SetOptionRange("max", max,1,INT_MAX);
}
public static class SetdarFilterGenExtensions
{
/// <summary>
/// Set the frame display aspect ratio.
/// </summary>
public static SetdarFilterGen SetdarFilterGen(this ImageMap input0) => new SetdarFilterGen(input0);
/// <summary>
/// Set the frame display aspect ratio.
/// </summary>
public static SetdarFilterGen SetdarFilterGen(this ImageMap input0,SetdarFilterGenConfig config)
{
var result = new SetdarFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.dar)) result.dar(config.dar);
if(!string.IsNullOrWhiteSpace(config?.ratio)) result.ratio(config.ratio);
if(!string.IsNullOrWhiteSpace(config?.r)) result.r(config.r);
if(config?.max != null) result.max(config.max.Value);
return result;
}
}
public class SetdarFilterGenConfig
{
/// <summary>
///  set display aspect ratio (default "0")
/// </summary>
public string dar { get; set; }
/// <summary>
///  set display aspect ratio (default "0")
/// </summary>
public string ratio { get; set; }
/// <summary>
///  set display aspect ratio (default "0")
/// </summary>
public string r { get; set; }
/// <summary>
///  set max value for nominator or denominator in the ratio (from 1 to INT_MAX) (default 100)
/// </summary>
public int? max { get; set; }
}
}
