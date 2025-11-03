namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. tinterlace        V-&gt;V       Perform temporal field interlacing.
    /// </summary>
    public class TinterlaceFilterGen : ImageToImageFilter
    {
        internal TinterlaceFilterGen(ImageMap input) : base("tinterlace", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  select interlace mode (from 0 to 7) (default merge)
        /// </summary>
        public TinterlaceFilterGen mode(TinterlaceFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  select interlace mode (from 0 to 7) (default merge)
    /// </summary>
    public enum TinterlaceFilterGenMode
    {
        /// <summary>
        /// merge           0            ..FV....... merge fields
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("merge")]
        merge = 0,
        /// <summary>
        /// drop_even       1            ..FV....... drop even fields
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("drop_even")]
        drop_even = 1,
        /// <summary>
        /// drop_odd        2            ..FV....... drop odd fields
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("drop_odd")]
        drop_odd = 2,
        /// <summary>
        /// pad             3            ..FV....... pad alternate lines with black
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("pad")]
        pad = 3,
        /// <summary>
        /// interleave_top  4            ..FV....... interleave top and bottom fields
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("interleave_top")]
        interleave_top = 4,
        /// <summary>
        /// interleave_bottom 5            ..FV....... interleave bottom and top fields
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("interleave_bottom")]
        interleave_bottom = 5,
        /// <summary>
        /// interlacex2     6            ..FV....... interlace fields from two consecutive frames
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("interlacex2")]
        interlacex2 = 6,
        /// <summary>
        /// mergex2         7            ..FV....... merge fields keeping same frame rate
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("mergex2")]
        mergex2 = 7
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Perform temporal field interlacing.
        /// </summary>
        public static TinterlaceFilterGen TinterlaceFilterGen(this ImageMap input0) => new TinterlaceFilterGen(input0);
    }
}