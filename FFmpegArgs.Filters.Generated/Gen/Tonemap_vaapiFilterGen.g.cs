namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. tonemap_vaapi     V-&gt;V       VAAPI VPP for tone-mapping
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
        public Tonemap_vaapiFilterGen format(String format) => this.SetOption("format", format.ToStringInv());
        /// <summary>
        ///  Output color matrix coefficient set
        /// </summary>
        public Tonemap_vaapiFilterGen matrix(String matrix) => this.SetOption("matrix", matrix.ToStringInv());
        /// <summary>
        ///  Output color primaries set
        /// </summary>
        public Tonemap_vaapiFilterGen primaries(String primaries) => this.SetOption("primaries", primaries.ToStringInv());
        /// <summary>
        ///  Output color transfer characteristics set
        /// </summary>
        public Tonemap_vaapiFilterGen transfer(String transfer) => this.SetOption("transfer", transfer.ToStringInv());
        /// <summary>
        ///  set mastering display colour volume
        /// </summary>
        public Tonemap_vaapiFilterGen display(String display) => this.SetOption("display", display.ToStringInv());
        /// <summary>
        ///  set content light level information
        /// </summary>
        public Tonemap_vaapiFilterGen light(String light) => this.SetOption("light", light.ToStringInv());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// VAAPI VPP for tone-mapping
        /// </summary>
        public static Tonemap_vaapiFilterGen Tonemap_vaapiFilterGen(this ImageMap input0) => new Tonemap_vaapiFilterGen(input0);
    }
}