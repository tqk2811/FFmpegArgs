namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. scale_d3d11       V-&gt;V       Scale video using Direct3D11
    /// </summary>
    public class Scale_d3d11FilterGen : ImageToImageFilter
    {
        internal Scale_d3d11FilterGen(ImageMap input) : base("scale_d3d11", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  Output video width (default &quot;iw&quot;)
        /// </summary>
        public Scale_d3d11FilterGen width(String width) => this.SetOption("width", width.ToString());
        /// <summary>
        ///  Output video height (default &quot;ih&quot;)
        /// </summary>
        public Scale_d3d11FilterGen height(String height) => this.SetOption("height", height.ToString());
        /// <summary>
        ///  Output video pixel format (default none)
        /// </summary>
        public Scale_d3d11FilterGen format(PixFmt format) => this.SetOption("format", format.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Scale video using Direct3D11
        /// </summary>
        public static Scale_d3d11FilterGen Scale_d3d11FilterGen(this ImageMap input0) => new Scale_d3d11FilterGen(input0);
    }
}