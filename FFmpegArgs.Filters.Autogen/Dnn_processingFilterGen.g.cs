using System;
using System.Linq;
using System.Drawing;
using System.Collections.Generic;
using FFmpegArgs;
using FFmpegArgs.Cores;
using FFmpegArgs.Cores.Filters;
using FFmpegArgs.Cores.Maps;
using FFmpegArgs.Expressions;
using FFmpegArgs.Filters;
using FFmpegArgs.Filters.Enums;
namespace FFmpegArgs.Filters.Autogens
{
public class Dnn_processingFilterGen : ImageToImageFilter
{
internal Dnn_processingFilterGen(ImageMap input) : base("dnn_processing",input) { AddMapOut(); }
/// <summary>
///  DNN backend (from INT_MIN to INT_MAX) (default native)
/// </summary>
public Dnn_processingFilterGen dnn_backend(Dnn_processingFilterGenDnn_backend dnn_backend) => this.SetOption("dnn_backend", dnn_backend.GetAttribute<NameAttribute>().Name);
/// <summary>
///  path to model file
/// </summary>
public Dnn_processingFilterGen model(string model) => this.SetOption("model",model);
/// <summary>
///  input name of the model
/// </summary>
public Dnn_processingFilterGen input(string input) => this.SetOption("input",input);
/// <summary>
///  output name of the model
/// </summary>
public Dnn_processingFilterGen output(string output) => this.SetOption("output",output);
/// <summary>
///  backend configs
/// </summary>
public Dnn_processingFilterGen backend_configs(string backend_configs) => this.SetOption("backend_configs",backend_configs);
/// <summary>
///  backend configs
/// </summary>
public Dnn_processingFilterGen options(string options) => this.SetOption("options",options);
/// <summary>
///  use DNN async inference (default true)
/// </summary>
public Dnn_processingFilterGen async(bool async) => this.SetOption("async",async.ToFFmpegFlag());
}
public static class Dnn_processingFilterGenExtensions
{
/// <summary>
/// Apply DNN processing filter to the input.
/// </summary>
public static Dnn_processingFilterGen Dnn_processingFilterGen(this ImageMap input0) => new Dnn_processingFilterGen(input0);
/// <summary>
/// Apply DNN processing filter to the input.
/// </summary>
public static Dnn_processingFilterGen Dnn_processingFilterGen(this ImageMap input0,Dnn_processingFilterGenConfig config)
{
var result = new Dnn_processingFilterGen(input0);
if(config?.dnn_backend != null) result.dnn_backend(config.dnn_backend.Value);
if(!string.IsNullOrWhiteSpace(config?.model)) result.model(config.model);
if(!string.IsNullOrWhiteSpace(config?.input)) result.input(config.input);
if(!string.IsNullOrWhiteSpace(config?.output)) result.output(config.output);
if(!string.IsNullOrWhiteSpace(config?.backend_configs)) result.backend_configs(config.backend_configs);
if(!string.IsNullOrWhiteSpace(config?.options)) result.options(config.options);
if(config?.async != null) result.async(config.async.Value);
return result;
}
}
public class Dnn_processingFilterGenConfig
{
/// <summary>
///  DNN backend (from INT_MIN to INT_MAX) (default native)
/// </summary>
public Dnn_processingFilterGenDnn_backend? dnn_backend { get; set; }
/// <summary>
///  path to model file
/// </summary>
public string model { get; set; }
/// <summary>
///  input name of the model
/// </summary>
public string input { get; set; }
/// <summary>
///  output name of the model
/// </summary>
public string output { get; set; }
/// <summary>
///  backend configs
/// </summary>
public string backend_configs { get; set; }
/// <summary>
///  backend configs
/// </summary>
public string options { get; set; }
/// <summary>
///  use DNN async inference (default true)
/// </summary>
public bool? async { get; set; }
}
public enum Dnn_processingFilterGenDnn_backend
{
[Name("native")] native,
}

}
