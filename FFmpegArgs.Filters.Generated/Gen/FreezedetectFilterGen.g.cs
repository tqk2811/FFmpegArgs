namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... freezedetect      V-&gt;V       Detects frozen video input.
/// </summary>
public class FreezedetectFilterGen : ImageToImageFilter
{
internal FreezedetectFilterGen(ImageMap input) : base("freezedetect",input) { AddMapOut(); }
/// <summary>
///  set noise tolerance (from 0 to 1) (default 0.001)
/// </summary>
public FreezedetectFilterGen noise(double noise) => this.SetOptionRange("noise", noise,0,1);
/// <summary>
///  set minimum duration in seconds (default 2)
/// </summary>
public FreezedetectFilterGen duration(TimeSpan duration) => this.SetOptionRange("duration",duration,TimeSpan.Zero,TimeSpan.MaxValue);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Detects frozen video input.
/// </summary>
public static FreezedetectFilterGen FreezedetectFilterGen(this ImageMap input0) => new FreezedetectFilterGen(input0);
}
}
