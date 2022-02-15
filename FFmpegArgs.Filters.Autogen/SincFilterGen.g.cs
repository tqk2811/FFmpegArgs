namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... sinc              |->A       Generate a sinc kaiser-windowed low-pass, high-pass, band-pass, or band-reject FIR coefficients.
/// </summary>
public class SincFilterGen : SourceAudioFilter
{
internal SincFilterGen(IFilterGraph input) : base("sinc",input) { AddMapOut(); }
/// <summary>
///  set sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public SincFilterGen sample_rate(int sample_rate) => this.SetOptionRange("sample_rate", sample_rate,1,INT_MAX);
/// <summary>
///  set sample rate (from 1 to INT_MAX) (default 44100)
/// </summary>
public SincFilterGen r(int r) => this.SetOptionRange("r", r,1,INT_MAX);
/// <summary>
///  set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
/// </summary>
public SincFilterGen nb_samples(int nb_samples) => this.SetOptionRange("nb_samples", nb_samples,1,INT_MAX);
/// <summary>
///  set high-pass filter frequency (from 0 to INT_MAX) (default 0)
/// </summary>
public SincFilterGen hp(float hp) => this.SetOptionRange("hp", hp,0,INT_MAX);
/// <summary>
///  set low-pass filter frequency (from 0 to INT_MAX) (default 0)
/// </summary>
public SincFilterGen lp(float lp) => this.SetOptionRange("lp", lp,0,INT_MAX);
/// <summary>
///  set filter phase response (from 0 to 100) (default 50)
/// </summary>
public SincFilterGen phase(float phase) => this.SetOptionRange("phase", phase,0,100);
/// <summary>
///  set kaiser window beta (from -1 to 256) (default -1)
/// </summary>
public SincFilterGen beta(float beta) => this.SetOptionRange("beta", beta,-1,256);
/// <summary>
///  set stop-band attenuation (from 40 to 180) (default 120)
/// </summary>
public SincFilterGen att(float att) => this.SetOptionRange("att", att,40,180);
/// <summary>
///  enable rounding (default false)
/// </summary>
public SincFilterGen round(bool round) => this.SetOption("round",round.ToFFmpegFlag());
/// <summary>
///  set number of taps for high-pass filter (from 0 to 32768) (default 0)
/// </summary>
public SincFilterGen hptaps(int hptaps) => this.SetOptionRange("hptaps", hptaps,0,32768);
/// <summary>
///  set number of taps for low-pass filter (from 0 to 32768) (default 0)
/// </summary>
public SincFilterGen lptaps(int lptaps) => this.SetOptionRange("lptaps", lptaps,0,32768);
}
/// <summary>
/// </summary>
public static class SincFilterGenExtensions
{
/// <summary>
/// Generate a sinc kaiser-windowed low-pass, high-pass, band-pass, or band-reject FIR coefficients.
/// </summary>
public static SincFilterGen SincFilterGen(this IFilterGraph input0) => new SincFilterGen(input0);
}
}
