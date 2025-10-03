namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... tonemap_vaapi     V-&gt;V       VAAPI VPP for tone-mapping
    /// </summary>
    public class Tonemap_vaapiFilterGen : ImageToImageFilter
    {
        internal Tonemap_vaapiFilterGen(ImageMap input) : base("tonemap_vaapi", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Output pixel format set
        /// </summary>
        public Tonemap_vaapiFilterGen format(String format) => this.SetOption("format", format.ToString());
        /// <summary>
        ///  Output color matrix coefficient set
        /// </summary>
        public Tonemap_vaapiFilterGen matrix(String matrix) => this.SetOption("matrix", matrix.ToString());
        /// <summary>
        ///  Output color primaries set
        /// </summary>
        public Tonemap_vaapiFilterGen primaries(String primaries) => this.SetOption("primaries", primaries.ToString());
        /// <summary>
        ///  Output color transfer characteristics set
        /// </summary>
        public Tonemap_vaapiFilterGen transfer(String transfer) => this.SetOption("transfer", transfer.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// VAAPI VPP for tone-mapping
        /// </summary>
        public static Tonemap_vaapiFilterGen Tonemap_vaapiFilterGen(this ImageMap input0) => new Tonemap_vaapiFilterGen(input0);
    }
}