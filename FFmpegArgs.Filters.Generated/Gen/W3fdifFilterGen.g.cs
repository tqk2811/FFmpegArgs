namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TSC w3fdif            V-&gt;V       Apply Martin Weston three field deinterlace.
    /// </summary>
    public class W3fdifFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading, ICommandSupport
    {
        internal W3fdifFilterGen(ImageMap input) : base("w3fdif", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  specify the filter (from 0 to 1) (default complex)
        /// </summary>
        public W3fdifFilterGen filter(W3fdifFilterGenFilter filter) => this.SetOption("filter", filter.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  specify the interlacing mode (from 0 to 1) (default field)
        /// </summary>
        public W3fdifFilterGen mode(W3fdifFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  specify the assumed picture field parity (from -1 to 1) (default auto)
        /// </summary>
        public W3fdifFilterGen parity(W3fdifFilterGenParity parity) => this.SetOption("parity", parity.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  specify which frames to deinterlace (from 0 to 1) (default all)
        /// </summary>
        public W3fdifFilterGen deint(W3fdifFilterGenDeint deint) => this.SetOption("deint", deint.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  specify the filter (from 0 to 1) (default complex)
    /// </summary>
    public enum W3fdifFilterGenFilter
    {
        /// <summary>
        /// simple          0            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("simple")]
        simple = 0,
        /// <summary>
        /// complex         1            ..FV.....T.
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("complex")]
        complex = 1
    }

    /// <summary>
    ///  specify the interlacing mode (from 0 to 1) (default field)
    /// </summary>
    public enum W3fdifFilterGenMode
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
    public enum W3fdifFilterGenParity
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
    public enum W3fdifFilterGenDeint
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

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply Martin Weston three field deinterlace.
        /// </summary>
        public static W3fdifFilterGen W3fdifFilterGen(this ImageMap input0) => new W3fdifFilterGen(input0);
    }
}