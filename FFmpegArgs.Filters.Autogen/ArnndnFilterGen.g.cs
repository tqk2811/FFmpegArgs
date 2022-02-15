namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC arnndn            A->A       Reduce noise from speech using Recurrent Neural Networks.
/// </summary>
public class ArnndnFilterGen : AudioToAudioFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ArnndnFilterGen(AudioMap input) : base("arnndn",input) { AddMapOut(); }
/// <summary>
///  set model name
/// </summary>
public ArnndnFilterGen model(string model) => this.SetOption("model",model);
/// <summary>
///  set output vs input mix (from -1 to 1) (default 1)
/// </summary>
public ArnndnFilterGen mix(float mix) => this.SetOptionRange("mix", mix,-1,1);
}
/// <summary>
/// </summary>
public static class ArnndnFilterGenExtensions
{
/// <summary>
/// Reduce noise from speech using Recurrent Neural Networks.
/// </summary>
public static ArnndnFilterGen ArnndnFilterGen(this AudioMap input0) => new ArnndnFilterGen(input0);
}
}
