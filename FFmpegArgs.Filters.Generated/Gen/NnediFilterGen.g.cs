namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS nnedi             V-&gt;V       Apply neural network edge directed interpolation intra-only deinterlacer.
    /// </summary>
    public class NnediFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal NnediFilterGen(ImageMap input) : base("nnedi", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set weights file (default &quot;nnedi3_weights.bin&quot;)
        /// </summary>
        public NnediFilterGen weights(String weights) => this.SetOption("weights", weights.ToString());
        /// <summary>
        ///  set which frames to deinterlace (from 0 to 1) (default all)
        /// </summary>
        public NnediFilterGen deint(NnediFilterGenDeint deint) => this.SetOption("deint", deint.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set mode of operation (from -2 to 3) (default a)
        /// </summary>
        public NnediFilterGen field(NnediFilterGenField field) => this.SetOption("field", field.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set which planes to process (from 0 to 15) (default 7)
        /// </summary>
        public NnediFilterGen planes(int planes) => this.SetOptionRange("planes", planes, 0, 15);
        /// <summary>
        ///  set size of local neighborhood around each pixel, used by the predictor neural network (from 0 to 6) (default s32x4)
        /// </summary>
        public NnediFilterGen nsize(NnediFilterGenNsize nsize) => this.SetOption("nsize", nsize.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set number of neurons in predictor neural network (from 0 to 4) (default n32)
        /// </summary>
        public NnediFilterGen nns(NnediFilterGenNns nns) => this.SetOption("nns", nns.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set quality (from 1 to 2) (default fast)
        /// </summary>
        public NnediFilterGen qual(NnediFilterGenQual qual) => this.SetOption("qual", qual.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set which set of weights to use in the predictor (from 0 to 1) (default a)
        /// </summary>
        public NnediFilterGen etype(NnediFilterGenEtype etype) => this.SetOption("etype", etype.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set prescreening (from 0 to 4) (default new)
        /// </summary>
        public NnediFilterGen pscrn(NnediFilterGenPscrn pscrn) => this.SetOption("pscrn", pscrn.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set which frames to deinterlace (from 0 to 1) (default all)
    /// </summary>
    public enum NnediFilterGenDeint
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
    ///  set mode of operation (from -2 to 3) (default a)
    /// </summary>
    public enum NnediFilterGenField
    {
        /// <summary>
        /// af              -2           ..FV.....T. use frame flags, both fields
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("af")]
        af = -2,
        /// <summary>
        /// a               -1           ..FV.....T. use frame flags, single field
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("a")]
        a = -1,
        /// <summary>
        /// t               0            ..FV.....T. use top field only
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("t")]
        t = 0,
        /// <summary>
        /// b               1            ..FV.....T. use bottom field only
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("b")]
        b = 1,
        /// <summary>
        /// tf              2            ..FV.....T. use both fields, top first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tf")]
        tf = 2,
        /// <summary>
        /// bf              3            ..FV.....T. use both fields, bottom first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bf")]
        bf = 3
    }

    /// <summary>
    ///  set size of local neighborhood around each pixel, used by the predictor neural network (from 0 to 6) (default s32x4)
    /// </summary>
    public enum NnediFilterGenNsize
    {
        /// <summary>
        /// s8x6            0            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s8x6")]
        s8x6 = 0,
        /// <summary>
        /// s16x6           1            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s16x6")]
        s16x6 = 1,
        /// <summary>
        /// s32x6           2            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s32x6")]
        s32x6 = 2,
        /// <summary>
        /// s48x6           3            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s48x6")]
        s48x6 = 3,
        /// <summary>
        /// s8x4            4            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s8x4")]
        s8x4 = 4,
        /// <summary>
        /// s16x4           5            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s16x4")]
        s16x4 = 5,
        /// <summary>
        /// s32x4           6            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s32x4")]
        s32x4 = 6
    }

    /// <summary>
    ///  set number of neurons in predictor neural network (from 0 to 4) (default n32)
    /// </summary>
    public enum NnediFilterGenNns
    {
        /// <summary>
        /// n16             0            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("n16")]
        n16 = 0,
        /// <summary>
        /// n32             1            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("n32")]
        n32 = 1,
        /// <summary>
        /// n64             2            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("n64")]
        n64 = 2,
        /// <summary>
        /// n128            3            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("n128")]
        n128 = 3,
        /// <summary>
        /// n256            4            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("n256")]
        n256 = 4
    }

    /// <summary>
    ///  set quality (from 1 to 2) (default fast)
    /// </summary>
    public enum NnediFilterGenQual
    {
        /// <summary>
        /// fast            1            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fast")]
        fast = 1,
        /// <summary>
        /// slow            2            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("slow")]
        slow = 2
    }

    /// <summary>
    ///  set which set of weights to use in the predictor (from 0 to 1) (default a)
    /// </summary>
    public enum NnediFilterGenEtype
    {
        /// <summary>
        /// a               0            ..FV.....T. weights trained to minimize absolute error
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("a")]
        a = 0,
        /// <summary>
        /// abs             0            ..FV.....T. weights trained to minimize absolute error
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("abs")]
        abs = 0,
        /// <summary>
        /// s               1            ..FV.....T. weights trained to minimize squared error
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("s")]
        s = 1,
        /// <summary>
        /// mse             1            ..FV.....T. weights trained to minimize squared error
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mse")]
        mse = 1
    }

    /// <summary>
    ///  set prescreening (from 0 to 4) (default new)
    /// </summary>
    public enum NnediFilterGenPscrn
    {
        /// <summary>
        /// none            0            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// original        1            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("original")]
        original = 1,
        /// <summary>
        /// new             2            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("new")]
        _new = 2,
        /// <summary>
        /// new2            3            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("new2")]
        new2 = 3,
        /// <summary>
        /// new3            4            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("new3")]
        new3 = 4
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply neural network edge directed interpolation intra-only deinterlacer.
        /// </summary>
        public static NnediFilterGen NnediFilterGen(this ImageMap input0) => new NnediFilterGen(input0);
    }
}