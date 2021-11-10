using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Filters.Enums;
using FFmpegArgs.Utils;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TSC convolution       V->V       Apply convolution filter.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#convolution
    /// </summary>
    public class ConvolutionFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        readonly Expression expression = new Expression();
        internal ConvolutionFilter(ImageMap imageMap) : base("convolution", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set matrix for each plane. Matrix is sequence of 9, 25 or 49 signed integers in square mode, and from 1 to 49 odd number of signed integers in row mode.
        /// </summary>
        /// <param name="plane"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public ConvolutionFilter Matrix(ConvolutionPlane plane, params int[] vals)
            => this.SetOption($"{plane.ToString().Substring(1)}m", string.Join(" ",vals));

        /// <summary>
        /// Set multiplier for calculated value for each plane. If unset or 0, it will be sum of all matrix elements.
        /// </summary>
        /// <param name="plane"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public ConvolutionFilter Multiplier(ConvolutionPlane plane, string val)
            => this.SetOption($"{plane.ToString().Substring(1)}rdiv", val.Expression().Run(expression));

        /// <summary>
        /// Set bias for each plane. This value is added to the result of the multiplication. Useful for making the overall image brighter or darker.<br>
        /// </br> Default is 0.0.
        /// </summary>
        /// <param name="plane"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public ConvolutionFilter Bias(ConvolutionPlane plane, double val)
           => this.SetOptionRange($"{plane.ToString().Substring(1)}bias", val, double.MinValue, double.MaxValue);

        /// <summary>
        /// Set matrix mode for each plane. Can be square, row or column. Default is square.
        /// </summary>
        /// <param name="plane"></param>
        /// <param name="val"></param>
        /// <returns></returns>
        public ConvolutionFilter MatrixMode(ConvolutionPlane plane, ConvolutionMatrixMode mode)
           => this.SetOption($"{plane.ToString().Substring(1)}mode", mode);

    }

    public static class ConvolutionFilterExtensions
    {
        /// <summary>
        /// Apply convolution of 3x3, 5x5, 7x7 or horizontal/vertical up to 49 elements.
        /// </summary>
        public static ConvolutionFilter ConvolutionFilter(this ImageMap imageMap)
          => new ConvolutionFilter(imageMap);
    }

    public enum ConvolutionPlane
    {
        _0,
        _1,
        _2,
        _3,
    }

    public enum ConvolutionMatrixMode
    {
        square,
        row,
        column
    }
}
