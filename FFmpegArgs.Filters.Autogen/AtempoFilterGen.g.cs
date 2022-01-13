namespace FFmpegArgs.Filters.Autogens
{
public class AtempoFilterGen : AudioToAudioFilter,ICommandSupport
{
internal AtempoFilterGen(AudioMap input) : base("atempo",input) { AddMapOut(); }
/// <summary>
///  set tempo scale factor (from 0.5 to 100) (default 1)
/// </summary>
public AtempoFilterGen tempo(double tempo) => this.SetOptionRange("tempo", tempo,0.5,100);
}
public static class AtempoFilterGenExtensions
{
/// <summary>
/// Adjust audio tempo.
/// </summary>
public static AtempoFilterGen AtempoFilterGen(this AudioMap input0) => new AtempoFilterGen(input0);
/// <summary>
/// Adjust audio tempo.
/// </summary>
public static AtempoFilterGen AtempoFilterGen(this AudioMap input0,AtempoFilterGenConfig config)
{
var result = new AtempoFilterGen(input0);
if(config?.tempo != null) result.tempo(config.tempo.Value);
return result;
}
}
public class AtempoFilterGenConfig
{
/// <summary>
///  set tempo scale factor (from 0.5 to 100) (default 1)
/// </summary>
public double? tempo { get; set; }
}
}
