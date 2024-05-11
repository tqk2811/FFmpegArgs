namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... dnn_detect        V-&gt;V       Apply DNN detect filter to the input.
/// </summary>
public class Dnn_detectFilterGen : ImageToImageFilter
{
internal Dnn_detectFilterGen(ImageMap input) : base("dnn_detect",input) { AddMapOut(); }
/// <summary>
///  DNN backend (from INT_MIN to INT_MAX) (default 2)
/// </summary>
public Dnn_detectFilterGen dnn_backend(int dnn_backend) => this.SetOptionRange("dnn_backend", dnn_backend,INT_MIN,INT_MAX);
/// <summary>
///  path to model file
/// </summary>
public Dnn_detectFilterGen model(string model) => this.SetOption("model",model);
/// <summary>
///  input name of the model
/// </summary>
public Dnn_detectFilterGen input(string input) => this.SetOption("input",input);
/// <summary>
///  output name of the model
/// </summary>
public Dnn_detectFilterGen output(string output) => this.SetOption("output",output);
/// <summary>
///  backend configs
/// </summary>
public Dnn_detectFilterGen backend_configs(string backend_configs) => this.SetOption("backend_configs",backend_configs);
/// <summary>
///  backend configs (deprecated, use backend_configs)
/// </summary>
[Obsolete]
public Dnn_detectFilterGen options(string options) => this.SetOption("options",options);
/// <summary>
///  use DNN async inference (ignored, use backend_configs=&#39;async=1&#39;) (default true)
/// </summary>
public Dnn_detectFilterGen _async(bool _async) => this.SetOption("async",_async.ToFFmpegFlag());
/// <summary>
///  threshold of confidence (from 0 to 1) (default 0.5)
/// </summary>
public Dnn_detectFilterGen confidence(float confidence) => this.SetOptionRange("confidence", confidence,0,1);
/// <summary>
///  path to labels file
/// </summary>
public Dnn_detectFilterGen labels(string labels) => this.SetOption("labels",labels);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Apply DNN detect filter to the input.
/// </summary>
public static Dnn_detectFilterGen Dnn_detectFilterGen(this ImageMap input0) => new Dnn_detectFilterGen(input0);
}
}
