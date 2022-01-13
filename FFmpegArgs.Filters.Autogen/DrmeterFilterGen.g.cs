namespace FFmpegArgs.Filters.Autogens
{
public class DrmeterFilterGen : AudioToAudioFilter
{
internal DrmeterFilterGen(AudioMap input) : base("drmeter",input) { AddMapOut(); }
/// <summary>
///  set the window length (from 0.01 to 10) (default 3)
/// </summary>
public DrmeterFilterGen length(double length) => this.SetOptionRange("length", length,0.01,10);
}
public static class DrmeterFilterGenExtensions
{
/// <summary>
/// Measure audio dynamic range.
/// </summary>
public static DrmeterFilterGen DrmeterFilterGen(this AudioMap input0) => new DrmeterFilterGen(input0);
/// <summary>
/// Measure audio dynamic range.
/// </summary>
public static DrmeterFilterGen DrmeterFilterGen(this AudioMap input0,DrmeterFilterGenConfig config)
{
var result = new DrmeterFilterGen(input0);
if(config?.length != null) result.length(config.length.Value);
return result;
}
}
public class DrmeterFilterGenConfig
{
/// <summary>
///  set the window length (from 0.01 to 10) (default 3)
/// </summary>
public double? length { get; set; }
}
}
