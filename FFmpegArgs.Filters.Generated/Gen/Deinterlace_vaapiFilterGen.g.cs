namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. deinterlace_vaapi V-&gt;V       Deinterlacing of VAAPI surfaces
    /// </summary>
    public class Deinterlace_vaapiFilterGen : ImageToImageFilter
    {
        internal Deinterlace_vaapiFilterGen(ImageMap input) : base("deinterlace_vaapi", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Deinterlacing mode (from 0 to 4) (default default)
        /// </summary>
        public Deinterlace_vaapiFilterGen mode(Deinterlace_vaapiFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Generate output at frame rate or field rate (from 1 to 2) (default frame)
        /// </summary>
        public Deinterlace_vaapiFilterGen rate(Deinterlace_vaapiFilterGenRate rate) => this.SetOption("rate", rate.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  Only deinterlace fields, passing frames through unchanged (from 0 to 1) (default 0)
        /// </summary>
        public Deinterlace_vaapiFilterGen auto(int auto) => this.SetOptionRange("auto", auto, 0, 1);
    }

    /// <summary>
    ///  Deinterlacing mode (from 0 to 4) (default default)
    /// </summary>
    public enum Deinterlace_vaapiFilterGenMode
    {
        /// <summary>
        /// default         0            ..FV....... Use the highest-numbered (and therefore possibly most advanced) deinterlacing algorithm
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("default")]
        _default = 0,
        /// <summary>
        /// bob             1            ..FV....... Use the bob deinterlacing algorithm
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bob")]
        bob = 1,
        /// <summary>
        /// weave           2            ..FV....... Use the weave deinterlacing algorithm
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("weave")]
        weave = 2,
        /// <summary>
        /// motion_adaptive 3            ..FV....... Use the motion adaptive deinterlacing algorithm
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("motion_adaptive")]
        motion_adaptive = 3,
        /// <summary>
        /// motion_compensated 4            ..FV....... Use the motion compensated deinterlacing algorithm
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("motion_compensated")]
        motion_compensated = 4
    }

    /// <summary>
    ///  Generate output at frame rate or field rate (from 1 to 2) (default frame)
    /// </summary>
    public enum Deinterlace_vaapiFilterGenRate
    {
        /// <summary>
        /// frame           1            ..FV....... Output at frame rate (one frame of output for each field-pair)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("frame")]
        frame = 1,
        /// <summary>
        /// field           2            ..FV....... Output at field rate (one frame of output for each field)
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("field")]
        field = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Deinterlacing of VAAPI surfaces
        /// </summary>
        public static Deinterlace_vaapiFilterGen Deinterlace_vaapiFilterGen(this ImageMap input0) => new Deinterlace_vaapiFilterGen(input0);
    }
}