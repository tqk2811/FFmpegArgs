namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... mestimate         V-&gt;V       Generate motion vectors.
/// </summary>
public class MestimateFilterGen : ImageToImageFilter
{
internal MestimateFilterGen(ImageMap input) : base("mestimate",input) { AddMapOut(); }
/// <summary>
///  motion estimation method (from 1 to 9) (default esa)
/// </summary>
public MestimateFilterGen method(MestimateFilterGenMethod method) => this.SetOption("method", method.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  macroblock size (from 8 to INT_MAX) (default 16)
/// </summary>
public MestimateFilterGen mb_size(int mb_size) => this.SetOptionRange("mb_size", mb_size,8,INT_MAX);
/// <summary>
///  search parameter (from 4 to INT_MAX) (default 7)
/// </summary>
public MestimateFilterGen search_param(int search_param) => this.SetOptionRange("search_param", search_param,4,INT_MAX);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Generate motion vectors.
/// </summary>
public static MestimateFilterGen MestimateFilterGen(this ImageMap input0) => new MestimateFilterGen(input0);
}
/// <summary>
///  motion estimation method (from 1 to 9) (default esa)
/// </summary>
public enum MestimateFilterGenMethod
{
/// <summary>
/// esa             1            ..FV....... exhaustive search
/// </summary>
[Name("esa")] esa,
/// <summary>
/// tss             2            ..FV....... three step search
/// </summary>
[Name("tss")] tss,
/// <summary>
/// tdls            3            ..FV....... two dimensional logarithmic search
/// </summary>
[Name("tdls")] tdls,
/// <summary>
/// ntss            4            ..FV....... new three step search
/// </summary>
[Name("ntss")] ntss,
/// <summary>
/// fss             5            ..FV....... four step search
/// </summary>
[Name("fss")] fss,
/// <summary>
/// ds              6            ..FV....... diamond search
/// </summary>
[Name("ds")] ds,
/// <summary>
/// hexbs           7            ..FV....... hexagon-based search
/// </summary>
[Name("hexbs")] hexbs,
/// <summary>
/// epzs            8            ..FV....... enhanced predictive zonal search
/// </summary>
[Name("epzs")] epzs,
/// <summary>
/// umh             9            ..FV....... uneven multi-hexagon search
/// </summary>
[Name("umh")] umh,
}

}
