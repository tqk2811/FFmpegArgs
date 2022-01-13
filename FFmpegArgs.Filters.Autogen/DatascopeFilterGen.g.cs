namespace FFmpegArgs.Filters.Autogens
{
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
public static class DatascopeFilterGenExtensions
{
/// <summary>
/// Video data analysis.
/// </summary>
public static DatascopeFilterGen DatascopeFilterGen(this ImageMap input0) => new DatascopeFilterGen(input0);
/// <summary>
/// Video data analysis.
/// </summary>
public static DatascopeFilterGen DatascopeFilterGen(this ImageMap input0,DatascopeFilterGenConfig config)
{
var result = new DatascopeFilterGen(input0);
if(config?.size != null) result.size(config.size.Value);
if(config?.x != null) result.x(config.x.Value);
if(config?.y != null) result.y(config.y.Value);
if(config?.mode != null) result.mode(config.mode.Value);
if(config?.axis != null) result.axis(config.axis.Value);
if(config?.opacity != null) result.opacity(config.opacity.Value);
if(config?.format != null) result.format(config.format.Value);
if(config?.components != null) result.components(config.components.Value);
return result;
}
}
public class DatascopeFilterGenConfig
{
/// <summary>
///  set output size (default "hd720")
/// </summary>
public Size? size { get; set; }
/// <summary>
///  set x offset (from 0 to INT_MAX) (default 0)
/// </summary>
public int? x { get; set; }
/// <summary>
///  set y offset (from 0 to INT_MAX) (default 0)
/// </summary>
public int? y { get; set; }
/// <summary>
///  set scope mode (from 0 to 2) (default mono)
/// </summary>
public DatascopeFilterGenMode? mode { get; set; }
/// <summary>
///  draw column/row numbers (default false)
/// </summary>
public bool? axis { get; set; }
/// <summary>
///  set background opacity (from 0 to 1) (default 0.75)
/// </summary>
public float? opacity { get; set; }
/// <summary>
///  set display number format (from 0 to 1) (default hex)
/// </summary>
public DatascopeFilterGenFormat? format { get; set; }
/// <summary>
///  set components to display (from 1 to 15) (default 15)
/// </summary>
public int? components { get; set; }
}
public enum DatascopeFilterGenMode
{
[Name("mono")] mono,
[Name("color")] color,
[Name("color2")] color2,
}

public enum DatascopeFilterGenFormat
{
[Name("hex")] hex,
[Name("dec")] dec,
}

}
