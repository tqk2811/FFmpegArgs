namespace FFmpegArgs.Filters.Autogens
{
public class FloodfillFilterGen : ImageToImageFilter,ITimelineSupport
{
internal FloodfillFilterGen(ImageMap input) : base("floodfill",input) { AddMapOut(); }
/// <summary>
///  set pixel x coordinate (from 0 to 65535) (default 0)
/// </summary>
public FloodfillFilterGen x(int x) => this.SetOptionRange("x", x,0,65535);
/// <summary>
///  set pixel y coordinate (from 0 to 65535) (default 0)
/// </summary>
public FloodfillFilterGen y(int y) => this.SetOptionRange("y", y,0,65535);
/// <summary>
///  set source #0 component value (from -1 to 65535) (default 0)
/// </summary>
public FloodfillFilterGen s0(int s0) => this.SetOptionRange("s0", s0,-1,65535);
/// <summary>
///  set source #1 component value (from -1 to 65535) (default 0)
/// </summary>
public FloodfillFilterGen s1(int s1) => this.SetOptionRange("s1", s1,-1,65535);
/// <summary>
///  set source #2 component value (from -1 to 65535) (default 0)
/// </summary>
public FloodfillFilterGen s2(int s2) => this.SetOptionRange("s2", s2,-1,65535);
/// <summary>
///  set source #3 component value (from -1 to 65535) (default 0)
/// </summary>
public FloodfillFilterGen s3(int s3) => this.SetOptionRange("s3", s3,-1,65535);
/// <summary>
///  set destination #0 component value (from 0 to 65535) (default 0)
/// </summary>
public FloodfillFilterGen d0(int d0) => this.SetOptionRange("d0", d0,0,65535);
/// <summary>
///  set destination #1 component value (from 0 to 65535) (default 0)
/// </summary>
public FloodfillFilterGen d1(int d1) => this.SetOptionRange("d1", d1,0,65535);
/// <summary>
///  set destination #2 component value (from 0 to 65535) (default 0)
/// </summary>
public FloodfillFilterGen d2(int d2) => this.SetOptionRange("d2", d2,0,65535);
/// <summary>
///  set destination #3 component value (from 0 to 65535) (default 0)
/// </summary>
public FloodfillFilterGen d3(int d3) => this.SetOptionRange("d3", d3,0,65535);
}
public static class FloodfillFilterGenExtensions
{
/// <summary>
/// Fill area with same color with another color.
/// </summary>
public static FloodfillFilterGen FloodfillFilterGen(this ImageMap input0) => new FloodfillFilterGen(input0);
/// <summary>
/// Fill area with same color with another color.
/// </summary>
public static FloodfillFilterGen FloodfillFilterGen(this ImageMap input0,FloodfillFilterGenConfig config)
{
var result = new FloodfillFilterGen(input0);
if(config?.x != null) result.x(config.x.Value);
if(config?.y != null) result.y(config.y.Value);
if(config?.s0 != null) result.s0(config.s0.Value);
if(config?.s1 != null) result.s1(config.s1.Value);
if(config?.s2 != null) result.s2(config.s2.Value);
if(config?.s3 != null) result.s3(config.s3.Value);
if(config?.d0 != null) result.d0(config.d0.Value);
if(config?.d1 != null) result.d1(config.d1.Value);
if(config?.d2 != null) result.d2(config.d2.Value);
if(config?.d3 != null) result.d3(config.d3.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class FloodfillFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set pixel x coordinate (from 0 to 65535) (default 0)
/// </summary>
public int? x { get; set; }
/// <summary>
///  set pixel y coordinate (from 0 to 65535) (default 0)
/// </summary>
public int? y { get; set; }
/// <summary>
///  set source #0 component value (from -1 to 65535) (default 0)
/// </summary>
public int? s0 { get; set; }
/// <summary>
///  set source #1 component value (from -1 to 65535) (default 0)
/// </summary>
public int? s1 { get; set; }
/// <summary>
///  set source #2 component value (from -1 to 65535) (default 0)
/// </summary>
public int? s2 { get; set; }
/// <summary>
///  set source #3 component value (from -1 to 65535) (default 0)
/// </summary>
public int? s3 { get; set; }
/// <summary>
///  set destination #0 component value (from 0 to 65535) (default 0)
/// </summary>
public int? d0 { get; set; }
/// <summary>
///  set destination #1 component value (from 0 to 65535) (default 0)
/// </summary>
public int? d1 { get; set; }
/// <summary>
///  set destination #2 component value (from 0 to 65535) (default 0)
/// </summary>
public int? d2 { get; set; }
/// <summary>
///  set destination #3 component value (from 0 to 65535) (default 0)
/// </summary>
public int? d3 { get; set; }
public string TimelineSupport { get; set; }
}
}
