namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TSC fftdnoiz          V-&gt;V       Denoise frames using 3D FFT.
    /// </summary>
    public class FftdnoizFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal FftdnoizFilterGen(ImageMap input) : base("fftdnoiz", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set denoise strength (from 0 to 100) (default 1)
        /// </summary>
        public FftdnoizFilterGen sigma(float sigma) => this.SetOptionRange("sigma", sigma, 0, 100);
        /// <summary>
        ///  set amount of denoising (from 0.01 to 1) (default 1)
        /// </summary>
        public FftdnoizFilterGen amount(float amount) => this.SetOptionRange("amount", amount, 0.01, 1);
        /// <summary>
        ///  set block size (from 8 to 256) (default 32)
        /// </summary>
        public FftdnoizFilterGen block(int block) => this.SetOptionRange("block", block, 8, 256);
        /// <summary>
        ///  set block overlap (from 0.2 to 0.8) (default 0.5)
        /// </summary>
        public FftdnoizFilterGen overlap(float overlap) => this.SetOptionRange("overlap", overlap, 0.2, 0.8);
        /// <summary>
        ///  set method of denoising (from 0 to 1) (default wiener)
        /// </summary>
        public FftdnoizFilterGen method(FftdnoizFilterGenMethod method) => this.SetOption("method", method.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set number of previous frames for temporal denoising (from 0 to 1) (default 0)
        /// </summary>
        public FftdnoizFilterGen prev(int prev) => this.SetOptionRange("prev", prev, 0, 1);
        /// <summary>
        ///  set number of next frames for temporal denoising (from 0 to 1) (default 0)
        /// </summary>
        public FftdnoizFilterGen next(int next) => this.SetOptionRange("next", next, 0, 1);
        /// <summary>
        ///  set planes to filter (from 0 to 15) (default 7)
        /// </summary>
        public FftdnoizFilterGen planes(int planes) => this.SetOptionRange("planes", planes, 0, 15);
        /// <summary>
        ///  set window function (from 0 to 20) (default hann)
        /// </summary>
        public FftdnoizFilterGen window(FftdnoizFilterGenWindow window) => this.SetOption("window", window.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set method of denoising (from 0 to 1) (default wiener)
    /// </summary>
    public enum FftdnoizFilterGenMethod
    {
        /// <summary>
        /// wiener          0            ..FV.....T. wiener method
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("wiener")]
        wiener = 0,
        /// <summary>
        /// hard            1            ..FV.....T. hard thresholding
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hard")]
        hard = 1
    }

    /// <summary>
    ///  set window function (from 0 to 20) (default hann)
    /// </summary>
    public enum FftdnoizFilterGenWindow
    {
        /// <summary>
        /// rect            0            ..FV....... Rectangular
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("rect")]
        rect = 0,
        /// <summary>
        /// bartlett        4            ..FV....... Bartlett
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bartlett")]
        bartlett = 4,
        /// <summary>
        /// hann            1            ..FV....... Hann
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hann")]
        hann = 1,
        /// <summary>
        /// hanning         1            ..FV....... Hanning
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hanning")]
        hanning = 1,
        /// <summary>
        /// hamming         2            ..FV....... Hamming
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hamming")]
        hamming = 2,
        /// <summary>
        /// blackman        3            ..FV....... Blackman
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blackman")]
        blackman = 3,
        /// <summary>
        /// welch           5            ..FV....... Welch
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("welch")]
        welch = 5,
        /// <summary>
        /// flattop         6            ..FV....... Flat-top
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("flattop")]
        flattop = 6,
        /// <summary>
        /// bharris         7            ..FV....... Blackman-Harris
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bharris")]
        bharris = 7,
        /// <summary>
        /// bnuttall        8            ..FV....... Blackman-Nuttall
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bnuttall")]
        bnuttall = 8,
        /// <summary>
        /// bhann           11           ..FV....... Bartlett-Hann
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bhann")]
        bhann = 11,
        /// <summary>
        /// sine            9            ..FV....... Sine
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sine")]
        sine = 9,
        /// <summary>
        /// nuttall         10           ..FV....... Nuttall
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("nuttall")]
        nuttall = 10,
        /// <summary>
        /// lanczos         12           ..FV....... Lanczos
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("lanczos")]
        lanczos = 12,
        /// <summary>
        /// gauss           13           ..FV....... Gauss
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("gauss")]
        gauss = 13,
        /// <summary>
        /// tukey           14           ..FV....... Tukey
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tukey")]
        tukey = 14,
        /// <summary>
        /// dolph           15           ..FV....... Dolph-Chebyshev
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("dolph")]
        dolph = 15,
        /// <summary>
        /// cauchy          16           ..FV....... Cauchy
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cauchy")]
        cauchy = 16,
        /// <summary>
        /// parzen          17           ..FV....... Parzen
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("parzen")]
        parzen = 17,
        /// <summary>
        /// poisson         18           ..FV....... Poisson
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("poisson")]
        poisson = 18,
        /// <summary>
        /// bohman          19           ..FV....... Bohman
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bohman")]
        bohman = 19,
        /// <summary>
        /// kaiser          20           ..FV....... Kaiser
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("kaiser")]
        kaiser = 20
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Denoise frames using 3D FFT.
        /// </summary>
        public static FftdnoizFilterGen FftdnoizFilterGen(this ImageMap input0) => new FftdnoizFilterGen(input0);
    }
}