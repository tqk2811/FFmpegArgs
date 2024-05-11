namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... ainterleave       N->A       Temporally interleave audio inputs.
/// </summary>
public class AinterleaveFilterGen : AudioToAudioFilter
{
internal AinterleaveFilterGen(params AudioMap[] inputs) : base("ainterleave",inputs) { AddMapOut(); }
/// <summary>
///  set number of inputs (from 1 to INT_MAX) (default 2)
/// </summary>
public AinterleaveFilterGen nb_inputs(int nb_inputs) => this.SetOptionRange("nb_inputs", nb_inputs,1,INT_MAX);
/// <summary>
///  how to determine the end-of-stream (from 0 to 2) (default longest)
/// </summary>
public AinterleaveFilterGen duration(AinterleaveFilterGenDuration duration) => this.SetOption("duration", duration.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Temporally interleave audio inputs.
/// </summary>
public static AinterleaveFilterGen AinterleaveFilterGen(this IEnumerable<AudioMap> inputs) => new AinterleaveFilterGen(inputs.ToArray());
}
/// <summary>
///  how to determine the end-of-stream (from 0 to 2) (default longest)
/// </summary>
public enum AinterleaveFilterGenDuration
{
/// <summary>
/// longest         0            ..F.A...... Duration of longest input
/// </summary>
[Name("longest")] longest,
/// <summary>
/// shortest        1            ..F.A...... Duration of shortest input
/// </summary>
[Name("shortest")] shortest,
/// <summary>
/// first           2            ..F.A...... Duration of first input
/// </summary>
[Name("first")] first,
}

}
