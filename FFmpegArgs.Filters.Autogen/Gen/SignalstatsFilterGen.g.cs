namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// .S. signalstats       V->V       Generate statistics from video analysis.
/// </summary>
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
/// <summary>
/// </summary>
public static class SignalstatsFilterGenExtensions
{
/// <summary>
/// Generate statistics from video analysis.
/// </summary>
public static SignalstatsFilterGen SignalstatsFilterGen(this ImageMap input0) => new SignalstatsFilterGen(input0);
}
/// <summary>
///  set statistics filters (default 0)
/// </summary>
public enum SignalstatsFilterGenStat
{
/// <summary>
/// tout                         ..FV....... analyze pixels for temporal outliers
/// </summary>
[Name("tout")] tout,
/// <summary>
/// vrep                         ..FV....... analyze video lines for vertical line repetition
/// </summary>
[Name("vrep")] vrep,
/// <summary>
/// brng                         ..FV....... analyze for pixels outside of broadcast range
/// </summary>
[Name("brng")] brng,
}

/// <summary>
///  set video filter (from -1 to 2) (default -1)
/// </summary>
public enum SignalstatsFilterGenOut
{
/// <summary>
/// tout            0            ..FV....... highlight pixels that depict temporal outliers
/// </summary>
[Name("tout")] tout,
/// <summary>
/// vrep            1            ..FV....... highlight video lines that depict vertical line repetition
/// </summary>
[Name("vrep")] vrep,
/// <summary>
/// brng            2            ..FV....... highlight pixels that are outside of broadcast range
/// </summary>
[Name("brng")] brng,
}

}
