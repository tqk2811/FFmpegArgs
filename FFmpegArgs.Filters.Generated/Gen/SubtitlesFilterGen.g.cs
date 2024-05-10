namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... subtitles         V->V       Render text subtitles onto input video using the libass library.
/// </summary>
public class SubtitlesFilterGen : ImageToImageFilter
{
internal SubtitlesFilterGen(ImageMap input) : base("subtitles",input) { AddMapOut(); }
/// <summary>
///  set the filename of file to read
/// </summary>
public SubtitlesFilterGen filename(string filename) => this.SetOption("filename",filename);
/// <summary>
///  set the size of the original video (used to scale fonts)
/// </summary>
public SubtitlesFilterGen original_size(Size original_size) => this.SetOption("original_size",$"{original_size.Width}x{original_size.Height}");
/// <summary>
///  set the directory containing the fonts to read
/// </summary>
public SubtitlesFilterGen fontsdir(string fontsdir) => this.SetOption("fontsdir",fontsdir);
/// <summary>
///  enable processing of alpha channel (default false)
/// </summary>
public SubtitlesFilterGen alpha(bool alpha) => this.SetOption("alpha",alpha.ToFFmpegFlag());
/// <summary>
///  set input character encoding
/// </summary>
public SubtitlesFilterGen charenc(string charenc) => this.SetOption("charenc",charenc);
/// <summary>
///  set stream index (from -1 to INT_MAX) (default -1)
/// </summary>
public SubtitlesFilterGen stream_index(int stream_index) => this.SetOptionRange("stream_index", stream_index,-1,INT_MAX);
/// <summary>
///  set stream index (from -1 to INT_MAX) (default -1)
/// </summary>
public SubtitlesFilterGen si(int si) => this.SetOptionRange("si", si,-1,INT_MAX);
/// <summary>
///  force subtitle style
/// </summary>
public SubtitlesFilterGen force_style(string force_style) => this.SetOption("force_style",force_style);
/// <summary>
///  break lines according to the Unicode Line Breaking Algorithm (default auto)
/// </summary>
public SubtitlesFilterGen wrap_unicode(bool wrap_unicode) => this.SetOption("wrap_unicode",wrap_unicode.ToFFmpegFlag());
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Render text subtitles onto input video using the libass library.
/// </summary>
public static SubtitlesFilterGen SubtitlesFilterGen(this ImageMap input0) => new SubtitlesFilterGen(input0);
}
}
