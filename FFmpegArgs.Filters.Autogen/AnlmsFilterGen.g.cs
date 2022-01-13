namespace FFmpegArgs.Filters.Autogens
{
public class AnlmsFilterGen : AudioToAudioFilter,ISliceThreading,ICommandSupport
{
internal AnlmsFilterGen(params AudioMap[] inputs) : base("anlms",inputs) { AddMapOut(); }
/// <summary>
///  set the filter order (from 1 to 32767) (default 256)
/// </summary>
public AnlmsFilterGen order(int order) => this.SetOptionRange("order", order,1,32767);
/// <summary>
///  set the filter mu (from 0 to 2) (default 0.75)
/// </summary>
public AnlmsFilterGen mu(float mu) => this.SetOptionRange("mu", mu,0,2);
/// <summary>
///  set the filter eps (from 0 to 1) (default 1)
/// </summary>
public AnlmsFilterGen eps(float eps) => this.SetOptionRange("eps", eps,0,1);
/// <summary>
///  set the filter leakage (from 0 to 1) (default 0)
/// </summary>
public AnlmsFilterGen leakage(float leakage) => this.SetOptionRange("leakage", leakage,0,1);
/// <summary>
///  set output mode (from 0 to 3) (default o)
/// </summary>
public AnlmsFilterGen out_mode(AnlmsFilterGenOut_mode out_mode) => this.SetOption("out_mode", out_mode.GetEnumAttribute<NameAttribute>().Name);
}
public static class AnlmsFilterGenExtensions
{
/// <summary>
/// Apply Normalized Least-Mean-Squares algorithm to first audio stream.
/// </summary>
public static AnlmsFilterGen AnlmsFilterGen(this AudioMap input0, AudioMap input1) => new AnlmsFilterGen(input0, input1);
/// <summary>
/// Apply Normalized Least-Mean-Squares algorithm to first audio stream.
/// </summary>
public static AnlmsFilterGen AnlmsFilterGen(this AudioMap input0, AudioMap input1,AnlmsFilterGenConfig config)
{
var result = new AnlmsFilterGen(input0, input1);
if(config?.order != null) result.order(config.order.Value);
if(config?.mu != null) result.mu(config.mu.Value);
if(config?.eps != null) result.eps(config.eps.Value);
if(config?.leakage != null) result.leakage(config.leakage.Value);
if(config?.out_mode != null) result.out_mode(config.out_mode.Value);
return result;
}
}
public class AnlmsFilterGenConfig
{
/// <summary>
///  set the filter order (from 1 to 32767) (default 256)
/// </summary>
public int? order { get; set; }
/// <summary>
///  set the filter mu (from 0 to 2) (default 0.75)
/// </summary>
public float? mu { get; set; }
/// <summary>
///  set the filter eps (from 0 to 1) (default 1)
/// </summary>
public float? eps { get; set; }
/// <summary>
///  set the filter leakage (from 0 to 1) (default 0)
/// </summary>
public float? leakage { get; set; }
/// <summary>
///  set output mode (from 0 to 3) (default o)
/// </summary>
public AnlmsFilterGenOut_mode? out_mode { get; set; }
}
public enum AnlmsFilterGenOut_mode
{
[Name("i")] i,
[Name("d")] d,
[Name("o")] o,
[Name("n")] n,
}

}
