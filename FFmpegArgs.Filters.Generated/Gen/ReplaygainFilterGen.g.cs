namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... replaygain        A-&gt;A       ReplayGain scanner.
/// </summary>
public class ReplaygainFilterGen : AudioToAudioFilter
{
internal ReplaygainFilterGen(AudioMap input) : base("replaygain",input) { AddMapOut(); }
/// <summary>
///  track gain (dB) (from -FLT_MAX to FLT_MAX) (default 0)
/// </summary>
public ReplaygainFilterGen track_gain(float track_gain) => this.SetOptionRange("track_gain", track_gain,-FLT_MAX,FLT_MAX);
/// <summary>
///  track peak (from -FLT_MAX to FLT_MAX) (default 0)
/// </summary>
public ReplaygainFilterGen track_peak(float track_peak) => this.SetOptionRange("track_peak", track_peak,-FLT_MAX,FLT_MAX);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// ReplayGain scanner.
/// </summary>
public static ReplaygainFilterGen ReplaygainFilterGen(this AudioMap input0) => new ReplaygainFilterGen(input0);
}
}
