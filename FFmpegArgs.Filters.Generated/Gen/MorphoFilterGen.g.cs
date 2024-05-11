namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC morpho            VV-&gt;V      Apply Morphological filter.
/// </summary>
public class MorphoFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal MorphoFilterGen(params ImageMap[] inputs) : base("morpho",inputs) { AddMapOut(); }
/// <summary>
///  set morphological transform (from 0 to 6) (default erode)
/// </summary>
public MorphoFilterGen mode(MorphoFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set planes to filter (from 0 to 15) (default 7)
/// </summary>
public MorphoFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  when to process structures (from 0 to 1) (default all)
/// </summary>
public MorphoFilterGen structure(MorphoFilterGenStructure structure) => this.SetOption("structure", structure.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply Morphological filter.
/// </summary>
public static MorphoFilterGen MorphoFilterGen(this ImageMap input0, ImageMap input1) => new MorphoFilterGen(input0, input1);
}
/// <summary>
///  set morphological transform (from 0 to 6) (default erode)
/// </summary>
public enum MorphoFilterGenMode
{
/// <summary>
/// erode           0            ..FV.....T.
/// </summary>
[Name("erode")] erode,
/// <summary>
/// dilate          1            ..FV.....T.
/// </summary>
[Name("dilate")] dilate,
/// <summary>
/// open            2            ..FV.....T.
/// </summary>
[Name("open")] open,
/// <summary>
/// close           3            ..FV.....T.
/// </summary>
[Name("close")] close,
/// <summary>
/// gradient        4            ..FV.....T.
/// </summary>
[Name("gradient")] gradient,
/// <summary>
/// tophat          5            ..FV.....T.
/// </summary>
[Name("tophat")] tophat,
/// <summary>
/// blackhat        6            ..FV.....T.
/// </summary>
[Name("blackhat")] blackhat,
}

/// <summary>
///  when to process structures (from 0 to 1) (default all)
/// </summary>
public enum MorphoFilterGenStructure
{
/// <summary>
/// first           0            ..FV.....T. process only first structure, ignore rest
/// </summary>
[Name("first")] first,
/// <summary>
/// all             1            ..FV.....T. process all structure
/// </summary>
[Name("all")] all,
}

}
