namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... dnn_classify      V->V       Apply DNN classify filter to the input.
/// </summary>
public class Dnn_classifyFilterGen : ImageToImageFilter
{
internal Dnn_classifyFilterGen(ImageMap input) : base("dnn_classify",input) { AddMapOut(); }
/// <summary>
///  DNN backend (from INT_MIN to INT_MAX) (default 2)
/// </summary>
public Dnn_classifyFilterGen dnn_backend(int dnn_backend) => this.SetOptionRange("dnn_backend", dnn_backend,INT_MIN,INT_MAX);
/// <summary>
///  path to model file
/// </summary>
public Dnn_classifyFilterGen model(string model) => this.SetOption("model",model);
/// <summary>
///  input name of the model
/// </summary>
public Dnn_classifyFilterGen input(string input) => this.SetOption("input",input);
/// <summary>
///  output name of the model
/// </summary>
public Dnn_classifyFilterGen output(string output) => this.SetOption("output",output);
/// <summary>
///  backend configs
/// </summary>
public Dnn_classifyFilterGen backend_configs(string backend_configs) => this.SetOption("backend_configs",backend_configs);
/// <summary>
///  backend configs (deprecated, use backend_configs)
/// </summary>
public Dnn_classifyFilterGen options(string options) => this.SetOption("options",options);
/// <summary>
///  use DNN async inference (ignored, use backend_configs='async=1') (default true)
/// </summary>
public Dnn_classifyFilterGen async(bool async) => this.SetOption("async",async.ToFFmpegFlag());
/// <summary>
///  threshold of confidence (from 0 to 1) (default 0.5)
/// </summary>
public Dnn_classifyFilterGen confidence(float confidence) => this.SetOptionRange("confidence", confidence,0,1);
/// <summary>
///  path to labels file
/// </summary>
public Dnn_classifyFilterGen labels(string labels) => this.SetOption("labels",labels);
/// <summary>
///  which one to be classified
/// </summary>
public Dnn_classifyFilterGen target(string target) => this.SetOption("target",target);
}
/// <summary>
/// </summary>
public static class Dnn_classifyFilterGenExtensions
{
/// <summary>
/// Apply DNN classify filter to the input.
/// </summary>
public static Dnn_classifyFilterGen Dnn_classifyFilterGen(this ImageMap input0) => new Dnn_classifyFilterGen(input0);
}
}
