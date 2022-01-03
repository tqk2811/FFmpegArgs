/*
hilbert AVOptions:
  sample_rate       <int>        ..F.A...... set sample rate (from 1 to INT_MAX) (default 44100)
  r                 <int>        ..F.A...... set sample rate (from 1 to INT_MAX) (default 44100)
  taps              <int>        ..F.A...... set number of taps (from 11 to 65535) (default 22051)
  t                 <int>        ..F.A...... set number of taps (from 11 to 65535) (default 22051)
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
    /// ... hilbert           |->A       Generate a Hilbert transform FIR coefficients.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#hilbert
    /// </summary>
    public class HilbertFilter : SourceAudioFilter
    {
        internal HilbertFilter(FilterGraph filterGraph) : base("hilbert", filterGraph)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set sample rate, (from 1 to INT_MAX) (default 44100)
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public HilbertFilter SampleRate(int r)
          => this.SetOptionRange("r", r, 1, INT_MAX);

        /// <summary>
        /// Set length of FIR filter, (from 11 to 65535) (default 22051)
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public HilbertFilter Taps(int t)
          => this.SetOptionRange("t", t, 11, 65535);

        /// <summary>
        /// Set number of samples per each frame. (from 1 to INT_MAX) (default 1024)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public HilbertFilter NbSamples(int n)
          => this.SetOptionRange("n", n, 1, INT_MAX);

        /// <summary>
        /// Set window function to be used when generating FIR coefficients.
        /// </summary>
        /// <param name="w"></param>
        /// <returns></returns>
        public HilbertFilter WinFunc(HilbertWinFunc winFunc)
          => this.SetOption("w", winFunc);
    }

    public static class HilbertFilterExtensions
    {
        /// <summary>
        /// Generate odd-tap Hilbert transform FIR coefficients.<br></br>
        /// The resulting stream can be used with <see cref="AfirFilter"/> for phase-shifting the signal by 90 degrees.<br></br>
        /// This is used in many matrix coding schemes and for analytic signal generation.The process is often written as a multiplication by i(or j), the imaginary unit.
        /// </summary>
        /// <param name="filterGraph"></param>
        /// <returns></returns>
        public static HilbertFilter HilbertFilter(this FilterGraph filterGraph)
          => new HilbertFilter(filterGraph);
    }


    public enum HilbertWinFunc
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
        bohman
    }
}
