namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... sr                V->V       Apply DNN-based image super resolution to the input.
/// </summary>
public class SrFilterGen : ImageToImageFilter
{
internal SrFilterGen(ImageMap input) : base("sr",input) { AddMapOut(); }
/// <summary>
///  DNN backend used for model execution (from 0 to 1) (default 1)
/// </summary>
public SrFilterGen dnn_backend(int dnn_backend) => this.SetOptionRange("dnn_backend", dnn_backend,0,1);
/// <summary>
///  scale factor for SRCNN model (from 2 to 4) (default 2)
/// </summary>
public SrFilterGen scale_factor(int scale_factor) => this.SetOptionRange("scale_factor", scale_factor,2,4);
/// <summary>
///  path to model file specifying network architecture and its parameters
/// </summary>
public SrFilterGen model(string model) => this.SetOption("model",model);
/// <summary>
///  input name of the model (default "x")
/// </summary>
public SrFilterGen input(string input) => this.SetOption("input",input);
/// <summary>
///  output name of the model (default "y")
/// </summary>
public SrFilterGen output(string output) => this.SetOption("output",output);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply DNN-based image super resolution to the input.
/// </summary>
public static SrFilterGen SrFilterGen(this ImageMap input0) => new SrFilterGen(input0);
}
}
