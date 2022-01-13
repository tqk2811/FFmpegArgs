namespace FFmpegArgs.Filters.Autogens
{
public class AdelayFilterGen : AudioToAudioFilter,ITimelineSupport
{
internal AdelayFilterGen(AudioMap input) : base("adelay",input) { AddMapOut(); }
/// <summary>
///  set list of delays for each channel
/// </summary>
public AdelayFilterGen delays(string delays) => this.SetOption("delays",delays);
/// <summary>
///  use last available delay for remained channels (default false)
/// </summary>
public AdelayFilterGen all(bool all) => this.SetOption("all",all.ToFFmpegFlag());
}
public static class AdelayFilterGenExtensions
{
/// <summary>
/// Delay one or more audio channels.
/// </summary>
public static AdelayFilterGen AdelayFilterGen(this AudioMap input0) => new AdelayFilterGen(input0);
/// <summary>
/// Delay one or more audio channels.
/// </summary>
public static AdelayFilterGen AdelayFilterGen(this AudioMap input0,AdelayFilterGenConfig config)
{
var result = new AdelayFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.delays)) result.delays(config.delays);
if(config?.all != null) result.all(config.all.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class AdelayFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set list of delays for each channel
/// </summary>
public string delays { get; set; }
/// <summary>
///  use last available delay for remained channels (default false)
/// </summary>
public bool? all { get; set; }
public string TimelineSupport { get; set; }
}
}
