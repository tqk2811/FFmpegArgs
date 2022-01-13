namespace FFmpegArgs.Filters.Autogens
{
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
public static class McdeintFilterGenExtensions
{
/// <summary>
/// Apply motion compensating deinterlacing.
/// </summary>
public static McdeintFilterGen McdeintFilterGen(this ImageMap input0) => new McdeintFilterGen(input0);
/// <summary>
/// Apply motion compensating deinterlacing.
/// </summary>
public static McdeintFilterGen McdeintFilterGen(this ImageMap input0,McdeintFilterGenConfig config)
{
var result = new McdeintFilterGen(input0);
if(config?.mode != null) result.mode(config.mode.Value);
if(config?.parity != null) result.parity(config.parity.Value);
if(config?.qp != null) result.qp(config.qp.Value);
return result;
}
}
public class McdeintFilterGenConfig
{
/// <summary>
///  set mode (from 0 to 3) (default fast)
/// </summary>
public McdeintFilterGenMode? mode { get; set; }
/// <summary>
///  set the assumed picture field parity (from -1 to 1) (default bff)
/// </summary>
public McdeintFilterGenParity? parity { get; set; }
/// <summary>
///  set qp (from INT_MIN to INT_MAX) (default 1)
/// </summary>
public int? qp { get; set; }
}
public enum McdeintFilterGenMode
{
[Name("fast")] fast,
[Name("medium")] medium,
[Name("slow")] slow,
[Name("extra_slow")] extra_slow,
}

public enum McdeintFilterGenParity
{
[Name("tff")] tff,
[Name("bff")] bff,
}

}
