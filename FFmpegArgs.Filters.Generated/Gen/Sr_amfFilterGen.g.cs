namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. sr_amf            V-&gt;V       AMF HQ video upscaling
    /// </summary>
    public class Sr_amfFilterGen : ImageToImageFilter
    {
        internal Sr_amfFilterGen(ImageMap input) : base("sr_amf", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Output video width (default &quot;iw&quot;)
        /// </summary>
        public Sr_amfFilterGen w(String w) => this.SetOption("w", w.ToString());
        /// <summary>
        ///  Output video height (default &quot;ih&quot;)
        /// </summary>
        public Sr_amfFilterGen h(String h) => this.SetOption("h", h.ToString());
        /// <summary>
        ///  Output pixel format (default &quot;same&quot;)
        /// </summary>
        public Sr_amfFilterGen format(String format) => this.SetOption("format", format.ToString());
        /// <summary>
        ///  Sharpness (from -1 to 2) (default -1)
        /// </summary>
        public Sr_amfFilterGen sharpness(float sharpness) => this.SetOptionRange("sharpness", sharpness, -1, 2);
        /// <summary>
        ///  Keep aspect ratio (default false)
        /// </summary>
        public Sr_amfFilterGen keep_ratio(bool keep_ratio) => this.SetOption("keep-ratio", keep_ratio.ToFFmpegFlag());
        /// <summary>
        ///  Fill (default false)
        /// </summary>
        public Sr_amfFilterGen fill(bool fill) => this.SetOption("fill", fill.ToFFmpegFlag());
        /// <summary>
        ///  Scaling algorithm (from -1 to 4) (default -1)
        /// </summary>
        public Sr_amfFilterGen algorithm(Sr_amfFilterGenAlgorithm algorithm) => this.SetOption("algorithm", algorithm.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  Scaling algorithm (from -1 to 4) (default -1)
    /// </summary>
    public enum Sr_amfFilterGenAlgorithm
    {
        /// <summary>
        /// bilinear        0            ..FV....... Bilinear
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bilinear")]
        bilinear = 0,
        /// <summary>
        /// bicubic         1            ..FV....... Bicubic
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("bicubic")]
        bicubic = 1,
        /// <summary>
        /// sr1-0           2            ..FV....... Video SR1.0
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sr1-0")]
        sr1_0 = 2,
        /// <summary>
        /// point           3            ..FV....... Point
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("point")]
        point = 3,
        /// <summary>
        /// sr1-1           4            ..FV....... Video SR1.1
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("sr1-1")]
        sr1_1 = 4
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// AMF HQ video upscaling
        /// </summary>
        public static Sr_amfFilterGen Sr_amfFilterGen(this ImageMap input0) => new Sr_amfFilterGen(input0);
    }
}