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
        /// Set sample rate, default is 44100.
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public HilbertFilter SampleRate(int r)
          => this.SetOptionRange("r", r, 0, int.MaxValue);

        /// <summary>
        /// Set length of FIR filter, default is 22051.
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public HilbertFilter Taps(int t)
          => this.SetOptionRange("t", t, 0, int.MaxValue);

        /// <summary>
        /// Set number of samples per each frame.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public HilbertFilter NbSamples(int n)
          => this.SetOptionRange("n", n, 0, int.MaxValue);

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
