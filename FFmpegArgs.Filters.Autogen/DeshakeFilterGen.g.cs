namespace FFmpegArgs.Filters.Autogens
{
public class DeshakeFilterGen : ImageToImageFilter
{
internal DeshakeFilterGen(ImageMap input) : base("deshake",input) { AddMapOut(); }
/// <summary>
///  set x for the rectangular search area (from -1 to INT_MAX) (default -1)
/// </summary>
public DeshakeFilterGen x(int x) => this.SetOptionRange("x", x,-1,INT_MAX);
/// <summary>
///  set y for the rectangular search area (from -1 to INT_MAX) (default -1)
/// </summary>
public DeshakeFilterGen y(int y) => this.SetOptionRange("y", y,-1,INT_MAX);
/// <summary>
///  set width for the rectangular search area (from -1 to INT_MAX) (default -1)
/// </summary>
public DeshakeFilterGen w(int w) => this.SetOptionRange("w", w,-1,INT_MAX);
/// <summary>
///  set height for the rectangular search area (from -1 to INT_MAX) (default -1)
/// </summary>
public DeshakeFilterGen h(int h) => this.SetOptionRange("h", h,-1,INT_MAX);
/// <summary>
///  set x for the rectangular search area (from 0 to 64) (default 16)
/// </summary>
public DeshakeFilterGen rx(int rx) => this.SetOptionRange("rx", rx,0,64);
/// <summary>
///  set y for the rectangular search area (from 0 to 64) (default 16)
/// </summary>
public DeshakeFilterGen ry(int ry) => this.SetOptionRange("ry", ry,0,64);
/// <summary>
///  set edge mode (from 0 to 3) (default mirror)
/// </summary>
public DeshakeFilterGen edge(DeshakeFilterGenEdge edge) => this.SetOption("edge", edge.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set motion search blocksize (from 4 to 128) (default 8)
/// </summary>
public DeshakeFilterGen blocksize(int blocksize) => this.SetOptionRange("blocksize", blocksize,4,128);
/// <summary>
///  set contrast threshold for blocks (from 1 to 255) (default 125)
/// </summary>
public DeshakeFilterGen contrast(int contrast) => this.SetOptionRange("contrast", contrast,1,255);
/// <summary>
///  set search strategy (from 0 to 1) (default exhaustive)
/// </summary>
public DeshakeFilterGen search(DeshakeFilterGenSearch search) => this.SetOption("search", search.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set motion search detailed log file name
/// </summary>
public DeshakeFilterGen filename(string filename) => this.SetOption("filename",filename);
/// <summary>
///  ignored (default false)
/// </summary>
public DeshakeFilterGen opencl(bool opencl) => this.SetOption("opencl",opencl.ToFFmpegFlag());
}
public static class DeshakeFilterGenExtensions
{
/// <summary>
/// Stabilize shaky video.
/// </summary>
public static DeshakeFilterGen DeshakeFilterGen(this ImageMap input0) => new DeshakeFilterGen(input0);
/// <summary>
/// Stabilize shaky video.
/// </summary>
public static DeshakeFilterGen DeshakeFilterGen(this ImageMap input0,DeshakeFilterGenConfig config)
{
var result = new DeshakeFilterGen(input0);
if(config?.x != null) result.x(config.x.Value);
if(config?.y != null) result.y(config.y.Value);
if(config?.w != null) result.w(config.w.Value);
if(config?.h != null) result.h(config.h.Value);
if(config?.rx != null) result.rx(config.rx.Value);
if(config?.ry != null) result.ry(config.ry.Value);
if(config?.edge != null) result.edge(config.edge.Value);
if(config?.blocksize != null) result.blocksize(config.blocksize.Value);
if(config?.contrast != null) result.contrast(config.contrast.Value);
if(config?.search != null) result.search(config.search.Value);
if(!string.IsNullOrWhiteSpace(config?.filename)) result.filename(config.filename);
if(config?.opencl != null) result.opencl(config.opencl.Value);
return result;
}
}
public class DeshakeFilterGenConfig
{
/// <summary>
///  set x for the rectangular search area (from -1 to INT_MAX) (default -1)
/// </summary>
public int? x { get; set; }
/// <summary>
///  set y for the rectangular search area (from -1 to INT_MAX) (default -1)
/// </summary>
public int? y { get; set; }
/// <summary>
///  set width for the rectangular search area (from -1 to INT_MAX) (default -1)
/// </summary>
public int? w { get; set; }
/// <summary>
///  set height for the rectangular search area (from -1 to INT_MAX) (default -1)
/// </summary>
public int? h { get; set; }
/// <summary>
///  set x for the rectangular search area (from 0 to 64) (default 16)
/// </summary>
public int? rx { get; set; }
/// <summary>
///  set y for the rectangular search area (from 0 to 64) (default 16)
/// </summary>
public int? ry { get; set; }
/// <summary>
///  set edge mode (from 0 to 3) (default mirror)
/// </summary>
public DeshakeFilterGenEdge? edge { get; set; }
/// <summary>
///  set motion search blocksize (from 4 to 128) (default 8)
/// </summary>
public int? blocksize { get; set; }
/// <summary>
///  set contrast threshold for blocks (from 1 to 255) (default 125)
/// </summary>
public int? contrast { get; set; }
/// <summary>
///  set search strategy (from 0 to 1) (default exhaustive)
/// </summary>
public DeshakeFilterGenSearch? search { get; set; }
/// <summary>
///  set motion search detailed log file name
/// </summary>
public string filename { get; set; }
/// <summary>
///  ignored (default false)
/// </summary>
public bool? opencl { get; set; }
}
public enum DeshakeFilterGenEdge
{
[Name("blank")] blank,
[Name("original")] original,
[Name("clamp")] clamp,
[Name("mirror")] mirror,
}

public enum DeshakeFilterGenSearch
{
[Name("exhaustive")] exhaustive,
[Name("less")] less,
}

}
