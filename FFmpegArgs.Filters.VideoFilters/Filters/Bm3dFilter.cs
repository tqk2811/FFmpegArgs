namespace FFmpegArgs.Filters.VideoFilters
{
    /// <summary>
    /// TS. bm3d              N->V       Block-Matching 3D denoiser.<br></br>
    /// https://ffmpeg.org/ffmpeg-filters.html#bm3d
    /// </summary>
    public class Bm3dFilter : ImageToImageFilter
    {
        internal Bm3dFilter(ImageMap imageMap) : base("bm3d", imageMap)
        {
            AddMapOut();
        }
        /// <summary>
        /// Set denoising strength. Default value is 1. Allowed range is from 0 to 999.9.<br>
        /// </br> The denoising algorithm is very sensitive to sigma, so adjust it according to the source.
        /// </summary>
        /// <param name="sigma"></param>
        /// <returns></returns>
        public Bm3dFilter Sigma(float sigma)
          => this.SetOptionRange("sigma", sigma, 0, 999.9f);
        /// <summary>
        /// Set local patch size. This sets dimensions in 2D.<br>
        /// </br>..FV....... set log2(size) of local patch (from 4 to 6) (default 4)
        /// </summary>
        /// <param name="block"></param>
        /// <returns></returns>
        public Bm3dFilter Block(int block)
          => this.SetOptionRange("block", block, 4, 6);
        /// <summary>
        /// Set sliding step for processing blocks. Default value is 4. Allowed range is from 1 to 64.<br>
        /// </br> Smaller values allows processing more reference blocks and is slower.
        /// </summary>
        /// <param name="bstep"></param>
        /// <returns></returns>
        public Bm3dFilter Bstep(int bstep)
          => this.SetOptionRange("bstep", bstep, 1, 64);
        /// <summary>
        /// Set maximal number of similar blocks for 3rd dimension. Default value is 1. When set to 1, no block matching is done.<br>
        /// </br> Larger values allows more blocks in single group. Allowed range is from 1 to 256.
        /// </summary>
        /// <param name="group"></param>
        /// <returns></returns>
        public Bm3dFilter Group(int group)
          => this.SetOptionRange("group", group, 1, 256);
        /// <summary>
        /// Set radius for search block matching. Default is 9. Allowed range is from 1 to INT32_MAX.
        /// </summary>
        /// <param name="range"></param>
        /// <returns></returns>
        public Bm3dFilter Range(int range)
          => this.SetOptionRange("range", range, 1, int.MaxValue);
        /// <summary>
        /// Set step between two search locations for block matching. Default is 1. Allowed range is from 1 to 64. Smaller is slower.
        /// </summary>
        /// <param name="mstep"></param>
        /// <returns></returns>
        public Bm3dFilter Mstep(int mstep)
          => this.SetOptionRange("mstep", mstep, 1, 64);
        /// <summary>
        /// Set threshold of mean square error for block matching. Valid range is 0 to INT32_MAX.
        /// </summary>
        /// <param name="thmse"></param>
        /// <returns></returns>
        public Bm3dFilter Thmse(float thmse)
          => this.SetOptionRange("thmse", thmse, 0, int.MaxValue);
        /// <summary>
        /// Set thresholding parameter for hard thresholding in 3D transformed domain.<br>
        /// </br> Larger values results in stronger hard-thresholding filtering in frequency domain.
        /// </summary>
        /// <param name="hdthr"></param>
        /// <returns></returns>
        public Bm3dFilter HdThr(float hdthr)
          => this.SetOptionRange("hdthr", hdthr, 0, int.MaxValue);
        /// <summary>
        /// Set filtering estimation mode. Can be basic or final. Default is basic.
        /// </summary>
        /// <param name="estim"></param>
        /// <returns></returns>
        public Bm3dFilter Estim(Bm3dEstim estim)
          => this.SetOption("estim", estim);
        /// <summary>
        /// If enabled, filter will use 2nd stream for block matching.<br>
        /// </br> Default is disabled for basic value of estim option, and always enabled if value of estim is final.
        /// </summary>
        /// <param name="flag"></param>
        /// <returns></returns>
        public Bm3dFilter Ref(bool flag)
          => this.SetOption("ref", flag.ToFFmpegFlag());
        /// <summary>
        /// Set planes to filter. Default is all available except alpha.<br>
        /// </br>..FV....... set planes to filter (from 0 to 15) (default 7)
        /// </summary>
        /// <param name="planes"></param>
        /// <returns></returns>
        public Bm3dFilter Planes(int planes)
          => this.SetOptionRange("planes", planes, 0, int.MaxValue);
    }
    public static class Bm3dFilterExtensions
    {
        /// <summary>
        /// Denoise frames using Block-Matching 3D algorithm.
        /// </summary>
        public static Bm3dFilter Bm3dFilter(this ImageMap imageMap)
          => new Bm3dFilter(imageMap);
    }
    public enum Bm3dEstim
    {
        basic,
        final
    }
}
