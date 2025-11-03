namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. cover_rect        V-&gt;V       Find and cover a user specified object.
    /// </summary>
    public class Cover_rectFilterGen : ImageToImageFilter
    {
        internal Cover_rectFilterGen(ImageMap input) : base("cover_rect", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  cover bitmap filename
        /// </summary>
        public Cover_rectFilterGen cover(String cover) => this.SetOption("cover", cover.ToStringInv());
        /// <summary>
        ///  set removal mode (from 0 to 1) (default blur)
        /// </summary>
        public Cover_rectFilterGen mode(Cover_rectFilterGenMode mode) => this.SetOption("mode", mode.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set removal mode (from 0 to 1) (default blur)
    /// </summary>
    public enum Cover_rectFilterGenMode
    {
        /// <summary>
        /// cover           0            ..FV....... cover area with bitmap
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cover")]
        cover = 0,
        /// <summary>
        /// blur            1            ..FV....... blur area
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("blur")]
        blur = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Find and cover a user specified object.
        /// </summary>
        public static Cover_rectFilterGen Cover_rectFilterGen(this ImageMap input0) => new Cover_rectFilterGen(input0);
    }
}