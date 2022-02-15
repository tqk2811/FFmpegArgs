namespace FFmpegArgs.Filters.Autogens
{
/// <summary>
/// ... axcorrelate       AA->A      Cross-correlate two audio streams.
/// </summary>
public class AxcorrelateFilterGen : AudioToAudioFilter
{
internal AxcorrelateFilterGen(params AudioMap[] inputs) : base("axcorrelate",inputs) { AddMapOut(); }
/// <summary>
///  set segment size (from 2 to 131072) (default 256)
/// </summary>
public AxcorrelateFilterGen size(int size) => this.SetOptionRange("size", size,2,131072);
/// <summary>
///  set alghorithm (from 0 to 1) (default slow)
/// </summary>
public AxcorrelateFilterGen algo(AxcorrelateFilterGenAlgo algo) => this.SetOption("algo", algo.GetEnumAttribute<NameAttribute>().Name);
}
/// <summary>
/// </summary>
public static class AxcorrelateFilterGenExtensions
{
/// <summary>
/// Cross-correlate two audio streams.
/// </summary>
public static AxcorrelateFilterGen AxcorrelateFilterGen(this AudioMap input0, AudioMap input1) => new AxcorrelateFilterGen(input0, input1);
}
/// <summary>
///  set alghorithm (from 0 to 1) (default slow)
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
}

}
