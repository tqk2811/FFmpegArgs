namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS. bwdif             V-&gt;V       Deinterlace the input image.
    /// </summary>
    public class BwdifFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal BwdifFilterGen(ImageMap input) : base("bwdif", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  specify the interlacing mode (from 0 to 1) (default send_field)
        /// </summary>
        public BwdifFilterGen mode(BwdifFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  specify the assumed picture field parity (from -1 to 1) (default auto)
        /// </summary>
        public BwdifFilterGen parity(BwdifFilterGenParity parity) => this.SetOption("parity", parity.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  specify which frames to deinterlace (from 0 to 1) (default all)
        /// </summary>
        public BwdifFilterGen deint(BwdifFilterGenDeint deint) => this.SetOption("deint", deint.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  specify the interlacing mode (from 0 to 1) (default send_field)
    /// </summary>
    public enum BwdifFilterGenMode
    {
        /// <summary>
        /// send_frame      0            ..FV....... send one frame for each frame
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("send_frame")]
        send_frame = 0,
        /// <summary>
        /// send_field      1            ..FV....... send one frame for each field
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("send_field")]
        send_field = 1
    }

    /// <summary>
    ///  specify the assumed picture field parity (from -1 to 1) (default auto)
    /// </summary>
    public enum BwdifFilterGenParity
    {
        /// <summary>
        /// tff             0            ..FV....... assume top field first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("tff")]
        tff = 0,
        /// <summary>
        /// bff             1            ..FV....... assume bottom field first
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bff")]
        bff = 1,
        /// <summary>
        /// auto            -1           ..FV....... auto detect parity
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("auto")]
        auto = -1
    }

    /// <summary>
    ///  specify which frames to deinterlace (from 0 to 1) (default all)
    /// </summary>
    public enum BwdifFilterGenDeint
    {
        /// <summary>
        /// all             0            ..FV....... deinterlace all frames
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("all")]
        all = 0,
        /// <summary>
        /// interlaced      1            ..FV....... only deinterlace frames marked as interlaced
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("interlaced")]
        interlaced = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Deinterlace the input image.
        /// </summary>
        public static BwdifFilterGen BwdifFilterGen(this ImageMap input0) => new BwdifFilterGen(input0);
    }
}