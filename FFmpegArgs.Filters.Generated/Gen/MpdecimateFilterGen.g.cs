namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... mpdecimate        V-&gt;V       Remove near-duplicate frames.
/// </summary>
public class MpdecimateFilterGen : ImageToImageFilter
{
internal MpdecimateFilterGen(ImageMap input) : base("mpdecimate",input) { AddMapOut(); }
/// <summary>
///  set the maximum number of consecutive dropped frames (positive), or the minimum interval between dropped frames (negative) (from INT_MIN to INT_MAX) (default 0)
/// </summary>
public MpdecimateFilterGen max(int max) => this.SetOptionRange("max", max,INT_MIN,INT_MAX);
/// <summary>
///  set the number of similar consecutive frames to be kept before starting to drop similar frames (from 0 to INT_MAX) (default 0)
/// </summary>
public MpdecimateFilterGen keep(int keep) => this.SetOptionRange("keep", keep,0,INT_MAX);
/// <summary>
///  set high dropping threshold (from INT_MIN to INT_MAX) (default 768)
/// </summary>
public MpdecimateFilterGen hi(int hi) => this.SetOptionRange("hi", hi,INT_MIN,INT_MAX);
/// <summary>
///  set low dropping threshold (from INT_MIN to INT_MAX) (default 320)
/// </summary>
public MpdecimateFilterGen lo(int lo) => this.SetOptionRange("lo", lo,INT_MIN,INT_MAX);
/// <summary>
///  set fraction dropping threshold (from 0 to 1) (default 0.33)
/// </summary>
public MpdecimateFilterGen frac(float frac) => this.SetOptionRange("frac", frac,0,1);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Remove near-duplicate frames.
/// </summary>
public static MpdecimateFilterGen MpdecimateFilterGen(this ImageMap input0) => new MpdecimateFilterGen(input0);
}
}
