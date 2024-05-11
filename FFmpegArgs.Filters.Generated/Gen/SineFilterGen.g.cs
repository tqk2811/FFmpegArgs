namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... sine              |-&gt;A       Generate sine wave audio signal.
/// </summary>
public class SineFilterGen : SourceToAudioFilter
{
internal SineFilterGen(IAudioFilterGraph input) : base("sine",input) { AddMapOut(); }
/// <summary>
///  set the sine frequency (from 0 to DBL_MAX) (default 440)
/// </summary>
public SineFilterGen frequency(double frequency) => this.SetOptionRange("frequency", frequency,0,DBL_MAX);
/// <summary>
///  set the beep frequency factor (from 0 to DBL_MAX) (default 0)
/// </summary>
public SineFilterGen beep_factor(double beep_factor) => this.SetOptionRange("beep_factor", beep_factor,0,DBL_MAX);
/// <summary>
///  set the sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public SineFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate,1,INT_MAX);
/// <summary>
///  set the sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public SineFilterGen r(int r) => this.SetOptionRange("r", r,1,INT_MAX);
/// <summary>
///  set the audio duration (default 0)
/// </summary>
public SineFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
/// <summary>
///  set the number of samples per frame (default &quot;1024&quot;)
/// </summary>
public SineFilterGen samples_per_frame(string samples_per_frame) => this.SetOption("samples_per_frame",samples_per_frame);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Generate sine wave audio signal.
/// </summary>
public static SineFilterGen SineFilterGen(this IAudioFilterGraph input0) => new SineFilterGen(input0);
}
}
