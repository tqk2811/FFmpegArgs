namespace FFmpegArgs.Filters.Autogens
{
public class AbufferFilterGen : SourceAudioFilter
{
internal AbufferFilterGen(FilterGraph input) : base("abuffer",input) { AddMapOut(); }
/// <summary>
///  (from 0 to INT_MAX) (default 0/1)
/// </summary>
public AbufferFilterGen time_base(Rational time_base) => this.SetOption("time_base",time_base.Check(0,INT_MAX));
/// <summary>
///  (from 0 to INT_MAX) (default 0)
/// </summary>
public AbufferFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate,0,INT_MAX);
/// <summary>
///  (default none)
/// </summary>
public AbufferFilterGen sample_fmt(AVSampleFormat sample_fmt) => this.SetOption("sample_fmt",sample_fmt.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
/// 
/// </summary>
public AbufferFilterGen channel_layout(string channel_layout) => this.SetOption("channel_layout",channel_layout);
/// <summary>
///  (from 0 to INT_MAX) (default 0)
/// </summary>
public AbufferFilterGen channels(int channels) => this.SetOptionRange("channels", channels,0,INT_MAX);
}
public static class AbufferFilterGenExtensions
{
/// <summary>
/// Buffer audio frames, and make them accessible to the filterchain.
/// </summary>
public static AbufferFilterGen AbufferFilterGen(this FilterGraph input0) => new AbufferFilterGen(input0);
/// <summary>
/// Buffer audio frames, and make them accessible to the filterchain.
/// </summary>
public static AbufferFilterGen AbufferFilterGen(this FilterGraph input0,AbufferFilterGenConfig config)
{
var result = new AbufferFilterGen(input0);
if(config?.time_base != null) result.time_base(config.time_base);
if(config?.sample_rate != null) result.sample_rate(config.sample_rate.Value);
if(config?.sample_fmt != null) result.sample_fmt(config.sample_fmt.Value);
if(!string.IsNullOrWhiteSpace(config?.channel_layout)) result.channel_layout(config.channel_layout);
if(config?.channels != null) result.channels(config.channels.Value);
return result;
}
}
public class AbufferFilterGenConfig
{
/// <summary>
///  (from 0 to INT_MAX) (default 0/1)
/// </summary>
public Rational time_base { get; set; }
/// <summary>
///  (from 0 to INT_MAX) (default 0)
/// </summary>
public int? sample_rate { get; set; }
/// <summary>
///  (default none)
/// </summary>
public AVSampleFormat? sample_fmt { get; set; }
/// <summary>
/// 
/// </summary>
public string channel_layout { get; set; }
/// <summary>
///  (from 0 to INT_MAX) (default 0)
/// </summary>
public int? channels { get; set; }
}
}
