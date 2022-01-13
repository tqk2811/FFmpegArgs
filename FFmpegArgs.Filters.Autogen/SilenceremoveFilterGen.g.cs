namespace FFmpegArgs.Filters.Autogens
{
public class SilenceremoveFilterGen : AudioToAudioFilter
{
internal SilenceremoveFilterGen(AudioMap input) : base("silenceremove",input) { AddMapOut(); }
/// <summary>
///  (from 0 to 9000) (default 0)
/// </summary>
public SilenceremoveFilterGen start_periods(int start_periods) => this.SetOptionRange("start_periods", start_periods,0,9000);
/// <summary>
///  set start duration of non-silence part (default 0)
/// </summary>
public SilenceremoveFilterGen start_duration(TimeSpan start_duration) => this.SetOptionRange("start_duration",start_duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set threshold for start silence detection (from 0 to DBL_MAX) (default 0)
/// </summary>
public SilenceremoveFilterGen start_threshold(double start_threshold) => this.SetOptionRange("start_threshold", start_threshold,0,DBL_MAX);
/// <summary>
///  set start duration of silence part to keep (default 0)
/// </summary>
public SilenceremoveFilterGen start_silence(TimeSpan start_silence) => this.SetOptionRange("start_silence",start_silence,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set which channel will trigger trimming from start (from 0 to 1) (default any)
/// </summary>
public SilenceremoveFilterGen start_mode(SilenceremoveFilterGenStart_mode start_mode) => this.SetOption("start_mode", start_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  (from -9000 to 9000) (default 0)
/// </summary>
public SilenceremoveFilterGen stop_periods(int stop_periods) => this.SetOptionRange("stop_periods", stop_periods,-9000,9000);
/// <summary>
///  set stop duration of non-silence part (default 0)
/// </summary>
public SilenceremoveFilterGen stop_duration(TimeSpan stop_duration) => this.SetOptionRange("stop_duration",stop_duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set threshold for stop silence detection (from 0 to DBL_MAX) (default 0)
/// </summary>
public SilenceremoveFilterGen stop_threshold(double stop_threshold) => this.SetOptionRange("stop_threshold", stop_threshold,0,DBL_MAX);
/// <summary>
///  set stop duration of silence part to keep (default 0)
/// </summary>
public SilenceremoveFilterGen stop_silence(TimeSpan stop_silence) => this.SetOptionRange("stop_silence",stop_silence,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set which channel will trigger trimming from end (from 0 to 1) (default any)
/// </summary>
public SilenceremoveFilterGen stop_mode(SilenceremoveFilterGenStop_mode stop_mode) => this.SetOption("stop_mode", stop_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set how silence is detected (from 0 to 1) (default rms)
/// </summary>
public SilenceremoveFilterGen detection(SilenceremoveFilterGenDetection detection) => this.SetOption("detection", detection.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set duration of window in seconds (from 0 to 10) (default 0.02)
/// </summary>
public SilenceremoveFilterGen window(double window) => this.SetOptionRange("window", window,0,10);
}
public static class SilenceremoveFilterGenExtensions
{
/// <summary>
/// Remove silence.
/// </summary>
public static SilenceremoveFilterGen SilenceremoveFilterGen(this AudioMap input0) => new SilenceremoveFilterGen(input0);
/// <summary>
/// Remove silence.
/// </summary>
public static SilenceremoveFilterGen SilenceremoveFilterGen(this AudioMap input0,SilenceremoveFilterGenConfig config)
{
var result = new SilenceremoveFilterGen(input0);
if(config?.start_periods != null) result.start_periods(config.start_periods.Value);
if(config?.start_duration != null) result.start_duration(config.start_duration.Value);
if(config?.start_threshold != null) result.start_threshold(config.start_threshold.Value);
if(config?.start_silence != null) result.start_silence(config.start_silence.Value);
if(config?.start_mode != null) result.start_mode(config.start_mode.Value);
if(config?.stop_periods != null) result.stop_periods(config.stop_periods.Value);
if(config?.stop_duration != null) result.stop_duration(config.stop_duration.Value);
if(config?.stop_threshold != null) result.stop_threshold(config.stop_threshold.Value);
if(config?.stop_silence != null) result.stop_silence(config.stop_silence.Value);
if(config?.stop_mode != null) result.stop_mode(config.stop_mode.Value);
if(config?.detection != null) result.detection(config.detection.Value);
if(config?.window != null) result.window(config.window.Value);
return result;
}
}
public class SilenceremoveFilterGenConfig
{
/// <summary>
///  (from 0 to 9000) (default 0)
/// </summary>
public int? start_periods { get; set; }
/// <summary>
///  set start duration of non-silence part (default 0)
/// </summary>
public TimeSpan? start_duration { get; set; }
/// <summary>
///  set threshold for start silence detection (from 0 to DBL_MAX) (default 0)
/// </summary>
public double? start_threshold { get; set; }
/// <summary>
///  set start duration of silence part to keep (default 0)
/// </summary>
public TimeSpan? start_silence { get; set; }
/// <summary>
///  set which channel will trigger trimming from start (from 0 to 1) (default any)
/// </summary>
public SilenceremoveFilterGenStart_mode? start_mode { get; set; }
/// <summary>
///  (from -9000 to 9000) (default 0)
/// </summary>
public int? stop_periods { get; set; }
/// <summary>
///  set stop duration of non-silence part (default 0)
/// </summary>
public TimeSpan? stop_duration { get; set; }
/// <summary>
///  set threshold for stop silence detection (from 0 to DBL_MAX) (default 0)
/// </summary>
public double? stop_threshold { get; set; }
/// <summary>
///  set stop duration of silence part to keep (default 0)
/// </summary>
public TimeSpan? stop_silence { get; set; }
/// <summary>
///  set which channel will trigger trimming from end (from 0 to 1) (default any)
/// </summary>
public SilenceremoveFilterGenStop_mode? stop_mode { get; set; }
/// <summary>
///  set how silence is detected (from 0 to 1) (default rms)
/// </summary>
public SilenceremoveFilterGenDetection? detection { get; set; }
/// <summary>
///  set duration of window in seconds (from 0 to 10) (default 0.02)
/// </summary>
public double? window { get; set; }
}
public enum SilenceremoveFilterGenStart_mode
{
[Name("any")] any,
[Name("all")] all,
}

public enum SilenceremoveFilterGenStop_mode
{
[Name("any")] any,
[Name("all")] all,
}

public enum SilenceremoveFilterGenDetection
{
[Name("peak")] peak,
[Name("rms")] rms,
}

}
