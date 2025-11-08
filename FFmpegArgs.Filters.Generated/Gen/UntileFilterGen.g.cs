namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. untile            V-&gt;V       Untile a frame into a sequence of frames.
    /// </summary>
    public class UntileFilterGen : ImageToImageFilter
    {
        internal UntileFilterGen(ImageMap input) : base("untile", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set grid size (default &quot;6x5&quot;)
        /// </summary>
        public UntileFilterGen layout(Size layout) => this.SetOption("layout", $"{layout.Width}x{layout.Height}");
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Untile a frame into a sequence of frames.
        /// </summary>
        public static UntileFilterGen UntileFilterGen(this ImageMap input0) => new UntileFilterGen(input0);
    }
}