namespace FFmpegArgs.Filters.Autogens
{
public class EdgedetectFilterGen : ImageToImageFilter,ITimelineSupport
{
internal EdgedetectFilterGen(ImageMap input) : base("edgedetect",input) { AddMapOut(); }
/// <summary>
///  set high threshold (from 0 to 1) (default 0.196078)
/// </summary>
public EdgedetectFilterGen high(double high) => this.SetOptionRange("high", high,0,1);
/// <summary>
///  set low threshold (from 0 to 1) (default 0.0784314)
/// </summary>
public EdgedetectFilterGen low(double low) => this.SetOptionRange("low", low,0,1);
/// <summary>
///  set mode (from 0 to 2) (default wires)
/// </summary>
public EdgedetectFilterGen mode(EdgedetectFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set planes to filter (default y+u+v+r+g+b)
/// </summary>
public EdgedetectFilterGen planes(EdgedetectFilterGenPlanes planes) => this.SetOption("planes", planes.GetEnumAttribute<NameAttribute>().Name);
}
public static class EdgedetectFilterGenExtensions
{
/// <summary>
/// Detect and draw edge.
/// </summary>
public static EdgedetectFilterGen EdgedetectFilterGen(this ImageMap input0) => new EdgedetectFilterGen(input0);
/// <summary>
/// Detect and draw edge.
/// </summary>
public static EdgedetectFilterGen EdgedetectFilterGen(this ImageMap input0,EdgedetectFilterGenConfig config)
{
var result = new EdgedetectFilterGen(input0);
if(config?.high != null) result.high(config.high.Value);
if(config?.low != null) result.low(config.low.Value);
if(config?.mode != null) result.mode(config.mode.Value);
if(config?.planes != null) result.planes(config.planes.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class EdgedetectFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set high threshold (from 0 to 1) (default 0.196078)
/// </summary>
public double? high { get; set; }
/// <summary>
///  set low threshold (from 0 to 1) (default 0.0784314)
/// </summary>
public double? low { get; set; }
/// <summary>
///  set mode (from 0 to 2) (default wires)
/// </summary>
public EdgedetectFilterGenMode? mode { get; set; }
/// <summary>
///  set planes to filter (default y+u+v+r+g+b)
/// </summary>
public EdgedetectFilterGenPlanes? planes { get; set; }
public string TimelineSupport { get; set; }
}
public enum EdgedetectFilterGenMode
{
[Name("wires")] wires,
[Name("colormix")] colormix,
[Name("canny")] canny,
}

public enum EdgedetectFilterGenPlanes
{
[Name("y")] y,
[Name("u")] u,
[Name("v")] v,
[Name("r")] r,
[Name("g")] g,
[Name("b")] b,
}

}
