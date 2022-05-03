namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.. histeq            V->V       Apply global color histogram equalization.
/// </summary>
public class HisteqFilterGen : ImageToImageFilter,ITimelineSupport
{
internal HisteqFilterGen(ImageMap input) : base("histeq",input) { AddMapOut(); }
/// <summary>
///  set the strength (from 0 to 1) (default 0.2)
/// </summary>
public HisteqFilterGen strength(float strength) => this.SetOptionRange("strength", strength,0,1);
/// <summary>
///  set the intensity (from 0 to 1) (default 0.21)
/// </summary>
public HisteqFilterGen intensity(float intensity) => this.SetOptionRange("intensity", intensity,0,1);
/// <summary>
///  set the antibanding level (from 0 to 2) (default none)
/// </summary>
public HisteqFilterGen antibanding(HisteqFilterGenAntibanding antibanding) => this.SetOption("antibanding", antibanding.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class HisteqFilterGenExtensions
{
/// <summary>
/// Apply global color histogram equalization.
/// </summary>
public static HisteqFilterGen HisteqFilterGen(this ImageMap input0) => new HisteqFilterGen(input0);
}
/// <summary>
///  set the antibanding level (from 0 to 2) (default none)
/// </summary>
public enum HisteqFilterGenAntibanding
{
/// <summary>
/// none            0            ..FV....... apply no antibanding
/// </summary>
[Name("none")] none,
/// <summary>
/// weak            1            ..FV....... apply weak antibanding
/// </summary>
[Name("weak")] weak,
/// <summary>
/// strong          2            ..FV....... apply strong antibanding
/// </summary>
[Name("strong")] strong,
}

}
