namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... aecho             A->A       Add echoing to the audio.
/// </summary>
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
/// <summary>
/// </summary>
public static class AechoFilterGenExtensions
{
/// <summary>
/// Add echoing to the audio.
/// </summary>
public static AechoFilterGen AechoFilterGen(this AudioMap input0) => new AechoFilterGen(input0);
}
}
