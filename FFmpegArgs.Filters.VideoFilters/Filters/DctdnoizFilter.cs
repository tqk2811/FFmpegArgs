/*
 dctdnoiz AVOptions:
   sigma             <float>      ..FV....... set noise sigma constant (from 0 to 999) (default 0)
   s                 <float>      ..FV....... set noise sigma constant (from 0 to 999) (default 0)
   overlap           <int>        ..FV....... set number of block overlapping pixels (from -1 to 15) (default -1)
   expr              <string>     ..FV....... set coefficient factor expression
   e                 <string>     ..FV....... set coefficient factor expression
   n                 <int>        ..FV....... set the block size, expressed in bits (from 3 to 4) (default 3)
 */
namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TS. dctdnoiz          V->V       Denoise frames using 2D DCT.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#dctdnoiz
    /// </summary>
    public class DctdnoizFilter : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        readonly FFmpegExpression expression = new FFmpegExpression();
        internal DctdnoizFilter(ImageMap imageMap) : base("dctdnoiz", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the noise sigma constant.<br>
        /// </br>This sigma defines a hard threshold of 3 * sigma; every DCT coefficient(absolute value) below this threshold with be dropped.<br>
        /// </br>If you need a more advanced filtering, see <see cref="Expr"/>.<br>
        /// </br>(from 0 to 999) (default 0)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public DctdnoizFilter Sigma(float s)
            => this.SetOptionRange("s", s, 0, 999);
        /// <summary>
        /// Set number overlapping pixels for each block. Since the filter can be slow, you may want to reduce this value, at the cost of a less effective filter and the risk of various artefacts.<br>
        /// </br>If the overlapping value doesn’t permit processing the whole input width or height, a warning will be displayed and according borders won’t be denoised.<br>
        /// </br>Default value is blocksize-1, which is the best possible setting.
        /// </summary>
        /// <param name="overlap"></param>
        /// <returns></returns>
        public DctdnoizFilter Overlap(int overlap)
            => this.SetOptionRange("overlap", overlap, -1, 15);
        /// <summary>
        /// Set the coefficient factor expression.<br>
        /// </br>For each coefficient of a DCT block, this expression will be evaluated as a multiplier value for the coefficient.<br>
        /// </br>If this is option is set, the sigma option will be ignored.<br>
        /// </br>The absolute value of the coefficient can be accessed through the c variable.
        /// </summary>
        /// <param name="e"></param>
        /// <returns></returns>
        public DctdnoizFilter Expr(ExpressionValue e)
            => this.SetOption("e", expression.Check(e));
        /// <summary>
        /// Set the blocksize using the number of bits. 1&lt;&lt;n defines the blocksize, which is the width and height of the processed blocks.<br>
        /// </br>The default value is 3 (8x8) and can be raised to 4 for a blocksize of 16x16.Note that changing this setting has huge consequences on the speed processing. Also, a larger block size does not necessarily means a better de-noising.<br>
        /// </br>(from 3 to 4) (default 3)
        /// </summary>
        /// <param name="n">(from 3 to 4) (default 3)</param>
        /// <returns></returns>
        public DctdnoizFilter Blocksize(int n)
            => this.SetOptionRange("n", n, 3, 4);
    }
    /// <summary>
    /// 
    /// </summary>
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
