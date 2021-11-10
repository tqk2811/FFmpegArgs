using FFmpegArgs.Filters.AudioFilters;
namespace FFmpegArgs.Filters.AudioSources
{
  /// <summary>
  /// ... sinc              |->A       Generate a sinc kaiser-windowed low-pass, high-pass, band-pass, or band-reject FIR coefficients.<br>
  /// </br>https://ffmpeg.org/ffmpeg-filters.html#sinc
  /// </summary>
  public class SincFilter : SourceAudioFilter
  {
    internal SincFilter(FilterGraph filterGraph) : base("sinc", filterGraph)
    {
      AddMapOut();
    }

    /// <summary>
    /// Set sample rate, default is 44100.
    /// </summary>
    /// <param name="r"></param>
    /// <returns></returns>
    public SincFilter SampleRate(int r)
      => this.SetOptionRange("r", r, 0, int.MaxValue);

    /// <summary>
    /// Set number of samples per each frame. Default is 1024.
    /// </summary>
    /// <param name="n"></param>
    /// <returns></returns>
    public SincFilter NbSamples(int n)
      => this.SetOptionRange("n", n, 0, int.MaxValue);

    /// <summary>
    /// Set high-pass frequency. Default is 0.
    /// </summary>
    /// <param name="hp"></param>
    /// <returns></returns>
    public SincFilter HighPass(int hp)
      => this.SetOptionRange("hp", hp, int.MinValue, int.MaxValue);

    /// <summary>
    /// Set low-pass frequency. Default is 0.<br>
    /// </br> If high-pass frequency is lower than low-pass frequency and low-pass frequency is higher than 0 then filter will create band-pass filter coefficients, otherwise band-reject filter coefficients.
    /// </summary>
    /// <param name="lp"></param>
    /// <returns></returns>
    public SincFilter LowPass(int lp)
      => this.SetOptionRange("lp", lp, int.MinValue, int.MaxValue);

    /// <summary>
    /// Set filter phase response. Default is 50. Allowed range is from 0 to 100.
    /// </summary>
    /// <param name="phase"></param>
    /// <returns></returns>
    public SincFilter Phase(int phase)
      => this.SetOptionRange("phase", phase, 0, 100);

    /// <summary>
    /// Set Kaiser window beta.
    /// </summary>
    /// <param name="flag"></param>
    /// <returns></returns>
    public SincFilter Beta(bool flag)
      => this.SetOption("beta", flag.ToFFmpegFlag());

    /// <summary>
    /// Set stop-band attenuation. Default is 120dB, allowed range is from 40 to 180 dB.
    /// </summary>
    /// <param name="att"></param>
    /// <returns></returns>
    public SincFilter Att(int att)
      => this.SetOptionRange("att", att, 40, 180);

    /// <summary>
    /// Enable rounding, by default is disabled.
    /// </summary>
    /// <param name="flag"></param>
    /// <returns></returns>
    public SincFilter Round(bool flag)
      => this.SetOption("round", flag.ToFFmpegFlag());

    /// <summary>
    /// Set number of taps for high-pass filter.
    /// </summary>
    /// <param name="phase"></param>
    /// <returns></returns>
    public SincFilter HpTaps(int phase)
      => this.SetOptionRange("hptaps", phase, 0, int.MaxValue);

    /// <summary>
    /// Set number of taps for low-pass filter.
    /// </summary>
    /// <param name="phase"></param>
    /// <returns></returns>
    public SincFilter LpTaps(int phase)
      => this.SetOptionRange("lptaps", phase, 0, int.MaxValue);
  }

  public static class SincFilterExtensions
  {
    /// <summary>
    /// Generate a sinc kaiser-windowed low-pass, high-pass, band-pass, or band-reject FIR coefficients.<br></br>
    /// The resulting stream can be used with <see cref="AfirFilter"/> for filtering the audio signal.
    /// </summary>
    /// <param name="filterGraph"></param>
    /// <returns></returns>
    public static SincFilter SincFilter(this FilterGraph filterGraph)
      => new SincFilter(filterGraph);
  }
}
