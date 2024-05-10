namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... chorus            A->A       Add a chorus effect to the audio.
/// </summary>
public class ChorusFilterGen : AudioToAudioFilter
{
internal ChorusFilterGen(AudioMap input) : base("chorus",input) { AddMapOut(); }
/// <summary>
///  set input gain (from 0 to 1) (default 0.4)
/// </summary>
public ChorusFilterGen in_gain(float in_gain) => this.SetOptionRange("in_gain", in_gain,0,1);
/// <summary>
///  set output gain (from 0 to 1) (default 0.4)
/// </summary>
public ChorusFilterGen out_gain(float out_gain) => this.SetOptionRange("out_gain", out_gain,0,1);
/// <summary>
///  set delays
/// </summary>
public ChorusFilterGen delays(string delays) => this.SetOption("delays",delays);
/// <summary>
///  set decays
/// </summary>
public ChorusFilterGen decays(string decays) => this.SetOption("decays",decays);
/// <summary>
///  set speeds
/// </summary>
public ChorusFilterGen speeds(string speeds) => this.SetOption("speeds",speeds);
/// <summary>
///  set depths
/// </summary>
public ChorusFilterGen depths(string depths) => this.SetOption("depths",depths);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Add a chorus effect to the audio.
/// </summary>
public static ChorusFilterGen ChorusFilterGen(this AudioMap input0) => new ChorusFilterGen(input0);
}
}
