namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC haldclut          VV-&gt;V      Adjust colors using a Hald CLUT.
/// </summary>
public class HaldclutFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal HaldclutFilterGen(params ImageMap[] inputs) : base("haldclut",inputs) { AddMapOut(); }
/// <summary>
///  when to process CLUT (from 0 to 1) (default all)
/// </summary>
public HaldclutFilterGen clut(HaldclutFilterGenClut clut) => this.SetOption("clut", clut.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  select interpolation mode (from 0 to 4) (default tetrahedral)
/// </summary>
public HaldclutFilterGen interp(HaldclutFilterGenInterp interp) => this.SetOption("interp", interp.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Adjust colors using a Hald CLUT.
/// </summary>
public static HaldclutFilterGen HaldclutFilterGen(this ImageMap input0, ImageMap input1) => new HaldclutFilterGen(input0, input1);
}
/// <summary>
///  when to process CLUT (from 0 to 1) (default all)
/// </summary>
public enum HaldclutFilterGenClut
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
public enum HaldclutFilterGenInterp
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
