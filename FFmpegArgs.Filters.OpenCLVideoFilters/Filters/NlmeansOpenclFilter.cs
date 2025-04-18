/*
nlmeans_opencl AVOptions:
   s                 <double>     ..FV....... denoising strength (from 1 to 30) (default 1)
   p                 <int>        ..FV....... patch size (from 0 to 99) (default 7)
   pc                <int>        ..FV....... patch size for chroma planes (from 0 to 99) (default 0)
   r                 <int>        ..FV....... research window (from 0 to 99) (default 15)
   rc                <int>        ..FV....... research window for chroma planes (from 0 to 99) (default 0)
*/
namespace FFmpegArgs.Filters.OpenCLVideoFilters
{
    /// <summary>
    /// ... nlmeans_opencl    V->V       Non-local means denoiser through OpenCL<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#nlmeans_005fopencl
    /// </summary>
    public class NlmeansOpenclFilter : ImageToImageFilter
    {
        internal NlmeansOpenclFilter(ImageMap imageMap) : base("nlmeans_opencl", imageMap)
        {
            AddMapOut();
        }

        /// <summary>
        /// Set denoising strength.<br>
        /// </br>(from 1 to 30) (default 1)
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public NlmeansOpenclFilter S(double s)
            => this.SetOptionRange("s", s, 1, 30);
        /// <summary>
        /// Set patch size.<br>
        /// </br>(from 0 to 99) (default 7)
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public NlmeansOpenclFilter P(int p)
            => this.SetOptionRange("p", p, 0, 99);
        /// <summary>
        /// Same as p but for chroma planes.<br>
        /// </br>The default value is 0 and means automatic.<br>
        /// </br>(from 0 to 99) (default 0)
        /// </summary>
        /// <param name="pc"></param>
        /// <returns></returns>
        public NlmeansOpenclFilter Pc(int pc)
            => this.SetOptionRange("pc", pc, 0, 99);
        /// <summary>
        /// Set research size.<br>
        /// </br>(from 0 to 99) (default 15)
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public NlmeansOpenclFilter R(int r)
            => this.SetOptionRange("r", r, 0, 99);
        /// <summary>
        /// Same as r but for chroma planes.<br>
        /// </br>The default value is 0 and means automatic.<br>
        /// </br>(from 0 to 99) (default 0)
        /// </summary>
        /// <param name="rc"></param>
        /// <returns></returns>
        public NlmeansOpenclFilter Rc(int rc)
            => this.SetOptionRange("rc", rc, 0, 99);

    }
    /// <summary>
    /// 
    /// </summary>
    public static class NlmeansOpenclFilterExtensions
    {
        /// <summary>
        /// Denoise frames using Non-Local Means algorithm.<br>
        /// </br>Each pixel is adjusted by looking for other pixels with similar contexts.This context similarity is defined by comparing their surrounding patches of size pxp.Patches are searched in an area of rxr around the pixel.<br>
        /// </br>Note that the research area defines centers for patches, which means some patches will be made of pixels outside that research area.
        /// </summary>
        public static NlmeansOpenclFilter NlmeansOpenclFilter(this ImageMap imageMap)
          => new NlmeansOpenclFilter(imageMap);
    }
}
