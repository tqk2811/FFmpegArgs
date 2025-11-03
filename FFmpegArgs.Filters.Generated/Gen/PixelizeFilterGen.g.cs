namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// TS pixelize          V-&gt;V       Pixelize video.
    /// </summary>
    public class PixelizeFilterGen : ImageToImageFilter, ITimelineSupport, ISliceThreading
    {
        internal PixelizeFilterGen(ImageMap input) : base("pixelize", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set block width (from 1 to 1024) (default 16)
        /// </summary>
        public PixelizeFilterGen width(int width) => this.SetOptionRange("width", width, 1, 1024);
        /// <summary>
        ///  set block height (from 1 to 1024) (default 16)
        /// </summary>
        public PixelizeFilterGen height(int height) => this.SetOptionRange("height", height, 1, 1024);
        /// <summary>
        ///  set the pixelize mode (from 0 to 2) (default avg)
        /// </summary>
        public PixelizeFilterGen mode(PixelizeFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  set what planes to filter (default F)
        /// </summary>
        public PixelizeFilterGen planes(String planes) => this.SetOption("planes", planes.ToStringInv());
    }

    /// <summary>
    ///  set the pixelize mode (from 0 to 2) (default avg)
    /// </summary>
    public enum PixelizeFilterGenMode
    {
        /// <summary>
        /// avg             0            ..FV.....T. average
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("avg")]
        avg = 0,
        /// <summary>
        /// min             1            ..FV.....T. minimum
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("min")]
        min = 1,
        /// <summary>
        /// max             2            ..FV.....T. maximum
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("max")]
        max = 2
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Pixelize video.
        /// </summary>
        public static PixelizeFilterGen PixelizeFilterGen(this ImageMap input0) => new PixelizeFilterGen(input0);
    }
}