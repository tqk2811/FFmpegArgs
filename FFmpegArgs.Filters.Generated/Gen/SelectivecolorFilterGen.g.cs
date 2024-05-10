namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TS. selectivecolor    V->V       Apply CMYK adjustments to specific color ranges.
/// </summary>
public class SelectivecolorFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal SelectivecolorFilterGen(ImageMap input) : base("selectivecolor",input) { AddMapOut(); }
/// <summary>
///  select correction method (from 0 to 1) (default absolute)
/// </summary>
public SelectivecolorFilterGen correction_method(SelectivecolorFilterGenCorrection_method correction_method) => this.SetOption("correction_method", correction_method.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  adjust red regions
/// </summary>
public SelectivecolorFilterGen reds(string reds) => this.SetOption("reds",reds);
/// <summary>
///  adjust yellow regions
/// </summary>
public SelectivecolorFilterGen yellows(string yellows) => this.SetOption("yellows",yellows);
/// <summary>
///  adjust green regions
/// </summary>
public SelectivecolorFilterGen greens(string greens) => this.SetOption("greens",greens);
/// <summary>
///  adjust cyan regions
/// </summary>
public SelectivecolorFilterGen cyans(string cyans) => this.SetOption("cyans",cyans);
/// <summary>
///  adjust blue regions
/// </summary>
public SelectivecolorFilterGen blues(string blues) => this.SetOption("blues",blues);
/// <summary>
///  adjust magenta regions
/// </summary>
public SelectivecolorFilterGen magentas(string magentas) => this.SetOption("magentas",magentas);
/// <summary>
///  adjust white regions
/// </summary>
public SelectivecolorFilterGen whites(string whites) => this.SetOption("whites",whites);
/// <summary>
///  adjust neutral regions
/// </summary>
public SelectivecolorFilterGen neutrals(string neutrals) => this.SetOption("neutrals",neutrals);
/// <summary>
///  adjust black regions
/// </summary>
public SelectivecolorFilterGen blacks(string blacks) => this.SetOption("blacks",blacks);
/// <summary>
///  set Photoshop selectivecolor file name
/// </summary>
public SelectivecolorFilterGen psfile(string psfile) => this.SetOption("psfile",psfile);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply CMYK adjustments to specific color ranges.
/// </summary>
public static SelectivecolorFilterGen SelectivecolorFilterGen(this ImageMap input0) => new SelectivecolorFilterGen(input0);
}
/// <summary>
///  select correction method (from 0 to 1) (default absolute)
/// </summary>
public enum SelectivecolorFilterGenCorrection_method
{
/// <summary>
/// absolute        0            ..FV.......
/// </summary>
[Name("absolute")] absolute,
/// <summary>
/// relative        1            ..FV.......
/// </summary>
[Name("relative")] relative,
}

}
