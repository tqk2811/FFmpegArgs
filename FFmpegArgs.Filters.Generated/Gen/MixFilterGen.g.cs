namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// TSC mix               N->V       Mix video inputs.
/// </summary>
public class MixFilterGen : ImageToImageFilter,ITimelineSupport,ISliceThreading,ICommandSupport
{
internal MixFilterGen(params ImageMap[] inputs) : base("mix",inputs) { AddMapOut(); }
/// <summary>
///  set number of inputs (from 2 to 32767) (default 2)
/// </summary>
public MixFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs,2,32767);
/// <summary>
///  set weight for each input (default "1 1")
/// </summary>
public MixFilterGen weights(string weights) => this.SetOption("weights",weights);
/// <summary>
///  set scale (from 0 to 32767) (default 0)
/// </summary>
public MixFilterGen scale(float scale) => this.SetOptionRange("scale", scale,0,32767);
/// <summary>
///  set what planes to filter (default F)
/// </summary>
public MixFilterGen planes(MixFilterGenPlanes planes) => this.SetOption("planes", planes.GetEnumAttribute<NameAttribute>().Name);
/// <summary>
///  how to determine end of stream (from 0 to 2) (default longest)
/// </summary>
public MixFilterGen duration(MixFilterGenDuration duration) => this.SetOption("duration", duration.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Mix video inputs.
/// </summary>
public static MixFilterGen MixFilterGen(this IEnumerable<ImageMap> inputs) => new MixFilterGen(inputs.ToArray());
}
/// <summary>
///  set what planes to filter (default F)
/// </summary>
public enum MixFilterGenPlanes
{
}

/// <summary>
///  how to determine end of stream (from 0 to 2) (default longest)
/// </summary>
public enum MixFilterGenDuration
{
/// <summary>
/// longest         0            ..FV....... Duration of longest input
/// </summary>
[Name("longest")] longest,
/// <summary>
/// shortest        1            ..FV....... Duration of shortest input
/// </summary>
[Name("shortest")] shortest,
/// <summary>
/// first           2            ..FV....... Duration of first input
/// </summary>
[Name("first")] first,
}

}
