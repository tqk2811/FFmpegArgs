namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .S transpose         V-&gt;V       Transpose input video.
    /// </summary>
    public class TransposeFilterGen : ImageToImageFilter, ISliceThreading
    {
        internal TransposeFilterGen(ImageMap input) : base("transpose", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set transpose direction (from 0 to 7) (default cclock_flip)
        /// </summary>
        public TransposeFilterGen dir(TransposeFilterGenDir dir) => this.SetOption("dir", dir.GetEnumAttribute<NameAttribute>().Name);
        /// <summary>
        ///  do not apply transposition if the input matches the specified geometry (from 0 to INT_MAX) (default none)
        /// </summary>
        public TransposeFilterGen passthrough(TransposeFilterGenPassthrough passthrough) => this.SetOption("passthrough", passthrough.GetEnumAttribute<NameAttribute>().Name);
    }

    /// <summary>
    ///  set transpose direction (from 0 to 7) (default cclock_flip)
    /// </summary>
    public enum TransposeFilterGenDir
    {
        /// <summary>
        /// cclock_flip     0            ..FV....... rotate counter-clockwise with vertical flip
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cclock_flip")]
        cclock_flip = 0,
        /// <summary>
        /// clock           1            ..FV....... rotate clockwise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("clock")]
        clock = 1,
        /// <summary>
        /// cclock          2            ..FV....... rotate counter-clockwise
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("cclock")]
        cclock = 2,
        /// <summary>
        /// clock_flip      3            ..FV....... rotate clockwise with vertical flip
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("clock_flip")]
        clock_flip = 3
    }

    /// <summary>
    ///  do not apply transposition if the input matches the specified geometry (from 0 to INT_MAX) (default none)
    /// </summary>
    public enum TransposeFilterGenPassthrough
    {
        /// <summary>
        /// none            0            ..FV....... always apply transposition
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("none")]
        none = 0,
        /// <summary>
        /// portrait        2            ..FV....... preserve portrait geometry
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("portrait")]
        portrait = 2,
        /// <summary>
        /// landscape       1            ..FV....... preserve landscape geometry
        /// </summary>
        [FFmpegArgs.Cores.Attributes.NameAttribute("landscape")]
        landscape = 1
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Transpose input video.
        /// </summary>
        public static TransposeFilterGen TransposeFilterGen(this ImageMap input0) => new TransposeFilterGen(input0);
    }
}