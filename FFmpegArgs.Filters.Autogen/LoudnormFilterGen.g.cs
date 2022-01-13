namespace FFmpegArgs.Filters.Autogens
{
public class LoudnormFilterGen : AudioToAudioFilter
{
internal LoudnormFilterGen(AudioMap input) : base("loudnorm",input) { AddMapOut(); }
/// <summary>
///  set integrated loudness target (from -70 to -5) (default -24)
/// </summary>
public LoudnormFilterGen I(double I) => this.SetOptionRange("I", I,-70,-5);
/// <summary>
///  set integrated loudness target (from -70 to -5) (default -24)
/// </summary>
public LoudnormFilterGen i(double i) => this.SetOptionRange("i", i,-70,-5);
/// <summary>
///  set loudness range target (from 1 to 20) (default 7)
/// </summary>
public LoudnormFilterGen LRA(double LRA) => this.SetOptionRange("LRA", LRA,1,20);
/// <summary>
///  set loudness range target (from 1 to 20) (default 7)
/// </summary>
public LoudnormFilterGen lra(double lra) => this.SetOptionRange("lra", lra,1,20);
/// <summary>
///  set maximum true peak (from -9 to 0) (default -2)
/// </summary>
public LoudnormFilterGen TP(double TP) => this.SetOptionRange("TP", TP,-9,0);
/// <summary>
///  set maximum true peak (from -9 to 0) (default -2)
/// </summary>
public LoudnormFilterGen tp(double tp) => this.SetOptionRange("tp", tp,-9,0);
/// <summary>
///  measured IL of input file (from -99 to 0) (default 0)
/// </summary>
public LoudnormFilterGen measured_I(double measured_I) => this.SetOptionRange("measured_I", measured_I,-99,0);
/// <summary>
///  measured IL of input file (from -99 to 0) (default 0)
/// </summary>
public LoudnormFilterGen measured_i(double measured_i) => this.SetOptionRange("measured_i", measured_i,-99,0);
/// <summary>
///  measured LRA of input file (from 0 to 99) (default 0)
/// </summary>
public LoudnormFilterGen measured_LRA(double measured_LRA) => this.SetOptionRange("measured_LRA", measured_LRA,0,99);
/// <summary>
///  measured LRA of input file (from 0 to 99) (default 0)
/// </summary>
public LoudnormFilterGen measured_lra(double measured_lra) => this.SetOptionRange("measured_lra", measured_lra,0,99);
/// <summary>
///  measured true peak of input file (from -99 to 99) (default 99)
/// </summary>
public LoudnormFilterGen measured_TP(double measured_TP) => this.SetOptionRange("measured_TP", measured_TP,-99,99);
/// <summary>
///  measured true peak of input file (from -99 to 99) (default 99)
/// </summary>
public LoudnormFilterGen measured_tp(double measured_tp) => this.SetOptionRange("measured_tp", measured_tp,-99,99);
/// <summary>
///  measured threshold of input file (from -99 to 0) (default -70)
/// </summary>
public LoudnormFilterGen measured_thresh(double measured_thresh) => this.SetOptionRange("measured_thresh", measured_thresh,-99,0);
/// <summary>
///  set offset gain (from -99 to 99) (default 0)
/// </summary>
public LoudnormFilterGen offset(double offset) => this.SetOptionRange("offset", offset,-99,99);
/// <summary>
///  normalize linearly if possible (default true)
/// </summary>
public LoudnormFilterGen linear(bool linear) => this.SetOption("linear",linear.ToFFmpegFlag());
/// <summary>
///  treat mono input as dual-mono (default false)
/// </summary>
public LoudnormFilterGen dual_mono(bool dual_mono) => this.SetOption("dual_mono",dual_mono.ToFFmpegFlag());
/// <summary>
///  set print format for stats (from 0 to 2) (default none)
/// </summary>
public LoudnormFilterGen print_format(LoudnormFilterGenPrint_format print_format) => this.SetOption("print_format", print_format.GetEnumAttribute<NameAttribute>().Name);
}
public static class LoudnormFilterGenExtensions
{
/// <summary>
/// EBU R128 loudness normalization
/// </summary>
public static LoudnormFilterGen LoudnormFilterGen(this AudioMap input0) => new LoudnormFilterGen(input0);
/// <summary>
/// EBU R128 loudness normalization
/// </summary>
public static LoudnormFilterGen LoudnormFilterGen(this AudioMap input0,LoudnormFilterGenConfig config)
{
var result = new LoudnormFilterGen(input0);
if(config?.I != null) result.I(config.I.Value);
if(config?.i != null) result.i(config.i.Value);
if(config?.LRA != null) result.LRA(config.LRA.Value);
if(config?.lra != null) result.lra(config.lra.Value);
if(config?.TP != null) result.TP(config.TP.Value);
if(config?.tp != null) result.tp(config.tp.Value);
if(config?.measured_I != null) result.measured_I(config.measured_I.Value);
if(config?.measured_i != null) result.measured_i(config.measured_i.Value);
if(config?.measured_LRA != null) result.measured_LRA(config.measured_LRA.Value);
if(config?.measured_lra != null) result.measured_lra(config.measured_lra.Value);
if(config?.measured_TP != null) result.measured_TP(config.measured_TP.Value);
if(config?.measured_tp != null) result.measured_tp(config.measured_tp.Value);
if(config?.measured_thresh != null) result.measured_thresh(config.measured_thresh.Value);
if(config?.offset != null) result.offset(config.offset.Value);
if(config?.linear != null) result.linear(config.linear.Value);
if(config?.dual_mono != null) result.dual_mono(config.dual_mono.Value);
if(config?.print_format != null) result.print_format(config.print_format.Value);
return result;
}
}
public class LoudnormFilterGenConfig
{
/// <summary>
///  set integrated loudness target (from -70 to -5) (default -24)
/// </summary>
public double? I { get; set; }
/// <summary>
///  set integrated loudness target (from -70 to -5) (default -24)
/// </summary>
public double? i { get; set; }
/// <summary>
///  set loudness range target (from 1 to 20) (default 7)
/// </summary>
public double? LRA { get; set; }
/// <summary>
///  set loudness range target (from 1 to 20) (default 7)
/// </summary>
public double? lra { get; set; }
/// <summary>
///  set maximum true peak (from -9 to 0) (default -2)
/// </summary>
public double? TP { get; set; }
/// <summary>
///  set maximum true peak (from -9 to 0) (default -2)
/// </summary>
public double? tp { get; set; }
/// <summary>
///  measured IL of input file (from -99 to 0) (default 0)
/// </summary>
public double? measured_I { get; set; }
/// <summary>
///  measured IL of input file (from -99 to 0) (default 0)
/// </summary>
public double? measured_i { get; set; }
/// <summary>
///  measured LRA of input file (from 0 to 99) (default 0)
/// </summary>
public double? measured_LRA { get; set; }
/// <summary>
///  measured LRA of input file (from 0 to 99) (default 0)
/// </summary>
public double? measured_lra { get; set; }
/// <summary>
///  measured true peak of input file (from -99 to 99) (default 99)
/// </summary>
public double? measured_TP { get; set; }
/// <summary>
///  measured true peak of input file (from -99 to 99) (default 99)
/// </summary>
public double? measured_tp { get; set; }
/// <summary>
///  measured threshold of input file (from -99 to 0) (default -70)
/// </summary>
public double? measured_thresh { get; set; }
/// <summary>
///  set offset gain (from -99 to 99) (default 0)
/// </summary>
public double? offset { get; set; }
/// <summary>
///  normalize linearly if possible (default true)
/// </summary>
public bool? linear { get; set; }
/// <summary>
///  treat mono input as dual-mono (default false)
/// </summary>
public bool? dual_mono { get; set; }
/// <summary>
///  set print format for stats (from 0 to 2) (default none)
/// </summary>
public LoudnormFilterGenPrint_format? print_format { get; set; }
}
public enum LoudnormFilterGenPrint_format
{
[Name("none")] none,
[Name("json")] json,
[Name("summary")] summary,
}

}
