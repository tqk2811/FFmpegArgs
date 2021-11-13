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
public class SrFilterGen : ImageToImageFilter
{
internal SrFilterGen(ImageMap input) : base("sr",input) { AddMapOut(); }
/// <summary>
///  DNN backend used for model execution (from 0 to 1) (default native)
/// </summary>
public SrFilterGen dnn_backend(SrFilterGenDnn_backend dnn_backend) => this.SetOption("dnn_backend", dnn_backend.GetAttribute<NameAttribute>().Name);
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
public static SrFilterGen SrFilterGen(this ImageMap input) => new SrFilterGen(input);
}
public enum SrFilterGenDnn_backend
{
[Name("native")] native,
}

}
