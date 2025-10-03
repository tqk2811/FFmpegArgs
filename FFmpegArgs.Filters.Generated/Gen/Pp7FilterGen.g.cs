namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T.. pp7               V-&gt;V       Apply Postprocessing 7 filter.
    /// </summary>
    public class Pp7FilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal Pp7FilterGen(ImageMap input) : base("pp7", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  force a constant quantizer parameter (from 0 to 64) (default 0)
        /// </summary>
        public Pp7FilterGen qp(int qp) => this.SetOptionRange("qp", qp, 0, 64);
        /// <summary>
        ///  set thresholding mode (from 0 to 2) (default medium)
        /// </summary>
        public Pp7FilterGen mode(Pp7FilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set thresholding mode (from 0 to 2) (default medium)
    /// </summary>
    public enum Pp7FilterGenMode
    {
        /// <summary>
        /// hard            0            ..FV....... hard thresholding
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("hard")]
        hard = 0,
        /// <summary>
        /// soft            1            ..FV....... soft thresholding
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("soft")]
        soft = 1,
        /// <summary>
        /// medium          2            ..FV....... medium thresholding
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("medium")]
        medium = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Apply Postprocessing 7 filter.
        /// </summary>
        public static Pp7FilterGen Pp7FilterGen(this ImageMap input0) => new Pp7FilterGen(input0);
    }
}