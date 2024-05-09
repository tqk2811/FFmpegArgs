namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC shear             V->V       Shear transform the input image.
/// </summary>
public class ShearFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ShearFilterGen(ImageMap input) : base("shear",input) { AddMapOut(); }
/// <summary>
///  set x shear factor (from -2 to 2) (default 0)
/// </summary>
public ShearFilterGen shx(float shx) => this.SetOptionRange("shx", shx,-2,2);
/// <summary>
///  set y shear factor (from -2 to 2) (default 0)
/// </summary>
public ShearFilterGen shy(float shy) => this.SetOptionRange("shy", shy,-2,2);
/// <summary>
///  set background fill color (default "black")
/// </summary>
public ShearFilterGen fillcolor(string fillcolor) => this.SetOption("fillcolor",fillcolor);
/// <summary>
///  set background fill color (default "black")
/// </summary>
public ShearFilterGen c(string c) => this.SetOption("c",c);
/// <summary>
///  set interpolation (from 0 to 1) (default bilinear)
/// </summary>
public ShearFilterGen interp(ShearFilterGenInterp interp) => this.SetOption("interp", interp.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class ShearFilterGenExtensions
{
/// <summary>
/// Shear transform the input image.
/// </summary>
public static ShearFilterGen ShearFilterGen(this ImageMap input0) => new ShearFilterGen(input0);
}
/// <summary>
///  set interpolation (from 0 to 1) (default bilinear)
/// </summary>
public enum ShearFilterGenInterp
{
/// <summary>
/// nearest         0            ..FV.....T. nearest neighbour
/// </summary>
[Name("nearest")] nearest,
/// <summary>
/// bilinear        1            ..FV.....T. bilinear
/// </summary>
[Name("bilinear")] bilinear,
}

}
