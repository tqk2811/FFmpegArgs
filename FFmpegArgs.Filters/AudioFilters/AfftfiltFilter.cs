using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using System;
using System.Collections.Generic;

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
        readonly Expression expression = new Expression(_variables, _functions);
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
        public AfftfiltFilter Real(Action<Expression> real)
          => this.SetOption("real", real.Run(expression));

        /// <summary>
        /// Set frequency domain real expression for each separate channel separated by ’|’. Default is "re".<br>
        /// </br> If the number of input channels is greater than the number of expressions, the last specified expression is used for the remaining output channels.
        /// </summary>
        /// <param name="real"></param>
        /// <returns></returns>
        public AfftfiltFilter Real(string real)
         => this.SetOption("real", real.Expression().Run(expression));


        /// <summary>
        /// Set frequency domain imaginary expression for each separate channel separated by ’|’. Default is "im".
        /// </summary>
        /// <param name="imag"></param>
        /// <returns></returns>
        public AfftfiltFilter Imag(Action<Expression> imag)
          => this.SetOption("imag", imag.Run(expression));

        /// <summary>
        /// Set frequency domain imaginary expression for each separate channel separated by ’|’. Default is "im".
        /// </summary>
        /// <param name="imag"></param>
        /// <returns></returns>
        public AfftfiltFilter Imag(string imag)
         => this.SetOption("imag", imag.Expression().Run(expression));

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
        /// Set window overlap. If set to 1, the recommended overlap for selected window function will be picked. Default is 0.75.
        /// </summary>
        /// <param name="overlap"></param>
        /// <returns></returns>
        public AfftfiltFilter Overlap(float overlap)
          => this.SetOption("overlap", overlap);
    }

    public static class AfftfiltFilterExtension
    {
        public static AfftfiltFilter AfftfiltFilter(this AudioMap audioMap)
            => new AfftfiltFilter(audioMap);
    }

    public enum AfftfiltWinFunc
    {
        rect,
        bartlett,
        hann,
        hanning,
        hamming,
        blackman,
        welch,
        flattop,
        bharris,
        bnuttall,
        bhann,
        sine,
        nuttall,
        lanczos,
        gauss,
        tukey,
        dolph,
        cauchy,
        parzen,
        poisson,
        bohman
    }
}
