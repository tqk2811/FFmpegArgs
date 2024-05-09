namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// TSC colorkey          V->V       Turns a certain color into transparency. Operates on RGB colors.
/// </summary>
public class ColorkeyFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal ColorkeyFilterGen(ImageMap input) : base("colorkey",input) { AddMapOut(); }
/// <summary>
///  set the colorkey key color (default "black")
/// </summary>
public ColorkeyFilterGen color(Color color) => this.SetOption("color",color.ToHexStringRGBA());
/// <summary>
///  set the colorkey similarity value (from 1e-05 to 1) (default 0.01)
/// </summary>
public ColorkeyFilterGen similarity(float similarity) => this.SetOptionRange("similarity", similarity,1e-05,1);
/// <summary>
///  set the colorkey key blend value (from 0 to 1) (default 0)
/// </summary>
public ColorkeyFilterGen blend(float blend) => this.SetOptionRange("blend", blend,0,1);
}
/// <summary>
/// </summary>
public static class ColorkeyFilterGenExtensions
{
/// <summary>
/// Turns a certain color into transparency. Operates on RGB colors.
/// </summary>
public static ColorkeyFilterGen ColorkeyFilterGen(this ImageMap input0) => new ColorkeyFilterGen(input0);
}
}
