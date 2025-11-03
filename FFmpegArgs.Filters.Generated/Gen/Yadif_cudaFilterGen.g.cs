namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. yadif_cuda        V-&gt;V       Deinterlace CUDA frames
    /// </summary>
    public class Yadif_cudaFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal Yadif_cudaFilterGen(ImageMap input) : base("yadif_cuda", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  specify the interlacing mode (from 0 to 3) (default send_frame)
        /// </summary>
        public Yadif_cudaFilterGen mode(Yadif_cudaFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  specify the assumed picture field parity (from -1 to 1) (default auto)
        /// </summary>
        public Yadif_cudaFilterGen parity(Yadif_cudaFilterGenParity parity) => this.SetOption("parity", parity.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  specify which frames to deinterlace (from 0 to 1) (default all)
        /// </summary>
        public Yadif_cudaFilterGen deint(Yadif_cudaFilterGenDeint deint) => this.SetOption("deint", deint.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  specify the interlacing mode (from 0 to 3) (default send_frame)
    /// </summary>
    public enum Yadif_cudaFilterGenMode
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
    public enum Yadif_cudaFilterGenParity
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
    public enum Yadif_cudaFilterGenDeint
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
        /// Deinterlace CUDA frames
        /// </summary>
        public static Yadif_cudaFilterGen Yadif_cudaFilterGen(this ImageMap input0) => new Yadif_cudaFilterGen(input0);
    }
}