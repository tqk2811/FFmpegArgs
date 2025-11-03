namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS estdif            V-&gt;V       Apply Edge Slope Tracing deinterlace.
    /// </summary>
    public class EstdifFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal EstdifFilterGen(ImageMap input) : base("estdif", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  specify the mode (from 0 to 1) (default field)
        /// </summary>
        public EstdifFilterGen mode(EstdifFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  specify the assumed picture field parity (from -1 to 1) (default auto)
        /// </summary>
        public EstdifFilterGen parity(EstdifFilterGenParity parity) => this.SetOption("parity", parity.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  specify which frames to deinterlace (from 0 to 1) (default all)
        /// </summary>
        public EstdifFilterGen deint(EstdifFilterGenDeint deint) => this.SetOption("deint", deint.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  specify the search radius for edge slope tracing (from 1 to 15) (default 1)
        /// </summary>
        public EstdifFilterGen rslope(int rslope) => this.SetOptionRange("rslope", rslope, 1, 15);
        /// <summary>
        ///  specify the search radius for best edge matching (from 0 to 15) (default 2)
        /// </summary>
        public EstdifFilterGen redge(int redge) => this.SetOptionRange("redge", redge, 0, 15);
        /// <summary>
        ///  specify the edge cost for edge matching (from 0 to 50) (default 2)
        /// </summary>
        public EstdifFilterGen ecost(int ecost) => this.SetOptionRange("ecost", ecost, 0, 50);
        /// <summary>
        ///  specify the middle cost for edge matching (from 0 to 50) (default 1)
        /// </summary>
        public EstdifFilterGen mcost(int mcost) => this.SetOptionRange("mcost", mcost, 0, 50);
        /// <summary>
        ///  specify the distance cost for edge matching (from 0 to 50) (default 1)
        /// </summary>
        public EstdifFilterGen dcost(int dcost) => this.SetOptionRange("dcost", dcost, 0, 50);
        /// <summary>
        ///  specify the type of interpolation (from 0 to 2) (default 4p)
        /// </summary>
        public EstdifFilterGen interp(EstdifFilterGenInterp interp) => this.SetOption("interp", interp.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  specify the mode (from 0 to 1) (default field)
    /// </summary>
    public enum EstdifFilterGenMode
    {
        /// <summary>
        /// frame           0            ..FV.....T. send one frame for each frame
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("frame")]
        frame = 0,
        /// <summary>
        /// field           1            ..FV.....T. send one frame for each field
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("field")]
        field = 1
    }

    /// <summary>
    ///  specify the assumed picture field parity (from -1 to 1) (default auto)
    /// </summary>
    public enum EstdifFilterGenParity
    {
        /// <summary>
        /// tff             0            ..FV.....T. assume top field first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tff")]
        tff = 0,
        /// <summary>
        /// bff             1            ..FV.....T. assume bottom field first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bff")]
        bff = 1,
        /// <summary>
        /// auto            -1           ..FV.....T. auto detect parity
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1
    }

    /// <summary>
    ///  specify which frames to deinterlace (from 0 to 1) (default all)
    /// </summary>
    public enum EstdifFilterGenDeint
    {
        /// <summary>
        /// all             0            ..FV.....T. deinterlace all frames
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("all")]
        all = 0,
        /// <summary>
        /// interlaced      1            ..FV.....T. only deinterlace frames marked as interlaced
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("interlaced")]
        interlaced = 1
    }

    /// <summary>
    ///  specify the type of interpolation (from 0 to 2) (default 4p)
    /// </summary>
    public enum EstdifFilterGenInterp
    {
        /// <summary>
        /// 2p              0            ..FV.....T. two-point interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("2p")]
        _2p = 0,
        /// <summary>
        /// 4p              1            ..FV.....T. four-point interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("4p")]
        _4p = 1,
        /// <summary>
        /// 6p              2            ..FV.....T. six-point interpolation
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("6p")]
        _6p = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply Edge Slope Tracing deinterlace.
        /// </summary>
        public static EstdifFilterGen EstdifFilterGen(this ImageMap input0) => new EstdifFilterGen(input0);
    }
}