namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... aevalsrc          |->A       Generate an audio signal generated by an expression.
/// </summary>
public class AevalsrcFilterGen : SourceAudioFilter
{
internal AevalsrcFilterGen(IAudioFilterGraph input) : base("aevalsrc",input) { AddMapOut(); }
/// <summary>
///  set the '|'-separated list of channels expressions
/// </summary>
public AevalsrcFilterGen exprs(string exprs) => this.SetOption("exprs",exprs);
/// <summary>
///  set the number of samples per requested frame (from 0 to INT_MAX) (default 1024)
/// </summary>
public AevalsrcFilterGen nb_samples(int nb_samples) => this.SetOptionRange("nb_samples", nb_samples,0,INT_MAX);
/// <summary>
///  set the sample rate (default "44100")
/// </summary>
public AevalsrcFilterGen sample_rate(string sample_rate) => this.SetOption("sample_rate",sample_rate);
/// <summary>
///  set audio duration (default -0.000001)
/// </summary>
public AevalsrcFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set channel layout
/// </summary>
public AevalsrcFilterGen channel_layout(string channel_layout) => this.SetOption("channel_layout",channel_layout);
}
/// <summary>
/// </summary>
public static class AevalsrcFilterGenExtensions
{
/// <summary>
/// Generate an audio signal generated by an expression.
/// </summary>
public static AevalsrcFilterGen AevalsrcFilterGen(this IAudioFilterGraph input0) => new AevalsrcFilterGen(input0);
}
}