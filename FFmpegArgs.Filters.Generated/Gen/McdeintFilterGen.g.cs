namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... mcdeint           V-&gt;V       Apply motion compensating deinterlacing.
/// </summary>
public class McdeintFilterGen : ImageToImageFilter
{
internal McdeintFilterGen(ImageMap input) : base("mcdeint",input) { AddMapOut(); }
/// <summary>
///  set mode (from 0 to 3) (default fast)
/// </summary>
public McdeintFilterGen mode(McdeintFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set the assumed picture field parity (from -1 to 1) (default bff)
/// </summary>
public McdeintFilterGen parity(McdeintFilterGenParity parity) => this.SetOption("parity", parity.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set qp (from INT_MIN to INT_MAX) (default 1)
/// </summary>
public McdeintFilterGen qp(int qp) => this.SetOptionRange("qp", qp,INT_MIN,INT_MAX);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply motion compensating deinterlacing.
/// </summary>
public static McdeintFilterGen McdeintFilterGen(this ImageMap input0) => new McdeintFilterGen(input0);
}
/// <summary>
///  set mode (from 0 to 3) (default fast)
/// </summary>
public enum McdeintFilterGenMode
{
/// <summary>
/// fast            0            ..FV.......
/// </summary>
[Name("fast")] fast,
/// <summary>
/// medium          1            ..FV.......
/// </summary>
[Name("medium")] medium,
/// <summary>
/// slow            2            ..FV.......
/// </summary>
[Name("slow")] slow,
/// <summary>
/// extra_slow      3            ..FV.......
/// </summary>
[Name("extra_slow")] extra_slow,
}

/// <summary>
///  set the assumed picture field parity (from -1 to 1) (default bff)
/// </summary>
public enum McdeintFilterGenParity
{
/// <summary>
/// tff             0            ..FV....... assume top field first
/// </summary>
[Name("tff")] tff,
/// <summary>
/// bff             1            ..FV....... assume bottom field first
/// </summary>
[Name("bff")] bff,
}

}
