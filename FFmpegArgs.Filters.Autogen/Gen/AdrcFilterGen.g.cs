namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC adrc              A->A       Audio Spectral Dynamic Range Controller.
/// </summary>
public class AdrcFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal AdrcFilterGen(AudioMap input) : base("adrc",input) { AddMapOut(); }
/// <summary>
///  set the transfer expression (default "p")
/// </summary>
public AdrcFilterGen transfer(string transfer) => this.SetOption("transfer",transfer);
/// <summary>
///  set the attack (from 1 to 1000) (default 50)
/// </summary>
public AdrcFilterGen attack(double attack) => this.SetOptionRange("attack", attack,1,1000);
/// <summary>
///  set the release (from 5 to 2000) (default 100)
/// </summary>
public AdrcFilterGen release(double release) => this.SetOptionRange("release", release,5,2000);
/// <summary>
///  set channels to filter (default "all")
/// </summary>
public AdrcFilterGen channels(string channels) => this.SetOption("channels",channels);
}
/// <summary>
/// </summary>
public static class AdrcFilterGenExtensions
{
/// <summary>
/// Audio Spectral Dynamic Range Controller.
/// </summary>
public static AdrcFilterGen AdrcFilterGen(this AudioMap input0) => new AdrcFilterGen(input0);
}
}
