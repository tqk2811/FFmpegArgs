/*
afftfilt AVOptions:
  real              <string>     ..F.A...... set channels real expressions (default "re")
  imag              <string>     ..F.A...... set channels imaginary expressions (default "im")
  win_size          <int>        ..F.A...... set window size (from 16 to 131072) (default 4096)
  win_func          <int>        ..F.A...... set window function (from 0 to 19) (default hann)
     rect            0            ..F.A...... Rectangular
     bartlett        4            ..F.A...... Bartlett
     hann            1            ..F.A...... Hann
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
  overlap           <float>      ..F.A...... set window overlap (from 0 to 1) (default 0.75)
 */
namespace FFmpegArgs.Filters.AudioFilters
{
    /// <summary>
    /// ... afftfilt          A->A       Apply arbitrary expressions to samples in frequency domain.<br>
    /// </br>https://ffmpeg.org/ffmpeg-filters.html#afftfilt
    /// </summary>
    public class AfftfiltFilter : AudioToAudioFilter
    {
        static readonly IEnumerable<string> _variables = new List<string>()
        {
            "sr",
            "b",
            "nb",
            "ch",
            "chs",
            "pts",
            "re",
            "im"
        };
        static readonly IEnumerable<ShuntingYardFunction> _functions = new List<ShuntingYardFunction>()
        {
            new ShuntingYardFunction("real","real_2"),
            new ShuntingYardFunction("imag","imag_2")
        };
        readonly FFmpegExpression expression = new FFmpegExpression(_variables, _functions);
        internal AfftfiltFilter(AudioMap audioMap) : base("afftfilt", audioMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set frequency domain real expression for each separate channel separated by ’|’. Default is "re".<br>
        /// </br> If the number of input channels is greater than the number of expressions, the last specified expression is used for the remaining output channels.
        /// </summary>
        /// <param name="real"></param>
        /// <returns></returns>
        public AfftfiltFilter Real(ExpressionValue real)
         => this.SetOption("real", expression.Check(real));
        /// <summary>
        /// Set frequency domain imaginary expression for each separate channel separated by ’|’. Default is "im".
        /// </summary>
        /// <param name="imag"></param>
        /// <returns></returns>
        public AfftfiltFilter Imag(ExpressionValue imag)
         => this.SetOption("imag", expression.Check(imag));
        /// <summary>
        /// Set window size. Allowed range is from 16 to 131072. Default is 4096
        /// </summary>
        /// <param name="win_size"></param>
        /// <returns></returns>
        public AfftfiltFilter WinSize(int win_size)
          => this.SetOptionRange("win_size", win_size, 16, 131072);
        /// <summary>
        /// Set window function.
        /// </summary>
        /// <param name="win_func"></param>
        /// <returns></returns>
        public AfftfiltFilter WinFunc(AfftfiltWinFunc win_func)
          => this.SetOption("win_func", win_func);
        /// <summary>
        /// Set window overlap. If set to 1, the recommended overlap for selected window function will be picked. (from 0 to 1) (default 0.75)
        /// </summary>
        /// <param name="overlap"></param>
        /// <returns></returns>
        public AfftfiltFilter Overlap(float overlap)
          => this.SetOptionRange("overlap", overlap, 0, 1);
    }
    /// <summary>
    /// 
    /// </summary>
    public static class AfftfiltFilterExtension
    {
        /// <summary>
        /// Apply arbitrary expressions to samples in frequency domain.
        /// </summary>
        /// <param name="audioMap"></param>
        /// <returns></returns>
        public static AfftfiltFilter AfftfiltFilter(this AudioMap audioMap)
            => new AfftfiltFilter(audioMap);
    }
    /// <summary>
    /// set window function
    /// </summary>
    public enum AfftfiltWinFunc
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
        /// Hann
        /// </summary>
        hann,
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
