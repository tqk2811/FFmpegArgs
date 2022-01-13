namespace FFmpegArgs.Filters.Autogens
{
public class AssFilterGen : ImageToImageFilter
{
internal AssFilterGen(ImageMap input) : base("ass",input) { AddMapOut(); }
/// <summary>
///  set the filename of file to read
/// </summary>
public AssFilterGen filename(string filename) => this.SetOption("filename",filename);
/// <summary>
///  set the size of the original video (used to scale fonts)
/// </summary>
public AssFilterGen original_size(Size original_size) => this.SetOption("original_size",$"{original_size.Width}x{original_size.Height}");
/// <summary>
///  set the directory containing the fonts to read
/// </summary>
public AssFilterGen fontsdir(string fontsdir) => this.SetOption("fontsdir",fontsdir);
/// <summary>
///  enable processing of alpha channel (default false)
/// </summary>
public AssFilterGen alpha(bool alpha) => this.SetOption("alpha",alpha.ToFFmpegFlag());
/// <summary>
///  set shaping engine (from -1 to 1) (default auto)
/// </summary>
public AssFilterGen shaping(AssFilterGenShaping shaping) => this.SetOption("shaping", shaping.GetEnumAttribute<NameAttribute>().Name);
}
public static class AssFilterGenExtensions
{
/// <summary>
/// Render ASS subtitles onto input video using the libass library.
/// </summary>
public static AssFilterGen AssFilterGen(this ImageMap input0) => new AssFilterGen(input0);
/// <summary>
/// Render ASS subtitles onto input video using the libass library.
/// </summary>
public static AssFilterGen AssFilterGen(this ImageMap input0,AssFilterGenConfig config)
{
var result = new AssFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.filename)) result.filename(config.filename);
if(config?.original_size != null) result.original_size(config.original_size.Value);
if(!string.IsNullOrWhiteSpace(config?.fontsdir)) result.fontsdir(config.fontsdir);
if(config?.alpha != null) result.alpha(config.alpha.Value);
if(config?.shaping != null) result.shaping(config.shaping.Value);
return result;
}
}
public class AssFilterGenConfig
{
/// <summary>
///  set the filename of file to read
/// </summary>
public string filename { get; set; }
/// <summary>
///  set the size of the original video (used to scale fonts)
/// </summary>
public Size? original_size { get; set; }
/// <summary>
///  set the directory containing the fonts to read
/// </summary>
public string fontsdir { get; set; }
/// <summary>
///  enable processing of alpha channel (default false)
/// </summary>
public bool? alpha { get; set; }
/// <summary>
///  set shaping engine (from -1 to 1) (default auto)
/// </summary>
public AssFilterGenShaping? shaping { get; set; }
}
public enum AssFilterGenShaping
{
[Name("auto")] auto,
[Name("simple")] simple,
[Name("complex")] complex,
}

}
