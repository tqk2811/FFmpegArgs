namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... ass               V->V       Render ASS subtitles onto input video using the libass library.
/// </summary>
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
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Render ASS subtitles onto input video using the libass library.
/// </summary>
public static AssFilterGen AssFilterGen(this ImageMap input0) => new AssFilterGen(input0);
}
/// <summary>
///  set shaping engine (from -1 to 1) (default auto)
/// </summary>
public enum AssFilterGenShaping
{
/// <summary>
/// auto            -1           ..FV.......
/// </summary>
[Name("auto")] auto,
/// <summary>
/// simple          0            ..FV....... simple shaping
/// </summary>
[Name("simple")] simple,
/// <summary>
/// complex         1            ..FV....... complex shaping
/// </summary>
[Name("complex")] complex,
}

}
