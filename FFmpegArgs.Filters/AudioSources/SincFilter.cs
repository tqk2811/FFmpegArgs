/*
sinc AVOptions:
  sample_rate       <int>        ..F.A...... set sample rate (from 1 to INT_MAX) (default 44100)
  r                 <int>        ..F.A...... set sample rate (from 1 to INT_MAX) (default 44100)
  nb_samples        <int>        ..F.A...... set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
  n                 <int>        ..F.A...... set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
  hp                <float>      ..F.A...... set high-pass filter frequency (from 0 to INT_MAX) (default 0)
  lp                <float>      ..F.A...... set low-pass filter frequency (from 0 to INT_MAX) (default 0)
  phase             <float>      ..F.A...... set filter phase response (from 0 to 100) (default 50)
  beta              <float>      ..F.A...... set kaiser window beta (from -1 to 256) (default -1)
  att               <float>      ..F.A...... set stop-band attenuation (from 40 to 180) (default 120)
  round             <boolean>    ..F.A...... enable rounding (default false)
  hptaps            <int>        ..F.A...... set number of taps for high-pass filter (from 0 to 32768) (default 0)
  lptaps            <int>        ..F.A...... set number of taps for low-pass filter (from 0 to 32768) (default 0)
 */
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
        /// Set sample rate, (from 1 to INT_MAX) (default 44100)
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public SincFilter SampleRate(int r)
          => this.SetOptionRange("r", r, 1, INT_MAX);
        /// <summary>
        /// Set number of samples per each frame. (from 1 to INT_MAX) (default 1024)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public SincFilter NbSamples(int n)
          => this.SetOptionRange("n", n, 1, INT_MAX);
        /// <summary>
        /// Set high-pass frequency. (from 0 to INT_MAX) (default 0)
        /// </summary>
        /// <param name="hp"></param>
        /// <returns></returns>
        public SincFilter HighPass(float hp)
          => this.SetOptionRange("hp", hp, 0, INT_MAX);
        /// <summary>
        /// Set low-pass frequency. (from 0 to INT_MAX) (default 0)<br>
        /// </br> If high-pass frequency is lower than low-pass frequency and low-pass frequency is higher than 0 then filter will create band-pass filter coefficients, otherwise band-reject filter coefficients.
        /// </summary>
        /// <param name="lp"></param>
        /// <returns></returns>
        public SincFilter LowPass(float lp)
          => this.SetOptionRange("lp", lp, 0, INT_MAX);
        /// <summary>
        /// Set filter phase response. (from 0 to 100) (default 50)
        /// </summary>
        /// <param name="phase"></param>
        /// <returns></returns>
        public SincFilter Phase(float phase)
          => this.SetOptionRange("phase", phase, 0, 100);
        /// <summary>
        /// Set Kaiser window beta. (from -1 to 256) (default -1)
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public SincFilter Beta(float beta)
          => this.SetOptionRange("beta", beta, -1, 256);
        /// <summary>
        /// Set stop-band attenuation. Default is 120dB, allowed range is from 40 to 180 dB.
        /// </summary>
        /// <param name="att"></param>
        /// <returns></returns>
        public SincFilter Att(float att)
          => this.SetOptionRange("att", att, 40, 180);
        /// <summary>
        /// Enable rounding, by default is disabled.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public SincFilter Round(bool flag)
          => this.SetOption("round", flag.ToFFmpegFlag());
        /// <summary>
        /// Set number of taps for high-pass filter. (from 0 to 32768) (default 0)
        /// </summary>
        /// <param name="phase"></param>
        /// <returns></returns>
        public SincFilter HpTaps(int phase)
          => this.SetOptionRange("hptaps", phase, 0, 32768);
        /// <summary>
        /// Set number of taps for low-pass filter. (from 0 to 32768) (default 0)
        /// </summary>
        /// <param name="phase"></param>
        /// <returns></returns>
        public SincFilter LpTaps(int phase)
          => this.SetOptionRange("lptaps", phase, 0, 32768);
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
