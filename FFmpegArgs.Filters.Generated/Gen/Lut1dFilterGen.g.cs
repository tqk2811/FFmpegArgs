namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC lut1d             V->V       Adjust colors using a 1D LUT.
/// </summary>
public class Lut1dFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal Lut1dFilterGen(ImageMap input) : base("lut1d",input) { AddMapOut(); }
/// <summary>
///  set 1D LUT file name
/// </summary>
public Lut1dFilterGen file(string file) => this.SetOption("file",file);
/// <summary>
///  select interpolation mode (from 0 to 4) (default linear)
/// </summary>
public Lut1dFilterGen interp(Lut1dFilterGenInterp interp) => this.SetOption("interp", interp.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class Lut1dFilterGenExtensions
{
/// <summary>
/// Adjust colors using a 1D LUT.
/// </summary>
public static Lut1dFilterGen Lut1dFilterGen(this ImageMap input0) => new Lut1dFilterGen(input0);
}
/// <summary>
///  select interpolation mode (from 0 to 4) (default linear)
/// </summary>
public enum Lut1dFilterGenInterp
{
/// <summary>
/// nearest         0            ..FV.....T. use values from the nearest defined points
/// </summary>
[Name("nearest")] nearest,
/// <summary>
/// linear          1            ..FV.....T. use values from the linear interpolation
/// </summary>
[Name("linear")] linear,
/// <summary>
/// cosine          3            ..FV.....T. use values from the cosine interpolation
/// </summary>
[Name("cosine")] cosine,
/// <summary>
/// cubic           2            ..FV.....T. use values from the cubic interpolation
/// </summary>
[Name("cubic")] cubic,
/// <summary>
/// spline          4            ..FV.....T. use values from the spline interpolation
/// </summary>
[Name("spline")] spline,
}

}
