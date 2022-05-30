namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.C adynamicsmooth    A->A       Apply Dynamic Smoothing of input audio.
/// </summary>
public class AdynamicsmoothFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal AdynamicsmoothFilterGen(AudioMap input) : base("adynamicsmooth",input) { AddMapOut(); }
/// <summary>
///  set smooth sensitivity (from 0 to 1e+06) (default 2)
/// </summary>
public AdynamicsmoothFilterGen sensitivity(double sensitivity) => this.SetOptionRange("sensitivity", sensitivity,0,1e+06);
/// <summary>
///  set base frequency (from 2 to 1e+06) (default 22050)
/// </summary>
public AdynamicsmoothFilterGen basefreq(double basefreq) => this.SetOptionRange("basefreq", basefreq,2,1e+06);
}
/// <summary>
/// </summary>
public static class AdynamicsmoothFilterGenExtensions
{
/// <summary>
/// Apply Dynamic Smoothing of input audio.
/// </summary>
public static AdynamicsmoothFilterGen AdynamicsmoothFilterGen(this AudioMap input0) => new AdynamicsmoothFilterGen(input0);
}
}
