namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... avgblur_opencl    V->V       Apply average blur filter
/// </summary>
public class Avgblur_openclFilterGen : ImageToImageFilter
{
internal Avgblur_openclFilterGen(ImageMap input) : base("avgblur_opencl",input) { AddMapOut(); }
/// <summary>
///  set horizontal size (from 1 to 1024) (default 1)
/// </summary>
public Avgblur_openclFilterGen sizeX(int sizeX) => this.SetOptionRange("sizeX", sizeX,1,1024);
/// <summary>
///  set planes to filter (from 0 to 15) (default 15)
/// </summary>
public Avgblur_openclFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  set vertical size (from 0 to 1024) (default 0)
/// </summary>
public Avgblur_openclFilterGen sizeY(int sizeY) => this.SetOptionRange("sizeY", sizeY,0,1024);
}
/// <summary>
/// </summary>
public static class Avgblur_openclFilterGenExtensions
{
/// <summary>
/// Apply average blur filter
/// </summary>
public static Avgblur_openclFilterGen Avgblur_openclFilterGen(this ImageMap input0) => new Avgblur_openclFilterGen(input0);
}
}
