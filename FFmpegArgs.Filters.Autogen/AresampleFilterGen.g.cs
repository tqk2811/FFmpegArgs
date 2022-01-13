namespace FFmpegArgs.Filters.Autogens
{
public class AresampleFilterGen : AudioToAudioFilter
{
internal AresampleFilterGen(AudioMap input) : base("aresample",input) { AddMapOut(); }
/// <summary>
///  (from 0 to INT_MAX) (default 0)
/// </summary>
public AresampleFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate,0,INT_MAX);
}
public static class AresampleFilterGenExtensions
{
/// <summary>
/// Resample audio data.
/// </summary>
public static AresampleFilterGen AresampleFilterGen(this AudioMap input0) => new AresampleFilterGen(input0);
/// <summary>
/// Resample audio data.
/// </summary>
public static AresampleFilterGen AresampleFilterGen(this AudioMap input0,AresampleFilterGenConfig config)
{
var result = new AresampleFilterGen(input0);
if(config?.sample_rate != null) result.sample_rate(config.sample_rate.Value);
return result;
}
}
public class AresampleFilterGenConfig
{
/// <summary>
///  (from 0 to INT_MAX) (default 0)
/// </summary>
public int? sample_rate { get; set; }
}
}
