namespace FFmpegArgs.Filters.Autogens
{
public class SilencedetectFilterGen : AudioToAudioFilter
{
internal SilencedetectFilterGen(AudioMap input) : base("silencedetect",input) { AddMapOut(); }
/// <summary>
///  set noise tolerance (from 0 to DBL_MAX) (default 0.001)
/// </summary>
public SilencedetectFilterGen noise(double noise) => this.SetOptionRange("noise", noise,0,DBL_MAX);
/// <summary>
///  set minimum duration in seconds (default 2)
/// </summary>
public SilencedetectFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  check each channel separately (default false)
/// </summary>
public SilencedetectFilterGen mono(bool mono) => this.SetOption("mono",mono.ToFFmpegFlag());
}
public static class SilencedetectFilterGenExtensions
{
/// <summary>
/// Detect silence.
/// </summary>
public static SilencedetectFilterGen SilencedetectFilterGen(this AudioMap input0) => new SilencedetectFilterGen(input0);
/// <summary>
/// Detect silence.
/// </summary>
public static SilencedetectFilterGen SilencedetectFilterGen(this AudioMap input0,SilencedetectFilterGenConfig config)
{
var result = new SilencedetectFilterGen(input0);
if(config?.noise != null) result.noise(config.noise.Value);
if(config?.duration != null) result.duration(config.duration.Value);
if(config?.mono != null) result.mono(config.mono.Value);
return result;
}
}
public class SilencedetectFilterGenConfig
{
/// <summary>
///  set noise tolerance (from 0 to DBL_MAX) (default 0.001)
/// </summary>
public double? noise { get; set; }
/// <summary>
///  set minimum duration in seconds (default 2)
/// </summary>
public TimeSpan? duration { get; set; }
/// <summary>
///  check each channel separately (default false)
/// </summary>
public bool? mono { get; set; }
}
}
