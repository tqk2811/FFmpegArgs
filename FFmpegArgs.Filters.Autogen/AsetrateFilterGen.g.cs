namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... asetrate          A->A       Change the sample rate without altering the data.
/// </summary>
public class AsetrateFilterGen : AudioToAudioFilter
{
internal AsetrateFilterGen(AudioMap input) : base("asetrate",input) { AddMapOut(); }
/// <summary>
///  set the sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public AsetrateFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate,1,INT_MAX);
/// <summary>
///  set the sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public AsetrateFilterGen r(int r) => this.SetOptionRange("r", r,1,INT_MAX);
}
/// <summary>
/// </summary>
public static class AsetrateFilterGenExtensions
{
/// <summary>
/// Change the sample rate without altering the data.
/// </summary>
public static AsetrateFilterGen AsetrateFilterGen(this AudioMap input0) => new AsetrateFilterGen(input0);
}
}
