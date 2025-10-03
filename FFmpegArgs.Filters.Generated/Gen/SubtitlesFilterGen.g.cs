namespace FFmpegArgs.Filters.Generated
{
    /// <summary>
    /// ... subtitles         V-&gt;V       Render text subtitles onto input video using the libass library.
    /// </summary>
    public class SubtitlesFilterGen : ImageToImageFilter
    {
        internal SubtitlesFilterGen(ImageMap input) : base("subtitles", input)
        {
            AddMapOut();
        }

        /// <summary>
        ///  set the filename of file to read
        /// </summary>
        public SubtitlesFilterGen filename(String filename) => this.SetOption("filename", filename.ToString());
        /// <summary>
        ///  set the size of the original video (used to scale fonts)
        /// </summary>
        public SubtitlesFilterGen original_size(Size original_size) => this.SetOption("original_size", $"{original_size.Width}x{original_size.Height}");
        /// <summary>
        ///  set the directory containing the fonts to read
        /// </summary>
        public SubtitlesFilterGen fontsdir(String fontsdir) => this.SetOption("fontsdir", fontsdir.ToString());
        /// <summary>
        ///  enable processing of alpha channel (default false)
        /// </summary>
        public SubtitlesFilterGen alpha(bool alpha) => this.SetOption("alpha", alpha.ToFFmpegFlag());
        /// <summary>
        ///  set input character encoding
        /// </summary>
        public SubtitlesFilterGen charenc(String charenc) => this.SetOption("charenc", charenc.ToString());
        /// <summary>
        ///  set stream index (from -1 to INT_MAX) (default -1)
        /// </summary>
        public SubtitlesFilterGen stream_index(int stream_index) => this.SetOptionRange("stream_index", stream_index, -1, INT_MAX);
        /// <summary>
        ///  set stream index (from -1 to INT_MAX) (default -1)
        /// </summary>
        public SubtitlesFilterGen si(int si) => this.SetOptionRange("si", si, -1, INT_MAX);
        /// <summary>
        ///  force subtitle style
        /// </summary>
        public SubtitlesFilterGen force_style(String force_style) => this.SetOption("force_style", force_style.ToString());
        /// <summary>
        ///  break lines according to the Unicode Line Breaking Algorithm (default auto)
        /// </summary>
        public SubtitlesFilterGen wrap_unicode(bool wrap_unicode) => this.SetOption("wrap_unicode", wrap_unicode.ToFFmpegFlag());
    }

    public static partial class FilterGeneratedExtensions
    {
        /// <summary>
        /// Render text subtitles onto input video using the libass library.
        /// </summary>
        public static SubtitlesFilterGen SubtitlesFilterGen(this ImageMap input0) => new SubtitlesFilterGen(input0);
    }
}