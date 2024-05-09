namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... silencedetect     A->A       Detect silence.
/// </summary>
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
/// <summary>
/// </summary>
public static class SilencedetectFilterGenExtensions
{
/// <summary>
/// Detect silence.
/// </summary>
public static SilencedetectFilterGen SilencedetectFilterGen(this AudioMap input0) => new SilencedetectFilterGen(input0);
}
}
