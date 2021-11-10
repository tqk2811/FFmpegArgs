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
    /// TS. dctdnoiz          V->V       Denoise frames using 2D DCT.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#dctdnoiz
    /// </summary>
    public class DctdnoizFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        readonly Expression expression = new Expression();
        internal DctdnoizFilter(ImageMap imageMap) : base("dctdnoiz", imageMap)
        {
            AddMapOut();
            IsAllowEmptyOption = true;
        }

        /// <summary>
        /// Set the noise sigma constant.<br>
        /// </br>This sigma defines a hard threshold of 3 * sigma; every DCT coefficient(absolute value) below this threshold with be dropped.<br>
        /// </br>If you need a more advanced filtering, see <see cref="Expr"/>.<br>
        /// </br>Default is 0.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public DctdnoizFilter Sigma(string s)
            => Sigma(s.Expression());
        /// <summary>
        /// Set the noise sigma constant.<br>
        /// </br>This sigma defines a hard threshold of 3 * sigma; every DCT coefficient(absolute value) below this threshold with be dropped.<br>
        /// </br>If you need a more advanced filtering, see <see cref="Expr"/>.<br>
        /// </br>Default is 0.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public DctdnoizFilter Sigma(Action<Expression> s)
            => this.SetOption("s", s.Run(expression));

        /// <summary>
        /// Set number overlapping pixels for each block. Since the filter can be slow, you may want to reduce this value, at the cost of a less effective filter and the risk of various artefacts.<br>
        /// </br>If the overlapping value doesn’t permit processing the whole input width or height, a warning will be displayed and according borders won’t be denoised.<br>
        /// </br>Default value is blocksize-1, which is the best possible setting.
        /// </summary>
        /// <param name="overlap"></param>
        /// <returns></returns>
        public DctdnoizFilter Overlap(int overlap)
            => this.SetOptionRange("overlap", overlap, 0, int.MaxValue);


        /// <summary>
        /// Set the coefficient factor expression.<br>
        /// </br>For each coefficient of a DCT block, this expression will be evaluated as a multiplier value for the coefficient.<br>
        /// </br>If this is option is set, the sigma option will be ignored.<br>
        /// </br>The absolute value of the coefficient can be accessed through the c variable.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public DctdnoizFilter Expr(string e)
            => Expr(e.Expression());

        /// <summary>
        /// Set the coefficient factor expression.<br>
        /// </br>For each coefficient of a DCT block, this expression will be evaluated as a multiplier value for the coefficient.<br>
        /// </br>If this is option is set, the sigma option will be ignored.<br>
        /// </br>The absolute value of the coefficient can be accessed through the c variable.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public DctdnoizFilter Expr(Action<Expression> e)
            => this.SetOption("e", e.Run(expression));

        /// <summary>
        /// Set the blocksize using the number of bits. 1&lt;&lt;n defines the blocksize, which is the width and height of the processed blocks.<br>
        /// </br>The default value is 3 (8x8) and can be raised to 4 for a blocksize of 16x16.Note that changing this setting has huge consequences on the speed processing. Also, a larger block size does not necessarily means a better de-noising.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public DctdnoizFilter Blocksize(int n)
            => this.SetOptionRange("n", n, 0, int.MaxValue);

    }

    public static class DctdnoizFilterExtensions
    {
        /// <summary>
        /// Denoise frames using 2D DCT (frequency domain filtering).<br>
        /// </br> This filter is not designed for real time.
        /// </summary>
        public static DctdnoizFilter DctdnoizFilter(this ImageMap imageMap)
          => new DctdnoizFilter(imageMap);
    }
}
