namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... program_opencl    N-&gt;V       Filter video using an OpenCL program
/// </summary>
public class Program_openclFilterGen : ImageToImageFilter
{
internal Program_openclFilterGen(params ImageMap[] inputs) : base("program_opencl",inputs) { AddMapOut(); }
/// <summary>
///  OpenCL program source file
/// </summary>
public Program_openclFilterGen source(string source) => this.SetOption("source",source);
/// <summary>
///  Kernel name in program
/// </summary>
public Program_openclFilterGen kernel(string kernel) => this.SetOption("kernel",kernel);
/// <summary>
///  Number of inputs (from 1 to INT_MAX) (default 1)
/// </summary>
public Program_openclFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs,1,INT_MAX);
/// <summary>
///  Video size
/// </summary>
public Program_openclFilterGen size(Size size) => this.SetOption("size",$"{size.Width}x{size.Height}");
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Filter video using an OpenCL program
/// </summary>
public static Program_openclFilterGen Program_openclFilterGen(this IEnumerable<ImageMap> inputs) => new Program_openclFilterGen(inputs.ToArray());
}
}
