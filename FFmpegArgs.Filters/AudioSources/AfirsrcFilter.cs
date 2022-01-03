/*
afirsrc AVOptions:
  taps              <int>        ..F.A...... set number of taps (from 9 to 65535) (default 1025)
  t                 <int>        ..F.A...... set number of taps (from 9 to 65535) (default 1025)
  frequency         <string>     ..F.A...... set frequency points (default "0 1")
  f                 <string>     ..F.A...... set frequency points (default "0 1")
  magnitude         <string>     ..F.A...... set magnitude values (default "1 1")
  m                 <string>     ..F.A...... set magnitude values (default "1 1")
  phase             <string>     ..F.A...... set phase values (default "0 0")
  p                 <string>     ..F.A...... set phase values (default "0 0")
  sample_rate       <int>        ..F.A...... set sample rate (from 1 to INT_MAX) (default 44100)
  r                 <int>        ..F.A...... set sample rate (from 1 to INT_MAX) (default 44100)
  nb_samples        <int>        ..F.A...... set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
  n                 <int>        ..F.A...... set the number of samples per requested frame (from 1 to INT_MAX) (default 1024)
  win_func          <int>        ..F.A...... set window function (from 0 to 19) (default blackman)
     rect            0            ..F.A...... Rectangular
     bartlett        4            ..F.A...... Bartlett
     hanning         1            ..F.A...... Hanning
     hamming         2            ..F.A...... Hamming
     blackman        3            ..F.A...... Blackman
     welch           5            ..F.A...... Welch
     flattop         6            ..F.A...... Flat-top
     bharris         7            ..F.A...... Blackman-Harris
     bnuttall        8            ..F.A...... Blackman-Nuttall
     bhann           11           ..F.A...... Bartlett-Hann
     sine            9            ..F.A...... Sine
     nuttall         10           ..F.A...... Nuttall
     lanczos         12           ..F.A...... Lanczos
     gauss           13           ..F.A...... Gauss
     tukey           14           ..F.A...... Tukey
     dolph           15           ..F.A...... Dolph-Chebyshev
     cauchy          16           ..F.A...... Cauchy
     parzen          17           ..F.A...... Parzen
     poisson         18           ..F.A...... Poisson
     bohman          19           ..F.A...... Bohman
  w                 <int>        ..F.A...... set window function (from 0 to 19) (default blackman)
     rect            0            ..F.A...... Rectangular
     bartlett        4            ..F.A...... Bartlett
     hanning         1            ..F.A...... Hanning
     hamming         2            ..F.A...... Hamming
     blackman        3            ..F.A...... Blackman
     welch           5            ..F.A...... Welch
     flattop         6            ..F.A...... Flat-top
     bharris         7            ..F.A...... Blackman-Harris
     bnuttall        8            ..F.A...... Blackman-Nuttall
     bhann           11           ..F.A...... Bartlett-Hann
     sine            9            ..F.A...... Sine
     nuttall         10           ..F.A...... Nuttall
     lanczos         12           ..F.A...... Lanczos
     gauss           13           ..F.A...... Gauss
     tukey           14           ..F.A...... Tukey
     dolph           15           ..F.A...... Dolph-Chebyshev
     cauchy          16           ..F.A...... Cauchy
     parzen          17           ..F.A...... Parzen
     poisson         18           ..F.A...... Poisson
     bohman          19           ..F.A...... Bohman
 */
using FFmpegArgs.Filters.AudioFilters;
namespace FFmpegArgs.Filters.AudioSources
{
    /// <summary>
    /// ... afirsrc           |->A       Generate a FIR coefficients audio stream.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#afirsrc
    /// </summary>
    public class AfirsrcFilter : SourceAudioFilter
    {
        internal AfirsrcFilter(FilterGraph filterGraph) : base("afirsrc", filterGraph)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set number of filter coefficents in output audio stream. (from 9 to 65535) (default 1025)
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public AfirsrcFilter Taps(int t)
          => this.SetOptionRange("t", t, 9, 65535);

        /// <summary>
        /// Set frequency points from where magnitude and phase are set.<br>
        /// </br> This must be in non decreasing order, and first element must be 0, while last element must be 1. Elements are separated by white spaces.
        /// <br></br>(default "0 1")
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public AfirsrcFilter Frequency(params int[] f)
          => this.SetOption("f", string.Join(" ", f));

        /// <summary>
        /// set magnitude values (default "1 1")
        /// </summary>
        /// <param name="f"></param>
        /// <returns></returns>
        public AfirsrcFilter Magnitude(params int[] f)
          => this.SetOption("m", string.Join(" ", f));


        /// <summary>
        /// Set phase value for every frequency point set by frequency.<br>
        /// </br> Number of values must be same as number of frequency points.<br>
        /// </br> Values are separated by white spaces. (default "0 0")
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public AfirsrcFilter Phase(params int[] p)
         => this.SetOption("p", string.Join(" ", p));

        /// <summary>
        /// Set sample rate, (from 1 to INT_MAX) (default 44100)
        /// </summary>
        /// <param name="sample_rate"></param>
        /// <returns></returns>
        public AfirsrcFilter SampleRate(int sample_rate)
          => this.SetOptionRange("r", sample_rate, 1, INT_MAX);

        /// <summary>
        /// Set number of samples per each frame. (from 1 to INT_MAX) (default 1024)
        /// </summary>
        /// <param name="nb_samples"></param>
        /// <returns></returns>
        public AfirsrcFilter NbSamples(int nb_samples)
          => this.SetOptionRange("n", nb_samples, 1, INT_MAX);

        /// <summary>
        /// Set window function. Default is blackman.
        /// </summary>
        /// <param name="win_func"></param>
        /// <returns></returns>
        public AfirsrcFilter WinFunc(AfirsrcWinfunc win_func)
            => this.SetOption("w", win_func);
    }

    public static class AfirsrcFilterExtensions
    {
        /// <summary>
        /// Generate a FIR coefficients using frequency sampling method.<br></br>
        /// The resulting stream can be used with <see cref="AfirFilter"/> for filtering the audio signal.
        /// </summary>
        /// <returns></returns>
        public static AfirsrcFilter AfirsrcFilter(this FilterGraph filterGraph)
          => new AfirsrcFilter(filterGraph);
    }

    public enum AfirsrcWinfunc
    {
        /// <summary>
        /// Rectangular
        /// </summary>
        rect,
        /// <summary>
        /// Bartlett
        /// </summary>
        bartlett,
        /// <summary>
        /// Hanning
        /// </summary>
        hanning,
        /// <summary>
        /// Hamming
        /// </summary>
        hamming,
        /// <summary>
        /// Blackman
        /// </summary>
        blackman,
        /// <summary>
        /// Welch
        /// </summary>
        welch,
        /// <summary>
        /// Flat-top
        /// </summary>
        flattop,
        /// <summary>
        /// Blackman-Harris
        /// </summary>
        bharris,
        /// <summary>
        /// Blackman-Nuttall
        /// </summary>
        bnuttall,
        /// <summary>
        /// Bartlett-Hann
        /// </summary>
        bhann,
        /// <summary>
        /// Sine
        /// </summary>
        sine,
        /// <summary>
        /// Nuttall
        /// </summary>
        nuttall,
        /// <summary>
        /// Lanczos
        /// </summary>
        lanczos,
        /// <summary>
        /// Gauss
        /// </summary>
        gauss,
        /// <summary>
        /// Tukey
        /// </summary>
        tukey,
        /// <summary>
        /// Dolph-Chebyshev
        /// </summary>
        dolph,
        /// <summary>
        /// Cauchy
        /// </summary>
        cauchy,
        /// <summary>
        /// Parzen
        /// </summary>
        parzen,
        /// <summary>
        /// Poisson
        /// </summary>
        poisson,
        /// <summary>
        /// Bohman
        /// </summary>
        bohman,
    }
}
