namespace FFmpegArgs.Filters.Autogens
{
public class SrFilterGen : ImageToImageFilter
{
internal SrFilterGen(ImageMap input) : base("sr",input) { AddMapOut(); }
/// <summary>
///  DNN backend used for model execution (from 0 to 1) (default native)
/// </summary>
public SrFilterGen dnn_backend(SrFilterGenDnn_backend dnn_backend) => this.SetOption("dnn_backend", dnn_backend.GetEnumAttribute<NameAttribute>().Name);
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
public static class SrFilterGenExtensions
{
/// <summary>
/// Apply DNN-based image super resolution to the input.
/// </summary>
public static SrFilterGen SrFilterGen(this ImageMap input0) => new SrFilterGen(input0);
/// <summary>
/// Apply DNN-based image super resolution to the input.
/// </summary>
public static SrFilterGen SrFilterGen(this ImageMap input0,SrFilterGenConfig config)
{
var result = new SrFilterGen(input0);
if(config?.dnn_backend != null) result.dnn_backend(config.dnn_backend.Value);
if(config?.scale_factor != null) result.scale_factor(config.scale_factor.Value);
if(!string.IsNullOrWhiteSpace(config?.model)) result.model(config.model);
if(!string.IsNullOrWhiteSpace(config?.input)) result.input(config.input);
if(!string.IsNullOrWhiteSpace(config?.output)) result.output(config.output);
return result;
}
}
public class SrFilterGenConfig
{
/// <summary>
///  DNN backend used for model execution (from 0 to 1) (default native)
/// </summary>
public SrFilterGenDnn_backend? dnn_backend { get; set; }
/// <summary>
///  scale factor for SRCNN model (from 2 to 4) (default 2)
/// </summary>
public int? scale_factor { get; set; }
/// <summary>
///  path to model file specifying network architecture and its parameters
/// </summary>
public string model { get; set; }
/// <summary>
///  input name of the model (default "x")
/// </summary>
public string input { get; set; }
/// <summary>
///  output name of the model (default "y")
/// </summary>
public string output { get; set; }
}
public enum SrFilterGenDnn_backend
{
[Name("native")] native,
}

}
