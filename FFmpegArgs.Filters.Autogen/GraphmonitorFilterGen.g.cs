namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... graphmonitor      V->V       Show various filtergraph stats.
/// </summary>
public class GraphmonitorFilterGen : ImageToImageFilter
{
internal GraphmonitorFilterGen(ImageMap input) : base("graphmonitor",input) { AddMapOut(); }
/// <summary>
///  set monitor size (default "hd720")
/// </summary>
public GraphmonitorFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set video opacity (from 0 to 1) (default 0.9)
/// </summary>
public GraphmonitorFilterGen opacity(float opacity) => this.SetOptionRange("opacity", opacity,0,1);
/// <summary>
///  set mode (from 0 to 1) (default full)
/// </summary>
public GraphmonitorFilterGen mode(GraphmonitorFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set flags (default queue)
/// </summary>
public GraphmonitorFilterGen flags(GraphmonitorFilterGenFlags flags) => this.SetOption("flags", flags.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set video rate (default "25")
/// </summary>
public GraphmonitorFilterGen rate(Rational rate) => this.SetOption("rate",rate);
}
/// <summary>
/// </summary>
public static class GraphmonitorFilterGenExtensions
{
/// <summary>
/// Show various filtergraph stats.
/// </summary>
public static GraphmonitorFilterGen GraphmonitorFilterGen(this ImageMap input0) => new GraphmonitorFilterGen(input0);
}
/// <summary>
///  set mode (from 0 to 1) (default full)
/// </summary>
public enum GraphmonitorFilterGenMode
{
/// <summary>
/// full            0            ..FV.......
/// </summary>
[Name("full")] full,
/// <summary>
/// compact         1            ..FV.......
/// </summary>
[Name("compact")] compact,
}

/// <summary>
///  set flags (default queue)
/// </summary>
public enum GraphmonitorFilterGenFlags
{
/// <summary>
/// queue                        ..FV.......
/// </summary>
[Name("queue")] queue,
/// <summary>
/// frame_count_in               ..FV.......
/// </summary>
[Name("frame_count_in")] frame_count_in,
/// <summary>
/// frame_count_out              ..FV.......
/// </summary>
[Name("frame_count_out")] frame_count_out,
/// <summary>
/// pts                          ..FV.......
/// </summary>
[Name("pts")] pts,
/// <summary>
/// time                         ..FV.......
/// </summary>
[Name("time")] time,
/// <summary>
/// timebase                     ..FV.......
/// </summary>
[Name("timebase")] timebase,
/// <summary>
/// format                       ..FV.......
/// </summary>
[Name("format")] format,
/// <summary>
/// size                         ..FV.......
/// </summary>
[Name("size")] size,
/// <summary>
/// rate                         ..FV.......
/// </summary>
[Name("rate")] rate,
/// <summary>
/// eof                          ..FV.......
/// </summary>
[Name("eof")] eof,
}

}
