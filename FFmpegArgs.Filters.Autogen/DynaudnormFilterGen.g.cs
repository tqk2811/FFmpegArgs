namespace FFmpegArgs.Filters.Autogens
{
public class DynaudnormFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal DynaudnormFilterGen(AudioMap input) : base("dynaudnorm",input) { AddMapOut(); }
/// <summary>
///  set the frame length in msec (from 10 to 8000) (default 500)
/// </summary>
public DynaudnormFilterGen framelen(int framelen) => this.SetOptionRange("framelen", framelen,10,8000);
/// <summary>
///  set the filter size (from 3 to 301) (default 31)
/// </summary>
public DynaudnormFilterGen gausssize(int gausssize) => this.SetOptionRange("gausssize", gausssize,3,301);
/// <summary>
///  set the peak value (from 0 to 1) (default 0.95)
/// </summary>
public DynaudnormFilterGen peak(double peak) => this.SetOptionRange("peak", peak,0,1);
/// <summary>
///  set the max amplification (from 1 to 100) (default 10)
/// </summary>
public DynaudnormFilterGen maxgain(double maxgain) => this.SetOptionRange("maxgain", maxgain,1,100);
/// <summary>
///  set the target RMS (from 0 to 1) (default 0)
/// </summary>
public DynaudnormFilterGen targetrms(double targetrms) => this.SetOptionRange("targetrms", targetrms,0,1);
/// <summary>
///  set the target RMS (from 0 to 1) (default 0)
/// </summary>
public DynaudnormFilterGen r(double r) => this.SetOptionRange("r", r,0,1);
/// <summary>
///  set channel coupling (default true)
/// </summary>
public DynaudnormFilterGen coupling(bool coupling) => this.SetOption("coupling",coupling.ToFFmpegFlag());
/// <summary>
///  set channel coupling (default true)
/// </summary>
public DynaudnormFilterGen n(bool n) => this.SetOption("n",n.ToFFmpegFlag());
/// <summary>
///  set DC correction (default false)
/// </summary>
public DynaudnormFilterGen correctdc(bool correctdc) => this.SetOption("correctdc",correctdc.ToFFmpegFlag());
/// <summary>
///  set alternative boundary mode (default false)
/// </summary>
public DynaudnormFilterGen altboundary(bool altboundary) => this.SetOption("altboundary",altboundary.ToFFmpegFlag());
/// <summary>
///  set alternative boundary mode (default false)
/// </summary>
public DynaudnormFilterGen b(bool b) => this.SetOption("b",b.ToFFmpegFlag());
/// <summary>
///  set the compress factor (from 0 to 30) (default 0)
/// </summary>
public DynaudnormFilterGen compress(double compress) => this.SetOptionRange("compress", compress,0,30);
/// <summary>
///  set the compress factor (from 0 to 30) (default 0)
/// </summary>
public DynaudnormFilterGen s(double s) => this.SetOptionRange("s", s,0,30);
/// <summary>
///  set the threshold value (from 0 to 1) (default 0)
/// </summary>
public DynaudnormFilterGen threshold(double threshold) => this.SetOptionRange("threshold", threshold,0,1);
}
public static class DynaudnormFilterGenExtensions
{
/// <summary>
/// Dynamic Audio Normalizer.
/// </summary>
public static DynaudnormFilterGen DynaudnormFilterGen(this AudioMap input0) => new DynaudnormFilterGen(input0);
/// <summary>
/// Dynamic Audio Normalizer.
/// </summary>
public static DynaudnormFilterGen DynaudnormFilterGen(this AudioMap input0,DynaudnormFilterGenConfig config)
{
var result = new DynaudnormFilterGen(input0);
if(config?.framelen != null) result.framelen(config.framelen.Value);
if(config?.gausssize != null) result.gausssize(config.gausssize.Value);
if(config?.peak != null) result.peak(config.peak.Value);
if(config?.maxgain != null) result.maxgain(config.maxgain.Value);
if(config?.targetrms != null) result.targetrms(config.targetrms.Value);
if(config?.r != null) result.r(config.r.Value);
if(config?.coupling != null) result.coupling(config.coupling.Value);
if(config?.n != null) result.n(config.n.Value);
if(config?.correctdc != null) result.correctdc(config.correctdc.Value);
if(config?.altboundary != null) result.altboundary(config.altboundary.Value);
if(config?.b != null) result.b(config.b.Value);
if(config?.compress != null) result.compress(config.compress.Value);
if(config?.s != null) result.s(config.s.Value);
if(config?.threshold != null) result.threshold(config.threshold.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class DynaudnormFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set the frame length in msec (from 10 to 8000) (default 500)
/// </summary>
public int? framelen { get; set; }
/// <summary>
///  set the filter size (from 3 to 301) (default 31)
/// </summary>
public int? gausssize { get; set; }
/// <summary>
///  set the peak value (from 0 to 1) (default 0.95)
/// </summary>
public double? peak { get; set; }
/// <summary>
///  set the max amplification (from 1 to 100) (default 10)
/// </summary>
public double? maxgain { get; set; }
/// <summary>
///  set the target RMS (from 0 to 1) (default 0)
/// </summary>
public double? targetrms { get; set; }
/// <summary>
///  set the target RMS (from 0 to 1) (default 0)
/// </summary>
public double? r { get; set; }
/// <summary>
///  set channel coupling (default true)
/// </summary>
public bool? coupling { get; set; }
/// <summary>
///  set channel coupling (default true)
/// </summary>
public bool? n { get; set; }
/// <summary>
///  set DC correction (default false)
/// </summary>
public bool? correctdc { get; set; }
/// <summary>
///  set alternative boundary mode (default false)
/// </summary>
public bool? altboundary { get; set; }
/// <summary>
///  set alternative boundary mode (default false)
/// </summary>
public bool? b { get; set; }
/// <summary>
///  set the compress factor (from 0 to 30) (default 0)
/// </summary>
public double? compress { get; set; }
/// <summary>
///  set the compress factor (from 0 to 30) (default 0)
/// </summary>
public double? s { get; set; }
/// <summary>
///  set the threshold value (from 0 to 1) (default 0)
/// </summary>
public double? threshold { get; set; }
public string TimelineSupport { get; set; }
}
}
