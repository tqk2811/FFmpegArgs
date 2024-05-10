namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... anullsrc          |->A       Null audio source, return empty audio frames.
/// </summary>
public class AnullsrcFilterGen : SourceAudioFilter
{
internal AnullsrcFilterGen(IAudioFilterGraph input) : base("anullsrc",input) { AddMapOut(); }
/// <summary>
///  set channel_layout (default "stereo")
/// </summary>
public AnullsrcFilterGen channel_layout(string channel_layout) => this.SetOption("channel_layout",channel_layout);
/// <summary>
///  set channel_layout (default "stereo")
/// </summary>
public AnullsrcFilterGen cl(string cl) => this.SetOption("cl",cl);
/// <summary>
///  set sample rate (default "44100")
/// </summary>
public AnullsrcFilterGen sample_rate(string sample_rate) => this.SetOption("sample_rate",sample_rate);
/// <summary>
///  set sample rate (default "44100")
/// </summary>
public AnullsrcFilterGen r(string r) => this.SetOption("r",r);
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
