namespace FFmpegArgs.Filters.Autogens
{
public class SignalstatsFilterGen : ImageToImageFilter,ISliceThreading
{
internal SignalstatsFilterGen(ImageMap input) : base("signalstats",input) { AddMapOut(); }
/// <summary>
///  set statistics filters (default 0)
/// </summary>
public SignalstatsFilterGen stat(SignalstatsFilterGenStat stat) => this.SetOption("stat", stat.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set video filter (from -1 to 2) (default -1)
/// </summary>
public SignalstatsFilterGen _out(SignalstatsFilterGenOut _out) => this.SetOption("out", _out.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set highlight color (default "yellow")
/// </summary>
public SignalstatsFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
}
public static class SignalstatsFilterGenExtensions
{
/// <summary>
/// Generate statistics from video analysis.
/// </summary>
public static SignalstatsFilterGen SignalstatsFilterGen(this ImageMap input0) => new SignalstatsFilterGen(input0);
/// <summary>
/// Generate statistics from video analysis.
/// </summary>
public static SignalstatsFilterGen SignalstatsFilterGen(this ImageMap input0,SignalstatsFilterGenConfig config)
{
var result = new SignalstatsFilterGen(input0);
if(config?.stat != null) result.stat(config.stat.Value);
if(config?._out != null) result._out(config._out.Value);
if(config?.color != null) result.color(config.color.Value);
return result;
}
}
public class SignalstatsFilterGenConfig
{
/// <summary>
///  set statistics filters (default 0)
/// </summary>
public SignalstatsFilterGenStat? stat { get; set; }
/// <summary>
///  set video filter (from -1 to 2) (default -1)
/// </summary>
public SignalstatsFilterGenOut? _out { get; set; }
/// <summary>
///  set highlight color (default "yellow")
/// </summary>
public Color? color { get; set; }
}
public enum SignalstatsFilterGenStat
{
[Name("tout")] tout,
[Name("vrep")] vrep,
[Name("brng")] brng,
}

public enum SignalstatsFilterGenOut
{
[Name("tout")] tout,
[Name("vrep")] vrep,
[Name("brng")] brng,
}

}
