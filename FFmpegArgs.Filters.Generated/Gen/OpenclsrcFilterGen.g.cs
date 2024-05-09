namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... openclsrc         |->V       Generate video using an OpenCL program
/// </summary>
public class OpenclsrcFilterGen : SourceImageFilter
{
internal OpenclsrcFilterGen(IImageFilterGraph input) : base("openclsrc",input) { AddMapOut(); }
/// <summary>
///  OpenCL program source file
/// </summary>
public OpenclsrcFilterGen source(string source) => this.SetOption("source",source);
/// <summary>
///  Kernel name in program
/// </summary>
public OpenclsrcFilterGen kernel(string kernel) => this.SetOption("kernel",kernel);
/// <summary>
///  Video size
/// </summary>
public OpenclsrcFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
/// <summary>
///  Video format (default none)
/// </summary>
public OpenclsrcFilterGen format(PixFmt format) => this.SetOption("format",format.ToString());
/// <summary>
///  Video frame rate (default "25")
/// </summary>
public OpenclsrcFilterGen rate(Rational rate) => this.SetOption("rate",rate);
}
/// <summary>
/// </summary>
public static class OpenclsrcFilterGenExtensions
{
/// <summary>
/// Generate video using an OpenCL program
/// </summary>
public static OpenclsrcFilterGen OpenclsrcFilterGen(this IImageFilterGraph input0) => new OpenclsrcFilterGen(input0);
}
}
