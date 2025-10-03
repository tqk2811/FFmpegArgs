namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... ccrepack          V-&gt;V       Repack CEA-708 closed caption metadata
    /// </summary>
    public class CcrepackFilterGen : ImageToImageFilter
    {
        internal CcrepackFilterGen(ImageMap input) : base("ccrepack", input)
        {
            AddMapOut();
        }
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Repack CEA-708 closed caption metadata
        /// </summary>
        public static CcrepackFilterGen CcrepackFilterGen(this ImageMap input0) => new CcrepackFilterGen(input0);
    }
}