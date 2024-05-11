namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... axcorrelate       AA-&gt;A      Cross-correlate two audio streams.
/// </summary>
public class AxcorrelateFilterGen : AudioToAudioFilter
{
internal AxcorrelateFilterGen(params AudioMap[] inputs) : base("axcorrelate",inputs) { AddMapOut(); }
/// <summary>
///  set the segment size (from 2 to 131072) (default 256)
/// </summary>
public AxcorrelateFilterGen size(int size) => this.SetOptionRange("size", size,2,131072);
/// <summary>
///  set the algorithm (from 0 to 2) (default best)
/// </summary>
public AxcorrelateFilterGen algo(AxcorrelateFilterGenAlgo algo) => this.SetOption("algo", algo.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Cross-correlate two audio streams.
/// </summary>
public static AxcorrelateFilterGen AxcorrelateFilterGen(this AudioMap input0, AudioMap input1) => new AxcorrelateFilterGen(input0, input1);
}
/// <summary>
///  set the algorithm (from 0 to 2) (default best)
/// </summary>
public enum AxcorrelateFilterGenAlgo
{
/// <summary>
/// slow            0            ..F.A...... slow algorithm
/// </summary>
[Name("slow")] slow,
/// <summary>
/// fast            1            ..F.A...... fast algorithm
/// </summary>
[Name("fast")] fast,
/// <summary>
/// best            2            ..F.A...... best algorithm
/// </summary>
[Name("best")] best,
}

}
