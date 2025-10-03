namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... fsync             V-&gt;V       Synchronize video frames from external source.
    /// </summary>
    public class FsyncFilterGen : ImageToImageFilter
    {
        internal FsyncFilterGen(ImageMap input) : base("fsync", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the file name to use for frame sync (default &quot;&quot;)
        /// </summary>
        public FsyncFilterGen file(String file) => this.SetOption("file", file.ToString());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Synchronize video frames from external source.
        /// </summary>
        public static FsyncFilterGen FsyncFilterGen(this ImageMap input0) => new FsyncFilterGen(input0);
    }
}