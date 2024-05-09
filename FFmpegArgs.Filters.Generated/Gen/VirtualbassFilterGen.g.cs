namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.C virtualbass       A->A       Audio Virtual Bass.
/// </summary>
public class VirtualbassFilterGen : AudioToAudioFilter,ITimelineSupport,ICommandSupport
{
internal VirtualbassFilterGen(AudioMap input) : base("virtualbass",input) { AddMapOut(); }
/// <summary>
///  set virtual bass cutoff (from 100 to 500) (default 250)
/// </summary>
public VirtualbassFilterGen cutoff(double cutoff) => this.SetOptionRange("cutoff", cutoff,100,500);
/// <summary>
///  set virtual bass strength (from 0.5 to 3) (default 3)
/// </summary>
public VirtualbassFilterGen strength(double strength) => this.SetOptionRange("strength", strength,0.5,3);
}
/// <summary>
/// </summary>
public static class VirtualbassFilterGenExtensions
{
/// <summary>
/// Audio Virtual Bass.
/// </summary>
public static VirtualbassFilterGen VirtualbassFilterGen(this AudioMap input0) => new VirtualbassFilterGen(input0);
}
}
