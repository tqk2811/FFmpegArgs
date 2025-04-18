/*
unsharp_opencl AVOptions:
   luma_msize_x      <float>      ..FV....... Set luma mask horizontal diameter (pixels) (from 1 to 23) (default 5)
   lx                <float>      ..FV....... Set luma mask horizontal diameter (pixels) (from 1 to 23) (default 5)
   luma_msize_y      <float>      ..FV....... Set luma mask vertical diameter (pixels) (from 1 to 23) (default 5)
   ly                <float>      ..FV....... Set luma mask vertical diameter (pixels) (from 1 to 23) (default 5)
   luma_amount       <float>      ..FV....... Set luma amount (multiplier) (from -10 to 10) (default 1)
   la                <float>      ..FV....... Set luma amount (multiplier) (from -10 to 10) (default 1)
   chroma_msize_x    <float>      ..FV....... Set chroma mask horizontal diameter (pixels after subsampling) (from 1 to 23) (default 5)
   cx                <float>      ..FV....... Set chroma mask horizontal diameter (pixels after subsampling) (from 1 to 23) (default 5)
   chroma_msize_y    <float>      ..FV....... Set chroma mask vertical diameter (pixels after subsampling) (from 1 to 23) (default 5)
   cy                <float>      ..FV....... Set chroma mask vertical diameter (pixels after subsampling) (from 1 to 23) (default 5)
   chroma_amount     <float>      ..FV....... Set chroma amount (multiplier) (from -10 to 10) (default 0)
   ca                <float>      ..FV....... Set chroma amount (multiplier) (from -10 to 10) (default 0)
*/
namespace FFmpegArgs.Filters.OpenCLVideoFilters
{
    /// <summary>
    /// ... unsharp_opencl    V->V       Apply unsharp mask to input video<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#unsharp_005fopencl
    /// </summary>
    public class UnsharpOpenclFilter : ImageToImageFilter
    {
        internal UnsharpOpenclFilter(ImageMap imageMap) : base("unsharp_opencl", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set the luma matrix horizontal size. (pixels) (from 1 to 23) (default 5)
        /// </summary>
        /// <param name="lumaMsizeX"></param>
        /// <returns></returns>
        public UnsharpOpenclFilter LumaMsizeX(float lumaMsizeX)
            => this.SetOptionRange("lx", lumaMsizeX, 1, 23);
        /// <summary>
        /// Set the luma matrix vertical size. (pixels) (from 1 to 23) (default 5)
        /// </summary>
        /// <param name="lumaMsizeY"></param>
        /// <returns></returns>
        public UnsharpOpenclFilter LumaMsizeY(float lumaMsizeY)
            => this.SetOptionRange("ly", lumaMsizeY, 1, 23);
        /// <summary>
        /// Set the luma effect strength.<br>
        /// </br>Negative values will blur the input video, while positive values will sharpen it, a value of zero will disable the effect.<br>
        /// </br> (multiplier) (from -10 to 10) (default 1)
        /// </summary>
        /// <param name="lumaAmount"></param>
        /// <returns></returns>
        public UnsharpOpenclFilter LumaAmount(float lumaAmount)
            => this.SetOptionRange("la", lumaAmount, -10, 10);
        /// <summary>
        /// Set the chroma matrix horizontal size. (pixels after subsampling) (from 1 to 23) (default 5)
        /// </summary>
        /// <param name="chromaMsizeX"></param>
        /// <returns></returns>
        public UnsharpOpenclFilter ChromaMsizeX(float chromaMsizeX)
            => this.SetOptionRange("cx", chromaMsizeX, 1, 23);
        /// <summary>
        /// Set the chroma matrix vertical size. (pixels after subsampling) (from 1 to 23) (default 5)
        /// </summary>
        /// <param name="chromaMsizeY"></param>
        /// <returns></returns>
        public UnsharpOpenclFilter ChromaMsizeY(float chromaMsizeY)
            => this.SetOptionRange("cy", chromaMsizeY, 1, 23);
        /// <summary>
        /// Set the chroma effect strength.<br>
        /// </br>Negative values will blur the input video, while positive values will sharpen it, a value of zero will disable the effect.<br>
        /// </br> (multiplier) (from -10 to 10) (default 0)
        /// </summary>
        /// <param name="chromaAmount"></param>
        /// <returns></returns>
        public UnsharpOpenclFilter ChromaAmount(float chromaAmount)
            => this.SetOptionRange("ca", chromaAmount, -10, 10);
        

    }
    /// <summary>
    /// 
    /// </summary>
    public static class UnsharpOpenclFilterExtensions
    {
        /// <summary>
        /// Sharpen or blur the input video.
        /// </summary>
        public static UnsharpOpenclFilter UnsharpOpenclFilter(this ImageMap imageMap)
          => new UnsharpOpenclFilter(imageMap);
    }
}
