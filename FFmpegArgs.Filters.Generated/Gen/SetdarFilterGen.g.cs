namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... setdar            V->V       Set the frame display aspect ratio.
/// </summary>
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
/// <summary>
/// </summary>
public static class SetdarFilterGenExtensions
{
/// <summary>
/// Set the frame display aspect ratio.
/// </summary>
public static SetdarFilterGen SetdarFilterGen(this ImageMap input0) => new SetdarFilterGen(input0);
}
}
