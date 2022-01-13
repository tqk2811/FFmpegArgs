namespace FFmpegArgs.Filters.Autogens
{
public class VmafmotionFilterGen : ImageToImageFilter
{
internal VmafmotionFilterGen(ImageMap input) : base("vmafmotion",input) { AddMapOut(); }
/// <summary>
///  Set file where to store per-frame difference information
/// </summary>
public VmafmotionFilterGen stats_file(string stats_file) => this.SetOption("stats_file",stats_file);
}
public static class VmafmotionFilterGenExtensions
{
/// <summary>
/// Calculate the VMAF Motion score.
/// </summary>
public static VmafmotionFilterGen VmafmotionFilterGen(this ImageMap input0) => new VmafmotionFilterGen(input0);
/// <summary>
/// Calculate the VMAF Motion score.
/// </summary>
public static VmafmotionFilterGen VmafmotionFilterGen(this ImageMap input0,VmafmotionFilterGenConfig config)
{
var result = new VmafmotionFilterGen(input0);
if(!string.IsNullOrWhiteSpace(config?.stats_file)) result.stats_file(config.stats_file);
return result;
}
}
public class VmafmotionFilterGenConfig
{
/// <summary>
///  Set file where to store per-frame difference information
/// </summary>
public string stats_file { get; set; }
}
}
