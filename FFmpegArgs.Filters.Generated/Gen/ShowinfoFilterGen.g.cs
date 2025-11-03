namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// .. showinfo          V-&gt;V       Show textual information for each video frame.
    /// </summary>
    public class ShowinfoFilterGen : ImageToImageFilter
    {
        internal ShowinfoFilterGen(ImageMap input) : base("showinfo", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  calculate checksums (default true)
        /// </summary>
        public ShowinfoFilterGen checksum(bool checksum) => this.SetOption("checksum", checksum.ToFFmpegFlag());
        /// <summary>
        ///  try to print user data unregistered SEI as ascii character when possible (default false)
        /// </summary>
        public ShowinfoFilterGen udu_sei_as_ascii(bool udu_sei_as_ascii) => this.SetOption("udu_sei_as_ascii", udu_sei_as_ascii.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Show textual information for each video frame.
        /// </summary>
        public static ShowinfoFilterGen ShowinfoFilterGen(this ImageMap input0) => new ShowinfoFilterGen(input0);
    }
}