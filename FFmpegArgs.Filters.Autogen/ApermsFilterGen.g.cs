namespace FFmpegArgs.Filters.Autogens
{
public class ApermsFilterGen : AudioToAudioFilter,ITimelineSupport
{
internal ApermsFilterGen(AudioMap input) : base("aperms",input) { AddMapOut(); }
/// <summary>
///  select permissions mode (from 0 to 4) (default none)
/// </summary>
public ApermsFilterGen mode(ApermsFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set the seed for the random mode (from -1 to UINT32_MAX) (default -1)
/// </summary>
public ApermsFilterGen seed(long seed) => this.SetOptionRange("seed", seed,-1,UINT32_MAX);
}
public static class ApermsFilterGenExtensions
{
/// <summary>
/// Set permissions for the output audio frame.
/// </summary>
public static ApermsFilterGen ApermsFilterGen(this AudioMap input0) => new ApermsFilterGen(input0);
/// <summary>
/// Set permissions for the output audio frame.
/// </summary>
public static ApermsFilterGen ApermsFilterGen(this AudioMap input0,ApermsFilterGenConfig config)
{
var result = new ApermsFilterGen(input0);
if(config?.mode != null) result.mode(config.mode.Value);
if(config?.seed != null) result.seed(config.seed.Value);
if(!string.IsNullOrWhiteSpace(config?.TimelineSupport)) result.Enable(config.TimelineSupport);
return result;
}
}
public class ApermsFilterGenConfig
:ITimelineSupportConfig
{
/// <summary>
///  select permissions mode (from 0 to 4) (default none)
/// </summary>
public ApermsFilterGenMode? mode { get; set; }
/// <summary>
///  set the seed for the random mode (from -1 to UINT32_MAX) (default -1)
/// </summary>
public long? seed { get; set; }
public string TimelineSupport { get; set; }
}
public enum ApermsFilterGenMode
{
[Name("none")] none,
[Name("ro")] ro,
[Name("rw")] rw,
[Name("toggle")] toggle,
[Name("random")] random,
}

}
