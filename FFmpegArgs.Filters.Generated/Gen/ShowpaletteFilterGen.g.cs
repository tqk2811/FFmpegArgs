namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... showpalette       V->V       Display frame palette.
/// </summary>
public class ShowpaletteFilterGen : ImageToImageFilter
{
internal ShowpaletteFilterGen(ImageMap input) : base("showpalette",input) { AddMapOut(); }
/// <summary>
///  set pixel box size (from 1 to 100) (default 30)
/// </summary>
public ShowpaletteFilterGen s(int s) => this.SetOptionRange("s", s,1,100);
}
/// <summary>
/// </summary>
public static class ShowpaletteFilterGenExtensions
{
/// <summary>
/// Display frame palette.
/// </summary>
public static ShowpaletteFilterGen ShowpaletteFilterGen(this ImageMap input0) => new ShowpaletteFilterGen(input0);
}
}
