namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... signature         N-&gt;V       Calculate the MPEG-7 video signature
    /// </summary>
    public class SignatureFilterGen : ImageToImageFilter
    {
        internal SignatureFilterGen(params ImageMap[] inputs) : base("signature", inputs)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the detectmode (from 0 to 2) (default off)
        /// </summary>
        public SignatureFilterGen detectmode(SignatureFilterGenDetectmode detectmode) => this.SetOption("detectmode", detectmode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  number of inputs (from 1 to INT_MAX) (default 1)
        /// </summary>
        public SignatureFilterGen nb_inputs(int nb_inputs) => this.SetOptionRange("nb_inputs", nb_inputs, 1, INT_MAX);
        /// <summary>
        ///  filename for output files (default &quot;&quot;)
        /// </summary>
        public SignatureFilterGen filename(String filename) => this.SetOption("filename", filename.ToString());
        /// <summary>
        ///  set output format (from 0 to 1) (default binary)
        /// </summary>
        public SignatureFilterGen format(SignatureFilterGenFormat format) => this.SetOption("format", format.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  threshold to detect one word as similar (from 1 to INT_MAX) (default 9000)
        /// </summary>
        public SignatureFilterGen th_d(int th_d) => this.SetOptionRange("th_d", th_d, 1, INT_MAX);
        /// <summary>
        ///  threshold to detect all words as similar (from 1 to INT_MAX) (default 60000)
        /// </summary>
        public SignatureFilterGen th_dc(int th_dc) => this.SetOptionRange("th_dc", th_dc, 1, INT_MAX);
        /// <summary>
        ///  threshold to detect frames as similar (from 1 to INT_MAX) (default 116)
        /// </summary>
        public SignatureFilterGen th_xh(int th_xh) => this.SetOptionRange("th_xh", th_xh, 1, INT_MAX);
        /// <summary>
        ///  minimum length of matching sequence in frames (from 0 to INT_MAX) (default 0)
        /// </summary>
        public SignatureFilterGen th_di(int th_di) => this.SetOptionRange("th_di", th_di, 0, INT_MAX);
        /// <summary>
        ///  threshold for relation of good to all frames (from 0 to 1) (default 0.5)
        /// </summary>
        public SignatureFilterGen th_it(double th_it) => this.SetOptionRange("th_it", th_it, 0, 1);
    }

    /// <summary>
    ///  set the detectmode (from 0 to 2) (default off)
    /// </summary>
    public enum SignatureFilterGenDetectmode
    {
        /// <summary>
        /// off             0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("off")]
        off = 0,
        /// <summary>
        /// full            1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("full")]
        full = 1,
        /// <summary>
        /// fast            2            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("fast")]
        fast = 2
    }

    /// <summary>
    ///  set output format (from 0 to 1) (default binary)
    /// </summary>
    public enum SignatureFilterGenFormat
    {
        /// <summary>
        /// binary          0            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("binary")]
        binary = 0,
        /// <summary>
        /// xml             1            ..FV.......
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("xml")]
        xml = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Calculate the MPEG-7 video signature
        /// </summary>
        public static SignatureFilterGen SignatureFilterGen(this ImageMap input) => new SignatureFilterGen(input);
    }
}