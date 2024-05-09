namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC lut3d             V->V       Adjust colors using a 3D LUT.
/// </summary>
public class Lut3dFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal Lut3dFilterGen(ImageMap input) : base("lut3d",input) { AddMapOut(); }
/// <summary>
///  set 3D LUT file name
/// </summary>
public Lut3dFilterGen file(string file) => this.SetOption("file",file);
/// <summary>
///  when to process CLUT (from 0 to 1) (default all)
/// </summary>
public Lut3dFilterGen clut(Lut3dFilterGenClut clut) => this.SetOption("clut", clut.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  select interpolation mode (from 0 to 4) (default tetrahedral)
/// </summary>
public Lut3dFilterGen interp(Lut3dFilterGenInterp interp) => this.SetOption("interp", interp.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class Lut3dFilterGenExtensions
{
/// <summary>
/// Adjust colors using a 3D LUT.
/// </summary>
public static Lut3dFilterGen Lut3dFilterGen(this ImageMap input0) => new Lut3dFilterGen(input0);
}
/// <summary>
///  when to process CLUT (from 0 to 1) (default all)
/// </summary>
public enum Lut3dFilterGenClut
{
/// <summary>
/// first           0            ..FV.....T. process only first CLUT, ignore rest
/// </summary>
[Name("first")] first,
/// <summary>
/// all             1            ..FV.....T. process all CLUTs
/// </summary>
[Name("all")] all,
}

/// <summary>
///  select interpolation mode (from 0 to 4) (default tetrahedral)
/// </summary>
public enum Lut3dFilterGenInterp
{
/// <summary>
/// nearest         0            ..FV.....T. use values from the nearest defined points
/// </summary>
[Name("nearest")] nearest,
/// <summary>
/// trilinear       1            ..FV.....T. interpolate values using the 8 points defining a cube
/// </summary>
[Name("trilinear")] trilinear,
/// <summary>
/// tetrahedral     2            ..FV.....T. interpolate values using a tetrahedron
/// </summary>
[Name("tetrahedral")] tetrahedral,
/// <summary>
/// pyramid         3            ..FV.....T. interpolate values using a pyramid
/// </summary>
[Name("pyramid")] pyramid,
/// <summary>
/// prism           4            ..FV.....T. interpolate values using a prism
/// </summary>
[Name("prism")] prism,
}

}
