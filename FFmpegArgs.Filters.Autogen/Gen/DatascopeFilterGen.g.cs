namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// .SC datascope         V->V       Video data analysis.
/// </summary>
public class DatascopeFilterGen : ImageToImageFilter,ISliceThreading,ICommandSupport
{
internal DatascopeFilterGen(ImageMap input) : base("datascope",input) { AddMapOut(); }
/// <summary>
///  set output size (default "hd720")
/// </summary>
public DatascopeFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  set x offset (from 0 to INT_MAX) (default 0)
/// </summary>
public DatascopeFilterGen x(int x) => this.SetOptionRange("x", x,0,INT_MAX);
/// <summary>
///  set y offset (from 0 to INT_MAX) (default 0)
/// </summary>
public DatascopeFilterGen y(int y) => this.SetOptionRange("y", y,0,INT_MAX);
/// <summary>
///  set scope mode (from 0 to 2) (default mono)
/// </summary>
public DatascopeFilterGen mode(DatascopeFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  draw column/row numbers (default false)
/// </summary>
public DatascopeFilterGen axis(bool axis) => this.SetOption("axis",axis.ToFFmpegFlag());
/// <summary>
///  set background opacity (from 0 to 1) (default 0.75)
/// </summary>
public DatascopeFilterGen opacity(float opacity) => this.SetOptionRange("opacity", opacity,0,1);
/// <summary>
///  set display number format (from 0 to 1) (default hex)
/// </summary>
public DatascopeFilterGen format(DatascopeFilterGenFormat format) => this.SetOption("format", format.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set components to display (from 1 to 15) (default 15)
/// </summary>
public DatascopeFilterGen components(int components) => this.SetOptionRange("components", components,1,15);
}
/// <summary>
/// </summary>
public static class DatascopeFilterGenExtensions
{
/// <summary>
/// Video data analysis.
/// </summary>
public static DatascopeFilterGen DatascopeFilterGen(this ImageMap input0) => new DatascopeFilterGen(input0);
}
/// <summary>
///  set scope mode (from 0 to 2) (default mono)
/// </summary>
public enum DatascopeFilterGenMode
{
/// <summary>
/// mono            0            ..FV.....T.
/// </summary>
[Name("mono")] mono,
/// <summary>
/// color           1            ..FV.....T.
/// </summary>
[Name("color")] color,
/// <summary>
/// color2          2            ..FV.....T.
/// </summary>
[Name("color2")] color2,
}

/// <summary>
///  set display number format (from 0 to 1) (default hex)
/// </summary>
public enum DatascopeFilterGenFormat
{
/// <summary>
/// hex             0            ..FV.....T.
/// </summary>
[Name("hex")] hex,
/// <summary>
/// dec             1            ..FV.....T.
/// </summary>
[Name("dec")] dec,
}

}
