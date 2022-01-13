namespace FFmpegArgs.Filters.Autogens
{
public class AechoFilterGen : AudioToAudioFilter
{
internal AechoFilterGen(AudioMap input) : base("aecho",input) { AddMapOut(); }
/// <summary>
///  set signal input gain (from 0 to 1) (default 0.6)
/// </summary>
public AechoFilterGen in_gain(float in_gain) => this.SetOptionRange("in_gain", in_gain,0,1);
/// <summary>
///  set signal output gain (from 0 to 1) (default 0.3)
/// </summary>
public AechoFilterGen out_gain(float out_gain) => this.SetOptionRange("out_gain", out_gain,0,1);
/// <summary>
///  set list of signal delays (default "1000")
/// </summary>
public AechoFilterGen delays(string delays) => this.SetOption("delays",delays);
/// <summary>
///  set list of signal decays (default "0.5")
/// </summary>
public AechoFilterGen decays(string decays) => this.SetOption("decays",decays);
}
public static class AechoFilterGenExtensions
{
/// <summary>
/// Add echoing to the audio.
/// </summary>
public static AechoFilterGen AechoFilterGen(this AudioMap input0) => new AechoFilterGen(input0);
/// <summary>
/// Add echoing to the audio.
/// </summary>
public static AechoFilterGen AechoFilterGen(this AudioMap input0,AechoFilterGenConfig config)
{
var result = new AechoFilterGen(input0);
if(config?.in_gain != null) result.in_gain(config.in_gain.Value);
if(config?.out_gain != null) result.out_gain(config.out_gain.Value);
if(!string.IsNullOrWhiteSpace(config?.delays)) result.delays(config.delays);
if(!string.IsNullOrWhiteSpace(config?.decays)) result.decays(config.decays);
return result;
}
}
public class AechoFilterGenConfig
{
/// <summary>
///  set signal input gain (from 0 to 1) (default 0.6)
/// </summary>
public float? in_gain { get; set; }
/// <summary>
///  set signal output gain (from 0 to 1) (default 0.3)
/// </summary>
public float? out_gain { get; set; }
/// <summary>
///  set list of signal delays (default "1000")
/// </summary>
public string delays { get; set; }
/// <summary>
///  set list of signal decays (default "0.5")
/// </summary>
public string decays { get; set; }
}
}
