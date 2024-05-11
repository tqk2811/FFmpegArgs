namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... extractplanes     V->N       Extract planes as grayscale frames.
/// </summary>
public class ExtractplanesFilterGen : ImageToImageFilter
{
internal ExtractplanesFilterGen(int outputCount, ImageMap input) : base("extractplanes",input) { AddMultiMapOut(outputCount); }
/// <summary>
///  set planes (default r)
/// </summary>
public ExtractplanesFilterGen planes(ExtractplanesFilterGenPlanes planes) => this.SetOption("planes", planes.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Extract planes as grayscale frames.
/// </summary>
public static ExtractplanesFilterGen ExtractplanesFilterGen(this ImageMap input0, int outputCount) => new ExtractplanesFilterGen(outputCount, input0);
}
/// <summary>
///  set planes (default r)
/// </summary>
public enum ExtractplanesFilterGenPlanes
{
/// <summary>
/// y                            ..FV....... set luma plane
/// </summary>
[Name("y")] y,
/// <summary>
/// u                            ..FV....... set u plane
/// </summary>
[Name("u")] u,
/// <summary>
/// v                            ..FV....... set v plane
/// </summary>
[Name("v")] v,
/// <summary>
/// r                            ..FV....... set red plane
/// </summary>
[Name("r")] r,
/// <summary>
/// g                            ..FV....... set green plane
/// </summary>
[Name("g")] g,
/// <summary>
/// b                            ..FV....... set blue plane
/// </summary>
[Name("b")] b,
/// <summary>
/// a                            ..FV....... set alpha plane
/// </summary>
[Name("a")] a,
}

}
