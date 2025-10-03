namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS. bm3d              N-&gt;V       Block-Matching 3D denoiser.
    /// </summary>
    public class Bm3dFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal Bm3dFilterGen(params ImageMap[] inputs) : base("bm3d", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set denoising strength (from 0 to 99999.9) (default 1)
        /// </summary>
        public Bm3dFilterGen sigma(float sigma) => this.SetOptionRange("sigma", sigma, 0, 99999.9);
        /// <summary>
        ///  set size of local patch (from 8 to 64) (default 16)
        /// </summary>
        public Bm3dFilterGen block(int block) => this.SetOptionRange("block", block, 8, 64);
        /// <summary>
        ///  set sliding step for processing blocks (from 1 to 64) (default 4)
        /// </summary>
        public Bm3dFilterGen bstep(int bstep) => this.SetOptionRange("bstep", bstep, 1, 64);
        /// <summary>
        ///  set maximal number of similar blocks (from 1 to 256) (default 1)
        /// </summary>
        public Bm3dFilterGen group(int group) => this.SetOptionRange("group", group, 1, 256);
        /// <summary>
        ///  set block matching range (from 1 to INT_MAX) (default 9)
        /// </summary>
        public Bm3dFilterGen range(int range) => this.SetOptionRange("range", range, 1, INT_MAX);
        /// <summary>
        ///  set step for block matching (from 1 to 64) (default 1)
        /// </summary>
        public Bm3dFilterGen mstep(int mstep) => this.SetOptionRange("mstep", mstep, 1, 64);
        /// <summary>
        ///  set threshold of mean square error for block matching (from 0 to INT_MAX) (default 0)
        /// </summary>
        public Bm3dFilterGen thmse(float thmse) => this.SetOptionRange("thmse", thmse, 0, INT_MAX);
        /// <summary>
        ///  set hard threshold for 3D transfer domain (from 0 to INT_MAX) (default 2.7)
        /// </summary>
        public Bm3dFilterGen hdthr(float hdthr) => this.SetOptionRange("hdthr", hdthr, 0, INT_MAX);
        /// <summary>
        ///  set filtering estimation mode (from 0 to 1) (default basic)
        /// </summary>
        public Bm3dFilterGen estim(Bm3dFilterGenEstim estim) => this.SetOption("estim", estim.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  have reference stream (default false)
        /// </summary>
        public Bm3dFilterGen _ref(bool _ref) => this.SetOption("ref", _ref.ToFFmpegFlag());
        /// <summary>
        ///  set planes to filter (from 0 to 15) (default 7)
        /// </summary>
        public Bm3dFilterGen planes(int planes) => this.SetOptionRange("planes", planes, 0, 15);
    }

    /// <summary>
    ///  set filtering estimation mode (from 0 to 1) (default basic)
    /// </summary>
    public enum Bm3dFilterGenEstim
    {
        /// <summary>
        /// basic           0            ..FV....... basic estimate
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("basic")]
        basic = 0,
        /// <summary>
        /// final           1            ..FV....... final estimate
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("final")]
        final = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Block-Matching 3D denoiser.
        /// </summary>
        public static Bm3dFilterGen Bm3dFilterGen(this ImageMap input) => new Bm3dFilterGen(input);
    }
}