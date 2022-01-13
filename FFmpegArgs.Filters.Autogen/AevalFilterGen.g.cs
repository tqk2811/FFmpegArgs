namespace FFmpegArgs.Filters.Autogens
{
public class AevalFilterGen : AudioToAudioFilter,ITimelineSupport
{
internal AevalFilterGen(AudioMap input) : base("aeval",input) { AddMapOut(); }
/// <summary>
///  set the '|'-separated list of channels expressions
/// </summary>
public AevalFilterGen exprs(string exprs) => this.SetOption("exprs",exprs);
/// <summary>
///  set channel layout
/// </summary>
public AevalFilterGen channel_layout(string channel_layout) => this.SetOption("channel_layout",channel_layout);
}
public static class AevalFilterGenExtensions
{
/// <summary>
/// Filter audio signal according to a specified expression.
/// </summary>
public static AevalFilterGen AevalFilterGen(this AudioMap input0) => new AevalFilterGen(input0);
/// <summary>
/// Filter audio signal according to a specified expression.
/// </summary>
public static AevalFilterGen AevalFilterGen(this AudioMap input0,AevalFilterGenConfig config)
{
var result = new AevalFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.exprs)) result.exprs(config.exprs);
if(!string.IsNullOrWhiteSpace(config?.channel_layout)) result.channel_layout(config.channel_layout);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class AevalFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  set the '|'-separated list of channels expressions
/// </summary>
public string exprs { get; set; }
/// <summary>
///  set channel layout
/// </summary>
public string channel_layout { get; set; }
public string TimelineSupport { get; set; }
}
}
