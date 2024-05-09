namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.C silenceremove     A->A       Remove silence.
/// </summary>
public class SilenceremoveFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal SilenceremoveFilterGen(AudioMap input) : base("silenceremove",input) { AddMapOut(); }
/// <summary>
///  set periods of silence parts to skip from start (from 0 to 9000) (default 0)
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
///  set periods of silence parts to skip from end (from -9000 to 9000) (default 0)
/// </summary>
public SilenceremoveFilterGen stop_periods(int stop_periods) => this.SetOptionRange("stop_periods", stop_periods,-9000,9000);
/// <summary>
///  set stop duration of silence part (default 0)
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
///  set which channel will trigger trimming from end (from 0 to 1) (default all)
/// </summary>
public SilenceremoveFilterGen stop_mode(SilenceremoveFilterGenStop_mode stop_mode) => this.SetOption("stop_mode", stop_mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set how silence is detected (from 0 to 5) (default rms)
/// </summary>
public SilenceremoveFilterGen detection(SilenceremoveFilterGenDetection detection) => this.SetOption("detection", detection.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set duration of window for silence detection (default 0.02)
/// </summary>
public SilenceremoveFilterGen window(TimeSpan window) => this.SetOptionRange("window",window,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set how every output frame timestamp is processed (from 0 to 1) (default write)
/// </summary>
public SilenceremoveFilterGen timestamp(SilenceremoveFilterGenTimestamp timestamp) => this.SetOption("timestamp", timestamp.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class SilenceremoveFilterGenExtensions
{
/// <summary>
/// Remove silence.
/// </summary>
public static SilenceremoveFilterGen SilenceremoveFilterGen(this AudioMap input0) => new SilenceremoveFilterGen(input0);
}
/// <summary>
///  set which channel will trigger trimming from start (from 0 to 1) (default any)
/// </summary>
public enum SilenceremoveFilterGenStart_mode
{
/// <summary>
/// any             0            ..F.A....T.
/// </summary>
[Name("any")] any,
/// <summary>
/// all             1            ..F.A....T.
/// </summary>
[Name("all")] all,
}

/// <summary>
///  set which channel will trigger trimming from end (from 0 to 1) (default all)
/// </summary>
public enum SilenceremoveFilterGenStop_mode
{
/// <summary>
/// any             0            ..F.A....T.
/// </summary>
[Name("any")] any,
/// <summary>
/// all             1            ..F.A....T.
/// </summary>
[Name("all")] all,
}

/// <summary>
///  set how silence is detected (from 0 to 5) (default rms)
/// </summary>
public enum SilenceremoveFilterGenDetection
{
/// <summary>
/// avg             0            ..F.A...... use mean absolute values of samples
/// </summary>
[Name("avg")] avg,
/// <summary>
/// rms             1            ..F.A...... use root mean squared values of samples
/// </summary>
[Name("rms")] rms,
/// <summary>
/// peak            2            ..F.A...... use max absolute values of samples
/// </summary>
[Name("peak")] peak,
/// <summary>
/// median          3            ..F.A...... use median of absolute values of samples
/// </summary>
[Name("median")] median,
/// <summary>
/// ptp             4            ..F.A...... use absolute of max peak to min peak difference
/// </summary>
[Name("ptp")] ptp,
/// <summary>
/// dev             5            ..F.A...... use standard deviation from values of samples
/// </summary>
[Name("dev")] dev,
}

/// <summary>
///  set how every output frame timestamp is processed (from 0 to 1) (default write)
/// </summary>
public enum SilenceremoveFilterGenTimestamp
{
/// <summary>
/// write           0            ..F.A...... full timestamps rewrite, keep only the start time
/// </summary>
[Name("write")] write,
/// <summary>
/// copy            1            ..F.A...... non-dropped frames are left with same timestamp
/// </summary>
[Name("copy")] copy,
}

}
