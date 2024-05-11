namespace FFmpegArgs.Filters.Generated
{
/// <summary>
/// ... drmeter           A-&gt;A       Measure audio dynamic range.
/// </summary>
public class DrmeterFilterGen : AudioToAudioFilter
{
internal DrmeterFilterGen(AudioMap input) : base("drmeter",input) { AddMapOut(); }
/// <summary>
///  set the window length (from 0.01 to 10) (default 3)
/// </summary>
public DrmeterFilterGen length(double length) => this.SetOptionRange("length", length,0.01,10);
}
/// <summary>
/// </summary>
public static partial class FilterGeneratedExtensions
{
/// <summary>
/// Measure audio dynamic range.
/// </summary>
public static DrmeterFilterGen DrmeterFilterGen(this AudioMap input0) => new DrmeterFilterGen(input0);
}
}
