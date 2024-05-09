namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... deshake           V->V       Stabilize shaky video.
/// </summary>
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
/// <summary>
/// </summary>
public static class DeshakeFilterGenExtensions
{
/// <summary>
/// Stabilize shaky video.
/// </summary>
public static DeshakeFilterGen DeshakeFilterGen(this ImageMap input0) => new DeshakeFilterGen(input0);
}
/// <summary>
///  set edge mode (from 0 to 3) (default mirror)
/// </summary>
public enum DeshakeFilterGenEdge
{
/// <summary>
/// blank           0            ..FV....... fill zeroes at blank locations
/// </summary>
[Name("blank")] blank,
/// <summary>
/// original        1            ..FV....... original image at blank locations
/// </summary>
[Name("original")] original,
/// <summary>
/// clamp           2            ..FV....... extruded edge value at blank locations
/// </summary>
[Name("clamp")] clamp,
/// <summary>
/// mirror          3            ..FV....... mirrored edge at blank locations
/// </summary>
[Name("mirror")] mirror,
}

/// <summary>
///  set search strategy (from 0 to 1) (default exhaustive)
/// </summary>
public enum DeshakeFilterGenSearch
{
/// <summary>
/// exhaustive      0            ..FV....... exhaustive search
/// </summary>
[Name("exhaustive")] exhaustive,
/// <summary>
/// less            1            ..FV....... less exhaustive search
/// </summary>
[Name("less")] less,
}

}
