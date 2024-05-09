namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TS. convolve          VV->V      Convolve first video stream with second video stream.
/// </summary>
public class ConvolveFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading
{
internal ConvolveFilterGen(params ImageMap[] inputs) : base("convolve",inputs) { AddMapOut(); }
/// <summary>
///  set planes to convolve (from 0 to 15) (default 7)
/// </summary>
public ConvolveFilterGen planes(int planes) => this.SetOptionRange("planes", planes,0,15);
/// <summary>
///  when to process impulses (from 0 to 1) (default all)
/// </summary>
public ConvolveFilterGen impulse(ConvolveFilterGenImpulse impulse) => this.SetOption("impulse", impulse.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  set noise (from 0 to 1) (default 1e-07)
/// </summary>
public ConvolveFilterGen noise(float noise) => this.SetOptionRange("noise", noise,0,1);
}
/// <summary>
/// </summary>
public static class ConvolveFilterGenExtensions
{
/// <summary>
/// Convolve first video stream with second video stream.
/// </summary>
public static ConvolveFilterGen ConvolveFilterGen(this ImageMap input0, ImageMap input1) => new ConvolveFilterGen(input0, input1);
}
/// <summary>
///  when to process impulses (from 0 to 1) (default all)
/// </summary>
public enum ConvolveFilterGenImpulse
{
/// <summary>
/// first           0            ..FV....... process only first impulse, ignore rest
/// </summary>
[Name("first")] first,
/// <summary>
/// all             1            ..FV....... process all impulses
/// </summary>
[Name("all")] all,
}

}
