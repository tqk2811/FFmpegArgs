namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... amerge            N->A       Merge two or more audio streams into a single multi-channel stream.
/// </summary>
public class AmergeFilterGen : AudioToAudioFilter
{
internal AmergeFilterGen(params AudioMap[] inputs) : base("amerge",inputs) { AddMapOut(); }
/// <summary>
///  specify the number of inputs (from 1 to 64) (default 2)
/// </summary>
public AmergeFilterGen inputs(int inputs) => this.SetOptionRange("inputs", inputs,1,64);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Merge two or more audio streams into a single multi-channel stream.
/// </summary>
public static AmergeFilterGen AmergeFilterGen(this IEnumerable<AudioMap> inputs) => new AmergeFilterGen(inputs.ToArray());
}
}
