namespace FFmpegArgs.Filters.Autogens
{
public class AexciterFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal AexciterFilterGen(AudioMap input) : base("aexciter",input) { AddMapOut(); }
/// <summary>
///  set level in (from 0 to 64) (default 1)
/// </summary>
public AexciterFilterGen level_in(double level_in) => this.SetOptionRange("level_in", level_in,0,64);
/// <summary>
///  set level out (from 0 to 64) (default 1)
/// </summary>
public AexciterFilterGen level_out(double level_out) => this.SetOptionRange("level_out", level_out,0,64);
/// <summary>
///  set amount (from 0 to 64) (default 1)
/// </summary>
public AexciterFilterGen amount(double amount) => this.SetOptionRange("amount", amount,0,64);
/// <summary>
///  set harmonics (from 0.1 to 10) (default 8.5)
/// </summary>
public AexciterFilterGen drive(double drive) => this.SetOptionRange("drive", drive,0.1,10);
/// <summary>
///  set blend harmonics (from -10 to 10) (default 0)
/// </summary>
public AexciterFilterGen blend(double blend) => this.SetOptionRange("blend", blend,-10,10);
/// <summary>
///  set scope (from 2000 to 12000) (default 7500)
/// </summary>
public AexciterFilterGen freq(double freq) => this.SetOptionRange("freq", freq,2000,12000);
/// <summary>
///  set ceiling (from 9999 to 20000) (default 9999)
/// </summary>
public AexciterFilterGen ceil(double ceil) => this.SetOptionRange("ceil", ceil,9999,20000);
/// <summary>
///  enable listen mode (default false)
/// </summary>
public AexciterFilterGen listen(bool listen) => this.SetOption("listen",listen.ToFFmpegFlag());
}
public static class AexciterFilterGenExtensions
{
/// <summary>
/// Enhance high frequency part of audio.
/// </summary>
public static AexciterFilterGen AexciterFilterGen(this AudioMap input0) => new AexciterFilterGen(input0);
/// <summary>
/// Enhance high frequency part of audio.
/// </summary>
public static AexciterFilterGen AexciterFilterGen(this AudioMap input0,AexciterFilterGenConfig config)
{
var result = new AexciterFilterGen(input0);
if(config?.level_in != null) result.level_in(config.level_in.Value);
if(config?.level_out != null) result.level_out(config.level_out.Value);
if(config?.amount != null) result.amount(config.amount.Value);
if(config?.drive != null) result.drive(config.drive.Value);
if(config?.blend != null) result.blend(config.blend.Value);
if(config?.freq != null) result.freq(config.freq.Value);
if(config?.ceil != null) result.ceil(config.ceil.Value);
if(config?.listen != null) result.listen(config.listen.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class AexciterFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set level in (from 0 to 64) (default 1)
/// </summary>
public double? level_in { get; set; }
/// <summary>
///  set level out (from 0 to 64) (default 1)
/// </summary>
public double? level_out { get; set; }
/// <summary>
///  set amount (from 0 to 64) (default 1)
/// </summary>
public double? amount { get; set; }
/// <summary>
///  set harmonics (from 0.1 to 10) (default 8.5)
/// </summary>
public double? drive { get; set; }
/// <summary>
///  set blend harmonics (from -10 to 10) (default 0)
/// </summary>
public double? blend { get; set; }
/// <summary>
///  set scope (from 2000 to 12000) (default 7500)
/// </summary>
public double? freq { get; set; }
/// <summary>
///  set ceiling (from 9999 to 20000) (default 9999)
/// </summary>
public double? ceil { get; set; }
/// <summary>
///  enable listen mode (default false)
/// </summary>
public bool? listen { get; set; }
public string TimelineSupport { get; set; }
}
}
