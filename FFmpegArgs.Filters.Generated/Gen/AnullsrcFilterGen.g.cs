namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... anullsrc          |-&gt;A       Null audio source, return empty audio frames.
/// </summary>
public class AnullsrcFilterGen : SourceToAudioFilter
{
internal AnullsrcFilterGen(IAudioFilterGraph input) : base("anullsrc",input) { AddMapOut(); }
/// <summary>
///  set channel_layout (default &quot;stereo&quot;)
/// </summary>
public AnullsrcFilterGen channel_layout(ChannelLayout channel_layout) => this.SetOption("channel_layout",channel_layout.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set channel_layout (default &quot;stereo&quot;)
/// </summary>
public AnullsrcFilterGen cl(ChannelLayout cl) => this.SetOption("cl",cl.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public AnullsrcFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate,1,INT_MAX);
/// <summary>
///  set sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public AnullsrcFilterGen r(int r) => this.SetOptionRange("r", r,1,INT_MAX);
/// <summary>
///  set the number of samples per requested frame (from 1 to 65535) (default 1024)
/// </summary>
public AnullsrcFilterGen nb_samples(int nb_samples) => this.SetOptionRange("nb_samples", nb_samples,1,65535);
/// <summary>
///  set the audio duration (default -0.000001)
/// </summary>
public AnullsrcFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Null audio source, return empty audio frames.
/// </summary>
public static AnullsrcFilterGen AnullsrcFilterGen(this IAudioFilterGraph input0) => new AnullsrcFilterGen(input0);
}
}
