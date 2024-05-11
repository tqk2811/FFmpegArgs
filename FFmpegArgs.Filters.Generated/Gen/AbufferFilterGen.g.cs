namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... abuffer           |-&gt;A       Buffer audio frames, and make them accessible to the filterchain.
/// </summary>
public class AbufferFilterGen : SourceToAudioFilter
{
internal AbufferFilterGen(IAudioFilterGraph input) : base("abuffer",input) { AddMapOut(); }
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
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Buffer audio frames, and make them accessible to the filterchain.
/// </summary>
public static AbufferFilterGen AbufferFilterGen(this IAudioFilterGraph input0) => new AbufferFilterGen(input0);
}
}
