namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. scale_qsv         V-&gt;V       Quick Sync Video &quot;scaling and format conversion&quot;
    /// </summary>
    public class Scale_qsvFilterGen : ImageToImageFilter
    {
        internal Scale_qsvFilterGen(ImageMap input) : base("scale_qsv", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Output video width(0=input video width, -1=keep input video aspect) (default &quot;iw&quot;)
        /// </summary>
        public Scale_qsvFilterGen w(String w) => this.SetOption("w", w.ToStringInv());
        /// <summary>
        ///  Output video height(0=input video height, -1=keep input video aspect) (default &quot;ih&quot;)
        /// </summary>
        public Scale_qsvFilterGen h(String h) => this.SetOption("h", h.ToStringInv());
        /// <summary>
        ///  Output pixel format (default &quot;same&quot;)
        /// </summary>
        public Scale_qsvFilterGen format(String format) => this.SetOption("format", format.ToStringInv());
        /// <summary>
        ///  scaling &amp; format conversion mode (mode compute(3), vd(4) and ve(5) are only available on some platforms) (from 0 to 5) (default 0)
        /// </summary>
        public Scale_qsvFilterGen mode(Scale_qsvFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  scaling &amp; format conversion mode (mode compute(3), vd(4) and ve(5) are only available on some platforms) (from 0 to 5) (default 0)
    /// </summary>
    public enum Scale_qsvFilterGenMode
    {
        /// <summary>
        /// low_power       1            ..FV....... low power mode
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("low_power")]
        low_power = 1,
        /// <summary>
        /// hq              2            ..FV....... high quality mode
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hq")]
        hq = 2,
        /// <summary>
        /// compute         3            ..FV....... compute
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("compute")]
        compute = 3,
        /// <summary>
        /// vd              4            ..FV....... vd
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("vd")]
        vd = 4,
        /// <summary>
        /// ve              5            ..FV....... ve
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("ve")]
        ve = 5
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Quick Sync Video &quot;scaling and format conversion&quot;
        /// </summary>
        public static Scale_qsvFilterGen Scale_qsvFilterGen(this ImageMap input0) => new Scale_qsvFilterGen(input0);
    }
}