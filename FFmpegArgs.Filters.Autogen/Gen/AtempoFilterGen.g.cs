namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ..C atempo            A->A       Adjust audio tempo.
/// </summary>
public class AtempoFilterGen : AudioToAudioFilter,ICommandSupport
{
internal AtempoFilterGen(AudioMap input) : base("atempo",input) { AddMapOut(); }
/// <summary>
///  set tempo scale factor (from 0.5 to 100) (default 1)
/// </summary>
public AtempoFilterGen tempo(double tempo) => this.SetOptionRange("tempo", tempo,0.5,100);
}
/// <summary>
/// </summary>
public static class AtempoFilterGenExtensions
{
/// <summary>
/// Adjust audio tempo.
/// </summary>
public static AtempoFilterGen AtempoFilterGen(this AudioMap input0) => new AtempoFilterGen(input0);
}
}
