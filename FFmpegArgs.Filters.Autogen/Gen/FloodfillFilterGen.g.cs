namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.. floodfill         V->V       Fill area with same color with another color.
/// </summary>
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
/// <summary>
/// </summary>
public static class FloodfillFilterGenExtensions
{
/// <summary>
/// Fill area with same color with another color.
/// </summary>
public static FloodfillFilterGen FloodfillFilterGen(this ImageMap input0) => new FloodfillFilterGen(input0);
}
}
