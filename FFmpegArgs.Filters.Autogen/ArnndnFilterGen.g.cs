namespace FFmpegArgs.Filters.Autogens
{
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
public static class ArnndnFilterGenExtensions
{
/// <summary>
/// Reduce noise from speech using Recurrent Neural Networks.
/// </summary>
public static ArnndnFilterGen ArnndnFilterGen(this AudioMap input0) => new ArnndnFilterGen(input0);
/// <summary>
/// Reduce noise from speech using Recurrent Neural Networks.
/// </summary>
public static ArnndnFilterGen ArnndnFilterGen(this AudioMap input0,ArnndnFilterGenConfig config)
{
var result = new ArnndnFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.model)) result.model(config.model);
if(config?.mix != null) result.mix(config.mix.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class ArnndnFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set model name
/// </summary>
public string model { get; set; }
/// <summary>
///  set output vs input mix (from -1 to 1) (default 1)
/// </summary>
public float? mix { get; set; }
public string TimelineSupport { get; set; }
}
}
