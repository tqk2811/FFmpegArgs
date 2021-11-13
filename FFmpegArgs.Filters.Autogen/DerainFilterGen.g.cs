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
public class DerainFilterGen : ImageToImageFilter,ITimelineSupport
{
internal DerainFilterGen(ImageMap input) : base("derain",input) { AddMapOut(); }
/// <summary>
///  filter type(derain/dehaze) (from 0 to 1) (default derain)
/// </summary>
public DerainFilterGen filter_type(DerainFilterGenFilter_type filter_type) => this.SetOption("filter_type", filter_type.GetAttribute<NameAttribute>().Name);
/// <summary>
///  DNN backend (from 0 to 1) (default native)
/// </summary>
public DerainFilterGen dnn_backend(DerainFilterGenDnn_backend dnn_backend) => this.SetOption("dnn_backend", dnn_backend.GetAttribute<NameAttribute>().Name);
/// <summary>
///  path to model file
/// </summary>
public DerainFilterGen model(string model) => this.SetOption("model",model);
/// <summary>
///  input name of the model (default "x")
/// </summary>
public DerainFilterGen input(string input) => this.SetOption("input",input);
/// <summary>
///  output name of the model (default "y")
/// </summary>
public DerainFilterGen output(string output) => this.SetOption("output",output);
}
public static class DerainFilterGenExtensions
{
/// <summary>
/// Apply derain filter to the input.
/// </summary>
public static DerainFilterGen DerainFilterGen(this ImageMap input0) => new DerainFilterGen(input0);
}
public enum DerainFilterGenFilter_type
{
[Name("derain")] derain,
[Name("dehaze")] dehaze,
}

public enum DerainFilterGenDnn_backend
{
[Name("native")] native,
}

}
