namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS yadif             V-&gt;V       Deinterlace the input image.
    /// </summary>
    public class YadifFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal YadifFilterGen(ImageMap input) : base("yadif", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  specify the interlacing mode (from 0 to 3) (default send_frame)
        /// </summary>
        public YadifFilterGen mode(YadifFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  specify the assumed picture field parity (from -1 to 1) (default auto)
        /// </summary>
        public YadifFilterGen parity(YadifFilterGenParity parity) => this.SetOption("parity", parity.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  specify which frames to deinterlace (from 0 to 1) (default all)
        /// </summary>
        public YadifFilterGen deint(YadifFilterGenDeint deint) => this.SetOption("deint", deint.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  specify the interlacing mode (from 0 to 3) (default send_frame)
    /// </summary>
    public enum YadifFilterGenMode
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
        send_field = 1,
        /// <summary>
        /// send_frame_nospatial 2            ..FV....... send one frame for each frame, but skip spatial interlacing check
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("send_frame_nospatial")]
        send_frame_nospatial = 2,
        /// <summary>
        /// send_field_nospatial 3            ..FV....... send one frame for each field, but skip spatial interlacing check
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("send_field_nospatial")]
        send_field_nospatial = 3
    }

    /// <summary>
    ///  specify the assumed picture field parity (from -1 to 1) (default auto)
    /// </summary>
    public enum YadifFilterGenParity
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
    public enum YadifFilterGenDeint
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
        public static YadifFilterGen YadifFilterGen(this ImageMap input0) => new YadifFilterGen(input0);
    }
}