namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// T.. dcshift           A->A       Apply a DC shift to the audio.
/// </summary>
public class DcshiftFilterGen : AudioToAudioFilter,ITimelineSupport
{
internal DcshiftFilterGen(AudioMap input) : base("dcshift",input) { AddMapOut(); }
/// <summary>
///  set DC shift (from -1 to 1) (default 0)
/// </summary>
public DcshiftFilterGen shift(double shift) => this.SetOptionRange("shift", shift,-1,1);
/// <summary>
///  set limiter gain (from 0 to 1) (default 0)
/// </summary>
public DcshiftFilterGen limitergain(double limitergain) => this.SetOptionRange("limitergain", limitergain,0,1);
}
/// <summary>
/// </summary>
public static class DcshiftFilterGenExtensions
{
/// <summary>
/// Apply a DC shift to the audio.
/// </summary>
public static DcshiftFilterGen DcshiftFilterGen(this AudioMap input0) => new DcshiftFilterGen(input0);
}
}
