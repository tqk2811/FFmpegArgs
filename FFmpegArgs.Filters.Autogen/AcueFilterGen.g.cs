namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... acue              A->A       Delay filtering to match a cue.
/// </summary>
public class AcueFilterGen : AudioToAudioFilter
{
internal AcueFilterGen(AudioMap input) : base("acue",input) { AddMapOut(); }
/// <summary>
///  cue unix timestamp in microseconds (from 0 to I64_MAX) (default 0)
/// </summary>
public AcueFilterGen cue(long cue) => this.SetOptionRange("cue", cue,0,I64_MAX);
/// <summary>
///  preroll duration in seconds (default 0)
/// </summary>
public AcueFilterGen preroll(TimeSpan preroll) => this.SetOptionRange("preroll",preroll,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  buffer duration in seconds (default 0)
/// </summary>
public AcueFilterGen buffer(TimeSpan buffer) => this.SetOptionRange("buffer",buffer,TimeSpan.Zero,TimeSpan.MaxValue);
}
/// <summary>
/// </summary>
public static class AcueFilterGenExtensions
{
/// <summary>
/// Delay filtering to match a cue.
/// </summary>
public static AcueFilterGen AcueFilterGen(this AudioMap input0) => new AcueFilterGen(input0);
}
}
