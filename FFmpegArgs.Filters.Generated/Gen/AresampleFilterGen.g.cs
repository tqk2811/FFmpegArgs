namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... aresample         A-&gt;A       Resample audio data.
/// </summary>
public class AresampleFilterGen : AudioToAudioFilter
{
internal AresampleFilterGen(AudioMap input) : base("aresample",input) { AddMapOut(); }
/// <summary>
///  (from 0 to INT_MAX) (default 0)
/// </summary>
public AresampleFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate,0,INT_MAX);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Resample audio data.
/// </summary>
public static AresampleFilterGen AresampleFilterGen(this AudioMap input0) => new AresampleFilterGen(input0);
}
}
