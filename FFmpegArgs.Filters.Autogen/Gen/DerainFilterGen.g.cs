namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// T.. derain            V->V       Apply derain filter to the input.
/// </summary>
public class DerainFilterGen : ImageToImageFilter,ITimelineSupport
{
internal DerainFilterGen(ImageMap input) : base("derain",input) { AddMapOut(); }
/// <summary>
///  filter type(derain/dehaze) (from 0 to 1) (default derain)
/// </summary>
public DerainFilterGen filter_type(DerainFilterGenFilter_type filter_type) => this.SetOption("filter_type", filter_type.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  DNN backend (from 0 to 1) (default native)
/// </summary>
public DerainFilterGen dnn_backend(DerainFilterGenDnn_backend dnn_backend) => this.SetOption("dnn_backend", dnn_backend.GetEnumAttribute<NameAttribute>().Name);
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
/// <summary>
/// </summary>
public static class DerainFilterGenExtensions
{
/// <summary>
/// Apply derain filter to the input.
/// </summary>
public static DerainFilterGen DerainFilterGen(this ImageMap input0) => new DerainFilterGen(input0);
}
/// <summary>
///  filter type(derain/dehaze) (from 0 to 1) (default derain)
/// </summary>
public enum DerainFilterGenFilter_type
{
/// <summary>
/// derain          0            ..FV....... derain filter flag
/// </summary>
[Name("derain")] derain,
/// <summary>
/// dehaze          1            ..FV....... dehaze filter flag
/// </summary>
[Name("dehaze")] dehaze,
}

/// <summary>
///  DNN backend (from 0 to 1) (default native)
/// </summary>
public enum DerainFilterGenDnn_backend
{
/// <summary>
/// native          0            ..FV....... native backend flag
/// </summary>
[Name("native")] native,
}

}
