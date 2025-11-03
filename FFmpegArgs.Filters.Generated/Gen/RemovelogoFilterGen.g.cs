namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// T. removelogo        V-&gt;V       Remove a TV logo based on a mask image.
    /// </summary>
    public class RemovelogoFilterGen : ImageToImageFilter, ITimelineSupport
    {
        internal RemovelogoFilterGen(ImageMap input) : base("removelogo", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set bitmap filename
        /// </summary>
        public RemovelogoFilterGen filename(String filename) => this.SetOption("filename", filename.ToStringInv());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Remove a TV logo based on a mask image.
        /// </summary>
        public static RemovelogoFilterGen RemovelogoFilterGen(this ImageMap input0) => new RemovelogoFilterGen(input0);
    }
}