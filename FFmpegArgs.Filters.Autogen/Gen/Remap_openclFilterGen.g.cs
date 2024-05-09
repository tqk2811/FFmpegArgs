namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... remap_opencl      VVV->V     Remap pixels using OpenCL.
/// </summary>
public class Remap_openclFilterGen : ImageToImageFilter
{
internal Remap_openclFilterGen(params ImageMap[] inputs) : base("remap_opencl",inputs) { AddMapOut(); }
/// <summary>
///  set interpolation method (from 0 to 1) (default linear)
/// </summary>
public Remap_openclFilterGen interp(Remap_openclFilterGenInterp interp) => this.SetOption("interp", interp.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set the color of the unmapped pixels (default "black")
/// </summary>
public Remap_openclFilterGen fill(Color fill) => this.SetOption("fill",fill.ToHexStringRGBA());
}
/// <summary>
/// </summary>
public static class Remap_openclFilterGenExtensions
{
/// <summary>
/// Remap pixels using OpenCL.
/// </summary>
public static Remap_openclFilterGen Remap_openclFilterGen(this ImageMap input0, ImageMap input1, ImageMap input2) => new Remap_openclFilterGen(input0, input1, input2);
}
/// <summary>
///  set interpolation method (from 0 to 1) (default linear)
/// </summary>
public enum Remap_openclFilterGenInterp
{
/// <summary>
/// near            0            ..FV.......
/// </summary>
[Name("near")] near,
/// <summary>
/// linear          1            ..FV.......
/// </summary>
[Name("linear")] linear,
}

}
